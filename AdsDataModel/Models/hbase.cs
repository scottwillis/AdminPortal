using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Advantage.Data.Provider;
using Common;

namespace AdsDataModel {

	public class hbase : FoxProEntity {

		private string _base_fix;
		private string _series;
		private string _pseries;
		private string _app_lens;
		private string _frame;
		private string _shield;
		private string _style;
		private string _code;
		private string _bmanuf;
		private string _btype;
		private string _bvolt;
		private string _air_static;
		private int? _width;
		private int? _length;
		private int? _lampqty;
		private int? _b_qty;
		private int? _b_length;
		private string _b_style;
		private decimal? _book_price;
		private string _pack;
		private string _desc;
		private string _app_refl;
		private string _newbaseno;
		private string _oldbaseno;
		private decimal? _minutes;
		private string _avggroup;
		private string _commcode;
		private string _defline;
		private string _pricelist;
		private decimal? _oldbook;
		private decimal? _newbook;
		private string _avgmin;
		private string _obsolete;
		private string _prodtype;
		private string _hasrefl;
		private string _lab_def;
		private string _lab_wet;
		private string _lab_dry;
		private string _lab_noc;
		private string _lab_hpf;
		private string _class;
		private string _voltage;
		private string _oemcode;
		private string _nmark;
		private string _ssoptonly;
		private string _hassupp;
		private string _notes;

		public hbase() {
			Key = "base_fix";
		}

		public string base_fix { get => _base_fix; set => SetProperty(ref _base_fix, value); }
		public string series { get => _series; set => SetProperty(ref _series, value); }
		public string pseries { get => _pseries; set => SetProperty(ref _pseries, value); }
		public string app_lens { get => _app_lens; set => SetProperty(ref _app_lens, value); }
		public string frame { get => _frame; set => SetProperty(ref _frame, value); }
		public string shield { get => _shield; set => SetProperty(ref _shield, value); }
		public string style { get => _style; set => SetProperty(ref _style, value); }
		public string code { get => _code; set => SetProperty(ref _code, value); }
		public string bmanuf { get => _bmanuf; set => SetProperty(ref _bmanuf, value); }
		public string btype { get => _btype; set => SetProperty(ref _btype, value); }
		public string bvolt { get => _bvolt; set => SetProperty(ref _bvolt, value); }
		public string air_static { get => _air_static; set => SetProperty(ref _air_static, value); }
		public int? width { get => _width; set => SetProperty(ref _width, value); }
		public int? length { get => _length; set => SetProperty(ref _length, value); }
		public int? lampqty { get => _lampqty; set => SetProperty(ref _lampqty, value); }
		public int? b_qty { get => _b_qty; set => SetProperty(ref _b_qty, value); }
		public int? b_length { get => _b_length; set => SetProperty(ref _b_length, value); }
		public string b_style { get => _b_style; set => SetProperty(ref _b_style, value); }
		public decimal? book_price { get => _book_price; set => SetProperty(ref _book_price, value); }
		public string pack { get => _pack; set => SetProperty(ref _pack, value); }
		public string desc { get => _desc; set => SetProperty(ref _desc, value); }
		public string app_refl { get => _app_refl; set => SetProperty(ref _app_refl, value); }
		//public string newbaseno { get => _newbaseno; set { _newbaseno = value; OnPropertyChanged(); } }
		//public string oldbaseno { get => _oldbaseno; set { _oldbaseno = value; OnPropertyChanged(); } }
		public decimal? minutes { get => _minutes; set => SetProperty(ref _minutes, value); }
		public string avggroup { get => _avggroup; set => SetProperty(ref _avggroup, value); }
		public string commcode { get => _commcode; set => SetProperty(ref _commcode, value); }
		public string defline { get => _defline; set => SetProperty(ref _defline, value); }
		public string pricelist { get => _pricelist; set => SetProperty(ref _pricelist, value); }
		public decimal? oldbook { get => _oldbook; set => SetProperty(ref _oldbook, value); }
		public decimal? newbook { get => _newbook; set => SetProperty(ref _newbook, value); }
		public string avgmin { get => _avgmin; set => SetProperty(ref _avgmin, value); }
		public string obsolete { get => _obsolete; set => SetProperty(ref _obsolete, value); }
		public string prodtype { get => _prodtype; set => SetProperty(ref _prodtype, value); }
		public string hasrefl { get => _hasrefl; set => SetProperty(ref _hasrefl, value); }
		public string lab_def { get => _lab_def; set => SetProperty(ref _lab_def, value); }
		public string lab_wet { get => _lab_wet; set => SetProperty(ref _lab_wet, value); }
		public string lab_dry { get => _lab_dry; set => SetProperty(ref _lab_dry, value); }
		public string lab_noc { get => _lab_noc; set => SetProperty(ref _lab_noc, value); }
		public string lab_hpf { get => _lab_hpf; set => SetProperty(ref _lab_hpf, value); }
		public string Class { get => _class; set => SetProperty(ref _class, value); }
		public string voltage { get => _voltage; set => SetProperty(ref _voltage, value); }
		public string oemcode { get => _oemcode; set => SetProperty(ref _oemcode, value); }
		public string nmark { get => _nmark; set => SetProperty(ref _nmark, value); }
		public string ssoptonly { get => _ssoptonly; set => SetProperty(ref _ssoptonly, value); }
		public string hassupp { get => _hassupp; set => SetProperty(ref _hassupp, value); }
		public string notes { get => _notes; set => SetProperty(ref _notes, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { base_fix };

		public override bool Update() {
			var context = new FoxProDataContext();
			var updated = context.Update(this);
			if (updated) {

			}
			return updated;
		}

		public override void Refresh() {
			var context = new FoxProDataContext();
			var entity = context.GetEntity<hbase>(base_fix);
			if (series != entity.series) series = entity.series;
			MakeClean();
		}

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("base_fix")) base_fix = reader.ReadString("base_fix");
			if (InFieldList("series")) series = reader.ReadString("series");
			if (InFieldList("pseries")) pseries = reader.ReadString("pseries");
			if (InFieldList("app_lens")) app_lens = reader.ReadString("app_lens");
			if (InFieldList("frame")) frame = reader.ReadString("frame");
			if (InFieldList("shield")) shield = reader.ReadString("shield");
			if (InFieldList("style")) style = reader.ReadString("style");
			if (InFieldList("code")) code = reader.ReadString("code");
			if (InFieldList("bmanuf")) bmanuf = reader.ReadString("bmanuf");
			if (InFieldList("btype")) btype = reader.ReadString("btype");
			if (InFieldList("bvolt")) bvolt = reader.ReadString("bvolt");
			if (InFieldList("air_static")) air_static = reader.ReadString("air_static");
			if (InFieldList("width")) width = reader.ReadInt("width");
			if (InFieldList("length")) length = reader.ReadInt("length");
			if (InFieldList("lampqty")) lampqty = reader.ReadInt("lampqty");
			if (InFieldList("b_qty")) b_qty = reader.ReadInt("b_qty");
			if (InFieldList("b_length")) b_length = reader.ReadInt("b_length");
			if (InFieldList("b_style")) b_style = reader.ReadString("b_style");
			if (InFieldList("book_price")) book_price = reader.ReadDecimal("book_price");
			if (InFieldList("pack")) pack = reader.ReadString("pack");
			if (InFieldList("desc")) desc = reader.ReadString("desc");
			if (InFieldList("app_refl")) app_refl = reader.ReadString("app_refl");
			//if (InFieldList("newbaseno")) newbaseno = reader.ReadString("newbaseno");
			//if (InFieldList("oldbaseno")) oldbaseno = reader.ReadString("oldbaseno");
			if (InFieldList("minutes")) minutes = reader.ReadDecimal("minutes");
			if (InFieldList("avggroup")) avggroup = reader.ReadString("avggroup");
			if (InFieldList("commcode")) commcode = reader.ReadString("commcode");
			if (InFieldList("defline")) defline = reader.ReadString("defline");
			if (InFieldList("pricelist")) pricelist = reader.ReadString("pricelist");
			if (InFieldList("oldbook")) oldbook = reader.ReadDecimal("oldbook");
			if (InFieldList("newbook")) newbook = reader.ReadDecimal("newbook");
			if (InFieldList("avgmin")) avgmin = reader.ReadString("avgmin");
			if (InFieldList("obsolete")) obsolete = reader.ReadString("obsolete");
			if (InFieldList("prodtype")) prodtype = reader.ReadString("prodtype");
			if (InFieldList("hasrefl")) hasrefl = reader.ReadString("hasrefl");
			if (InFieldList("lab_def")) lab_def = reader.ReadString("lab_def");
			if (InFieldList("lab_wet")) lab_wet = reader.ReadString("lab_wet");
			if (InFieldList("lab_dry")) lab_dry = reader.ReadString("lab_dry");
			if (InFieldList("lab_noc")) lab_noc = reader.ReadString("lab_noc");
			if (InFieldList("lab_hpf")) lab_hpf = reader.ReadString("lab_hpf");
			if (InFieldList("class")) Class = reader.ReadString("class");
			if (InFieldList("voltage")) voltage = reader.ReadString("voltage");
			if (InFieldList("oemcode")) oemcode = reader.ReadString("oemcode");
			if (InFieldList("nmark")) nmark = reader.ReadString("nmark");
			if (InFieldList("ssoptonly")) ssoptonly = reader.ReadString("ssoptonly");
			if (InFieldList("hassupp")) hassupp = reader.ReadString("hassupp");
			if (InFieldList("notes")) notes = reader.ReadString("notes");
			MakeClean();
		}

	}

	public partial class FoxProDataContext
	{

		public hbase GetBase(string base_fix){
			var qTime = DateTime.Now;
			Conn.Open();
			hbase entity = new hbase();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hbase";
			var reader = cmd.ExecuteExtendedReader();
			reader.ActiveIndex = "base_fix";
			var found = reader.Seek(new object[] { base_fix }, AdsExtendedReader.SeekType.HardSeek);
			if (found) {
				var gotEntity = false;
				while (!gotEntity) {
					var baseFix = reader.ReadString("base_fix");
					if (baseFix != base_fix) break;
					entity.FillFromReader(reader);
					gotEntity = true;
				}
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetBase");
			return entity;
		}

}

}
