using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Advantage.Data.Provider;
using Common;

namespace AdsDataModel {

	public partial class FoxProDataContext {

		private const string TrimTrailingSpaces = "TRUE";
		private const string DbfsUseNulls = "TRUE";
		private const string ReadOnly = "FALSE";
		private const string LockMode = "COMPATIBLE";
		private const string TableType = "CDX";
		private const string ServerType = "REMOTE";
		//private const string DataSource = @"\\adsserver:2001\u\sys\data";
		private const string DataSource = @"\\192.168.40.46:2001\u\sys\data";

		public readonly AdsConnection Conn = new AdsConnection($@"Data Source={DataSource}; TableType={TableType}; ServerType={ServerType}; TrimTrailingSpaces={TrimTrailingSpaces}; LockMode={LockMode}; DbfsUseNulls={DbfsUseNulls}; ReadOnly={ReadOnly};");

		public IList<AgencyParent> AgencyParents;

		private string GetMethodName() {
			return new StackTrace(1).GetFrame(0).GetMethod().Name;
		}

		public bool Update(IFoxProEntity entity) {
			var qTime = DateTime.Now;
			entity.PrepareSave();
			var did = false;
			var table = entity.GetType().Name;
			//if (table == "hfinv") table = "xfinv";
			//if (table == "hfinvbm") table = "xfinvbm";
			//if (table == "hbmnote") table = "xhbmnote";
			//if (table == "hord") table = "xord";
			//if (table == "hdet") table = "xdet";
			Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = table;
			var rdr = cmd.ExecuteExtendedReader();
			if (rdr.FoxProSeek(entity)) {
				if (rdr.FoxRecordLock(table)) {
					try {
						foreach (var prop in entity.GetType().GetProperties()) {
							var att = prop.GetAttribute<MyCustomAttribute>();
							if (att != null && (att.AdsIgnore || att.AdsReadOnly)) continue;
							if (!entity.DupDirtyList.Contains(prop.Name)) continue;
							var value = prop.GetValue(entity, null);
							//if (value == null) continue;
							var ordinal = rdr.GetOrdinal(prop.Name);
							switch (prop.GetFoxType()) {
								case FoxType.DateTime:
									rdr.SetDateTime(ordinal, Convert.ToDateTime(value));
									break;
								case FoxType.Boolean:
									rdr.SetBoolean(ordinal, Convert.ToBoolean(value));
									break;
								case FoxType.Decimal:
									rdr.SetDecimal(ordinal, Convert.ToDecimal(value));
									break;
								case FoxType.Int32:
									rdr.SetInt32(ordinal, Convert.ToInt32(value));
									break;
								default:
									var str = value.ToString();
									if (att != null && att.Mask != null && att.Mask.Contains("###-###-####") && !str.Contains("-") && str.Length == 10) str = $"{str.Substring(0, 3)}-{str.Substring(3, 3)}-{str.Substring(6, 4)}";
									rdr.SetString(ordinal, str);
									break;
							}
						}
						rdr.WriteRecord();
						rdr.UnlockRecord();
						did = true;
					}
					catch (Exception e) {
						// Undo changes, data was not written
						// write update failure message
						if (rdr.IsRecordLocked()) {
							//rdr.WriteRecord();
							rdr.UnlockRecord();
						}
						Debug.WriteLine($"ADS Update Error: {e.Message}");
					}
				}
				else {
					// Record could not be locked, data was not written
					// write failure message somewhere
					if (rdr.IsRecordLocked()) {
						rdr.UnlockRecord();
					}
					Debug.WriteLine($"ADS Update Error: lock failed!");
				}
			}
			else {
				// write didn't find keyvalue record message
			}
			rdr.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"Update - {table}");
			return did;
		}

		public int Insert(IFoxProEntity entity) {
			return Insert(entity, "");
		}

		public int Insert(IFoxProEntity entity, string table) {
			var qTime = DateTime.Now;
			var recno = 0;
			if (string.IsNullOrEmpty(table)) table = entity.GetType().Name;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = table;
			var rdr = cmd.ExecuteExtendedReader();
			if (rdr.FoxTableLock(table)) {
				try {
					rdr.AppendRecord();
					foreach (var prop in entity.GetType().GetProperties()) {
						var att = prop.GetAttribute<MyCustomAttribute>();
						if (att != null && att.AdsIgnore) continue;
						var value = prop.GetValue(entity, null);
						if (value == null) continue;
						var ordinal = rdr.GetOrdinal(prop.Name);
						switch (prop.GetFoxType()) {
							case FoxType.DateTime:
								rdr.SetDateTime(ordinal, Convert.ToDateTime(value));
								break;
							case FoxType.Boolean:
								rdr.SetBoolean(ordinal, Convert.ToBoolean(value));
								break;
							case FoxType.Decimal:
								rdr.SetDecimal(ordinal, Convert.ToDecimal(value));
								break;
							case FoxType.Int32:
								rdr.SetInt32(ordinal, Convert.ToInt32(value));
								break;
							default:
								var str = value.ToString();
								if (att != null && att.Mask != null && att.Mask.Contains("###-###-####") && !str.Contains("-") && str.Length == 10) str = $"{str.Substring(0, 3)}-{str.Substring(3, 3)}-{str.Substring(6, 4)}";
								rdr.SetString(ordinal, str);
								break;
						}
					}
					rdr.WriteRecord();
					rdr.UnlockTable();
					recno = rdr.RecordNumber;
					entity.MakeClean();
				}
				catch (Exception e) {
					if (rdr.IsTableLocked()) {
						//rdr.WriteRecord();
						rdr.UnlockTable();
					}
					recno = 0;
					Debug.WriteLine($"ADS Insert Error: {e.Message}");
				}
			}
			else {
				if (rdr.IsTableLocked()) rdr.UnlockTable();
				recno = 0;
				Debug.WriteLine($"ADS Insert Error: lock failed!");
				// write failure message somewhere
			}
			rdr.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"Insert - {table}");
			return recno;
		}

		public bool Delete(IFoxProEntity entity) {
			var qTime = DateTime.Now;
			var did = false;
			var table = entity.GetType().Name;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = table;
			var rdr = cmd.ExecuteExtendedReader();
			if (rdr.FoxProSeek(entity)) {
				rdr.DeleteRecord();
				did = rdr.IsRecordDeleted();
			}
			else {
				Debug.WriteLine($"ADS Delete did not find: table {table} keyvalue {entity.KeyValue}");
				// write didn't find keyvalue record message
			}
			rdr.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"Delete - {table}");
			return did;
		}

		public TEntity GetEntity<TEntity>(object keyValue) where TEntity : class, IFoxProEntity, new() {
			var qTime = DateTime.Now;
			var sql = "";
			var entity = new TEntity();
			var valid = false;
			if (keyValue != null) {
				var alreadyOpen = Conn.State == ConnectionState.Open;
				if (!alreadyOpen) Conn.Open();
				var cmd = Conn.CreateCommand();
				if (keyValue.GetType().Name.Contains("AnonymousType")) {
					cmd.CommandText = entity.BuildSelectSql(keyValue);
				}
				else {
					var isInt = keyValue.GetType().Name.ToLower().Contains("int");
					var strValue = keyValue.ToString().Trim();
					var tryInt = int.TryParse(strValue, out var intValue);
					sql = isInt && tryInt ? entity.BuildSelectSql(intValue) : entity.BuildSelectSql(strValue);
					cmd.CommandText = sql;
				}
				try {
					var reader = cmd.ExecuteReader();
					while (reader.Read()) {
						entity.FillFromReader(reader);
						valid = true;
					}
					reader.Close();
				}
				catch (Exception e) {
					Console.WriteLine(e);
				}
				if (!alreadyOpen) Conn.Close();
			}
			QueryDebugEnd(qTime, $"GetEntity - {sql}");
			return valid ? entity : null;
		}

		public IList<TEntity> GetEntities<TEntity>(string whereValue, string orderValue, int top) where TEntity : class, IFoxProEntity, new() {
			var qTime = DateTime.Now;
			var entity = new TEntity();
			var entities = new List<TEntity>();
			var obj = new TEntity();
			Conn.Open();
			var cmd = Conn.CreateCommand();
			if (!string.IsNullOrEmpty(whereValue)) whereValue = $" where {whereValue}";
			if (!string.IsNullOrEmpty(orderValue)) orderValue = $" order by {orderValue}";
			var topValue = top != 0 ? $" top {top}" : "";
			var sql = $"select{topValue} * from {obj.GetTableName()}{whereValue}{orderValue}";
			cmd.CommandText = sql;
			try {
				var reader = cmd.ExecuteReader();
				while (reader.Read()) {
					entity = new TEntity();
					entity.FillFromReader(reader);
					entities.Add(entity);
				}
				reader.Close();
			}
			catch (Exception e) {
				Console.WriteLine(e);
			}
			Conn.Close();
			//var table = entity.GetType().Name;
			QueryDebugEnd(qTime, $"GetEntities - {sql}");
			return entities;
		}

		public IList<TEntity> GetEntities<TEntity>(string sql) where TEntity : IFoxProEntity, new() {
			var qTime = DateTime.Now;
			var alreadyOpen = Conn.State == ConnectionState.Open;
			if (!alreadyOpen) Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandText = sql;
			var entity = new TEntity();
			var entities = new List<TEntity>();
			var reader = cmd.ExecuteReader();
			while (reader.Read()) {
				entity = new TEntity();
				entity.FillFromReader(reader);
				entities.Add(entity);
			}
			reader.Close();
			if (!alreadyOpen) Conn.Close();
			QueryDebugEnd(qTime, $"GetEntities - {sql}");
			return entities;
		}

		public IList<TEntity> GetEntities<TEntity>(string sql, List<string> fields) where TEntity : IFoxProEntity, new() {
			var qTime = DateTime.Now;
			var alreadyOpen = Conn.State == ConnectionState.Open;
			if (!alreadyOpen) Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandText = sql;
			var entity = new TEntity();
			var entities = new List<TEntity>();
			var reader = cmd.ExecuteReader();
			while (reader.Read()) {
				entity = new TEntity();
				entity.FillFromReaderList(reader, fields);
				entities.Add(entity);
			}
			reader.Close();
			if (!alreadyOpen) Conn.Close();
			QueryDebugEnd(qTime, $"GetEntities - {sql}");
			return entities;
		}

		public TEntity GetEntitySql<TEntity>(string sql) where TEntity : IFoxProEntity, new() {
			var qTime = DateTime.Now;
			var alreadyOpen = Conn.State == ConnectionState.Open;
			if (!alreadyOpen) Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandText = sql;
			var reader = cmd.ExecuteReader();
			var entity = default(TEntity);
			while (reader.Read()) {
				entity = new TEntity();
				entity.FillFromReader(reader);
			}
			reader.Close();
			if (!alreadyOpen) Conn.Close();
			QueryDebugEnd(qTime, $"GetEntitySql - {sql}");
			return entity;
		}

		public TEntity GetEntitySql<TEntity>(string sql, List<string> fields) where TEntity : IFoxProEntity, new() {
			var qTime = DateTime.Now;
			var alreadyOpen = Conn.State == ConnectionState.Open;
			if (!alreadyOpen) Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandText = sql;
			var reader = cmd.ExecuteReader();
			var entity = default(TEntity);
			while (reader.Read()) {
				entity = new TEntity();
				entity.FillFromReaderList(reader, fields);
			}
			reader.Close();
			if (!alreadyOpen) Conn.Close();
			QueryDebugEnd(qTime, $"GetEntitySql - {sql}");
			return entity;
		}

		public IList<TEntity> GetEntitiesSql<TEntity>(string sql, List<string> fields) where TEntity : IFoxProEntity, new() {
			var qTime = DateTime.Now;
			var alreadyOpen = Conn.State == ConnectionState.Open;
			if (!alreadyOpen) Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandText = sql;
			var reader = cmd.ExecuteReader();
			var entity = default(TEntity);
			var entities = new List<TEntity>();
			while (reader.Read()) {
				entity = new TEntity();
				entity.FillFromReaderList(reader, fields);
				entities.Add(entity);
			}
			reader.Close();
			if (!alreadyOpen) Conn.Close();
			QueryDebugEnd(qTime, $"GetEntitySql - {sql}");
			return entities;
		}

		private string GetFields(List<string> fieldList) {
			var fields = fieldList.Any() ? string.Join(", ", fieldList) : "*";
			return fields;
		}

		public void QueryDebugEnd(DateTime qTime, string queryName) {
			Debug.WriteLine($"ADS: {Math.Round((DateTime.Now - qTime).TotalMilliseconds, 0)} SQL: {queryName}");
		}

	}

}
