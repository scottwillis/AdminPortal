using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Windows;
using Advantage.Data.Provider;
using Common;

namespace AdsDataModel {

	public class hregion : FoxProEntity {

		private int _id;
		private string _code;
		private string _name;
		private string _regional;
		private string _login;

		public hregion() {
			Key = "code";
		}

		public int id { get => _id; set => SetProperty(ref _id, value); }

		public string code { get => _code; set => SetProperty(ref _code, value); }

		public string name { get => _name; set => SetProperty(ref _name, value); }

		public string regional { get => _regional; set => SetProperty(ref _regional, value); }

		public string login { get => _login; set => SetProperty(ref _login, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { code };

		[MyCustom(AdsIgnore = true)]
		public string Email => $"{login}@hew.com";

		public override void FillFromReader(AdsDataReader reader) {
			id = reader.ReadInt("id");
			code = reader.ReadString("code");
			name = reader.ReadString("name");
			regional = reader.ReadString("regional");
			login = reader.ReadString("login");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public IList<hregion> GetAllRegions() {
			var qTime = DateTime.Now;
			Conn.Open();
			var entities = new List<hregion>();
			var cmd = Conn.CreateCommand();
			var sql = $"select * from hregion";
			cmd.CommandText = sql;
			var reader = cmd.ExecuteReader();
			while (reader.Read()) {
				var entity = new hregion();
				entity.FillFromReader(reader);
				entities.Add(entity);
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetAllRegions");
			return entities;
		}

		public hregion GetRegionByLogin(string login) {
			var qTime = DateTime.Now;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			var sql = $"select * from hregion where login='{login}'";
			cmd.CommandText = sql;
			var reader = cmd.ExecuteReader();
			var entity = new hregion();
			while (reader.Read()) {
				entity.FillFromReader(reader);
				break;
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetRegionByLogin");
			return entity;
		}

	}

}
