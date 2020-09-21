using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Windows;
using Advantage.Data.Provider;
using Common;

namespace AdsDataModel {

	public class hreplin : FoxProEntity, IAgencyCollection {

		public hreplin() {
			Key = "lineid";
		}

		private string _lineid;
		private int _salesno;
		private string _prodline;
		private hrep _hrep;

		[Display(Name = "LineId")]
		[MyCustom(IsVisible = true, IsReadOnly = true)]
		public string lineid { get => _lineid; set => SetProperty(ref _lineid, value); }

		[Display(Name = "Agency")]
		[MyCustom(IsVisible = true, IsReadOnly = true)]
		public int salesno { get => _salesno; set => SetProperty(ref _salesno, value); }

		[Display(Name = "Product Line")]
		[MyCustom(IsVisible = true)]
		public string prodline { get => _prodline; set => SetProperty(ref _prodline, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { lineid };

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public hrep Agency { get => _hrep; set => SetProperty(ref _hrep, value); }

		[Display(Name = "Agency Name")]
		[MyCustom(AdsIgnore = true, IsReadOnly = true)]
		public string AgencyName => Agency?.name;

		[Display(Name = "Region Name")]
		[MyCustom(AdsIgnore = true, IsReadOnly = true)]
		public string AgencyRegionName => Agency?.RegionName;

		[Display(Name = "Regional")]
		[MyCustom(AdsIgnore = true, IsReadOnly = true)]
		public string AgencyRegional => Agency?.Regional;

		[Display(Name = "Regional Email")]
		[MyCustom(AdsIgnore = true, IsReadOnly = true)]
		public string AgencyRegionalEmail => Agency?.RegionalEmail;

		public override int Insert() {
			var context = new FoxProDataContext();
			if (string.IsNullOrEmpty(lineid)) lineid = $"{DateTime.Today:yyyyMMdd}{DateTime.Now.TimeOfDay.TotalMilliseconds.ToString().Replace(".", "")}";
			var recno = context.Insert(this);
			if (recno > 0) {
				DirtyList.Clear();
			}
			return recno;
		}

		public override bool Update() {
			var context = new FoxProDataContext();
			var updated = context.Update(this);
			if (updated) {
			}
			return updated;
		}

		public override bool Delete() {
			var context = new FoxProDataContext();
			var deleted = context.Delete(this);
			if (deleted) {
			}
			return deleted;
		}

		public override void Refresh() {
			var context = new FoxProDataContext();
			var entity = context.GetAgencyProdLine(salesno, prodline);
			if (prodline != entity.prodline) prodline = entity.prodline;
			MakeClean();
		}

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("lineid")) lineid = reader.ReadString("lineid");
			if (InFieldList("salesno")) salesno = reader.ReadInt("salesno");
			if (InFieldList("prodline")) prodline = reader.ReadString("prodline");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public IList<hreplin> GetProdLines(string line) {
			var qTime = DateTime.Now;
			var sql = $"select * from hreplin where prodline like '{line}%' order by prodline";
			var entities = GetEntitiesSql<hreplin>(sql, new List<string>());
			QueryDebugEnd(qTime, $"GetProdLines - {sql}");
			return entities;
		}

		public IList<hreplin> GetAgencyProdLines(int salesno) {
			var qTime = DateTime.Now;
			var sql = $"select * from hreplin where salesno={salesno} order by prodline";
			var entities = GetEntitiesSql<hreplin>(sql, new List<string>());
			QueryDebugEnd(qTime, $"GetAgencyProdLines - {sql}");
			return entities;
		}

		public IList<hreplin> GetAgencyProdLines(string searchValue) {
			var qTime = DateTime.Now;

			var isInt = int.TryParse(searchValue, out var no);
			var whereValue = "";
			if (!string.IsNullOrEmpty(searchValue)) {
				if (isInt) {
					var len = searchValue.StartsWith("1") ? 4 : 3;
					whereValue = searchValue.Length == len ? $"TRUNCATE(salesno/10,0)={searchValue}" : $"salesno={searchValue}";
				}
				else {
					whereValue = $"UPPER(prodline) like '{searchValue.ToUpper()}%'";
				}
			}
			var entities = GetEntities<hreplin>(whereValue, "prodline", 0).ToList();
			//var sql = $"select * from hreplin where salesno={salesno} order by prodline";
			//var entities = GetEntitiesSql<hreplin>(sql, new List<string>());
			QueryDebugEnd(qTime, $"GetAgencyProdLines");
			return entities;
		}

		public hreplin GetAgencyProdLine(int salesno, string line) {
			var qTime = DateTime.Now;
			var sql = $"select * from hreplin where salesno={salesno} and prodline='{line}'";
			var entity = GetEntitySql<hreplin>(sql);
			QueryDebugEnd(qTime, $"GetAgencyProdLine - {sql}");
			return entity;
		}

	}

}
