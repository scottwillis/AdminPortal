using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using Advantage.Data.Provider;
using Common;

namespace AdsDataModel {

	public static class DataModelExtensions {

		public static bool IsField(this AdsDataReader reader, string field) {
			var table = reader.GetSchemaTable();
			var rows = table?.Rows.Cast<DataRow>().ToList();
			var item = rows?.SingleOrDefault(x => (string) x.ItemArray[0] == field);
			return item != null;
		}

		public static DateTime? ReadDate(this AdsDataReader reader, string field) {
			var x = (DateTime?)null;
			try {
				var col = reader.GetOrdinal(field);
				if (string.IsNullOrEmpty(reader.GetValue(col).ToString())) return null;
				var good = DateTime.TryParse(reader.GetValue(col).ToString(), out var xx);
				x = xx;
			}
			catch (Exception e) {
				Debug.WriteLine(e);
			}
			return x;
		}

		public static DateTime ReadDateNotNull(this AdsDataReader reader, string field) {
			var x = DateTime.Today;
			try {
				var col = reader.GetOrdinal(field);
				if (string.IsNullOrEmpty(reader.GetValue(col).ToString())) return x;
				var good = DateTime.TryParse(reader.GetValue(col).ToString(), out var xx);
				x = xx;
			}
			catch (Exception e) {
				Debug.WriteLine(e);
			}
			return x;
		}

		public static DateTime? ReadDate(this AdsDataReader reader, int col) {
			if (string.IsNullOrEmpty(reader.GetValue(col).ToString())) return null;
			var good = DateTime.TryParse(reader.GetValue(col).ToString(), out var x);
			return good ? x : (DateTime?)null;
		}

		public static string ReadString(this AdsDataReader reader, string field) {
			string x = null;
			try {
				var col = reader.GetOrdinal(field);
				x = reader.GetValue(col)?.ToString();
			}
			catch (Exception e) {
				Debug.WriteLine(e);
			}
			return x;
		}

		public static string ReadString(this AdsDataReader reader, int col) {
			return reader.GetValue(col) == null ? null : reader.GetValue(col).ToString();
		}

		public static char ReadChar(this AdsDataReader reader, string field) {
			var x = new char();
			try {
				var col = reader.GetOrdinal(field);
				if (reader.GetValue(col) == null) return x;
				var good = char.TryParse(reader.GetValue(col).ToString(), out x);
			}
			catch (Exception e) {
				Debug.WriteLine(e);
			}
			return x;
		}

		public static char ReadChar(this AdsDataReader reader, int col) {
			if (reader.GetValue(col) == null) return new char();
			var good = char.TryParse(reader.GetValue(col).ToString(), out var x);
			return good ? x : new char();
		}

		public static int ReadInt(this AdsDataReader reader, string field) {
			var x = 0;
			try {
				var col = reader.GetOrdinal(field);
				if (reader.GetValue(col) == null) return x;
				var good = int.TryParse(reader.GetValue(col).ToString(), out x);
			}
			catch (Exception e) {
				Debug.WriteLine(e);
			}
			return x;
		}

		public static int ReadInt(this AdsDataReader reader, int col) {
			if (reader.GetValue(col) == null) return 0;
			var good = int.TryParse(reader.GetValue(col).ToString(), out var x);
			return good ? x : 0;
		}

		public static decimal ReadDecimal(this AdsDataReader reader, string field) {
			decimal x = 0;
			try {
				var col = reader.GetOrdinal(field);
				if (reader.GetValue(col) == null) return x;
				var good = decimal.TryParse(reader.GetValue(col).ToString(), out x);
			}
			catch (Exception e) {
				Debug.WriteLine(e);
			}
			return x;
		}

		public static decimal ReadDecimal(this AdsDataReader reader, int col) {
			if (reader.GetValue(col) == null) return 0;
			var good = decimal.TryParse(reader.GetValue(col).ToString(), out var x);
			return good ? x : 0;
		}

		public static bool ReadBool(this AdsDataReader reader, string field) {
			var x = false;
			try {
				var col = reader.GetOrdinal(field);
				if (reader.GetValue(col) == null) return x;
				var good = bool.TryParse(reader.GetValue(col).ToString(), out x);
			}
			catch (Exception e) {
				Debug.WriteLine(e);
			}
			return x;
		}

		public static bool ReadBool(this AdsDataReader reader, int col) {
			if (reader.GetValue(col) == null) return false;
			var good = bool.TryParse(reader.GetValue(col).ToString(), out var x);
			return good && x;
		}

		public static string BuildSelectSql(this IFoxProEntity entity, int keyValue) {
			return $"select top 1 * from {entity.GetTableName()} where [{entity.Key}]={keyValue}";
		}

		public static string BuildSelectSql(this IFoxProEntity entity, string keyValue) {
			return $"select top 1 * from {entity.GetTableName()} where [{entity.Key}]='{keyValue}'";
		}

		public static string BuildSelectSql(this IFoxProEntity entity, object keyValue) {
			var where = "";
			var props = keyValue.GetType().GetProperties();
			foreach (var prop in props) {
				if (!string.IsNullOrEmpty(where)) where = $"{where} and";
				var q = prop.PropertyType.FullName.Contains("String") ? "'" : "";
				var propValue = prop.GetValue(keyValue);
				where = $"{where} [{prop.Name}] = {q}{propValue}{q}";
			}
			var sql = $"select top 1 * from {entity.GetTableName()} where {where}";
			return sql;
		}

		public static string BuildMultiSelectSql(this IFoxProEntity entity, string whereValue) {
			return $"select * from {entity.GetTableName()} where {whereValue}";
		}

		public static string BuildInsertSql(this IFoxProEntity obj) {
			var sb = new StringBuilder();
			var sb1 = new StringBuilder();
			var sb2 = new StringBuilder();
			foreach (var prop in obj.GetType().GetProperties()) {
				var att = prop.GetAttribute<MyCustomAttribute>();
				if (att != null && (att.AdsIgnore || att.AdsReadOnly)) continue;
				var value = prop.GetValue(obj, null);
				if (value == null) continue;
				var isDate = prop.PropertyType.FullName != null && prop.PropertyType.FullName.Contains("DateTime");
				if (isDate) {
					value = ((DateTime)value).ToShortDateString();
				}
				var q = prop.PropertyType.Name.Equals("String") || isDate ? "'" : "";
				sb1.Append($"[{prop.Name}], ");
				sb2.Append($"{q}{value}{q}, ");
			}
			if (sb1.ToString().EndsWith(", ")) sb1.Length = sb1.Length - 2;
			if (sb2.ToString().EndsWith(", ")) sb2.Length = sb2.Length - 2;
			var table = obj.GetType().Name;
			//if (table.StartsWith("h")) table = $"x{table.Remove(0, 1)}";
			sb.Append($"insert into {table} ({sb1}) values ({sb2})");
			return sb.ToString();
		}

		public static string BuildUpdateSql(this IFoxProEntity obj) {
			var sb = new StringBuilder();
			var sb1 = new StringBuilder();
			foreach (var prop in obj.GetType().GetProperties()) {
				var att = prop.GetAttribute<MyCustomAttribute>();
				if (att != null && (att.AdsIgnore || att.AdsReadOnly)) continue;
				if (!obj.DirtyList.Contains(prop.Name)) continue;
				var value = prop.GetValue(obj, null);
				if (value == null) continue;
				var isDate = prop.PropertyType.FullName != null && prop.PropertyType.FullName.Contains("DateTime");
				if (isDate) value = ((DateTime)value).ToShortDateString();
				var q = prop.PropertyType.Name.Equals("String") || isDate ? "'" : "";
				sb1.Append($"[{prop.Name}] = {q}{value}{q}, ");
			}
			if (sb1.ToString().EndsWith(", ")) sb1.Length = sb1.Length - 2;
			var table = obj.GetType().Name;
			//if (table.StartsWith("h")) table = $"x{table.Remove(0, 1)}";
			var wq = obj.KeyValue.GetType().Name.Equals("String") ? "'" : "";
			sb.Append($"update {table} set {sb1} where [{obj.Key}]={wq}{obj.KeyValue}{wq}");
			return sb.ToString();
		}

		public static string GetTableName(this IFoxProEntity entity) {
			var table = entity.GetType().Name;
			//if (table.StartsWith("h")) table = $"x{table.Remove(0, 1)}";
			return table;
		}

		public static FoxType GetFoxType(this PropertyInfo prop) {
			if (prop.PropertyType.FullName != null && prop.PropertyType.FullName.Contains("DateTime")) return FoxType.DateTime;
			if (prop.PropertyType.FullName != null && prop.PropertyType.FullName.Contains("String")) return FoxType.String;
			if (prop.PropertyType.FullName != null && prop.PropertyType.FullName.Contains("Int32")) return FoxType.Int32;
			if (prop.PropertyType.FullName != null && prop.PropertyType.FullName.Contains("Decimal")) return FoxType.Decimal;
			if (prop.PropertyType.FullName != null && prop.PropertyType.FullName.Contains("Boolean")) return FoxType.Boolean;
			return FoxType.String;
		}

		public static bool FoxTableLock(this AdsExtendedReader rdr, string table) {
			var isLocked = false;
			for (var i = 0; i < 100; i++) {
				try {
					rdr.LockTable();
					isLocked = rdr.IsTableLocked();
					if (isLocked) break;
				}
				catch (Exception e) {
					Debug.WriteLine($"waiting for flock {rdr.RecordNumber}");
					System.Threading.Thread.Sleep(500);
				}
			}
			if (!isLocked) {
				Debug.WriteLine($"Unable to flock {table}");
			}
			return isLocked;
		}

		public static bool FoxRecordLock(this AdsExtendedReader rdr, string table) {
			var isLocked = false;
			for (var i = 0; i < 100; i++) {
				try {
					rdr.LockRecord();
					isLocked = rdr.IsRecordLocked();
					if (isLocked) break;
				}
				catch (Exception e) {
					Debug.WriteLine($"waiting for lock {rdr.RecordNumber}");
					System.Threading.Thread.Sleep(500);
				}
			}
			if (!isLocked) {
				Debug.WriteLine($"Unable to flock {table}");
			}
			return isLocked;
		}

		public static bool FoxProSeek(this AdsExtendedReader rdr, IFoxProEntity entity) {
			rdr.ActiveIndex = entity.Key;
			var found = rdr.Seek(entity.KeyValue, AdsExtendedReader.SeekType.HardSeek);
			return found;
		}

		public static List<T> GetAttributes<T>(this ICustomAttributeProvider pi) where T : Attribute {
			return pi.GetCustomAttributes(typeof(T), false).OfType<T>().Select(a => a).ToList();
		}

		public static T GetAttribute<T>(this ICustomAttributeProvider cap) where T : Attribute {
			var atts = cap.GetAttributes<T>();
			return (atts.Count > 0) ? atts[0] : null;
		}

		public static T GetAttribute<T>(PropertyInfo pi) where T : Attribute {
			var atts = pi.GetAttributes<T>();
			return (atts.Count > 0) ? atts[0] : null;
		}

	}

	public enum FoxType {
		String,
		Int32,
		Decimal,
		DateTime,
		Boolean
	}

}

