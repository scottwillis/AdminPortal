using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Advantage.Data.Provider;
using Common;

namespace AdsDataModel {

	public class hrefl : FoxProEntity {

		private string _style;
		private string _code;
		private int? _qty;
		private string _series;
		private int? _length;
		private int? _lampqty;
		private string _b_style;
		private decimal? _book_price;
		private string _partno;
		private string _comm;
		private string _prodtype;

		public hrefl() {
			Key = "style";
		}

		public string style { get => _style; set => SetProperty(ref _style, value); }
		public string code { get => _code; set => SetProperty(ref _code, value); }
		public int? qty { get => _qty; set => SetProperty(ref _qty, value); }
		public string series { get => _series; set => SetProperty(ref _series, value); }
		public int? length { get => _length; set => SetProperty(ref _length, value); }
		public int? lampqty { get => _lampqty; set => SetProperty(ref _lampqty, value); }
		public string b_style { get => _b_style; set => SetProperty(ref _b_style, value); }
		public decimal? book_price { get => _book_price; set => SetProperty(ref _book_price, value); }
		public string partno { get => _partno; set => SetProperty(ref _partno, value); }
		public string comm { get => _comm; set => SetProperty(ref _comm, value); }
		public string prodtype { get => _prodtype; set => SetProperty(ref _prodtype, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { style, code, series, length.ToString(), lampqty.ToString(), b_style };

		public override bool Update() {
			var context = new FoxProDataContext();
			var updated = context.Update(this);
			if (updated) {

			}
			return updated;
		}

		public override void Refresh() {
			var context = new FoxProDataContext();
			var entity = context.GetEntity<hrefl>(style);
			if (series != entity.series) series = entity.series;
			MakeClean();
		}

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("style")) style = reader.ReadString("style");
			if (InFieldList("code")) code = reader.ReadString("code");
			if (InFieldList("qty")) qty = reader.ReadInt("qty");
			if (InFieldList("series")) series = reader.ReadString("series");
			if (InFieldList("length")) length = reader.ReadInt("length");
			if (InFieldList("lampqty")) lampqty = reader.ReadInt("lampqty");
			if (InFieldList("b_style")) b_style = reader.ReadString("b_style");
			if (InFieldList("book_price")) book_price = reader.ReadDecimal("book_price");
			if (InFieldList("partno")) partno = reader.ReadString("partno");
			if (InFieldList("comm")) comm = reader.ReadString("comm");
			if (InFieldList("prodtype")) prodtype = reader.ReadString("prodtype");
			MakeClean();
		}

	}

}
