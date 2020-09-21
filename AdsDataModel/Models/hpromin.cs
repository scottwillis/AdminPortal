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

	public class hpromin : FoxProEntity {

		public hpromin() {
			Key = "";
		}

		private string _partno;
		private string _desc;
		private decimal? _filemin;
		private int _qtymade;
		private int _minutes;
		private int _changes;
		private string _hasopt;
		private string _base;
		private DateTime? _date;
		private string _line;
		private int _no_emps;
		private string _shift;
		private decimal? _cost;
		private decimal? _selldoll;
		private string _isstock;
		private decimal? _sale_price;
		private int _gainloss;
		private int _tmin;


		[Display(AutoGenerateField = false)]
		public string partno { get => _partno; set => SetProperty(ref _partno, value); }

		[Display(AutoGenerateField = false)]
		public string desc { get => _desc; set => SetProperty(ref _desc, value); }

		[Display(AutoGenerateField = false)]
		public decimal? filemin { get => _filemin; set => SetProperty(ref _filemin, value); }

		[Display(AutoGenerateField = false)]
		public int qtymade { get => _qtymade; set => SetProperty(ref _qtymade, value); }

		[Display(AutoGenerateField = false)]
		public int minutes { get => _minutes; set => SetProperty(ref _minutes, value); }

		[Display(AutoGenerateField = false)]
		public int changes { get => _changes; set => SetProperty(ref _changes, value); }

		[Display(AutoGenerateField = false)]
		public string hasopt { get => _hasopt; set => SetProperty(ref _hasopt, value); }

		[Display(AutoGenerateField = false)]
		public string prodbase { get => _base; set => SetProperty(ref _base, value); }

		[Display(AutoGenerateField = false)]
		public DateTime? date { get => _date; set => SetProperty(ref _date, value); }

		[Display(AutoGenerateField = false)]
		public string line { get => _line; set => SetProperty(ref _line, value); }

		[Display(AutoGenerateField = false)]
		public int no_emps { get => _no_emps; set => SetProperty(ref _no_emps, value); }

		[Display(AutoGenerateField = false)]
		public string shift { get => _shift; set => SetProperty(ref _shift, value); }

		[Display(AutoGenerateField = false)]
		public decimal? cost { get => _cost; set => SetProperty(ref _cost, value); }

		[Display(AutoGenerateField = false)]
		public decimal? selldoll { get => _selldoll; set => SetProperty(ref _selldoll, value); }

		[Display(AutoGenerateField = false)]
		public string isstock { get => _isstock; set => SetProperty(ref _isstock, value); }

		[Display(AutoGenerateField = false)]
		public decimal? sale_price { get => _sale_price; set => SetProperty(ref _sale_price, value); }

		[Display(AutoGenerateField = false)]
		public int gainloss { get => _gainloss; set => SetProperty(ref _gainloss, value); }

		[Display(AutoGenerateField = false)]
		public int tmin { get => _tmin; set => SetProperty(ref _tmin, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { partno};

		public override void FillFromReader(AdsDataReader reader) {			
			partno = reader.ReadString("partno");
			desc = reader.ReadString("desc");
			filemin = reader.ReadDecimal("filemin");
			qtymade = reader.ReadInt("qtymade");
			minutes = reader.ReadInt("minutes");
			changes = reader.ReadInt("changes");
			hasopt = reader.ReadString("hasopt");
			prodbase = reader.ReadString("base");
			date = reader.ReadDate("date");
			line = reader.ReadString("line");
			no_emps = reader.ReadInt("no_emps");
			shift = reader.ReadString("shift");
			cost = reader.ReadDecimal("cost");
			selldoll = reader.ReadDecimal("selldoll");
			isstock = reader.ReadString("isstock");
			sale_price = reader.ReadDecimal("sale_price");
			gainloss = reader.ReadInt("gainloss");
			tmin = reader.ReadInt("tmin");

			MakeClean();
		}

	}

	public partial class FoxProDataContext {

	}

}
