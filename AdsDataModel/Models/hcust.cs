using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Windows;
using Advantage.Data.Provider;
using Common;

namespace AdsDataModel {

	public class hcust : FoxProEntity {

		public hcust() {
			Key = "custno";
		}

		private int _custno;
		private int _saleno;
		private int _stateno;
		private string _name;
		private string _address;
		private string _address2;
		private string _city;
		private string _state;
		private string _zip;
		private string _contact;
		private string _contact2;
		private string _taxid;
		private string _phone;
		private string _phone2;
		private string _dbrate;
		private int? _credit;
		private decimal? _csales;
		private decimal? _pysales;
		private string _credcheck;
		private DateTime? _fsaledate;
		private string _sname;
		private string _saddress;
		private string _saddress2;
		private string _scity;
		private string _sstate;
		private string _szip;
		private string _stocking;
		private string _pucredit;
		private DateTime? _linvdate;
		private decimal? _ar0;
		private decimal? _ar1;
		private decimal? _ar2;
		private decimal? _ar3;
		private decimal? _ar4;
		private decimal? _ar5;
		private int? _ar0_cnt;
		private int? _ar1_cnt;
		private int? _ar2_cnt;
		private int? _ar3_cnt;
		private int? _ar4_cnt;
		private int? _ar5_cnt;
		private int? _inv_6_mo;
		private int? _inv_avg;
		private string _oembl;
		private string _oemlabel;
		private int? _credlimit;
		private string _callinfo;
		private string _rebate;
		private string _pdpgrp;
		private string _invfaxno;
		private int? _terms;
		private bool? _faxinv;
		private string _email;
		private string _fxcontact;
		private bool? _inactive;
		private DateTime? _tdate;
		private int? _ppfrtmin;
		private bool? _taxable;
		private bool? _nocrhold;
		private bool? _wpo;
		private int? _oldkey;

		private hrep _hrep;

		[Display(Name = "No", Order = 10)]
		[MyCustom(Width = "*", IsVisible = true)]
		public int custno { get => _custno; set => SetProperty(ref _custno, value); }

		[Display(Name = "Agency", Order = 11)]
		[MyCustom(Width = "*")]
		public int saleno {
			get => _saleno;
			set {
				if (value == _saleno) return;
				if (_saleno != 0 && value != _saleno)
					_hrep = FindAgency();
				_saleno = value;
				OnPropertyChanged(); }
		}

		[Display(AutoGenerateField = false)]
		public int stateno { get => _stateno; set => SetProperty(ref _stateno, value); }

		[Display(Name = "Name", Order = 20)]
		[MyCustom(Width = "*")]
		public string name { get => _name; set => SetProperty(ref _name, value); }

		[Display(Name = "Address1", Order = 21)]
		[MyCustom(Width = "*", IsVisible = true)]
		public string address { get => _address; set => SetProperty(ref _address, value); }

		[Display(Name = "Address2", Order = 22)]
		[MyCustom(Width = "*", IsVisible = true)]
		public string address2 { get => _address2; set => SetProperty(ref _address2, value); }

		[Display(Name = "City", Order = 23)]
		[MyCustom(Width = "*", IsVisible = true)]
		public string city { get => _city; set => SetProperty(ref _city, value); }

		[Display(Name = "ST", Order = 25)]
		[MyCustom(LookupKey = "StateCode", SelectedValuePath = "Code", GridViewDisplayMemberPath = "Code", IsUserMaintainable = false, IsVisible = true)]
		public string state { get => _state; set => SetProperty(ref _state, value); }

		[Display(Name = "Zip", Order = 26)]
		[MyCustom(Mask = "#####")]
		public string zip { get => _zip; set => SetProperty(ref _zip, value); }

		[Display(Name = "Sls Contact", Order = 80)]
		[MyCustom(Width = "*", IsVisible = true)]
		public string contact { get => _contact; set => SetProperty(ref _contact, value); }

		[Display(Name = "Pay Contact", Order = 81)]
		[MyCustom(Width = "*", IsVisible = true)]
		public string contact2 { get => _contact2; set => SetProperty(ref _contact2, value); }

		[Display(Name = "Tax No", Order = 50)]
		[MyCustom(Width = "*", IsVisible = true)]
		public string taxid { get => _taxid; set => SetProperty(ref _taxid, value); }

		[Display(Name = "Tax Date", Order = 51)]
		[DataType(DataType.Date), DisplayFormat(DataFormatString = MagicString.SmallDateFormat, ApplyFormatInEditMode = true)]
		[MyCustom(Width = MagicString.DateColumnWidth)]
		public DateTime? tdate { get => _tdate; set => SetProperty(ref _tdate, value); }

		[Display(Name = "Phone", Order = 27)]
		[MyCustom(Mask = MagicString.PhoneMask, Width = "90", IsVisible = true)]
		public string phone { get => _phone; set => SetProperty(ref _phone, value); }

		[Display(Name = "Fax", Order = 28)]
		[MyCustom(Mask = MagicString.PhoneMask, Width = "90")]
		public string phone2 { get => _phone2; set => SetProperty(ref _phone2, value); }

		[Display(Name = "DB Rating", Order = 61)]
		public string dbrate { get => _dbrate; set => SetProperty(ref _dbrate, value); }

		[Display(Name = "Credit", Order = 62)]
		[MyCustom(AdsReadOnly = true)]
		public int? credit { get => _credit; set => SetProperty(ref _credit, value); }

		[Display(Name = "Curr YTD", Order = 70)]
		[DisplayFormat(DataFormatString = MagicString.CurrencyFormat)]
		[MyCustom(Mask = "", FormatString = MagicString.CurrencyFormatString, Alignment = TextAlignment.Right, AdsReadOnly = true)]
		public decimal? csales { get => _csales; set => SetProperty(ref _csales, value); }

		[Display(Name = "Prev YTD", Order = 71)]
		[DisplayFormat(DataFormatString = MagicString.CurrencyFormat)]
		[MyCustom(Mask = "", FormatString = MagicString.CurrencyFormatString, Alignment = TextAlignment.Right, AdsReadOnly = true)]
		public decimal? pysales { get => _pysales; set => SetProperty(ref _pysales, value); }

		[Display(Name = "Credit Check", Order = 64)]
		public string credcheck { get => _credcheck; set => SetProperty(ref _credcheck, value); }

		[Display(Name = "Ship Name", Order = 40)]
		[MyCustom(Width = "*", IsVisible = true)]
		public string sname { get => _sname; set => SetProperty(ref _sname, value); }

		[Display(Name = "Ship Address1", Order = 41)]
		[MyCustom(Width = "*", IsVisible = true)]
		public string saddress { get => _saddress; set => SetProperty(ref _saddress, value); }

		[Display(Name = "Ship Address2", Order = 42)]
		[MyCustom(Width = "*", IsVisible = true)]
		public string saddress2 { get => _saddress2; set => SetProperty(ref _saddress2, value); }

		[Display(Name = "Ship City", Order = 44)]
		[MyCustom(Width = "*", IsVisible = true)]
		public string scity { get => _scity; set => SetProperty(ref _scity, value); }

		[Display(Name = "Ship ST", Order = 43)]
		[MyCustom(LookupKey = "StateCode", SelectedValuePath = "Code", GridViewDisplayMemberPath = "Code", IsUserMaintainable = false, IsVisible = true)]
		public string sstate { get => _sstate; set => SetProperty(ref _sstate, value); }

		[Display(Name = "Ship Zip", Order = 45)]
		[MyCustom(Mask = "#####")]
		public string szip { get => _szip; set => SetProperty(ref _szip, value); }

		[Display(AutoGenerateField = false)]
		public string stocking { get => _stocking; set => SetProperty(ref _stocking, value); }

		[Display(AutoGenerateField = false)]
		public string pucredit { get => _pucredit; set => SetProperty(ref _pucredit, value); }

		[Display(Name = "First Inv", Order = 72)]
		[DataType(DataType.Date), DisplayFormat(DataFormatString = MagicString.SmallDateFormat, ApplyFormatInEditMode = true)]
		[MyCustom(IsVisible = true, Width = MagicString.DateColumnWidth, AdsReadOnly = true)]
		public DateTime? fsaledate { get => _fsaledate; set => SetProperty(ref _fsaledate, value); }

		[Display(Name = "Last Inv", Order = 73)]
		[DataType(DataType.Date), DisplayFormat(DataFormatString = MagicString.SmallDateFormat, ApplyFormatInEditMode = true)]
		[MyCustom(IsVisible = true, Width = MagicString.DateColumnWidth, AdsReadOnly = true)]
		public DateTime? linvdate { get => _linvdate; set => SetProperty(ref _linvdate, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? ar0 { get => _ar0; set => SetProperty(ref _ar0, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? ar1 { get => _ar1; set => SetProperty(ref _ar1, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? ar2 { get => _ar2; set => SetProperty(ref _ar2, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? ar3 { get => _ar3; set => SetProperty(ref _ar3, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? ar4 { get => _ar4; set => SetProperty(ref _ar4, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? ar5 { get => _ar5; set => SetProperty(ref _ar5, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public int? ar0_cnt { get => _ar0_cnt; set => SetProperty(ref _ar0_cnt, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public int? ar1_cnt { get => _ar1_cnt; set => SetProperty(ref _ar1_cnt, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public int? ar2_cnt { get => _ar2_cnt; set => SetProperty(ref _ar2_cnt, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public int? ar3_cnt { get => _ar3_cnt; set => SetProperty(ref _ar3_cnt, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public int? ar4_cnt { get => _ar4_cnt; set => SetProperty(ref _ar4_cnt, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public int? ar5_cnt { get => _ar5_cnt; set => SetProperty(ref _ar5_cnt, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public int? inv_6_mo { get => _inv_6_mo; set => SetProperty(ref _inv_6_mo, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public int? inv_avg { get => _inv_avg; set => SetProperty(ref _inv_avg, value); }

		[Display(AutoGenerateField = false)]
		public string oembl { get => _oembl; set => SetProperty(ref _oembl, value); }

		[Display(AutoGenerateField = false)]
		public string oemlabel { get => _oemlabel; set => SetProperty(ref _oemlabel, value); }

		[Display(AutoGenerateField = false)]
		public int? credlimit { get => _credlimit; set => SetProperty(ref _credlimit, value); }

		[Display(AutoGenerateField = false)]
		public string callinfo { get => _callinfo; set => SetProperty(ref _callinfo, value); }

		[Display(AutoGenerateField = false)]
		public string rebate { get => _rebate; set => SetProperty(ref _rebate, value); }

		[Display(Name = "PDP Group")]
		public string pdpgrp { get => _pdpgrp; set => SetProperty(ref _pdpgrp, value); }

		[Display(Name = "InvFax")]
		[MyCustom(Mask = MagicString.PhoneMask)]
		public string invfaxno { get => _invfaxno; set => SetProperty(ref _invfaxno, value); }

		[Display(Name = "FaxInv?")]
		public bool? faxinv { get => _faxinv; set => SetProperty(ref _faxinv, value); }

		[Display(Name = "Taxable?")]
		public bool? taxable { get => _taxable; set => SetProperty(ref _taxable, value); }

		[Display(AutoGenerateField = false)]
		public int? terms { get => _terms; set => SetProperty(ref _terms, value); }

		[Display(AutoGenerateField = false)]
		public string email { get => _email; set => SetProperty(ref _email, value); }

		[Display(AutoGenerateField = false)]
		public string fxcontact { get => _fxcontact; set => SetProperty(ref _fxcontact, value); }

		[Display(Name = "Inactive", Order = 34)]
		public bool? inactive { get => _inactive; set => SetProperty(ref _inactive, value); }

		[Display(AutoGenerateField = false)]
		public int? ppfrtmin { get => _ppfrtmin; set => SetProperty(ref _ppfrtmin, value); }

		[Display(AutoGenerateField = false)]
		public bool? nocrhold { get => _nocrhold; set => SetProperty(ref _nocrhold, value); }

		[Display(AutoGenerateField = false)]
		public bool? wpo { get => _wpo; set => SetProperty(ref _wpo, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public int? oldkey { get => _oldkey; set => SetProperty(ref _oldkey, value); }

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public sealed override string Key { get; set; }

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public sealed override object[] KeyValue => new object[] { custno };

		public string AddressLine1 => address;

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public string AddressLine2 => !string.IsNullOrEmpty(address2) ? address2 : CSZ;

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public string AddressLine3 => !string.IsNullOrEmpty(address2) ? CSZ : "";

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public string CSZ => $"{city}, {state}  {zip}";

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public string SCSZ => $"{scity}, {sstate}  {szip}";

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public string NoName => $"{custno} - {name}";

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public string NoNameCitySt => $"{custno} - {name} - {city}, {state}";

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public bool Rebate { get => rebate == "Y"; set => rebate = value ? "Y" : "N"; }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public bool Stocking { get => stocking == "Y"; set => stocking = value ? "Y" : "N"; }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public bool PuCredit { get => pucredit == "Y"; set => pucredit = value ? "Y" : "N"; }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public bool CallInfo { get => callinfo == "Y"; set => callinfo = value ? "Y" : "N"; }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public bool OemLabel { get => oemlabel == "Y"; set => oemlabel = value ? "Y" : "N"; }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public bool OemBl { get => oembl == "Y"; set => oembl = value ? "Y" : "N"; }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public bool Pdp => stocking == "Y";

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public hrep hrep {
			get {
				if (_hrep == null && _saleno != 0) {
					_hrep = FindAgency();
					OnPropertyChanged();
				}
				return _hrep;
			}
			set { _hrep = value; OnPropertyChanged(); }
		}

		public hrep FindAgency() {
			var context = new FoxProDataContext();
			return context.GetEntity<hrep>(_saleno);
		}

		public override bool Update() {
			var context = new FoxProDataContext();
			var updated = context.Update(this);
			if (updated) {

			}
			return updated;
		}

		public override void Refresh() {
			var context = new FoxProDataContext();
			var entity = context.GetEntity<hcust>(custno);
			if (name != entity.name) name = entity.name;
			if (stateno != entity.stateno) stateno = entity.stateno;
			if (name != entity.name) name = entity.name;
			if (address != entity.address) address = entity.address;
			if (address2 != entity.address2) address2 = entity.address2;
			if (city != entity.city) city = entity.city;
			if (state != entity.state) state = entity.state;
			if (zip != entity.zip) zip = entity.zip;
			if (contact != entity.contact) contact = entity.contact;
			if (contact2 != entity.contact2) contact2 = entity.contact2;
			if (taxid != entity.taxid) taxid = entity.taxid;
			if (phone != entity.phone) phone = entity.phone;
			if (phone2 != entity.phone2) phone2 = entity.phone2;
			if (dbrate != entity.dbrate) dbrate = entity.dbrate;
			if (credit != entity.credit) credit = entity.credit;
			if (credcheck != entity.credcheck) credcheck = entity.credcheck;
			if (sname != entity.sname) sname = entity.sname;
			if (saddress != entity.saddress) saddress = entity.saddress;
			if (saddress2 != entity.saddress2) saddress2 = entity.saddress2;
			if (scity != entity.scity) scity = entity.scity;
			if (sstate != entity.sstate) sstate = entity.sstate;
			if (szip != entity.szip) szip = entity.szip;
			if (stocking != entity.stocking) stocking = entity.stocking;
			if (pucredit != entity.pucredit) pucredit = entity.pucredit;
			if (oembl != entity.oembl) oembl = entity.oembl;
			if (oemlabel != entity.oemlabel) oemlabel = entity.oemlabel;
			if (credlimit != entity.credlimit) credlimit = entity.credlimit;
			if (callinfo != entity.callinfo) callinfo = entity.callinfo;
			if (rebate != entity.rebate) rebate = entity.rebate;
			if (pdpgrp != entity.pdpgrp) pdpgrp = entity.pdpgrp;
			if (invfaxno != entity.invfaxno) invfaxno = entity.invfaxno;
			if (taxable != entity.taxable) taxable = entity.taxable;
			if (terms != entity.terms) terms = entity.terms;
			if (faxinv != entity.faxinv) faxinv = entity.faxinv;
			if (email != entity.email) email = entity.email;
			if (fxcontact != entity.fxcontact) fxcontact = entity.fxcontact;
			if (inactive != entity.inactive) inactive = entity.inactive;
			if (tdate != entity.tdate) tdate = entity.tdate;
			if (ppfrtmin != entity.ppfrtmin) ppfrtmin = entity.ppfrtmin;
			if (nocrhold != entity.nocrhold) nocrhold = entity.nocrhold;
			if (wpo != entity.wpo) wpo = entity.wpo;
			MakeClean();
		}

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("custno")) custno = reader.ReadInt("custno");
			if (InFieldList("saleno")) saleno = reader.ReadInt("saleno");
			if (InFieldList("stateno")) stateno = reader.ReadInt("stateno");
			if (InFieldList("name")) name = reader.ReadString("name");
			if (InFieldList("address")) address = reader.ReadString("address");
			if (InFieldList("address2")) address2 = reader.ReadString("address2");
			if (InFieldList("city")) city = reader.ReadString("city");
			if (InFieldList("state")) state = reader.ReadString("state");
			if (InFieldList("zip")) zip = reader.ReadString("zip");
			if (InFieldList("contact")) contact = reader.ReadString("contact");
			if (InFieldList("contact2")) contact2 = reader.ReadString("contact2");
			if (InFieldList("taxid")) taxid = reader.ReadString("taxid");
			if (InFieldList("phone")) phone = reader.ReadString("phone");
			if (InFieldList("phone2")) phone2 = reader.ReadString("phone2");
			if (InFieldList("dbrate")) dbrate = reader.ReadString("dbrate");
			if (InFieldList("credit")) credit = reader.ReadInt("credit");
			if (InFieldList("csales")) csales = reader.ReadDecimal("csales");
			if (InFieldList("pysales")) pysales = reader.ReadDecimal("pysales");
			if (InFieldList("credcheck")) credcheck = reader.ReadString("credcheck");
			if (InFieldList("fsaledate")) fsaledate = reader.ReadDate("fsaledate");
			if (InFieldList("sname")) sname = reader.ReadString("sname");
			if (InFieldList("saddress")) saddress = reader.ReadString("saddress");
			if (InFieldList("saddress2")) saddress2 = reader.ReadString("saddress2");
			if (InFieldList("scity")) scity = reader.ReadString("scity");
			if (InFieldList("sstate")) sstate = reader.ReadString("sstate");
			if (InFieldList("szip")) szip = reader.ReadString("szip");
			if (InFieldList("stocking")) stocking = reader.ReadString("stocking");
			if (InFieldList("pucredit")) pucredit = reader.ReadString("pucredit");
			if (InFieldList("linvdate")) linvdate = reader.ReadDate("linvdate");
			if (InFieldList("ar0")) ar0 = reader.ReadDecimal("ar0");
			if (InFieldList("ar1")) ar1 = reader.ReadDecimal("ar1");
			if (InFieldList("ar2")) ar2 = reader.ReadDecimal("ar2");
			if (InFieldList("ar3")) ar3 = reader.ReadDecimal("ar3");
			if (InFieldList("ar4")) ar4 = reader.ReadDecimal("ar4");
			if (InFieldList("ar5")) ar5 = reader.ReadDecimal("ar5");
			if (InFieldList("ar0_cnt")) ar0_cnt = reader.ReadInt("ar0_cnt");
			if (InFieldList("ar1_cnt")) ar1_cnt = reader.ReadInt("ar1_cnt");
			if (InFieldList("ar2_cnt")) ar2_cnt = reader.ReadInt("ar2_cnt");
			if (InFieldList("ar3_cnt")) ar3_cnt = reader.ReadInt("ar3_cnt");
			if (InFieldList("ar4_cnt")) ar4_cnt = reader.ReadInt("ar4_cnt");
			if (InFieldList("ar5_cnt")) ar5_cnt = reader.ReadInt("ar5_cnt");
			if (InFieldList("inv_6_mo")) inv_6_mo = reader.ReadInt("inv_6_mo");
			if (InFieldList("inv_avg")) inv_avg = reader.ReadInt("inv_avg");
			if (InFieldList("oembl")) oembl = reader.ReadString("oembl");
			if (InFieldList("oemlabel")) oemlabel = reader.ReadString("oemlabel");
			if (InFieldList("credlimit")) credlimit = reader.ReadInt("credlimit");
			if (InFieldList("callinfo")) callinfo = reader.ReadString("callinfo");
			if (InFieldList("rebate")) rebate = reader.ReadString("rebate");
			if (InFieldList("pdpgrp")) pdpgrp = reader.ReadString("pdpgrp");
			if (InFieldList("invfaxno")) invfaxno = reader.ReadString("invfaxno");
			if (InFieldList("taxable")) taxable = reader.ReadBool("taxable");
			if (InFieldList("terms")) terms = reader.ReadInt("terms");
			if (InFieldList("faxinv")) faxinv = reader.ReadBool("faxinv");
			if (InFieldList("email")) email = reader.ReadString("email");
			if (InFieldList("fxcontact")) fxcontact = reader.ReadString("fxcontact");
			if (InFieldList("inactive")) inactive = reader.ReadBool("inactive");
			if (InFieldList("tdate")) tdate = reader.ReadDate("tdate");
			if (InFieldList("ppfrtmin")) ppfrtmin = reader.ReadInt("ppfrtmin");
			if (InFieldList("nocrhold")) nocrhold = reader.ReadBool("nocrhold");
			if (InFieldList("wpo")) wpo = reader.ReadBool("wpo");
			if (InFieldList("oldkey")) oldkey = reader.ReadInt("oldkey");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public IList<hcust> GetCustomersLookup(string whereValue) {
			var qTime = DateTime.Now;
			var entities = new List<hcust>();
			Conn.Open();
			var cmd = Conn.CreateCommand();
			var where = string.IsNullOrEmpty(whereValue) ? "" : $"where name like '{whereValue}%' and ";
			//var sql = $"select custno, saleno, name, address, address2, city, state, zip, phone from hcust {where}not inactive order by name"; //16 sec
			var sql = $"select custno, saleno, name, address, address2, city, state, zip, sname, saddress, saddress2, scity, sstate, szip, stocking, ppfrtmin, dbrate, phone, inactive from hcust {where}order by name"; // < 1 second -- deal with inactive below
			cmd.CommandText = sql;
			try {
				var reader = cmd.ExecuteReader();
				while (reader.Read()) {
					var inactive = reader.ReadBool(reader.GetOrdinal("inactive"));
					if (inactive) continue;
					var entity = new hcust {
						custno = reader.ReadInt(reader.GetOrdinal("custno")),
						saleno = reader.ReadInt(reader.GetOrdinal("saleno")),
						name = reader.ReadString(reader.GetOrdinal("name")),
						address = reader.ReadString(reader.GetOrdinal("address")),
						address2 = reader.ReadString(reader.GetOrdinal("address2")),
						city = reader.ReadString(reader.GetOrdinal("city")),
						state = reader.ReadString(reader.GetOrdinal("state")),
						zip = reader.ReadString(reader.GetOrdinal("zip")),
						sname = reader.ReadString(reader.GetOrdinal("sname")),
						saddress = reader.ReadString(reader.GetOrdinal("saddress")),
						saddress2 = reader.ReadString(reader.GetOrdinal("saddress2")),
						scity = reader.ReadString(reader.GetOrdinal("scity")),
						sstate = reader.ReadString(reader.GetOrdinal("sstate")),
						szip = reader.ReadString(reader.GetOrdinal("szip")),
						phone = reader.ReadString(reader.GetOrdinal("phone")),
						dbrate = reader.ReadString(reader.GetOrdinal("dbrate")),
						stocking = reader.ReadString(reader.GetOrdinal("stocking")),
						ppfrtmin = reader.ReadInt(reader.GetOrdinal("ppfrtmin"))
					};
					entities.Add(entity);
				}
				reader.Close();
			}
			catch (Exception e) {
				Console.WriteLine(e);
			}
			Conn.Close();
			var dtime = Math.Round((DateTime.Now - qTime).TotalMilliseconds, 0);
			QueryDebugEnd(qTime, $"GetCustomersLookup - {sql}");
			//entities = entities.Where(x => !x.inactive.GetValueOrDefault()).ToList();
			return entities;

		}

		public hcust GetCustomer(int custno, List<string> fieldList) {
			var qTime = DateTime.Now;
			var sql = $"select {GetFields(fieldList)} from hcust where custno={custno}";
			var entity = GetEntitySql<hcust>(sql, fieldList);
			QueryDebugEnd(qTime, $"GetCustomer - {sql}");
			return entity;
		}

		public hcust GetCustomer(int custno) {
			var qTime = DateTime.Now;
			var sql = $"select * from hcust where custno={custno}";
			var entity = GetEntitySql<hcust>(sql);
			QueryDebugEnd(qTime, $"GetCustomer - {sql}");
			return entity;
		}

		public IList<hcust> GetAgencyCustomers(int saleno) {
			var qTime = DateTime.Now;
			var sql = $"select * from hcust where saleno={saleno}";
			var entities = GetEntities<hcust>(sql);
			QueryDebugEnd(qTime, $"GetAgencyCustomers - {sql}");
			return entities;
		}

		public bool CustomerAgencySwitch(int from, int to) {
			var qTime = DateTime.Now;
			var custs = GetAgencyCustomers(from);
			foreach (var cust in custs) {
				cust.saleno = to;
				Update(cust);
			}
			QueryDebugEnd(qTime, $"CustomerAgencySwitch");
			return true;
		}

	}

}
