using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Advantage.Data.Provider;
using Common;

namespace AdsDataModel {

	public class hqdet : FoxProEntity {

		public hqdet() {
			Key = "sqlid";
		}

		private int _sqlid;
		private int _foxid;
		private int _refno;
		private int _lineno;
		private string _itemno;
		private string _pack;
		private int? _qty;
		private decimal? _cprice;
		private decimal? _price;
		private string _desc;
		private string _reflector;
		private string _ref_part;
		private int? _ref_qty;
		private string _type;
		private string _overage;
		private string _code;
		private string _comment;
		private int? _segment;
		private string _rectype;
		private int? _ship_qty;
		private int? _ship_qty2;
		private int? _no_carton;
		private decimal? _wt_carton;
		private int? _no_carton2;
		private decimal? _wt_carton2;
		private int? _prod_qty;
		private int? _prod_qty2;
		private DateTime? _prod_date;
		private int? _pcarton;
		private int? _pcarton2;
		private string _pack2;
		private string _location;
		private string _shpclass;
		private bool? _printedfrm;
		private string _finclass;
		private string _brand;
		private string _pair;
		private int? _lampqty;
		private int? _lampqty2;
		private decimal? _cost;
		private decimal? _fxprice;
		private string _fxcalcfrom;
		private int? _quoteid;
		private bool? _config;
		private string _ldesc;

		public int sqlid { get => _sqlid; set => SetProperty(ref _sqlid, value); }
		public int foxid { get => _foxid; set => SetProperty(ref _foxid, value); }
		public int refno { get => _refno; set => SetProperty(ref _refno, value); }
		public int lineno { get => _lineno; set => SetProperty(ref _lineno, value); }
		public string itemno { get => _itemno; set => SetProperty(ref _itemno, value.Left(8)); }
		public string pack { get => _pack; set => SetProperty(ref _pack, value.Left(2)); }
		public int? qty { get => _qty; set => SetProperty(ref _qty, value); }
		public decimal? cprice { get => _cprice; set => SetProperty(ref _cprice, value); }
		public decimal? price { get => _price; set => SetProperty(ref _price, value); }
		public string desc { get => _desc; set => SetProperty(ref _desc, value.Left(45)); }
		public string reflector { get => _reflector; set => SetProperty(ref _reflector, value.Left(40)); }
		public string ref_part { get => _ref_part; set => SetProperty(ref _ref_part, value.Left(8)); }
		public int? ref_qty { get => _ref_qty; set => SetProperty(ref _ref_qty, value); }
		public string type { get => _type; set => SetProperty(ref _type, value.Left(7)); }
		public string overage { get => _overage; set => SetProperty(ref _overage, value); }
		public string code { get => _code; set => SetProperty(ref _code, value); }
		public string comment { get => _comment; set => SetProperty(ref _comment, value.Left(45)); }
		public int? segment { get => _segment; set => SetProperty(ref _segment, value); }
		public string rectype { get => _rectype; set => SetProperty(ref _rectype, value); }
		public int? ship_qty { get => _ship_qty; set => SetProperty(ref _ship_qty, value); }
		public int? ship_qty2 { get => _ship_qty2; set => SetProperty(ref _ship_qty2, value); }
		public int? no_carton { get => _no_carton; set => SetProperty(ref _no_carton, value); }
		public decimal? wt_carton { get => _wt_carton; set => SetProperty(ref _wt_carton, value); }
		public int? no_carton2 { get => _no_carton2; set => SetProperty(ref _no_carton2, value); }
		public decimal? wt_carton2 { get => _wt_carton2; set => SetProperty(ref _wt_carton2, value); }
		public int? prod_qty { get => _prod_qty; set => SetProperty(ref _prod_qty, value); }
		public int? prod_qty2 { get => _prod_qty2; set => SetProperty(ref _prod_qty2, value); }
		public DateTime? prod_date { get => _prod_date; set => SetProperty(ref _prod_date, value); }
		public int? pcarton { get => _pcarton; set => SetProperty(ref _pcarton, value); }
		public int? pcarton2 { get => _pcarton2; set => SetProperty(ref _pcarton2, value); }
		public string pack2 { get => _pack2; set => SetProperty(ref _pack2, value); }
		public string location { get => _location; set => SetProperty(ref _location, value); }
		public string shpclass { get => _shpclass; set => SetProperty(ref _shpclass, value); }
		public bool? printedfrm { get => _printedfrm; set => SetProperty(ref _printedfrm, value); }
		public string finclass { get => _finclass; set => SetProperty(ref _finclass, value); }
		public string brand { get => _brand; set => SetProperty(ref _brand, value); }
		public string pair { get => _pair; set => SetProperty(ref _pair, value); }
		public int? lampqty { get => _lampqty; set => SetProperty(ref _lampqty, value); }
		public int? lampqty2 { get => _lampqty2; set => SetProperty(ref _lampqty2, value); }
		public decimal? cost { get => _cost; set => SetProperty(ref _cost, value); }
		public decimal? fxprice { get => _fxprice; set => SetProperty(ref _fxprice, value); }
		public string fxcalcfrom { get => _fxcalcfrom; set => SetProperty(ref _fxcalcfrom, value); }
		public int? quoteid { get => _quoteid; set => SetProperty(ref _quoteid, value); }
		public bool? config { get => _config; set => SetProperty(ref _config, value); }
		public string ldesc { get => _ldesc; set => SetProperty(ref _ldesc, value); }

		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[MyCustom(AdsIgnore = true)]
		public override object[] KeyValue {
			get {
				switch (Key) {
					case "refno":
						return new object[] { refno };
					case "itempack":
						return new object[] { itemno.PadRight(8, ' '), pack };
					case "refline":
						return new object[] { refno.ToString().PadRight(8, ' '), lineno.ToString().PadRight(3, ' ') };
					default:
						return new object[] { sqlid };
				}
			}
		}

		[MyCustom(AdsIgnore = true)]
		public string ItemPack => string.IsNullOrEmpty(pack) ? itemno : $"{itemno}-{pack}";

		[MyCustom(AdsIgnore = true)]
		public string Gdesc => !string.IsNullOrEmpty(ldesc) ? ldesc : Finished != null && Finished.itemno != "MISC" ? Finished.gdesc : desc;

		[MyCustom(AdsIgnore = true)]
		public decimal ExtPrice => qty.GetValueOrDefault() * price.GetValueOrDefault();

		[MyCustom(AdsIgnore = true)]
		public decimal ExtCost => qty.GetValueOrDefault() * cost.GetValueOrDefault();

		[MyCustom(AdsIgnore = true)]
		public hfinv Finished { get; set; } = new hfinv();

		public decimal CommPer() {
			switch (code) {
				case "D":
					return 0.01m;
				case "E":
					return 0.02m;
				case "F":
					return 0.03m;
				case "G":
					return 0.04m;
				case "H":
					return 0.05m;
				case "I":
					return 0.06m;
				case "J":
					return 0.07m;
				case "K":
					return 0.08m;
				case "L":
					return 0.09m;
				case "M":
					return 0.1m;
				default:
					return 0.0m;
			}
		}

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("sqlid")) sqlid = reader.ReadInt("sqlid");
			if (InFieldList("foxid")) foxid = reader.ReadInt("foxid");
			if (InFieldList("refno")) refno = reader.ReadInt("refno");
			if (InFieldList("lineno")) lineno = reader.ReadInt("lineno");
			if (InFieldList("itemno")) itemno = reader.ReadString("itemno");
			if (InFieldList("pack")) pack = reader.ReadString("pack");
			if (InFieldList("qty")) qty = reader.ReadInt("qty");
			if (InFieldList("cprice")) cprice = reader.ReadDecimal("cprice");
			if (InFieldList("price")) price = reader.ReadDecimal("price");
			if (InFieldList("desc")) desc = reader.ReadString("desc");
			if (InFieldList("reflector")) reflector = reader.ReadString("reflector");
			if (InFieldList("ref_part")) ref_part = reader.ReadString("ref_part");
			if (InFieldList("ref_qty")) ref_qty = reader.ReadInt("ref_qty");
			if (InFieldList("type")) type = reader.ReadString("type");
			if (InFieldList("overage")) overage = reader.ReadString("overage");
			if (InFieldList("code")) code = reader.ReadString("code");
			if (InFieldList("comment")) comment = reader.ReadString("comment");
			if (InFieldList("segment")) segment = reader.ReadInt("segment");
			if (InFieldList("rectype")) rectype = reader.ReadString("rectype");
			if (InFieldList("ship_qty")) ship_qty = reader.ReadInt("ship_qty");
			if (InFieldList("ship_qty2")) ship_qty2 = reader.ReadInt("ship_qty2");
			if (InFieldList("no_carton")) no_carton = reader.ReadInt("no_carton");
			if (InFieldList("wt_carton")) wt_carton = reader.ReadDecimal("wt_carton");
			if (InFieldList("no_carton2")) no_carton2 = reader.ReadInt("no_carton2");
			if (InFieldList("wt_carton2")) wt_carton2 = reader.ReadDecimal("wt_carton2");
			if (InFieldList("prod_qty")) prod_qty = reader.ReadInt("prod_qty");
			if (InFieldList("prod_qty2")) prod_qty2 = reader.ReadInt("prod_qty2");
			if (InFieldList("prod_date")) prod_date = reader.ReadDate("prod_date");
			if (InFieldList("pcarton")) pcarton = reader.ReadInt("pcarton");
			if (InFieldList("pcarton2")) pcarton2 = reader.ReadInt("pcarton2");
			if (InFieldList("pack2")) pack2 = reader.ReadString("pack2");
			if (InFieldList("location")) location = reader.ReadString("location");
			if (InFieldList("shpclass")) shpclass = reader.ReadString("shpclass");
			if (InFieldList("printedfrm")) printedfrm = reader.ReadBool("printedfrm");
			if (InFieldList("finclass")) finclass = reader.ReadString("finclass");
			if (InFieldList("brand")) brand = reader.ReadString("brand");
			if (InFieldList("pair")) pair = reader.ReadString("pair");
			if (InFieldList("lampqty")) lampqty = reader.ReadInt("lampqty");
			if (InFieldList("lampqty2")) lampqty2 = reader.ReadInt("lampqty2");
			if (InFieldList("cost")) cost = reader.ReadDecimal("cost");
			if (InFieldList("fxprice")) fxprice = reader.ReadDecimal("fxprice");
			if (InFieldList("fxcalcfrom")) fxcalcfrom = reader.ReadString("fxcalcfrom");
			if (InFieldList("quoteid")) quoteid = reader.ReadInt("quoteid");
			if (InFieldList("config")) config = reader.ReadBool("config");
			if (InFieldList("ldesc")) ldesc = reader.ReadString("ldesc");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public IList<hqdet> GetQuoteDetails(int refno) {
			var qTime = DateTime.Now;
			var entities = new List<hqdet>();
			if (refno == 0) return entities;
			var sql = $"select * from hqdet where refno={refno} order by ship_qty";
			entities = GetEntities<hqdet>(sql).ToList();
			foreach (var entity in entities) {
				entity.Finished = GetFinishedInventory(entity.itemno, entity.pack, false);
			}
			QueryDebugEnd(qTime, $"GetQuoteDetails - {sql}");
			return entities;
		}

	}

}
