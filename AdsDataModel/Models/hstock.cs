using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Advantage.Data.Provider;
using Common;

namespace AdsDataModel {

	public class hstock : FoxProEntity {

		public hstock() {
			Key = "itempack";
		}

		private string _itemno;
		private string _pack;
		private string _desc;
		private int _req_wk1;
		private int _req_wk2;
		private int _req_wk3;
		private int _req_othpak;
		private int _qtyonstk;
		private int _palletqty;
		private int _targetqty;

		[Display(Name = "ItemNo", Order = 10)]
		[MyCustom(Width = "*", IsVisible = true)]
		public string itemno { get => _itemno; set => SetProperty(ref _itemno, value); }

		[Display(Name = "Pack")]
		[MyCustom(Width = "*", IsVisible = true)]
		public string pack { get => _pack; set => SetProperty(ref _pack, value); }

		[Display(Name = "Desc")]
		[MyCustom(Width = "*", IsVisible = true)]
		public string desc { get => _desc; set => SetProperty(ref _desc, value); }

		public int req_wk1 { get => _req_wk1; set => SetProperty(ref _req_wk1, value); }

		public int req_wk2 { get => _req_wk2; set => SetProperty(ref _req_wk2, value); }

		public int req_wk3 { get => _req_wk3; set => SetProperty(ref _req_wk3, value); }

		public int req_othpak { get => _req_othpak; set => SetProperty(ref _req_othpak, value); }

		public int qtyonstk { get => _qtyonstk; set => SetProperty(ref _qtyonstk, value); }

		public int palletqty { get => _palletqty; set => SetProperty(ref _palletqty, value); }

		public int targetqty { get => _targetqty; set => SetProperty(ref _targetqty, value); }

		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { itemno, pack };

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("itemno")) itemno = reader.ReadString("itemno");
			if (InFieldList("pack")) pack = reader.ReadString("pack");
			if (InFieldList("desc")) desc = reader.ReadString("desc");
			if (InFieldList("req_wk1")) req_wk1 = reader.ReadInt("req_wk1");
			if (InFieldList("req_wk2")) req_wk2 = reader.ReadInt("req_wk2");
			if (InFieldList("req_wk3")) req_wk3 = reader.ReadInt("req_wk3");
			if (InFieldList("req_othpak")) req_othpak = reader.ReadInt("req_othpak");
			if (InFieldList("qtyonstk")) qtyonstk = reader.ReadInt("qtyonstk");
			if (InFieldList("palletqty")) palletqty = reader.ReadInt("palletqty");
			if (InFieldList("targetqty")) targetqty = reader.ReadInt("targetqty");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public hstock GetStock(string desc) {
			var qTime = DateTime.Now;
			var sql = $"select * from hstock where desc={desc}";
			var entity = GetEntitySql<hstock>(sql);
			QueryDebugEnd(qTime, $"GetStock - {sql}");
			return entity;
		}

	}

}
