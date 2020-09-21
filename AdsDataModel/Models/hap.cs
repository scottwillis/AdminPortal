using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Windows;
using Advantage.Data.Provider;
using Common;

namespace AdsDataModel {

	public class hap : FoxProEntity {

		public hap() {
			Key = "ap_no";
		}

		private int _ap_no;
		private string _invno;
		private string _vendor_no;
		private string _bname;
		private string _baddr1;
		private string _baddr2;
		private string _bcity;
		private string _bstate;
		private string _bzip;
		private int? _po_no;
		private string _order_stat;
		private DateTime? _date;
		private DateTime? _due_date;
		private int? _ledgerno;
		private int? _checkno;
		private DateTime? _check_date;
		private decimal? _gross;
		private decimal? _subtotal;
		private decimal? _discount;
		private decimal? _per_disc;
		private string _status;
		private decimal? _freight;
		private decimal? _setup;
		private decimal? _tax;
		private decimal? _other_chrg;
		private string _cash_acct;
		private DateTime? _inv_date;
		private string _comment;
		private DateTime? _keydate;
		private string _auth;
		private string _login;
		private string _notes;
		private int? _oldkey;

		[Display(Name = "No", Order = 10)]
		[MyCustom(Width = "*", IsVisible = true)]
		public int ap_no { get => _ap_no; set => SetProperty(ref _ap_no, value); }
			//set { if (value == _ap_no) return; _ap_no = value; OnPropertyChanged(); } }

			[Display(AutoGenerateField = false)]
		public string invno { get => _invno; set => SetProperty(ref _invno, value); }

		[Display(AutoGenerateField = false)]
		public string vendor_no { get => _vendor_no; set => SetProperty(ref _vendor_no, value); }

		[Display(AutoGenerateField = false)]
		public string bname { get => _bname; set => SetProperty(ref _bname, value); }

		[Display(AutoGenerateField = false)]
		public string baddr1 { get => _baddr1; set => SetProperty(ref _baddr1, value); }

		[Display(AutoGenerateField = false)]
		public string baddr2 { get => _baddr2; set => SetProperty(ref _baddr2, value); }

		[Display(AutoGenerateField = false)]
		public string bcity { get => _bcity; set => SetProperty(ref _bcity, value); }

		[Display(AutoGenerateField = false)]
		public string bstate { get => _bstate; set => SetProperty(ref _bstate, value); }

		[Display(AutoGenerateField = false)]
		public string bzip { get => _bzip; set => SetProperty(ref _bzip, value); }

		[Display(AutoGenerateField = false)]
		public int? po_no { get => _po_no; set => SetProperty(ref _po_no, value); }

		[Display(AutoGenerateField = false)]
		public string order_stat { get => _order_stat; set => SetProperty(ref _order_stat, value); }

		[Display(AutoGenerateField = false)]
		public DateTime? date { get => _date; set => SetProperty(ref _date, value); }

		[Display(AutoGenerateField = false)]
		public DateTime? due_date { get => _due_date; set => SetProperty(ref _due_date, value); }

		[Display(AutoGenerateField = false)]
		public int? ledgerno { get => _ledgerno; set => SetProperty(ref _ledgerno, value); }

		[Display(AutoGenerateField = false)]
		public int? checkno { get => _checkno; set => SetProperty(ref _checkno, value); }

		[Display(AutoGenerateField = false)]
		public DateTime? check_date { get => _check_date; set => SetProperty(ref _check_date, value); }

		[Display(AutoGenerateField = false)]
		public decimal? gross { get => _gross; set => SetProperty(ref _gross, value); }

		[Display(AutoGenerateField = false)]
		public decimal? subtotal { get => _subtotal; set => SetProperty(ref _subtotal, value); }

		[Display(AutoGenerateField = false)]
		public decimal? discount { get => _discount; set => SetProperty(ref _discount, value); }

		[Display(AutoGenerateField = false)]
		public decimal? per_disc { get => _per_disc; set => SetProperty(ref _per_disc, value); }

		[Display(AutoGenerateField = false)]
		public string status { get => _status; set => SetProperty(ref _status, value); }

		[Display(AutoGenerateField = false)]
		public decimal? freight { get => _freight; set => SetProperty(ref _freight, value); }

		[Display(AutoGenerateField = false)]
		public decimal? setup { get => _setup; set => SetProperty(ref _setup, value); }

		[Display(AutoGenerateField = false)]
		public decimal? tax { get => _tax; set => SetProperty(ref _tax, value); }

		[Display(AutoGenerateField = false)]
		public decimal? other_chrg { get => _other_chrg; set => SetProperty(ref _other_chrg, value); }

		[Display(AutoGenerateField = false)]
		public string cash_acct { get => _cash_acct; set => SetProperty(ref _cash_acct, value); }

		[Display(AutoGenerateField = false)]
		public DateTime? inv_date { get => _inv_date; set => SetProperty(ref _inv_date, value); }

		[Display(AutoGenerateField = false)]
		public string comment { get => _comment; set => SetProperty(ref _comment, value); }

		[Display(AutoGenerateField = false)]
		public DateTime? keydate { get => _keydate; set => SetProperty(ref _keydate, value); }

		[Display(AutoGenerateField = false)]
		public string auth { get => _auth; set => SetProperty(ref _auth, value); }

		[Display(AutoGenerateField = false)]
		public string login { get => _login; set => SetProperty(ref _login, value); }

		[Display(AutoGenerateField = false)]
		public string notes { get => _notes; set => SetProperty(ref _notes, value); }

		[Display(AutoGenerateField = false)]
		public int? oldkey { get => _oldkey; set => SetProperty(ref _oldkey, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { ap_no };

		public override bool Update() {
			var context = new FoxProDataContext();
			var updated = context.Update(this);
			if (updated) {

			}
			return updated;
		}

		public override void Refresh() {
			var context = new FoxProDataContext();
			var entity = context.GetEntity<hap>(ap_no);
			if (invno != entity.invno) invno = entity.invno;
			MakeClean();
		}

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("ap_no")) ap_no = reader.ReadInt("ap_no");
			if (InFieldList("invno")) invno = reader.ReadString("invno");
			if (InFieldList("vendor_no")) vendor_no = reader.ReadString("vendor_no");
			if (InFieldList("bname")) bname = reader.ReadString("bname");
			if (InFieldList("baddr1")) baddr1 = reader.ReadString("baddr1");
			if (InFieldList("baddr2")) baddr2 = reader.ReadString("baddr2");
			if (InFieldList("bcity")) bcity = reader.ReadString("bcity");
			if (InFieldList("bstate")) bstate = reader.ReadString("bstate");
			if (InFieldList("bzip")) bzip = reader.ReadString("bzip");
			if (InFieldList("po_no")) po_no = reader.ReadInt("po_no");
			if (InFieldList("order_stat")) order_stat = reader.ReadString("order_stat");
			if (InFieldList("date")) date = reader.ReadDate("date");
			if (InFieldList("due_date")) due_date = reader.ReadDate("due_date");
			if (InFieldList("ledgerno")) ledgerno = reader.ReadInt("ledgerno");
			if (InFieldList("checkno")) checkno = reader.ReadInt("checkno");
			if (InFieldList("check_date")) check_date = reader.ReadDate("check_date");
			if (InFieldList("gross")) gross = reader.ReadDecimal("gross");
			if (InFieldList("subtotal")) subtotal = reader.ReadDecimal("subtotal");
			if (InFieldList("discount")) discount = reader.ReadDecimal("discount");
			if (InFieldList("per_disc")) per_disc = reader.ReadDecimal("per_disc");
			if (InFieldList("status")) status = reader.ReadString("status");
			if (InFieldList("freight")) freight = reader.ReadDecimal("freight");
			if (InFieldList("setup")) setup = reader.ReadDecimal("setup");
			if (InFieldList("tax")) tax = reader.ReadDecimal("tax");
			if (InFieldList("other_chrg")) other_chrg = reader.ReadDecimal("other_chrg");
			if (InFieldList("cash_acct")) cash_acct = reader.ReadString("cash_acct");
			if (InFieldList("inv_date")) inv_date = reader.ReadDate("inv_date");
			if (InFieldList("comment")) comment = reader.ReadString("comment");
			if (InFieldList("keydate")) keydate = reader.ReadDate("keydate");
			if (InFieldList("auth")) auth = reader.ReadString("auth");
			if (InFieldList("login")) login = reader.ReadString("login");
			if (InFieldList("notes")) notes = reader.ReadString("notes");
			if (InFieldList("oldkey")) oldkey = reader.ReadInt("oldkey");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public hap GetAp(int no) {
			var qTime = DateTime.Now;
			var sql = $"select * from hap where ap_no={no}";
			var entity = GetEntitySql<hap>(sql);
			QueryDebugEnd(qTime, $"GetAp - {sql}");
			return entity;
		}

	}

}
