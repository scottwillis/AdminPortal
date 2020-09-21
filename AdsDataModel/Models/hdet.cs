using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using Advantage.Data.Provider;
using Common;
using DataModel;

namespace AdsDataModel {

	public class hdet : FoxProEntity, IPage {

		public hdet() {
			Key = "refline";
		}

		private int _sqlid;
		private int _foxid;
		private int _refno;
		private int _lineno;
		private string _itemno;
		private string _pack;
		private string _version;
		private int? _qty;
		private decimal? _cprice;
		private decimal? _price;
		private string _desc;
		private string _gdesc;
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
		private string _lastrev;
		private DateTime? _schday;
		private string _schline;
		private decimal? _fxprice;
		private string _fxcalcfrom;
		private int? _position;
		private int? _plineno;
		private int? _quoteno;

		[MyCustom(AdsIgnore = true)]
		public int sqlid { get => _sqlid; set => SetProperty(ref _sqlid, value); }

		[MyCustom(AdsIgnore = true)]
		public int foxid { get => _foxid; set => SetProperty(ref _foxid, value); }

		public int refno { get => _refno; set => SetProperty(ref _refno, value); }

		public int lineno { get => _lineno; set => SetProperty(ref _lineno, value); }

		public string itemno { get => _itemno; set => SetProperty(ref _itemno, value?.Left(8)); }

		public string pack { get => _pack; set => SetProperty(ref _pack, value?.Left(2)); }

		public string version { get => _version; set => SetProperty(ref _version, value?.Left(3)); }

		public int? qty { get => _qty; set => SetProperty(ref _qty, value); }

		public decimal? cprice { get => _cprice; set => SetProperty(ref _cprice, value); }

		public decimal? price { get => _price; set => SetProperty(ref _price, value); }

		public string desc { get => _desc; set => SetProperty(ref _desc, value?.Left(45)); }

		[MyCustom(AdsIgnore = true)]
		public string reflector { get => _reflector; set => SetProperty(ref _reflector, value?.Left(40)); }

		[MyCustom(AdsIgnore = true)]
		public string ref_part { get => _ref_part; set => SetProperty(ref _ref_part, value?.Left(8)); }

		[MyCustom(AdsIgnore = true)]
		public int? ref_qty { get => _ref_qty; set => SetProperty(ref _ref_qty, value); }

		public string type { get => _type; set => SetProperty(ref _type, value?.Left(7)); }

		public string overage { get => _overage; set => SetProperty(ref _overage, value?.Left(1)); }

		[MyCustom(AdsIgnore = true)]
		public bool isOverage => cprice != 0 && price != 0 && price > cprice;

		public string code { get => _code; set => SetProperty(ref _code, value?.Left(1)); }

		[MyCustom(AdsIgnore = true)]
		public string CodeWord {
			get {
				switch (code) {
					case "D":
						return "D 1%";
					case "E":
						return "E 2%";
					case "F":
						return "F 3%";
					case "G":
						return "G 4%";
					case "H":
						return "H 5%";
					case "I":
						return "I 6%";
					case "J":
						return "J 7%";
					case "K":
						return "K 8%";
					case "L":
						return "L 9%";
					case "M":
						return "M 10%";
					default:
						return "X 0%";
				}
			}
		}

		public string comment { get => _comment; set => SetProperty(ref _comment, value?.Left(45)); }

		[MyCustom(AdsIgnore = true)]
		public int? segment { get => _segment; set => SetProperty(ref _segment, value); }

		public string rectype { get => _rectype; set => SetProperty(ref _rectype, value?.Left(1)); }

		[MyCustom(AdsIgnore = true)]
		public int? ship_qty { get => _ship_qty; set => SetProperty(ref _ship_qty, value); }

		[MyCustom(AdsIgnore = true)]
		public int? ship_qty2 { get => _ship_qty2; set => SetProperty(ref _ship_qty2, value); }

		[MyCustom(AdsIgnore = true)]
		public int? no_carton { get => _no_carton; set => SetProperty(ref _no_carton, value); }

		[MyCustom(AdsIgnore = true)]
		public decimal? wt_carton { get => _wt_carton; set => SetProperty(ref _wt_carton, value); }

		[MyCustom(AdsIgnore = true)]
		public int? no_carton2 { get => _no_carton2; set => SetProperty(ref _no_carton2, value); }

		[MyCustom(AdsIgnore = true)]
		public decimal? wt_carton2 { get => _wt_carton2; set => SetProperty(ref _wt_carton2, value); }

		[MyCustom(AdsIgnore = true)]
		public int? prod_qty { get => _prod_qty; set => SetProperty(ref _prod_qty, value); }

		[MyCustom(AdsIgnore = true)]
		public int? prod_qty2 { get => _prod_qty2; set => SetProperty(ref _prod_qty2, value); }

		[MyCustom(AdsIgnore = true)]
		public DateTime? prod_date { get => _prod_date; set => SetProperty(ref _prod_date, value); }

		[MyCustom(AdsIgnore = true)]
		public int? pcarton { get => _pcarton; set => SetProperty(ref _pcarton, value); }

		[MyCustom(AdsIgnore = true)]
		public int? pcarton2 { get => _pcarton2; set => SetProperty(ref _pcarton2, value); }

		public string pack2 { get => _pack2; set => SetProperty(ref _pack2, value?.Left(2)); }

		[MyCustom(AdsIgnore = true)]
		public string location { get => _location; set => SetProperty(ref _location, value?.Left(4)); }

		[MyCustom(AdsIgnore = true)]
		public string shpclass { get => _shpclass; set => SetProperty(ref _shpclass, value?.Left(4)); }

		[MyCustom(AdsIgnore = true)]
		public bool? printedfrm { get => _printedfrm; set => SetProperty(ref _printedfrm, value); }

		[MyCustom(AdsIgnore = true)]
		public string finclass { get => _finclass; set => SetProperty(ref _finclass, value?.Left(2)); }

		public string brand { get => _brand; set => SetProperty(ref _brand, value?.Left(1)); }

		public string pair { get => _pair; set => SetProperty(ref _pair, value?.Left(1)); }

		[MyCustom(AdsIgnore = true)]
		public int? lampqty { get => _lampqty; set => SetProperty(ref _lampqty, value); }

		[MyCustom(AdsIgnore = true)]
		public int? lampqty2 { get => _lampqty2; set => SetProperty(ref _lampqty2, value); }

		public decimal? cost { get => _cost; set => SetProperty(ref _cost, value); }

		public string lastrev { get => _lastrev; set => SetProperty(ref _lastrev, value?.Left(1)); }

		[MyCustom(AdsIgnore = true)]
		public DateTime? schday { get => _schday; set => SetProperty(ref _schday, value); }

		[MyCustom(AdsIgnore = true)]
		public string schline { get => _schline; set => SetProperty(ref _schline, value?.Left(2)); }

		[MyCustom(AdsIgnore = true)]
		public decimal? fxprice { get => _fxprice; set => SetProperty(ref _fxprice, value); }

		[MyCustom(AdsIgnore = true)]
		public string fxcalcfrom { get => _fxcalcfrom; set => SetProperty(ref _fxcalcfrom, value?.Left(1)); }

		public int? position { get => _position; set => SetProperty(ref _position, value); }

		public int? plineno { get => _plineno; set => SetProperty(ref _plineno, value); }

		public int? quoteno { get => _quoteno; set => SetProperty(ref _quoteno, value); }

		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue {
			get {
				switch (Key) {
					case "itempack":
						return new object[] { itemno.PadRight(8, ' '), pack };
					case "refline":
						return new object[] { refno.ToString().PadRight(8, ' '), lineno.ToString().PadRight(3, ' ') };
					default:
						return new object[] { refno };
				}
			}
		}

		[MyCustom(AdsIgnore = true)]
		public string ItemPack => $"{itemno}-{pack}";

		[MyCustom(AdsIgnore = true)]
		public string Gdesc { get => !string.IsNullOrEmpty(_gdesc) ? _gdesc : desc; set { _gdesc = value; OnPropertyChanged(); } }

		[MyCustom(AdsIgnore = true)]
		public int ShipQty => ship_qty.GetValueOrDefault() + ship_qty2.GetValueOrDefault();

		[MyCustom(AdsIgnore = true)]
		public int BoQty => qty.GetValueOrDefault() - ShipQty;

		[MyCustom(AdsIgnore = true)]
		public int WtCarton => (int) Math.Round(wt_carton.GetValueOrDefault() + wt_carton2.GetValueOrDefault(), 0);

		[MyCustom(AdsIgnore = true)]
		public int NoCarton => no_carton.GetValueOrDefault() + no_carton2.GetValueOrDefault();

		[MyCustom(AdsIgnore = true)]
		public int Weight => (int) Math.Round(no_carton.GetValueOrDefault() * wt_carton.GetValueOrDefault(), 0) + (int) Math.Round(no_carton2.GetValueOrDefault() * wt_carton2.GetValueOrDefault(), 0);

		[MyCustom(AdsIgnore = true)]
		public int ProdQty => prod_qty.GetValueOrDefault() + prod_qty2.GetValueOrDefault();

		[MyCustom(AdsIgnore = true)]
		public decimal ExtPrice => (ShipQty > 0 ? ShipQty : qty.GetValueOrDefault()) * price.GetValueOrDefault();

		[MyCustom(AdsIgnore = true)]
		public bool Overage => price.GetValueOrDefault() > cprice.GetValueOrDefault() && price.GetValueOrDefault() != 0 && cprice.GetValueOrDefault() != 0;

		[MyCustom(AdsIgnore = true)]
		public decimal TotalOverage => Commissions.GetOverage(price.GetValueOrDefault(), cprice.GetValueOrDefault(), qty.GetValueOrDefault(), hord?.comper.GetValueOrDefault() ?? 0);

		[MyCustom(AdsIgnore = true)]
		public decimal? Commission => Commissions.GetCommission(code, ShipQty != 0 ? ShipQty : qty.GetValueOrDefault(), cprice.GetValueOrDefault());

		[MyCustom(AdsIgnore = true)]
		public decimal? TotalRepCompensation => Commission + TotalOverage;

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public int Page { get; set; } = 1;

		[MyCustom(AdsIgnore = true)]
		public hfinv Finished { get; set; } = new hfinv();

		[MyCustom(AdsIgnore = true)]
		public hord hord { get; set; } = new hord();

		public override bool Update() {
			var context = new FoxProDataContext();
			var updated = context.Update(this);
			if (updated) {

			}
			return updated;
		}

		public override void Refresh() {
			var context = new FoxProDataContext();
			var entity = context.GetEntity<hdet>(KeyValue);
			if (itemno != entity.itemno) itemno = entity.itemno;
			MakeClean();
		}

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("sqlid")) sqlid = reader.ReadInt("sqlid");
			if (InFieldList("foxid")) foxid = reader.ReadInt("foxid");
			if (InFieldList("refno")) refno = reader.ReadInt("refno");
			if (InFieldList("lineno")) lineno = reader.ReadInt("lineno");
			if (InFieldList("itemno")) itemno = reader.ReadString("itemno");
			if (InFieldList("pack")) pack = reader.ReadString("pack");
			if (InFieldList("version")) version = reader.ReadString("version");
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
			if (InFieldList("lastrev")) lastrev = reader.ReadString("lastrev");
			if (InFieldList("schday")) schday = reader.ReadDate("schday");
			if (InFieldList("schline")) schline = reader.ReadString("schline");
			if (InFieldList("fxprice")) fxprice = reader.ReadDecimal("fxprice");
			if (InFieldList("fxcalcfrom")) fxcalcfrom = reader.ReadString("fxcalcfrom");
			if (InFieldList("position")) position = reader.ReadInt("position");
			if (InFieldList("plineno")) plineno = reader.ReadInt("plineno");
			if (InFieldList("quoteno")) quoteno = reader.ReadInt("quoteno");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public IList<hdet> GetOrderDetailBySchDay(DateTime start, DateTime end, List<string> lines) {
			var qTime = DateTime.Now;
			var sql = $"select * from hdet where schday>='{start.ToShortDateString()}' and schday<='{end.ToShortDateString()}' and schline contains {lines}"; //NEED fixed!!
			var entities = GetEntities<hdet>(sql);
			QueryDebugEnd(qTime, $"GetOrderDetailBySchDay - {sql}");
			return entities;
		}

		public IList<hdet> GetOrderDetailsByDesc(string desc) {
			var qTime = DateTime.Now;
			var sql = $"select * from hdet where desc like '{desc}%'"; //NEED fixed!!
			var entities = GetEntities<hdet>(sql);
			QueryDebugEnd(qTime, $"GetOrderDetailsByDesc - {sql}");
			return entities;
		}

		public IList<hdet> GetOrderDetailsByDateDesc(DateTime start, string desc) {
			var qTime = DateTime.Now;
			var entities = new List<hdet>();
			var fields = new List<string> { "refno", "[desc]", "qty", "price" };
			var sql = $"select {string.Join(", ", fields)} from hdet d where d.[desc] like '{desc}%'";
			var entities1 = GetEntities<hdet>(sql, fields);
			var fields2 = new List<string> { "date", "orderno", "sale1" };
			var sql2 = $"select {string.Join(", ", fields2)} from hord o where o.invdate>='{start.ToShortDateString()}'";
			var entities2 = GetEntities<hord>(sql2, fields2);
			foreach (var entity in entities2) {
				var dets = entities1.Where(x => x.refno == entity.orderno).ToList();
				foreach (var det in dets) {
					det.hord = entity;
					entities.Add(det);
				}
			}
			QueryDebugEnd(qTime, $"GetOrderDetailsByDateDesc - {sql}");
			return entities;
		}

		public IList<hdet> GetOrderDetailsByDateDesc3(DateTime start, string desc) {
			var qTime = DateTime.Now;
			var entities = new List<hdet>();
			var sql = $"select * from hdet d where d.[desc] like '{desc}%'";
			var entities1 = GetEntities<hdet>(sql);
			var sql2 = $"select * from hord o where o.invdate>='{start.ToShortDateString()}'";
			var entities2 = GetEntities<hord>(sql2);
			foreach (var entity in entities2) {
				var dets = entities1.Where(x => x.refno == entity.orderno).ToList();
				foreach (var det in dets) {
					det.hord = entity;
					entities.Add(det);
				}
			}
			QueryDebugEnd(qTime, $"GetOrderDetailsByDateDesc3 - {sql}");
			return entities;
		}

		public IList<hdet> GetOrderDetailsByDateDesc4(DateTime start, string desc) {
			var qTime = DateTime.Now;
			var fields = new List<string> { "refno", "[desc]", "qty", "price", "date", "orderno", "sale1" };
			var sql = $"select {string.Join(", ", fields)} from hdet d, hord o where o.orderno=d.refno and o.invdate>='{start.ToShortDateString()}' and [desc] like '{desc}%'";
			//var sql = $"select {string.Join(", ", fields)} from hord o inner join hdet d on o.orderno=d.refno where o.invdate>='{start.ToShortDateString()}' and d.[desc] like '{desc}%'";
			//var sql = $"select {string.Join(", ", fields)} from hdet d inner join hord o on d.refno=o.orderno where d.[desc] like '{desc}%' and o.invdate>='{start.ToShortDateString()}'";
			var entities = GetEntities<hdet>(sql, fields);
			QueryDebugEnd(qTime, $"GetOrderDetailsByDateDesc4 - {sql}");
			return entities;
		}

		public hdet GetOrderDetailByLineNo(int no, int lineNo) {
			var qTime = DateTime.Now;
			if (no == 0 || lineNo == 0) return null;
			var sql = $"select * from hdet where refno={no} and lineno={lineNo}";
			var entity = GetEntitySql<hdet>(sql);
			QueryDebugEnd(qTime, $"GetOrderDetailByLineNo - {sql}");
			return entity;
		}

		public IList<hdet> GetOrderDetails(int no) {
			var qTime = DateTime.Now;
			var entities = new List<hdet>();
			if (no == 0) return entities;
			////var sql = $"select * from hdet where refno={no} order by lineno";
			//var sql = $"select * from hdet where refno={no}";
			//entities = GetEntities<hdet>(sql).ToList();

			Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hdet";
			var reader = cmd.ExecuteExtendedReader();
			reader.ActiveIndex = "refline";
			var found = reader.Seek(new object[] { no }, AdsExtendedReader.SeekType.HardSeek);
			//if (!found) {
			//	found = reader.Seek(new object[] { no, 0 }, AdsExtendedReader.SeekType.SeekGT);
			//}
			if (found) {
				var valid = true;
				while (valid) {
					var refno = reader.ReadInt("refno");
					if (refno == no) {
						var entity = new hdet();
						entity.FillFromReader(reader);
						entities.Add(entity);
					}
					else break;
					valid = reader.Read();
				}
			}
			reader.Close();
			Conn.Close();

			QueryDebugEnd(qTime, $"GetOrderDetails");
			return entities;
		}

	}

}
