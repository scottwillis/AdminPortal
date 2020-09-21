using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Advantage.Data.Provider;
using Common;

namespace AdsDataModel {

	public class hcstsrv : FoxProEntity {

		private string _custserv;
		private string _login;
		private string _name;

		public hcstsrv() {
			Key = "custserv";
		}

		[Display(Name = "Code", Order = 10)]
		[MyCustom(Width = "*")]
		public string custserv { get => _custserv; set => SetProperty(ref _custserv, value); }

		[Display(Name = "Login", Order = 11)]
		[MyCustom(Width = "*")]
		public string login { get => _login; set => SetProperty(ref _login, value); }

		[Display(Name = "Name", Order = 12)]
		[MyCustom(Width = "*")]
		public string name { get => _name; set => SetProperty(ref _name, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { custserv };

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public string Email => $"{login}@hew.com";

		public override bool Update() {
			var context = new FoxProDataContext();
			var updated = context.Update(this);
			if (updated) {

			}
			return updated;
		}

		public override void Refresh() {
			var context = new FoxProDataContext();
			var entity = context.GetEntity<hcstsrv>(custserv);
			if (login != entity.login) login = entity.login;
			if (name != entity.name) name = entity.name;
			MakeClean();
		}

		public override void FillFromReader(AdsDataReader reader) {
			custserv = reader.ReadString("custserv");
			login = reader.ReadString("login");
			name = reader.ReadString("name");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public hcstsrv GetCustSrv(string code) {
			var qTime = DateTime.Now;
			var sql = $"select * from hcstsrv where custserv='{code}'";
			var entity = GetEntitySql<hcstsrv>(sql);
			QueryDebugEnd(qTime, $"GetCustSrv - {sql}");
			return entity;
		}

		public IList<hcstsrv> GetAllCstSrvs() {
			var qTime = DateTime.Now;
			Conn.Open();
			var entities = new List<hcstsrv>();
			var cmd = Conn.CreateCommand();
			var sql = $"select * from hcstsrv";
			cmd.CommandText = sql;
			var reader = cmd.ExecuteReader();
			while (reader.Read()) {
				var entity = new hcstsrv();
				entity.FillFromReader(reader);
				entities.Add(entity);
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetAllCstSrvs");
			return entities;
		}

		public IList<hcstsrv> GetActiveCstSrvs() {
			var qTime = DateTime.Now;
			Conn.Open();
			var entities = new List<hcstsrv>();
			var cmd = Conn.CreateCommand();
			var sql = $"select * from hcstsrv where login<>''";
			cmd.CommandText = sql;
			var reader = cmd.ExecuteReader();
			while (reader.Read()) {
				var entity = new hcstsrv();
				entity.FillFromReader(reader);
				entities.Add(entity);
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetActiveCstSrvs");
			return entities;
		}

	}

}
