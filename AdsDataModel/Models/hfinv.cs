using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Advantage.Data.Provider;
using Common;

namespace AdsDataModel {

	public class hfinv : FoxProEntity {

		public hfinv() {
			Key = "itemno";
		}

		private int _sqlid;
		private int _foxid;
		private string _itemno;
		private string _pack;
		private string _desc;
		private string _base;
		private string _frame;
		private string _shield;
		private string _ref_style;
		private string _ref_code;
		private string _bal_asby;
		private string _bal_volt;
		private string _opt1;
		private string _opt2;
		private string _opt3;
		private string _opt4;
		private string _opt5;
		private string _opt6;
		private string _opt7;
		private string _opt8;
		private string _opt9;
		private string _opt10;
		private string _opt1qty;
		private string _opt2qty;
		private string _opt3qty;
		private string _opt4qty;
		private string _opt5qty;
		private string _opt6qty;
		private string _opt7qty;
		private string _opt8qty;
		private string _opt9qty;
		private string _opt10qty;
		private int? _stock;
		private string _hasbm;
		private string _haspbm;
		private int? _alloc;
		private int? _prodalloc;
		private int? _ropoint;
		private int? _roqty;
		private decimal? _weight;
		private decimal? _cuft;
		private string _stocking;
		private decimal? _minutes;
		private decimal? _pminutes;
		private decimal? _cost;
		private decimal? _sale_price;
		private string _shpclass;
		private string _line1;
		private string _line2;
		private string _origin;
		private string _class;
		private string _shld_manuf;
		private DateTime? _firstodate;
		private int? _firstorder;
		private string _prodtype;
		private string _enginvolve;
		private string _upccode;
		private string _invtype;
		private string _ulcode;
		private string _balldis;
		private string _basebment;
		private string _basebmchg;
		private string _packbment;
		private string _packbmchg;
		private string _fpent;
		private string _fpchg;
		private string _fpstat;
		private string _schno;
		private string _schnoalt;
		private string _schgeniot;
		private string _schosriot;
		private string _version;
		private DateTime? _verdate;
		private string _vercomment;
		private string _vermasschg;
		private string _bmlockby;
		private string _genlabel;
		private string _gdesc;
		private IList<hfinvbm> _bom;

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public int sqlid { get => _sqlid; set => SetProperty(ref _sqlid, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public int foxid { get => _foxid; set => SetProperty(ref _foxid, value); }

		[Display(Name = "ItemNo")]
		[MyCustom(IsVisible = true)]
		public string itemno { get => _itemno; set => SetProperty(ref _itemno, value?.Left(8)); }

		[Display(Name = "Pack")]
		[MyCustom(IsVisible = true)]
		public string pack { get => _pack; set => SetProperty(ref _pack, value?.Left(2)); }

		[Display(Name = "GenDesc")]
		[MyCustom(IsVisible = true)]
		public string gdesc { get => _gdesc; set => SetProperty(ref _gdesc, value?.Left(240)); }

		[Display(Name = "Desc")]
		[MyCustom(IsVisible = true)]
		public string desc { get => _desc; set => SetProperty(ref _desc, value?.Left(50)); }

		[Display(Name = "Base")]
		[MyCustom(IsVisible = true)]
		public string Base { get => _base; set => SetProperty(ref _base, value?.Left(40)); }

		[Display(Name = "Frame")]
		[MyCustom(IsVisible = true)]
		public string frame { get => _frame; set => SetProperty(ref _frame, value?.Left(2)); }

		[Display(Name = "Shield")]
		[MyCustom(IsVisible = true)]
		public string shield { get => _shield; set => SetProperty(ref _shield, value?.Left(20)); }

		[Display(Name = "Refl Style")]
		[MyCustom(IsVisible = true)]
		public string ref_style { get => _ref_style; set => SetProperty(ref _ref_style, value?.Left(8)); }

		[Display(Name = "Refl Code")]
		[MyCustom(IsVisible = true)]
		public string ref_code { get => _ref_code; set => SetProperty(ref _ref_code, value?.Left(40)); }

		[Display(Name = "Bal Asby")]
		[MyCustom(IsVisible = true)]
		public string bal_asby { get => _bal_asby; set => SetProperty(ref _bal_asby, value?.Left(40)); }

		[Display(Name = "Bal Volt")]
		[MyCustom(IsVisible = true)]
		public string bal_volt { get => _bal_volt; set => SetProperty(ref _bal_volt, value?.Left(3)); }

		[Display(Name = "Opt1")]
		[MyCustom(IsVisible = true)]
		public string opt1 { get => _opt1; set => SetProperty(ref _opt1, value?.Left(25)); }

		[Display(Name = "Opt2")]
		[MyCustom(IsVisible = true)]
		public string opt2 { get => _opt2; set => SetProperty(ref _opt2, value?.Left(25)); }

		[Display(Name = "Opt3")]
		[MyCustom(IsVisible = true)]
		public string opt3 { get => _opt3; set => SetProperty(ref _opt3, value?.Left(25)); }

		[Display(Name = "Opt4")]
		[MyCustom(IsVisible = true)]
		public string opt4 { get => _opt4; set => SetProperty(ref _opt4, value?.Left(25)); }

		[Display(Name = "Opt5")]
		[MyCustom(IsVisible = true)]
		public string opt5 { get => _opt5; set => SetProperty(ref _opt5, value?.Left(25)); }

		[Display(Name = "Opt6")]
		[MyCustom(IsVisible = true)]
		public string opt6 { get => _opt6; set => SetProperty(ref _opt6, value?.Left(25)); }

		[Display(Name = "Opt7")]
		[MyCustom(IsVisible = true)]
		public string opt7 { get => _opt7; set => SetProperty(ref _opt7, value?.Left(25)); }

		[Display(Name = "Opt8")]
		[MyCustom(IsVisible = true)]
		public string opt8 { get => _opt8; set => SetProperty(ref _opt8, value?.Left(25)); }

		[Display(Name = "Opt9")]
		[MyCustom(IsVisible = true)]
		public string opt9 { get => _opt9; set => SetProperty(ref _opt9, value?.Left(25)); }

		[Display(Name = "Opt10")]
		[MyCustom(IsVisible = true)]
		public string opt10 { get => _opt10; set => SetProperty(ref _opt10, value?.Left(25)); }

		[Display(Name = "Opt1Qty")]
		[MyCustom(IsVisible = true)]
		public string opt1qty { get => _opt1qty; set => SetProperty(ref _opt1qty, value?.Left(2)); }

		[Display(Name = "Opt2Qty")]
		[MyCustom(IsVisible = true)]
		public string opt2qty { get => _opt2qty; set => SetProperty(ref _opt2qty, value?.Left(2)); }

		[Display(Name = "Opt3Qty")]
		[MyCustom(IsVisible = true)]
		public string opt3qty { get => _opt3qty; set => SetProperty(ref _opt3qty, value?.Left(2)); }

		[Display(Name = "Opt4Qty")]
		[MyCustom(IsVisible = true)]
		public string opt4qty { get => _opt4qty; set => SetProperty(ref _opt4qty, value?.Left(2)); }

		[Display(Name = "Opt5Qty")]
		[MyCustom(IsVisible = true)]
		public string opt5qty { get => _opt5qty; set => SetProperty(ref _opt5qty, value?.Left(2)); }

		[Display(Name = "Opt6Qty")]
		[MyCustom(IsVisible = true)]
		public string opt6qty { get => _opt6qty; set => SetProperty(ref _opt6qty, value?.Left(2)); }

		[Display(Name = "Opt7Qty")]
		[MyCustom(IsVisible = true)]
		public string opt7qty { get => _opt7qty; set => SetProperty(ref _opt7qty, value?.Left(2)); }

		[Display(Name = "Opt8Qty")]
		[MyCustom(IsVisible = true)]
		public string opt8qty { get => _opt8qty; set => SetProperty(ref _opt8qty, value?.Left(2)); }

		[Display(Name = "Opt9Qty")]
		[MyCustom(IsVisible = true)]
		public string opt9qty { get => _opt9qty; set => SetProperty(ref _opt9qty, value?.Left(2)); }

		[Display(Name = "Opt10Qty")]
		[MyCustom(IsVisible = true)]
		public string opt10qty { get => _opt10qty; set => SetProperty(ref _opt10qty, value?.Left(2)); }

		[Display(Name = "Stock")]
		[MyCustom(IsVisible = true)]
		public int? stock { get => _stock; set => SetProperty(ref _stock, value); }

		[Display(Name = "HasBM")]
		[MyCustom(IsVisible = true)]
		public string hasbm { get => _hasbm; set => SetProperty(ref _hasbm, value?.Left(1)); }

		[Display(Name = "HasPBM")]
		[MyCustom(IsVisible = true)]
		public string haspbm { get => _haspbm; set => SetProperty(ref _haspbm, value?.Left(1)); }

		[Display(AutoGenerateField = false)]
		public int? alloc { get => _alloc; set => SetProperty(ref _alloc, value); }

		[Display(AutoGenerateField = false)]
		public int? prodalloc { get => _prodalloc; set => SetProperty(ref _prodalloc, value); }

		[Display(AutoGenerateField = false)]
		public int? ropoint { get => _ropoint; set => SetProperty(ref _ropoint, value); }

		[Display(AutoGenerateField = false)]
		public int? roqty { get => _roqty; set => SetProperty(ref _roqty, value); }

		[Display(AutoGenerateField = false)]
		public decimal? weight { get => _weight; set => SetProperty(ref _weight, value); }

		[Display(AutoGenerateField = false)]
		public decimal? cuft { get => _cuft; set => SetProperty(ref _cuft, value); }

		[Display(AutoGenerateField = false)]
		public string stocking { get => _stocking; set => SetProperty(ref _stocking, value?.Left(1)); }

		[Display(AutoGenerateField = false)]
		public decimal? minutes { get => _minutes; set => SetProperty(ref _minutes, value); }

		[Display(AutoGenerateField = false)]
		public decimal? pminutes { get => _pminutes; set => SetProperty(ref _pminutes, value); }

		[Display(Name = "Cost")]
		public decimal? cost { get => _cost; set => SetProperty(ref _cost, value); }

		[Display(AutoGenerateField = false)]
		public decimal? sale_price { get => _sale_price; set => SetProperty(ref _sale_price, value); }

		[Display(AutoGenerateField = false)]
		public string shpclass { get => _shpclass; set => SetProperty(ref _shpclass, value?.Left(4)); }

		[Display(AutoGenerateField = false)]
		public string line1 { get => _line1; set => SetProperty(ref _line1, value?.Left(2)); }

		[Display(AutoGenerateField = false)]
		public string line2 { get => _line2; set => SetProperty(ref _line2, value?.Left(2)); }

		[Display(AutoGenerateField = false)]
		public string origin { get => _origin; set => SetProperty(ref _origin, value?.Left(1)); }

		[Display(Name = "Class")]
		[MyCustom(IsVisible = true)]
		public string Class { get => _class; set => SetProperty(ref _class, value?.Left(4)); }

		[Display(AutoGenerateField = false)]
		public string shld_manuf { get => _shld_manuf; set => SetProperty(ref _shld_manuf, value?.Left(3)); }

		[Display(Name = "First Date")]
		[DataType(DataType.Date), DisplayFormat(DataFormatString = MagicString.SmallDateFormat, ApplyFormatInEditMode = true)]
		[MyCustom(IsVisible = true, Width = MagicString.DateColumnWidth, AdsReadOnly = true)]
		public DateTime? firstodate { get => _firstodate; set => SetProperty(ref _firstodate, value); }

		[Display(Name = "First Order")]
		[MyCustom(IsVisible = true)]
		public int? firstorder { get => _firstorder; set => SetProperty(ref _firstorder, value); }

		[Display(AutoGenerateField = false)]
		public string prodtype { get => _prodtype; set => SetProperty(ref _prodtype, value?.Left(2)); }

		[Display(AutoGenerateField = false)]
		public string enginvolve { get => _enginvolve; set => SetProperty(ref _enginvolve, value?.Left(1)); }

		[Display(AutoGenerateField = false)]
		public string upccode { get => _upccode; set => SetProperty(ref _upccode, value?.Left(13)); }

		[Display(AutoGenerateField = false)]
		public string invtype { get => _invtype; set => SetProperty(ref _invtype, value?.Left(1)); }

		[Display(AutoGenerateField = false)]
		public string ulcode { get => _ulcode; set => SetProperty(ref _ulcode, value?.Left(5)); }

		[Display(AutoGenerateField = false)]
		public string balldis { get => _balldis; set => SetProperty(ref _balldis, value?.Left(1)); }

		[Display(AutoGenerateField = false)]
		public string basebment { get => _basebment; set => SetProperty(ref _basebment, value?.Left(8)); }

		[Display(AutoGenerateField = false)]
		public string basebmchg { get => _basebmchg; set => SetProperty(ref _basebmchg, value?.Left(8)); }

		[Display(AutoGenerateField = false)]
		public string packbment { get => _packbment; set => SetProperty(ref _packbment, value?.Left(8)); }

		[Display(AutoGenerateField = false)]
		public string packbmchg { get => _packbmchg; set => SetProperty(ref _packbmchg, value?.Left(8)); }

		[Display(Name = "EnteredBy")]
		[MyCustom(IsVisible = true)]
		public string fpent { get => _fpent; set => SetProperty(ref _fpent, value?.Left(8)); }

		[Display(AutoGenerateField = false)]
		public string fpchg { get => _fpchg; set => SetProperty(ref _fpchg, value?.Left(8)); }

		[Display(Name = "Status")]
		[MyCustom(IsVisible = true)]
		public string fpstat { get => _fpstat; set => SetProperty(ref _fpstat, value?.Left(1)); }

		[Display(AutoGenerateField = false)]
		public string schno { get => _schno; set => SetProperty(ref _schno, value?.Left(5)); }

		[Display(AutoGenerateField = false)]
		public string schnoalt { get => _schnoalt; set => SetProperty(ref _schnoalt, value?.Left(5)); }

		[Display(AutoGenerateField = false)]
		public string schgeniot { get => _schgeniot; set => SetProperty(ref _schgeniot, value?.Left(5)); }

		[Display(AutoGenerateField = false)]
		public string schosriot { get => _schosriot; set => SetProperty(ref _schosriot, value?.Left(5)); }

		[Display(AutoGenerateField = false)]
		public string version { get => _version; set => SetProperty(ref _version, value?.Left(3)); }

		[Display(AutoGenerateField = false)]
		public DateTime? verdate { get => _verdate; set => SetProperty(ref _verdate, value); }

		[Display(AutoGenerateField = false)]
		public string vercomment { get => _vercomment; set => SetProperty(ref _vercomment, value?.Left(65)); }

		[Display(AutoGenerateField = false)]
		public string vermasschg { get => _vermasschg; set => SetProperty(ref _vermasschg, value?.Left(1)); }

		[Display(AutoGenerateField = false)]
		public string bmlockby { get => _bmlockby; set => SetProperty(ref _bmlockby, value?.Left(8)); }

		[Display(AutoGenerateField = false)]
		public string genlabel { get => _genlabel; set => SetProperty(ref _genlabel, value?.Left(1)); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { itemno, pack };

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public string ItemPack => $"{itemno}{pack}";

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public IList<hfinvbm> Bom {
			get {
				if (_bom == null) {
					_bom = GetBom();
					OnPropertyChanged();
				}
				return _bom;
			}
			set => SetProperty(ref _bom, value);
		}

		public IList<hfinvbm> GetBom() {
			var context = new FoxProDataContext();
			return context.GetFinishedInventoryBomItems(itemno);
		}

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("sqlid")) sqlid = reader.ReadInt("sqlid");
			if (InFieldList("foxid")) foxid = reader.ReadInt("foxid");
			if (InFieldList("itemno")) itemno = reader.ReadString("itemno");
			if (InFieldList("pack")) pack = reader.ReadString("pack");
			if (InFieldList("desc")) desc = reader.ReadString("desc");
			if (InFieldList("Base")) Base = reader.ReadString("Base");
			if (InFieldList("frame")) frame = reader.ReadString("frame");
			if (InFieldList("shield")) shield = reader.ReadString("shield");
			if (InFieldList("ref_style")) ref_style = reader.ReadString("ref_style");
			if (InFieldList("ref_code")) ref_code = reader.ReadString("ref_code");
			if (InFieldList("bal_asby")) bal_asby = reader.ReadString("bal_asby");
			if (InFieldList("bal_volt")) bal_volt = reader.ReadString("bal_volt");
			if (InFieldList("opt1")) opt1 = reader.ReadString("opt1");
			if (InFieldList("opt2")) opt2 = reader.ReadString("opt2");
			if (InFieldList("opt3")) opt3 = reader.ReadString("opt3");
			if (InFieldList("opt4")) opt4 = reader.ReadString("opt4");
			if (InFieldList("opt5")) opt5 = reader.ReadString("opt5");
			if (InFieldList("opt6")) opt6 = reader.ReadString("opt6");
			if (InFieldList("opt7")) opt7 = reader.ReadString("opt7");
			if (InFieldList("opt8")) opt8 = reader.ReadString("opt8");
			if (InFieldList("opt9")) opt9 = reader.ReadString("opt9");
			if (InFieldList("opt10")) opt10 = reader.ReadString("opt10");
			if (InFieldList("opt1qty")) opt1qty = reader.ReadString("opt1qty");
			if (InFieldList("opt2qty")) opt2qty = reader.ReadString("opt2qty");
			if (InFieldList("opt3qty")) opt3qty = reader.ReadString("opt3qty");
			if (InFieldList("opt4qty")) opt4qty = reader.ReadString("opt4qty");
			if (InFieldList("opt5qty")) opt5qty = reader.ReadString("opt5qty");
			if (InFieldList("opt6qty")) opt6qty = reader.ReadString("opt6qty");
			if (InFieldList("opt7qty")) opt7qty = reader.ReadString("opt7qty");
			if (InFieldList("opt8qty")) opt8qty = reader.ReadString("opt8qty");
			if (InFieldList("opt9qty")) opt9qty = reader.ReadString("opt9qty");
			if (InFieldList("opt9qty")) opt10qty = reader.ReadString("opt9qty");
			if (InFieldList("stock")) stock = reader.ReadInt("stock");
			if (InFieldList("hasbm")) hasbm = reader.ReadString("hasbm");
			if (InFieldList("haspbm")) haspbm = reader.ReadString("haspbm");
			if (InFieldList("alloc")) alloc = reader.ReadInt("alloc");
			if (InFieldList("prodalloc")) prodalloc = reader.ReadInt("prodalloc");
			if (InFieldList("ropoint")) ropoint = reader.ReadInt("ropoint");
			if (InFieldList("roqty")) roqty = reader.ReadInt("roqty");
			if (InFieldList("weight")) weight = reader.ReadDecimal("weight");
			if (InFieldList("cuft")) cuft = reader.ReadDecimal("cuft");
			if (InFieldList("stocking")) stocking = reader.ReadString("stocking");
			if (InFieldList("minutes")) minutes = reader.ReadDecimal("minutes");
			if (InFieldList("pminutes")) pminutes = reader.ReadDecimal("pminutes");
			if (InFieldList("cost")) cost = reader.ReadDecimal("cost");
			if (InFieldList("sale_price")) sale_price = reader.ReadDecimal("sale_price");
			if (InFieldList("shpclass")) shpclass = reader.ReadString("shpclass");
			if (InFieldList("line1")) line1 = reader.ReadString("line1");
			if (InFieldList("line2")) line2 = reader.ReadString("line2");
			if (InFieldList("origin")) origin = reader.ReadString("origin");
			if (InFieldList("Class")) Class = reader.ReadString("Class");
			if (InFieldList("shld_manuf")) shld_manuf = reader.ReadString("shld_manuf");
			if (InFieldList("firstodate")) firstodate = reader.ReadDate("firstodate");
			if (InFieldList("firstorder")) firstorder = reader.ReadInt("firstorder");
			if (InFieldList("prodtype")) prodtype = reader.ReadString("prodtype");
			if (InFieldList("enginvolve")) enginvolve = reader.ReadString("enginvolve");
			if (InFieldList("upccode")) upccode = reader.ReadString("upccode");
			if (InFieldList("invtype")) invtype = reader.ReadString("invtype");
			if (InFieldList("ulcode")) ulcode = reader.ReadString("ulcode");
			if (InFieldList("balldis")) balldis = reader.ReadString("balldis");
			if (InFieldList("basebment")) basebment = reader.ReadString("basebment");
			if (InFieldList("basebmchg")) basebmchg = reader.ReadString("basebmchg");
			if (InFieldList("packbment")) packbment = reader.ReadString("packbment");
			if (InFieldList("packbmchg")) packbmchg = reader.ReadString("packbmchg");
			if (InFieldList("fpent")) fpent = reader.ReadString("fpent");
			if (InFieldList("fpchg")) fpchg = reader.ReadString("fpchg");
			if (InFieldList("fpstat")) fpstat = reader.ReadString("fpstat");
			if (InFieldList("schno")) schno = reader.ReadString("schno");
			if (InFieldList("schnoalt")) schnoalt = reader.ReadString("schnoalt");
			if (InFieldList("schgeniot")) schgeniot = reader.ReadString("schgeniot");
			if (InFieldList("schosriot")) schosriot = reader.ReadString("schosriot");
			if (InFieldList("version")) version = reader.ReadString("version");
			if (InFieldList("verdate")) verdate = reader.ReadDate("verdate");
			if (InFieldList("vercomment")) vercomment = reader.ReadString("vercomment");
			if (InFieldList("vermasschg")) vermasschg = reader.ReadString("vermasschg");
			if (InFieldList("bmlockby")) bmlockby = reader.ReadString("bmlockby");
			if (InFieldList("genlabel")) genlabel = reader.ReadString("genlabel");
			if (InFieldList("gdesc")) gdesc = reader.ReadString("gdesc");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public hfinv GetFinishedInventory(string indexName, object[] keyValues, List<string> fields, bool activeOnly) {
			var qTime = DateTime.Now;
			hfinv entity = null;
			if (keyValues[0] == null || string.IsNullOrEmpty(keyValues[0].ToString())) return entity;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hfinv";
			var reader = cmd.ExecuteExtendedReader();
			reader.ActiveIndex = indexName;
			var searchItemno = "";
			var searchPack = "";
			var searchDesc = "";
			if (indexName == "gdesca") {
				searchDesc = keyValues[0].ToString();
			}
			if (indexName == "itemno") {
				searchItemno = keyValues[0].ToString();
				searchPack = keyValues[1].ToString();
			}
			var found = reader.Seek(keyValues, AdsExtendedReader.SeekType.HardSeek);
			if (found) {
				var valid = true;
				while (valid) {
					var fpstat = reader.ReadString("fpstat");
					var itemno = reader.ReadString("itemno");
					var pack = reader.ReadString("pack");
					var gdesc = reader.ReadString("gdesc");
					if (indexName == "gdesca" && gdesc != searchDesc) break;
					if (indexName == "itemno") {
						if (itemno != searchItemno) break;
						if (searchPack != "" && itemno != searchItemno && pack != searchPack) break;
					}
					if (fpstat != "I" || !activeOnly) {
						entity = new hfinv();
						entity.FillFromReaderList(reader, fields);
						break;
					}
					valid = reader.Read();
				}
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetFinishedInventory");
			return entity;
		}

		public hfinv GetFinishedInventory(string itemno, string pack, bool activeOnly, List<string> fields) {
			var keys = new object[] {itemno, pack};
			var entity = GetFinishedInventory("itemno", keys, fields, activeOnly);
			return entity;
		}

		public hfinv GetFinishedInventory(string desc, List<string> fields) { 
			var entity = GetFinishedInventory("gdesca", new object[] { desc }, fields, true);
			return entity;
		}

		public hfinv GetFinishedInventory(string itemno, string pack, bool activeOnly) {
			var entity = GetFinishedInventory(itemno, pack, activeOnly, new List<string> { "*" });
			return entity;
		}

		public IList<hfinv> GetFinishedInventories(string search, int take) {
			var qTime = DateTime.Now;
			Conn.Open();
			var entities = new List<hfinv>();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hfinv";
			var reader = cmd.ExecuteExtendedReader();
			var searchItemno = string.Empty;
			var searchPack = string.Empty;
			var searchDesc = string.Empty;
			var searchValue = search.ToUpper();
			var only90 = false;
			var only92 = false;
			if (searchValue.StartsWith("90 ")) {
				only90 = true;
				searchValue = searchValue.Substring(3);
			}
			if (searchValue.StartsWith("92 ")) {
				only92 = true;
				searchValue = searchValue.Substring(3);
			}
			var sections = new string[] { };
			var isInt = int.TryParse(searchValue, out var x);
			var indexName = isInt && searchValue.Length == 8 && searchValue.StartsWith("9") ? "itemno" : "gdesca";
			reader.ActiveIndex = indexName;
			var found = false;
			if (indexName == "itemno") {
				searchItemno = searchValue.Left(8);
				searchPack = searchValue.Replace(searchItemno, "");
				found = reader.Seek(new object[] { searchItemno, searchPack }, AdsExtendedReader.SeekType.HardSeek);
			}
			else {
				sections = searchValue.Split('%');
				searchDesc = sections[0];
				found = reader.Seek(new object[] { searchDesc }, AdsExtendedReader.SeekType.HardSeek);
			}
			if (found) {
				for (var i = 0; i < take; i++) {
					//var fpstat = reader.ReadString("fpstat");
					var gdesc = reader.ReadString("gdesc");
					var itemno = reader.ReadString("itemno");
					var pack = reader.ReadString("pack");
					//Debug.WriteLine($"cnt: {i} {itemno} {pack} {gdesc}");
					//if (fpstat == "I") continue;  // the index is already "Active" filtered
					var skip = false;
					if (indexName == "gdesca") {
						if (!gdesc.StartsWith(searchDesc)) break;
						if (only90 && itemno.StartsWith("92")) skip = true;
						if (only92 && itemno.StartsWith("90")) skip = true;
						if (sections.Length > 1) {
							for (var j = 1; j < sections.Length; j++) {
								var section = sections[j];
								if (!gdesc.Contains(section)) {
									skip = true;
									break;
								}
							}
						}
					}
					if (indexName == "itemno") {
						if (itemno != searchItemno) break;
						if (!string.IsNullOrEmpty(searchPack) && itemno != searchItemno && pack != searchPack) break;
					}
					if (!skip) {
						var entity = new hfinv();
						entity.FillFromReader(reader);
						entities.Add(entity);
					}
					var valid = reader.Read();
					if (!valid) break;
				}
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetFinishedInventories");
			return entities;
		}

		public IList<hfinv> GetFinishedInventoriesWithCost(string desc, int take) {
			var qTime = DateTime.Now;
			Conn.Open();
			var entities = new List<hfinv>();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hfinv";
			var reader = cmd.ExecuteExtendedReader();
			reader.ActiveIndex = "gdesca";
			var found = reader.Seek(new object[] { desc }, AdsExtendedReader.SeekType.HardSeek);
			if (found) {
				for (var i = 0; i < take; i++) {
					var gdesc = reader.ReadString("gdesc");
					if (gdesc != desc) break;
					var itemno = reader.ReadString("itemno");
					var cost = reader.ReadDecimal("cost");
					if (itemno.StartsWith("90") && cost > 0) {
						var entity = new hfinv();
						entity.FillFromReader(reader);
						entities.Add(entity);
					}
					var valid = reader.Read();
					if (!valid) break;
				}
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetFinishedInventories");
			return entities;
		}

		public IList<hfinv> GetFinishedInventoryQs() {
			var qTime = DateTime.Now;
			//var fieldList = new List<string> { "gdesc" };
			//var sql = $"select gdesc from hfinv where stocking='Y'";
			//var entity = GetEntitiesSql<hfinv>(sql, fieldList);
			Conn.Open();
			var entities = new List<hfinv>();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hfinv";
			var reader = cmd.ExecuteExtendedReader();
			reader.ActiveIndex = "stocking";
			var found = reader.Seek(new object[] { "Y" }, AdsExtendedReader.SeekType.HardSeek);
			if (found) {
				var valid = true;
				while (valid) {
					var stocking = reader.ReadString("stocking");
					if (stocking != "Y") break;
					var entity = new hfinv();
					entity.FillFromReader(reader);
					entities.Add(entity);
					valid = reader.Read();
				}
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetFinishedInventoryQs");
			return entities;
		}

		public string GetFinishedInventoryGDesc(string itemno) {
			Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = $"SELECT TOP 1 gDesc FROM hfinv WHERE ItemNo = \'{itemno}\' AND Pack LIKE \'%\'";
			var reader = cmd.ExecuteExtendedReader();
			var gDesc = "";
			if (reader.HasRows){
				while (reader.Read()){
					if (!reader.IsDBNull(reader.GetOrdinal("gDesc"))) gDesc = reader.GetString(reader.GetOrdinal("gDesc"));
				}
			}
			Conn.Close();
			return gDesc;
		}

		public hfinv GetFinishedInventoryItemNum(string itemno){
			var qTime = DateTime.Now;
			Conn.Open();
			hfinv entity = new hfinv();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hfinv";
			var reader = cmd.ExecuteExtendedReader();
			reader.ActiveIndex = "itemno";
			var found = reader.Seek(new object[]{itemno}, AdsExtendedReader.SeekType.HardSeek);
			if (found){
				var gotEntity = false;
				while (!gotEntity) {
					var itemNum = reader.ReadString("itemno");
					if (itemNum != itemno) break;
					var pack = reader.ReadString("pack");
					if (pack.StartsWith(" ")){
						reader.Read();
						continue;
					}
					entity.FillFromReader(reader);
					gotEntity = true;
				}
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetFinishedInventory");
			return entity;
		}

		public hfinv GetFinishedInventoryItemNumPack(string _itemno, string _pack) {
			var qTime = DateTime.Now;
			Conn.Open();
			hfinv entity = new hfinv();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hfinv";
			var reader = cmd.ExecuteExtendedReader();
			reader.ActiveIndex = "itemno";
			var found = reader.Seek(new object[] { _itemno, _pack }, AdsExtendedReader.SeekType.HardSeek);
			if (found) {
				//var gotEntity = false;
				//while (!gotEntity) {
					var itemNum = reader.ReadString("itemno");
					var pack = reader.ReadString("pack");
					if(itemNum.Trim() == _itemno.Trim() && pack.Trim() == _pack.Trim()) {
						//reader.Read();
						entity.FillFromReader(reader);
						//gotEntity = true;
					}
				//}

			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetFinishedInventory");
			return entity;
		}

	}

}
