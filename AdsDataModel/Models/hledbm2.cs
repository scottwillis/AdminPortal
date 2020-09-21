using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Advantage.Data.Provider;
using Common;
using DataModel;

namespace AdsDataModel {

	public class hledbm2 : FoxProEntity {

		public hledbm2() {
			Key = "itemno";
		}

		private string _itemno;
		private DateTime? _lupdate;
		private string _match;
		private string _notes;
		private string _bpartno;
		private int? _bqty;
		private string _dpartno;
		private int? _dqty;
		private string _hpart1;
		private string _hpart2;
		private string _sch1;
		private string _sch2;
		private string _sbpartno;
		private int? _sbqty;
		private string _tbpartno;
		private int? _tbqty;
		private string _ledstr1;
		private string _ledstr2;
		private string _ledstr3;

		public string itemno { get => _itemno; set => SetProperty(ref _itemno, value); }

		public DateTime? lupdate { get => _lupdate; set => SetProperty(ref _lupdate, value); }

		public string match { get => _match; set => SetProperty(ref _match, value); }

		public string notes { get => _notes; set => SetProperty(ref _notes, value); }

		public string bpartno { get => _bpartno; set => SetProperty(ref _bpartno, value); }

		public int? bqty { get => _bqty; set => SetProperty(ref _bqty, value); }

		public string dpartno { get => _dpartno; set => SetProperty(ref _dpartno, value); }

		public int? dqty { get => _dqty; set => SetProperty(ref _dqty, value); }

		public string hpart1 { get => _hpart1; set => SetProperty(ref _hpart1, value); }

		public string hpart2 { get => _hpart2; set => SetProperty(ref _hpart2, value); }

		public string sch1 { get => _sch1; set => SetProperty(ref _sch1, value); }

		public string sch2 { get => _sch2; set => SetProperty(ref _sch2, value); }

		public string sbpartno { get => _sbpartno; set => SetProperty(ref _sbpartno, value); }

		public int? sbqty { get => _sbqty; set => SetProperty(ref _sbqty, value); }

		public string tbpartno { get => _tbpartno; set => SetProperty(ref _tbpartno, value); }

		public int? tbqty { get => _tbqty; set => SetProperty(ref _tbqty, value); }

		public string ledstr1 { get => _ledstr1; set => SetProperty(ref _ledstr1, value); }

		public string ledstr2 { get => _ledstr2; set => SetProperty(ref _ledstr2, value); }

		public string ledstr3 { get => _ledstr3; set => SetProperty(ref _ledstr3, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { itemno };

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("itemno")) itemno = reader.ReadString("itemno");
			if (InFieldList("lupdate")) lupdate = reader.ReadDate("lupdate");
			if (InFieldList("match")) match = reader.ReadString("match");
			if (InFieldList("notes")) notes = reader.ReadString("notes");
			if (InFieldList("bpartno")) bpartno = reader.ReadString("bpartno");
			if (InFieldList("bqty")) bqty = reader.ReadInt("bqty");
			if (InFieldList("dpartno")) dpartno = reader.ReadString("dpartno");
			if (InFieldList("dqty")) dqty = reader.ReadInt("dqty");
			if (InFieldList("hpart1")) hpart1 = reader.ReadString("hpart1");
			if (InFieldList("hpart2")) hpart2 = reader.ReadString("hpart2");
			if (InFieldList("sch1")) sch1 = reader.ReadString("sch1");
			if (InFieldList("sch2")) sch2 = reader.ReadString("sch2");
			if (InFieldList("sbpartno")) sbpartno = reader.ReadString("sbpartno");
			if (InFieldList("sbqty")) sbqty = reader.ReadInt("sbqty");
			if (InFieldList("tbpartno")) tbpartno = reader.ReadString("tbpartno");
			if (InFieldList("tbqty")) tbqty = reader.ReadInt("tbqty");
			if (InFieldList("ledstr1")) ledstr1 = reader.ReadString("ledstr1");
			if (InFieldList("ledstr2")) ledstr2 = reader.ReadString("ledstr2");
			if (InFieldList("ledstr3")) ledstr3 = reader.ReadString("ledstr3");
			MakeClean();
		}
	}

	public partial class FoxProDataContext {
		public IList<hledbm2> GetHledbm2(string itemno) {
			var sql = $"select * from hledbm2 where itemno='{itemno}'";
			var entities = GetEntitiesSql<hledbm2>(sql, new List<string> {"*"});
			return entities;
		}

	}

}

