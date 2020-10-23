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
using DataModel;

namespace AdsDataModel {

	public class hord : FoxProEntity {

		public hord() {
			Key = "orderno";
		}

		private int _sqlid; // 10
		private int _foxid; // 10
		private int _custno; // 5
		private int _orderno; // 8
		private string _revision; // 1
		private int? _invno; // 10
		private int? _bofrom; // 8
		private int? _boto; // 8
		private string _status; // 1
		private string _ackstatus; // 1
		private string _wostatus; // 1
		private DateTime? _date; // 8
		private string _pono; // 23
		private DateTime? _po_date; // 8
		private DateTime? _rec_date; // 8
		private DateTime? _rel_date; // 8
		private DateTime? _ack_date; // 8
		private DateTime? _ship_date; // 8
		private DateTime? _asbl_date; // 8
		private DateTime? _ashp_date; // 8
		private DateTime? _invdate; // 8
		private DateTime? _datesched; // 8
		private DateTime? _datecancel; // 8
		private DateTime? _holdf_date; // 8
		private DateTime? _holdb_date; // 8
		private int? _sale1; // 5
		private int? _sale1per; // 3
		private int? _sale2; // 5
		private int? _sale2per; // 3
		private int? _sale3; // 5
		private int? _sale3per; // 3
		private string _route; // 20
		private string _pronum; // 12
		private string _mark; // 30
		private string _prepay; // 1
		private string _lotprice; // 1
		private string _blprint; // 1
		private string _call; // 20
		private string _call_phone; // 12
		private string _hrs_before; // 2
		private string _sname; // 25
		private string _saddress; // 25
		private string _saddress2; // 25
		private string _scity; // 20
		private string _sstate; // 2
		private string _szip; // 10
		private string _ack; // 50
		private string _spec; // 50
		private string _bott; // 50
		private string _takenby; // 8
		private decimal? _freight; // 10.2
		private string _taxable; // 1
		private decimal? _salestax; // 8.2
		private decimal? _subtotal; // 10.2
		private string _arstatus; // 1
		private decimal? _commission; // 9.2
		private string _credit; // 1
		private string _stocking; // 1
		private string _pickup; // 1
		private string _ordtype; // 1
		private DateTime? _paid_date; // 8
		private DateTime? _pcom_date; // 8
		private bool? _acctlock; // bool
		private bool? _commlock; // bool
		private int? _cmorderno; // 10
		private string _glcode; // 4
		private decimal? _commadjust; // 9.2
		private string _fvendor; // 5
		private string _checkmark; // 1
		private DateTime? _checkdate; // 8
		private string _checkuser; // 8
		private int? _subcuts; // 2
		private string _currency; // 1
		private decimal? _exrate; // 6.4
		private decimal? _exrate2usd; // 6.4
		private decimal? _brokefee; // 7.2
		private decimal? _csubtotal; // 10.2
		private decimal? _csalestax; // 7.2
		private decimal? _cost; // 10.2
		private string _lastrev; // 1
		private string _credclear; // 7
		private int? _comper; // 3
		private decimal? _vcamount; // 9.2
		private DateTime? _vcpaiddate; // 8
		private string _mso; // 1
		private decimal? _tax_st; // 5.3
		private decimal? _tax_co; // 5.3
		private decimal? _tax_lo; // 5.3
		private string _scounty; // 20
		private bool? _credapp; // bool
		private DateTime? _schday; // 8
		private string _cc; // 1
		private string _ouser; // 8
		private string _cuser; // 8
		private string _ordlst; // 1
		private string _whse; // 2
		private int? _apcom; // 8
		private int? _apvcom; // 8
		private int? _terms; // 3
		private string _ordstyle; // 3
		private int? _oldkey; // 8
		private int? _oldinv; // 10
		private int? _pallet48; // 2
		private int? _pallet44; // 2
		private int? _pallet42; // 2
		private int? _loosepcs; // 2
		private int? _crates; // 2
		private int? _cratewgt; // 4
		private string _shq_no; // 10
		private string _shq_name; // 15
		private decimal? _shq_amt; // 9.2
		private int? _shtrailer; // 6
		private string _shname; // 20
		private string _warr_yes; // 1
		private string _warr_chk; // 8
		private DateTime? _warr_date; // 8
		private DateTime? _esd_newdt; // 8
		private DateTime? _esd_lchg; // 8
		private string _esd_lchgby; // 8
		private string _esd_reason; // 1
		private DateTime? _dnsb4; //8
		private DateTime? _chgdate; // 8
		private decimal totalComm;

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public int sqlid { get => _sqlid; set => SetProperty(ref _sqlid, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public int foxid { get => _foxid; set => SetProperty(ref _foxid, value); }

		public int custno { get => _custno; set => SetProperty(ref _custno, value); }

		public int orderno { get => _orderno; set => SetProperty(ref _orderno, value); }
		
		public string revision { get => _revision; set => SetProperty(ref _revision, value?.Left(1)); }

		[MyCustom(AdsIgnore = true)]
		public string OrderNoRev => string.IsNullOrEmpty(revision) ? $"{orderno}" : $"{orderno}-{revision}";

		public int? invno { get => _invno; set => SetProperty(ref _invno, value); }

		public int? bofrom { get => _bofrom; set => SetProperty(ref _bofrom, value); }

		public int? boto { get => _boto; set => SetProperty(ref _boto, value); }

		public string status { get => _status; set => SetProperty(ref _status, value?.Left(1)); }

		public string ackstatus { get => _ackstatus; set => SetProperty(ref _ackstatus, value?.Left(1)); }

		public string wostatus { get => _wostatus; set => SetProperty(ref _wostatus, value?.Left(1)); }

		public DateTime? date { get => _date; set => SetProperty(ref _date, value); }

		public string pono { get => _pono; set => SetProperty(ref _pono, value?.Left(23)); }

		public DateTime? po_date { get => _po_date; set => SetProperty(ref _po_date, value); }

		public DateTime? rec_date { get => _rec_date; set => SetProperty(ref _rec_date, value); }

		public DateTime? rel_date { get => _rel_date; set => SetProperty(ref _rel_date, value); }

		public DateTime? ack_date { get => _ack_date; set => SetProperty(ref _ack_date, value); }

		public DateTime? ship_date { get => _ship_date; set => SetProperty(ref _ship_date, value); }

		public DateTime? asbl_date { get => _asbl_date; set => SetProperty(ref _asbl_date, value); }

		public DateTime? ashp_date { get => _ashp_date; set => SetProperty(ref _ashp_date, value); }

		public DateTime? invdate { get => _invdate; set => SetProperty(ref _invdate, value); }

		public DateTime? datesched { get => _datesched; set => SetProperty(ref _datesched, value); }

		public DateTime? datecancel { get => _datecancel; set => SetProperty(ref _datecancel, value); }

		public DateTime? holdf_date { get => _holdf_date; set => SetProperty(ref _holdf_date, value); }

		public DateTime? holdb_date { get => _holdb_date; set => SetProperty(ref _holdb_date, value); }

		public int? sale1 { get => _sale1; set => SetProperty(ref _sale1, value); }

		public int? sale1per { get => _sale1per; set => SetProperty(ref _sale1per, value); }

		public int? sale2 { get => _sale2; set => SetProperty(ref _sale2, value); }

		public int? sale2per { get => _sale2per; set => SetProperty(ref _sale2per, value); }

		public int? sale3 { get => _sale3; set => SetProperty(ref _sale3, value); }

		public int? sale3per { get => _sale3per; set => SetProperty(ref _sale3per, value); }

		public string route { get => _route; set => SetProperty(ref _route, value?.Left(20)); }

		public string pronum { get => _pronum; set => SetProperty(ref _pronum, value?.Left(12)); }

		public string mark { get => _mark; set => SetProperty(ref _mark, value?.Left(30)); }

		public string prepay { get => _prepay; set => SetProperty(ref _prepay, value?.Left(1)); }

		public string lotprice { get => _lotprice; set => SetProperty(ref _lotprice, value?.Left(1)); }

		public string blprint { get => _blprint; set => SetProperty(ref _blprint, value?.Left(1)); }

		public string call { get => _call; set => SetProperty(ref _call, value?.Left(20)); }

		public string call_phone { get => _call_phone; set => SetProperty(ref _call_phone, value?.Left(12)); }

		public string hrs_before { get => _hrs_before; set => SetProperty(ref _hrs_before, value?.Left(2)); }

		public string sname { get => _sname; set => SetProperty(ref _sname, value?.Left(25)); }

		public string saddress { get => _saddress; set => SetProperty(ref _saddress, value?.Left(25)); }

		public string saddress2 { get => _saddress2; set => SetProperty(ref _saddress2, value?.Left(25)); }

		public string scity { get => _scity; set => SetProperty(ref _scity, value?.Left(20)); }

		public string sstate { get => _sstate; set => SetProperty(ref _sstate, value?.Left(2)); }

		public string szip { get => _szip; set => SetProperty(ref _szip, value?.Left(10)); }

		public string ack { get => _ack; set => SetProperty(ref _ack, value?.Left(50)); }

		public string spec { get => _spec; set => SetProperty(ref _spec, value?.Left(50)); }

		public string bott { get => _bott; set => SetProperty(ref _bott, value?.Left(50)); }

		public string takenby { get => _takenby; set => SetProperty(ref _takenby, value?.Left(8)); }

		public decimal? freight { get => _freight; set => SetProperty(ref _freight, value); }

		public string taxable { get => _taxable; set => SetProperty(ref _taxable, value?.Left(1)); }

		public decimal? salestax { get => _salestax; set => SetProperty(ref _salestax, value); }

		public decimal? subtotal { get => _subtotal; set => SetProperty(ref _subtotal, value); }

		public string arstatus { get => _arstatus; set => SetProperty(ref _arstatus, value?.Left(1)); }

		[MyCustom(AdsIgnore = true)]
		public decimal? commission {
			get {
				//if (_commission == 0) _commission = Details.Sum(x => x.Commission.GetValueOrDefault());
				return _commission;
			}
			set => SetProperty(ref _commission, value);
		}

		public string credit { get => _credit; set => SetProperty(ref _credit, value?.Left(1)); }

		public string stocking { get => _stocking; set => SetProperty(ref _stocking, value?.Left(1)); }

		public string pickup { get => _pickup; set => SetProperty(ref _pickup, value?.Left(1)); }

		public string ordtype { get => _ordtype; set => SetProperty(ref _ordtype, value?.Left(1)); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public DateTime? paid_date { get => _paid_date; set => SetProperty(ref _paid_date, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public DateTime? pcom_date { get => _pcom_date; set => SetProperty(ref _pcom_date, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public bool? acctlock { get => _acctlock; set => SetProperty(ref _acctlock, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public bool? commlock { get => _commlock; set => SetProperty(ref _commlock, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public int? cmorderno { get => _cmorderno; set => SetProperty(ref _cmorderno, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public string glcode { get => _glcode; set => SetProperty(ref _glcode, value?.Left(4)); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public decimal? commadjust { get => _commadjust; set => SetProperty(ref _commadjust, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public string fvendor { get => _fvendor; set => SetProperty(ref _fvendor, value?.Left(5)); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public string checkmark { get => _checkmark; set => SetProperty(ref _checkmark, value?.Left(1)); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public DateTime? checkdate { get => _checkdate; set => SetProperty(ref _checkdate, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public string checkuser { get => _checkuser; set => SetProperty(ref _checkuser, value?.Left(8)); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public int? subcuts { get => _subcuts; set => SetProperty(ref _subcuts, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = false)]
		public string currency { get => _currency; set => SetProperty(ref _currency, value?.Left(1)); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public decimal? exrate { get => _exrate; set => SetProperty(ref _exrate, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public decimal? exrate2usd { get => _exrate2usd; set => SetProperty(ref _exrate2usd, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public decimal? brokefee { get => _brokefee; set => SetProperty(ref _brokefee, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public decimal? csubtotal { get => _csubtotal; set => SetProperty(ref _csubtotal, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public decimal? csalestax { get => _csalestax; set => SetProperty(ref _csalestax, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public decimal? cost { get => _cost; set => SetProperty(ref _cost, value); }

		[Display(AutoGenerateField = false)]
		public string lastrev { get => _lastrev; set => SetProperty(ref _lastrev, value?.Left(1)); }

		[Display(AutoGenerateField = false)]
		public string credclear { get => _credclear; set => SetProperty(ref _credclear, value?.Left(7)); }

		[Display(AutoGenerateField = false)]
		public int? comper { get => _comper; set => SetProperty(ref _comper, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public decimal? vcamount {
			get {
				//if (_vcamount == 0) _vcamount = Details.Sum(x => x.TotalOverage);
				return _vcamount;
			}
			set => SetProperty(ref _vcamount, value);
		}

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public DateTime? vcpaiddate { get => _vcpaiddate; set => SetProperty(ref _vcpaiddate, value); }

		[Display(AutoGenerateField = false)]
		public string mso { get => _mso; set => SetProperty(ref _mso, value?.Left(1)); }

		[Display(AutoGenerateField = false)]
		public decimal? tax_st { get => _tax_st; set => SetProperty(ref _tax_st, value); }

		[Display(AutoGenerateField = false)]
		public decimal? tax_co { get => _tax_co; set => SetProperty(ref _tax_co, value); }

		[Display(AutoGenerateField = false)]
		public decimal? tax_lo { get => _tax_lo; set => SetProperty(ref _tax_lo, value); }

		[Display(AutoGenerateField = false)]
		public string scounty { get => _scounty; set => SetProperty(ref _scounty, value?.Left(20)); }

		[Display(AutoGenerateField = false)]
		public bool? credapp { get => _credapp; set => SetProperty(ref _credapp, value); }

		[Display(AutoGenerateField = false)]
		public DateTime? schday { get => _schday; set => SetProperty(ref _schday, value); }

		[Display(AutoGenerateField = false)]
		public string cc { get => _cc; set => SetProperty(ref _cc, value?.Left(1)); }

		[Display(AutoGenerateField = false)]
		public string ouser { get => _ouser; set => SetProperty(ref _ouser, value?.Left(8)); }

		[Display(AutoGenerateField = false)]
		public string cuser { get => !string.IsNullOrEmpty(_cuser) ? _cuser : _ouser; set => SetProperty(ref _cuser, value?.Left(8)); }

		[Display(AutoGenerateField = false)]
		public string ordlst { get => _ordlst; set => SetProperty(ref _ordlst, value?.Left(1)); }

		[Display(AutoGenerateField = false)]
		public string whse { get => _whse; set => SetProperty(ref _whse, value?.Left(1)); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public int? apcom { get => _apcom; set => SetProperty(ref _apcom, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public int? apvcom { get => _apvcom; set => SetProperty(ref _apvcom, value); }

		[Display(AutoGenerateField = false)]
		public int? terms { get => _terms; set => SetProperty(ref _terms, value); }

		public string ordstyle { get => _ordstyle; set => SetProperty(ref _ordstyle, value?.Left(3)); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public int? oldkey { get => _oldkey; set => SetProperty(ref _oldkey, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public int? oldinv { get => _oldinv; set => SetProperty(ref _oldinv, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public int? pallet48 { get => _pallet48; set => SetProperty(ref _pallet48, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public int? pallet44 { get => _pallet44; set => SetProperty(ref _pallet44, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public int? pallet42 { get => _pallet42; set => SetProperty(ref _pallet42, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public int? loosepcs { get => _loosepcs; set => SetProperty(ref _loosepcs, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public int? crates { get => _crates; set => SetProperty(ref _crates, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public int? cratewgt { get => _cratewgt; set => SetProperty(ref _cratewgt, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public string shq_no { get => _shq_no; set => SetProperty(ref _shq_no, value?.Left(10)); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public string shq_name { get => _shq_name; set => SetProperty(ref _shq_name, value?.Left(15)); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public decimal? shq_amt { get => _shq_amt; set => SetProperty(ref _shq_amt, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public int? shtrailer { get => _shtrailer; set => SetProperty(ref _shtrailer, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public string shname { get => _shname; set => SetProperty(ref _shname, value?.Left(20)); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public string warr_yes { get => _warr_yes; set => SetProperty(ref _warr_yes, value?.Left(1)); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public string warr_chk { get => _warr_chk; set => SetProperty(ref _warr_chk, value?.Left(8)); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public DateTime? warr_date { get => _warr_date; set => SetProperty(ref _warr_date, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public DateTime? esd_newdt { get => _esd_newdt; set => SetProperty(ref _esd_newdt, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public DateTime? esd_lchg { get => _esd_lchg; set => SetProperty(ref _esd_lchg, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public string esd_lchgby { get => _esd_lchgby; set => SetProperty(ref _esd_lchgby, value?.Left(8)); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public string esd_reason { get => _esd_reason; set => SetProperty(ref _esd_reason, value?.Left(8)); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public DateTime? dnsb4 { get => _dnsb4; set => SetProperty(ref _dnsb4, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public DateTime? chgdate { get => _chgdate; set => SetProperty(ref _chgdate, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public override object[] KeyValue {
			get {
				switch (Key) {
					case "pono":
						return new object[] { pono };
					case "invno":
						return new object[] { invno };
					default:
						return new object[] { orderno };
				}
			}
		}

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string Alert { get; set; }

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public int Cartons { get; set; }

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public int Weight { get; set; }

		//[MyCustom(AdsIgnore = true)]
		//[Display(AutoGenerateField = false)]
		//public decimal CubicFeet { get; set; }

		//[MyCustom(AdsIgnore = true)]
		//[Display(AutoGenerateField = false)]
		//public decimal FloorSpace { get; set; }

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public hcust Customer { get; set; } = new hcust();

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string SoldName { get; set; }

		//[MyCustom(AdsIgnore = true)]
		//[Display(AutoGenerateField = false)]
		//public hrep Agency { get; set; } = new hrep();

		//[MyCustom(AdsIgnore = true)]
		//[Display(AutoGenerateField = false)]
		//public string AgencyNoName => Agency.salesno == 0 ? "" : $"{Agency.salesno} - {Agency.name}";

		//[MyCustom(AdsIgnore = true)]
		//[Display(AutoGenerateField = false)]
		//public IList<hdet> Details { get; set; } = new List<hdet>();

		//[MyCustom(AdsIgnore = true)]
		//[Display(AutoGenerateField = false)]
		//public IList<hpronum> ProNums { get; set; } = new List<hpronum>();

		//[MyCustom(AdsIgnore = true)]
		//[Display(AutoGenerateField = false)]
		//public IList<hcomment> Comments { get; set; } = new List<hcomment>();

		//[MyCustom(AdsIgnore = true)]
		//[Display(AutoGenerateField = false)]
		//public string FirstProNum => ProNums.FirstOrDefault()?.pronum;

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public decimal Total => subtotal.GetValueOrDefault() + salestax.GetValueOrDefault() + freight.GetValueOrDefault();

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		//public decimal TotalComm => commission.GetValueOrDefault() - vcamount.GetValueOrDefault() + commadjust.GetValueOrDefault();
		public decimal TotalComm {
			get {
				if (totalComm == 0) totalComm = commission.GetValueOrDefault() + vcamount.GetValueOrDefault() + commadjust.GetValueOrDefault();
				return totalComm;
			}
			set => SetProperty(ref totalComm, value);
		}

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string sAddressLine1 => saddress;

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string sAddressLine2 => !string.IsNullOrEmpty(saddress2) ? saddress2 : sCSZ;

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string sAddressLine3 => !string.IsNullOrEmpty(saddress2) ? sCSZ : "";

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string sCSZ => $"{scity}, {sstate}  {szip}";

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string StatusWord {
			get {
				switch (status) {
					case "1":
					case "2":
						return "Unsched";
					case "3":
					case "4":
					case "5":
					case "6":
						return "Sched";
					case "7":
					case "8":
					case "9":
						return "Shipped";
					case "C":
						return "Cancelled";
					default:
						return "On Hold";
				}
			}
		}

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string StatusColor {
			get {
				switch (StatusWord) {
					case "On Hold":
						return "Red";
					case "Unsched":
						return "Orange";
					case "Sched":
						return "Blue";
					case "Shipped":
						return "Green";
					default:
						return "Black";
				}
			}
		}

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string CreditDesc {
			get {
				switch (credit) {
					case "1":
						return "1 - Current";
					case "2":
						return "2 - Watch";
					case "3":
						return "3 - Over Limit";
					case "4":
						return "4 - Past Due";
					case "5":
						return "5 - UnAuth Deduction Taken";
					case "6":
						return "6 - UnEarned Discount Taken";
					case "9":
						return "9 - CIA";
					default:
						return "";
				}
			}
		}

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string PrepayDesc {
			get {
				switch (prepay) {
					case "P":
						return "Prepaid";
					case "A":
						return "Prepay & Add";
					case "C":
						return "Collect Frt on Del";
					case "T":
						return "Third Party Billing";
					case "B":
						return "PPP Coast Collect Beyond";
					case "D":
						return "Dead Head";
					case "O":
						return "Collect on Delivery";
					default:
						return "";
				}
			}
		}

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string CallInfo => string.IsNullOrEmpty(call_phone) ? "" : string.IsNullOrEmpty(call) ? $"{call_phone},<br/>{hrs_before} hours before" : $"{call}<br/>@ {call_phone},<br/>{hrs_before} hours before";

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string CreditClearEmail => $"mailto:{credclear}@hewilliams.com";

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string Terms1 => Total > 0 ? terms > 0 ? $"Due {terms} Days from Invoice Date." : "Terms: 1% 10th Prox Net 25th" : "";

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string Terms2 => Total > 0 ? $"Net Due on or before {DueDate:MMM dd, yyyy}" : "";

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string Terms3 => Total > 0 && terms == 0 ? $"A cash discount of {Math.Round(Total * 0.01m, 2):C}" : "";

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string Terms4 => Total > 0 ? $"will be allowed if paid by {DisDate:MMM dd, yyyy}" : "";

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public DateTime? DueDate {
			get {
				if (invdate == null) return null;
				var idate = invdate.GetValueOrDefault();
				var mon = idate.Month + (idate.Day < 25 ? 1 : 2);
				var year = idate.Year;
				if (mon > 12) {
					mon = mon - 12;
					year++;
				}
				var duedate = new DateTime(year, mon, 25);
				if (terms.GetValueOrDefault() > 0) {
					duedate = duedate.AddDays(terms.GetValueOrDefault());
				}
				return duedate;
			}
		}

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public DateTime? DisDate {
			get {
				if (invdate == null) return null;
				var idate = invdate.GetValueOrDefault();
				var mon = idate.Month + (idate.Day < 25 ? 1 : 2);
				var year = idate.Year;
				if (mon > 12) {
					mon = mon - 12;
					year++;
				}
				var disdate = new DateTime(year, mon, 10);
				return disdate;
			}
		}

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public bool IsLotPrice => lotprice.Equals("Y");

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string LotPriceWords => lotprice.Equals("Y") ? "Lot Price" : "";

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string InvoiceTotalWords => lotprice.Equals("Y") ? "Lot Price" : "Total";

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string CallAheadAtWord => !string.IsNullOrEmpty(call_phone) ? " @ " : " ";

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string CallAheadWithinWord => !string.IsNullOrEmpty(hrs_before) ? " within " : "";

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string CallAheadWords => $"{call}{CallAheadAtWord}{call_phone}{CallAheadWithinWord}{hrs_before}";

		//[MyCustom(AdsIgnore = true)]
		//public string Comment1 => Comments.Any() ? $"{Comments[0].date:d} {Comments[0].user} {Comments[0].comment}" : "";

		//[MyCustom(AdsIgnore = true)]
		//public string Comment2 => Comments.Count > 1 ? $"{Comments[1].date:d} {Comments[1].user} {Comments[1].comment}" : "";

		//[MyCustom(AdsIgnore = true)]
		//public string Comment3 => Comments.Count > 2 ? $"{Comments[2].date:d} {Comments[2].user} {Comments[2].comment}" : "";

		//[MyCustom(AdsIgnore = true)]
		//public string Comment4 => Comments.Count > 3 ? $"{Comments[3].date:d} {Comments[3].user} {Comments[3].comment}" : "";

		//[MyCustom(AdsIgnore = true)]
		//public string Comment5 => Comments.Count > 4 ? $"{Comments[4].date:d} {Comments[4].user} {Comments[4].comment}" : "";

		//[MyCustom(AdsIgnore = true)]
		//public string Comment6 => Comments.Count > 5 ? $"{Comments[5].date:d} {Comments[5].user} {Comments[5].comment}" : "";

		//[MyCustom(AdsIgnore = true)]
		//public string Comment7 => Comments.Count > 6 ? $"{Comments[6].date:d} {Comments[6].user} {Comments[6].comment}" : "";

		//[MyCustom(AdsIgnore = true)]
		//public string Comment8 => Comments.Count > 7 ? $"{Comments[7].date:d} {Comments[7].user} {Comments[7].comment}" : "";

		//[MyCustom(AdsIgnore = true)]
		//public string Comment9 => Comments.Count > 8 ? $"{Comments[8].date:d} {Comments[8].user} {Comments[8].comment}" : "";

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string SalesTaxWords => !salestax.Equals(0m) ? "Sales Tax" : "";

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string FreightWords => !freight.Equals(0m) ? "Freight" : "";

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string SubtotalWords => !subtotal.Equals(0m) ? "Subtotal" : "";

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string CsO { get; set; }

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string CsOb { get; set; }

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string CsQ { get; set; }

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public string CsQb { get; set; }

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("sqlid")) sqlid = reader.ReadInt("sqlid");
			if (InFieldList("foxid")) foxid = reader.ReadInt("foxid");
			if (InFieldList("custno")) custno = reader.ReadInt("custno");
			if (InFieldList("orderno")) orderno = reader.ReadInt("orderno");
			if (InFieldList("revision")) revision = reader.ReadString("revision");
			if (InFieldList("invno")) invno = reader.ReadInt("invno");
			if (InFieldList("bofrom")) bofrom = reader.ReadInt("bofrom");
			if (InFieldList("boto")) boto = reader.ReadInt("boto");
			if (InFieldList("status")) status = reader.ReadString("status");
			if (InFieldList("ackstatus")) ackstatus = reader.ReadString("ackstatus");
			if (InFieldList("wostatus")) wostatus = reader.ReadString("wostatus");
			if (InFieldList("date")) date = reader.ReadDate("date");
			if (InFieldList("pono")) pono = reader.ReadString("pono");
			if (InFieldList("po_date")) po_date = reader.ReadDate("po_date");
			if (InFieldList("rec_date")) rec_date = reader.ReadDate("rec_date");
			if (InFieldList("rel_date")) rel_date = reader.ReadDate("rel_date");
			if (InFieldList("ack_date")) ack_date = reader.ReadDate("ack_date");
			if (InFieldList("ship_date")) ship_date = reader.ReadDate("ship_date");
			if (InFieldList("asbl_date")) asbl_date = reader.ReadDate("asbl_date");
			if (InFieldList("ashp_date")) ashp_date = reader.ReadDate("ashp_date");
			if (InFieldList("invdate")) invdate = reader.ReadDate("invdate");
			if (InFieldList("datesched")) datesched = reader.ReadDate("datesched");
			if (InFieldList("datecancel")) datecancel = reader.ReadDate("datecancel");
			if (InFieldList("holdf_date")) holdf_date = reader.ReadDate("holdf_date");
			if (InFieldList("holdb_date")) holdb_date = reader.ReadDate("holdb_date");
			if (InFieldList("sale1")) sale1 = reader.ReadInt("sale1");
			if (InFieldList("sale1per")) sale1per = reader.ReadInt("sale1per");
			if (InFieldList("sale2")) sale2 = reader.ReadInt("sale2");
			if (InFieldList("sale2per")) sale2per = reader.ReadInt("sale2per");
			if (InFieldList("sale3")) sale3 = reader.ReadInt("sale3");
			if (InFieldList("sale3per")) sale3per = reader.ReadInt("sale3per");
			if (InFieldList("route")) route = reader.ReadString("route");
			if (InFieldList("pronum")) pronum = reader.ReadString("pronum");
			if (InFieldList("mark")) mark = reader.ReadString("mark");
			if (InFieldList("prepay")) prepay = reader.ReadString("prepay");
			if (InFieldList("lotprice")) lotprice = reader.ReadString("lotprice");
			if (InFieldList("blprint")) blprint = reader.ReadString("blprint");
			if (InFieldList("call")) call = reader.ReadString("call");
			if (InFieldList("call_phone")) call_phone = reader.ReadString("call_phone");
			if (InFieldList("hrs_before")) hrs_before = reader.ReadString("hrs_before");
			if (InFieldList("sname")) sname = reader.ReadString("sname");
			if (InFieldList("saddress")) saddress = reader.ReadString("saddress");
			if (InFieldList("saddress2")) saddress2 = reader.ReadString("saddress2");
			if (InFieldList("scity")) scity = reader.ReadString("scity");
			if (InFieldList("sstate")) sstate = reader.ReadString("sstate");
			if (InFieldList("szip")) szip = reader.ReadString("szip");
			if (InFieldList("ack")) ack = reader.ReadString("ack");
			if (InFieldList("spec")) spec = reader.ReadString("spec");
			if (InFieldList("bott")) bott = reader.ReadString("bott");
			if (InFieldList("takenby")) takenby = reader.ReadString("takenby");
			if (InFieldList("freight")) freight = reader.ReadDecimal("freight");
			if (InFieldList("taxable")) taxable = reader.ReadString("taxable");
			if (InFieldList("salestax")) salestax = reader.ReadDecimal("salestax");
			if (InFieldList("subtotal")) subtotal = reader.ReadDecimal("subtotal");
			if (InFieldList("arstatus")) arstatus = reader.ReadString("arstatus");
			if (InFieldList("commission")) commission = reader.ReadDecimal("commission");
			if (InFieldList("credit")) credit = reader.ReadString("credit");
			if (InFieldList("stocking")) stocking = reader.ReadString("stocking");
			if (InFieldList("pickup")) pickup = reader.ReadString("pickup");
			if (InFieldList("ordtype")) ordtype = reader.ReadString("ordtype");
			if (InFieldList("paid_date")) paid_date = reader.ReadDate("paid_date");
			if (InFieldList("pcom_date")) pcom_date = reader.ReadDate("pcom_date");
			if (InFieldList("acctlock")) acctlock = reader.ReadBool("acctlock");
			if (InFieldList("commlock")) commlock = reader.ReadBool("commlock");
			if (InFieldList("cmorderno")) cmorderno = reader.ReadInt("cmorderno");
			if (InFieldList("glcode")) glcode = reader.ReadString("glcode");
			if (InFieldList("commadjust")) commadjust = reader.ReadDecimal("commadjust");
			if (InFieldList("fvendor")) fvendor = reader.ReadString("fvendor");
			if (InFieldList("checkmark")) checkmark = reader.ReadString("checkmark");
			if (InFieldList("checkdate")) checkdate = reader.ReadDate("checkdate");
			if (InFieldList("checkuser")) checkuser = reader.ReadString("checkuser");
			if (InFieldList("subcuts")) subcuts = reader.ReadInt("subcuts");
			if (InFieldList("currency")) currency = reader.ReadString("currency");
			if (InFieldList("exrate")) exrate = reader.ReadDecimal("exrate");
			if (InFieldList("exrate2usd")) exrate2usd = reader.ReadDecimal("exrate2usd");
			if (InFieldList("brokefee")) brokefee = reader.ReadDecimal("brokefee");
			if (InFieldList("csubtotal")) csubtotal = reader.ReadDecimal("csubtotal");
			if (InFieldList("csalestax")) csalestax = reader.ReadDecimal("csalestax");
			if (InFieldList("cost")) cost = reader.ReadDecimal("cost");
			if (InFieldList("lastrev")) lastrev = reader.ReadString("lastrev");
			if (InFieldList("credclear")) credclear = reader.ReadString("credclear");
			if (InFieldList("comper")) comper = reader.ReadInt("comper");
			if (InFieldList("vcamount")) vcamount = reader.ReadDecimal("vcamount");
			if (InFieldList("vcpaiddate")) vcpaiddate = reader.ReadDate("vcpaiddate");
			if (InFieldList("mso")) mso = reader.ReadString("mso");
			if (InFieldList("tax_st")) tax_st = reader.ReadDecimal("tax_st");
			if (InFieldList("tax_co")) tax_co = reader.ReadDecimal("tax_co");
			if (InFieldList("tax_lo")) tax_lo = reader.ReadDecimal("tax_lo");
			if (InFieldList("scounty")) scounty = reader.ReadString("scounty");
			if (InFieldList("credapp")) credapp = reader.ReadBool("credapp");
			if (InFieldList("schday")) schday = reader.ReadDate("schday");
			if (InFieldList("cc")) cc = reader.ReadString("cc");
			if (InFieldList("ouser")) ouser = reader.ReadString("ouser");
			if (InFieldList("cuser")) cuser = reader.ReadString("cuser");
			if (InFieldList("ordlst")) ordlst = reader.ReadString("ordlst");
			if (InFieldList("whse")) whse = reader.ReadString("whse");
			if (InFieldList("apcom")) apcom = reader.ReadInt("apcom");
			if (InFieldList("apvcom")) apvcom = reader.ReadInt("apvcom");
			if (InFieldList("terms")) terms = reader.ReadInt("terms");
			if (InFieldList("ordstyle")) ordstyle = reader.ReadString("ordstyle");
			if (InFieldList("oldkey")) oldkey = reader.ReadInt("oldkey");
			if (InFieldList("oldinv")) oldinv = reader.ReadInt("oldinv");
			if (InFieldList("pallet48")) pallet48 = reader.ReadInt("pallet48");
			if (InFieldList("pallet44")) pallet44 = reader.ReadInt("pallet44");
			if (InFieldList("pallet42")) pallet42 = reader.ReadInt("pallet42");
			if (InFieldList("loosepcs")) loosepcs = reader.ReadInt("loosepcs");
			if (InFieldList("crates")) crates = reader.ReadInt("crates");
			if (InFieldList("cratewgt")) cratewgt = reader.ReadInt("cratewgt");
			if (InFieldList("shq_no")) shq_no = reader.ReadString("shq_no");
			if (InFieldList("shq_no")) shq_name = reader.ReadString("shq_name");
			if (InFieldList("shq_amt")) shq_amt = reader.ReadDecimal("shq_amt");
			if (InFieldList("shtrailer")) shtrailer = reader.ReadInt("shtrailer");
			if (InFieldList("shname")) shname = reader.ReadString("shname");
			if (InFieldList("warr_yes")) warr_yes = reader.ReadString("warr_yes");
			if (InFieldList("warr_chk")) warr_chk = reader.ReadString("warr_chk");
			if (InFieldList("warr_date")) warr_date = reader.ReadDate("warr_date");
			if (InFieldList("esd_newdt")) esd_newdt = reader.ReadDate("esd_newdt");
			if (InFieldList("esd_lchg")) esd_lchg = reader.ReadDate("esd_lchg");
			if (InFieldList("esd_lchgby")) esd_lchgby = reader.ReadString("esd_lchgby");
			if (InFieldList("esd_reason")) esd_reason = reader.ReadString("esd_reason");
			if (InFieldList("dnsb4")) dnsb4 = reader.ReadDate("dnsb4");
			if (InFieldList("chgdate")) chgdate = reader.ReadDate("chgdate");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public IList<hord> GetAlertOrders(int agencyNo) {
			var qTime = DateTime.Now;
			var entityCollection = new List<hord>();
			Conn.Open();
			var cmd = Conn.CreateCommand();
			var sql = $"select * from hnotordc order by orderno";
			cmd.CommandText = sql;
			var orderno = 0;
			try {
				var reader = cmd.ExecuteReader();
				while (reader.Read()) {
					var repno = reader.ReadInt("repno");
					if (agencyNo != 0 && Math.Round(repno / 10m, 0) != agencyNo) continue;
					var neworderno = reader.ReadInt("orderno");
					if (orderno == neworderno) continue;
					orderno = neworderno;
					var partno = reader.ReadString("partno");
					var desc = reader.ReadString("desc");
					var note = reader.ReadString("note");
					var partdesc = $"{partno} {desc} {note}";
					var cmd2 = Conn.CreateCommand();
					cmd2.CommandText = $"select * from hord where orderno = {orderno}";
					var reader2 = cmd2.ExecuteReader();
					while (reader2.Read()) {
						var entity = new hord();
						entity.FillFromReader(reader2);
						entity.Alert = partdesc;
						entityCollection.Add(entity);
					}
					reader2.Close();
				}
				reader.Close();
				Conn.Close();
			}
			catch (Exception e) {
				Debug.WriteLine(e);
				if (Conn.IsConnectionAlive) Conn.Close();
				entityCollection = GetAlertOrders2(agencyNo).ToList();
			}
			QueryDebugEnd(qTime, $"GetAlertOrders - {sql}");
			return entityCollection;
		}

		public IList<hord> GetAlertOrders2(int agencyNo) {
			var qTime = DateTime.Now;
			var entityCollection = new List<hord>();
			Conn.Open();
			var cmd = Conn.CreateCommand();
			var sql = $"select * from hnotord order by orderno";
			cmd.CommandText = sql;
			var orderno = 0;
			try {
				var reader = cmd.ExecuteReader();
				while (reader.Read()) {
					var repno = reader.ReadInt("repno");
					if (agencyNo != 0 && Math.Round(repno / 10m, 0) != agencyNo) continue;
					var neworderno = reader.ReadInt("orderno");
					if (orderno == neworderno) continue;
					orderno = neworderno;
					var desc = reader.ReadString("desc");
					var cmd2 = Conn.CreateCommand();
					cmd2.CommandText = $"select * from hord where orderno = {orderno}";
					var reader2 = cmd2.ExecuteReader();
					while (reader2.Read()) {
						var entity = new hord();
						entity.FillFromReader(reader2);
						entity.Alert = desc;
						entityCollection.Add(entity);
					}
					reader2.Close();
				}
				reader.Close();
				Conn.Close();
			}
			catch (Exception e) {
				Debug.WriteLine(e);
				if (Conn.IsConnectionAlive) Conn.Close();
			}
			QueryDebugEnd(qTime, $"GetAlertOrders2 - {sql}");
			return entityCollection;
		}

		public IList<hord> GetOrdersBySchedDate(DateTime start, DateTime end) {
			var qTime = DateTime.Now;
			var sql = $"select * from hord where rel_date>='{start.ToShortDateString()}' and rel_date<='{end.ToShortDateString()}'";
			var entities = GetEntities<hord>(sql);
			QueryDebugEnd(qTime, $"GetOrdersBySchedDate - {sql}");
			return entities;
		}

		public IList<hord> GetOrdersByRelDate(DateTime start, DateTime end) {
			var qTime = DateTime.Now;
			var sql = $"select * from hord where rel_date>='{start.ToShortDateString()}' and rel_date<='{end.ToShortDateString()}'";
			var entities = GetEntities<hord>(sql);
			QueryDebugEnd(qTime, $"GetOrdersByRelDate - {sql}");
			return entities;
		}

		public IList<hord> GetOrdersByDateSearch(DateTime start, DateTime end, string search) {
			var qTime = DateTime.Now;
			var emptySearch = string.IsNullOrEmpty(search);
			var isNumeric = int.TryParse(search, out var searchNum);
			var isOrderNo = isNumeric && search?.Length == 6;
			var isInvNo = isNumeric && search?.Length == 6;
			var whereQry = "";
			if (!emptySearch) {
				if (isOrderNo || isInvNo) {
					whereQry = isOrderNo ? $"orderno={search}" : $"invno={search})";
				}
				else {
					whereQry = $"(pono like '{search}%' or mark like '%{search}%')";
				}
			}
			var datesQry = isOrderNo || isInvNo ? "" : $"([date]>='{start.ToShortDateString()}' and [date]<='{end.ToShortDateString()}')";
			var conj = !string.IsNullOrEmpty(whereQry) && !string.IsNullOrEmpty(datesQry) ? " and " : "";
			var entities = new List<hord>();
			Conn.Open();
			var cmd = Conn.CreateCommand();
			var sql = $"select * from hord where {datesQry}{conj}{whereQry}";
			cmd.CommandText = sql;
			var reader = cmd.ExecuteReader();
			while (reader.Read()) {
				var entity = new hord();
				entity.FillFromReader(reader);
				entities.Add(entity);
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetOrdersSearchByDate - {sql}");
			return entities;
		}

		public IList<hord> GetOrdersByRelDateSearch(DateTime start, DateTime end) {
			var qTime = DateTime.Now;
			var entities = new List<hord>();
			Conn.Open();
			var cmd = Conn.CreateCommand();
			var sql = $"select * from hord where rel_date>='{start.ToShortDateString()}' and rel_date<='{end.ToShortDateString()}'";
			cmd.CommandText = sql;
			var reader = cmd.ExecuteReader();
			while (reader.Read()) {
				var entity = new hord();
				entity.FillFromReader(reader);
				entities.Add(entity);
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetOrdersByRelDateSearch - {sql}");
			return entities;
		}

		public IList<hord> GetAgencyOrdersListByDate(DateTime start, int agencyNo) {
			var qTime = DateTime.Now;
			var sql = $"select * from hord where date>={start} and (sale1={agencyNo} or sale2={agencyNo})";
			var entities = GetEntities<hord>(sql);
			QueryDebugEnd(qTime, $"GetAgencyOrdersListByDate - {sql}");
			return entities;
		}

		public IList<hord> GetAgencyOrdersListByPo(string po, int agencyNo) {
			var qTime = DateTime.Now;
			var sql = $"select * from hord where pono='{po}' and (sale1={agencyNo} or sale2={agencyNo})";
			var entities = GetEntities<hord>(sql);
			QueryDebugEnd(qTime, $"GetAgencyOrdersListByPo - {sql}");
			return entities;
		}

		public hord GetOrder(int orderNo) {
			var qTime = DateTime.Now;
			var table = orderNo > 990000 ? "xord" : "hord";
			var sql = $"select * from {table} where orderno={orderNo}";
			var entity = GetEntitySql<hord>(sql);
			QueryDebugEnd(qTime, $"GetOrder - {sql}");
			return entity;
		}

		public IList<hord> GetOrdersByOrderNo(int no) {
			var qTime = DateTime.Now;
			var table = no > 990000 ? "xord" : "hord";
			var sql = $"select * from {table} where orderno={no}";
			var entities = GetEntitiesSql<hord>(sql, new List<string> { "*" });
			QueryDebugEnd(qTime, $"GetOrdersByOrderNo - {sql}");
			return entities;
		}

		public IList<hord> GetOrdersByInvNo(int no) {
			var qTime = DateTime.Now;
			var table = "hord";
			var sql = $"select * from {table} where invno={no}";
			var entities = GetEntitiesSql<hord>(sql, new List<string> { "*" });
			QueryDebugEnd(qTime, $"GetOrdersByInvNo - {sql}");
			return entities;
		}

		public hord GetOrderComplete(int orderNo) {
			return GetOrderComplete(0, orderNo);
		}

		public hord GetOrderComplete(int agencyNo, int orderNo) {
			var ord = GetOrder(orderNo);
			if (ord == null) return ord;
			var cust = GetCustomer(ord.custno);
			var pronums = GetOrderPronums(ord.orderno);
			var det = GetOrderDetails(ord.orderno);
			var comments = GetOrderComments2(ord.orderno);
			//ord.Customer = cust;
			//ord.ProNums = pronums;
			//ord.Details = det;
			//ord.Comments = comments;
			var totalCartons = 0;
			decimal totalWeight = 0;
			//foreach (var hdet in ord.Details) {
			//	hdet.hord = ord;
			//	if (hdet.itemno.StartsWith("90")) {
			//		var finv = GetFinishedInventory(hdet.itemno, hdet.pack, false);
			//		//hdet.Finished = finv;
			//		hdet.Gdesc = finv?.gdesc;
			//	}
			//	totalCartons += hdet.NoCarton;
			//	totalWeight += hdet.Weight;
			//}
			ord.Weight = Convert.ToInt32(totalWeight);
			ord.Cartons = totalCartons;
			if (agencyNo > 0) {
				var sale1 = ord.sale1.GetValueOrDefault();
				var sale1per = ord.sale1per.GetValueOrDefault();
				var sale2 = ord.sale2.GetValueOrDefault();
				var sale2per = ord.sale2per.GetValueOrDefault();
				var sale3 = ord.sale3.GetValueOrDefault();
				var sale3per = ord.sale3per.GetValueOrDefault();
				var agency = 0;
				var tRegComm = 0m;
				var regComm = ord.commission.GetValueOrDefault() - ord.vcamount.GetValueOrDefault();
				if (sale3 / 10 == agencyNo) {
					tRegComm = regComm * sale3per / 100;
					agency = sale3;
				}
				if (sale2 / 10 == agencyNo) {
					tRegComm = regComm * sale2per / 100;
					agency = sale2;
				}
				if (sale1 / 10 == agencyNo) {
					tRegComm = regComm * sale1per / 100;
					agency = sale1;
				}
				var isPrimary = false;
				if (sale1per != 0) {
					if (sale1 == agency) isPrimary = true;
				}
				else if (sale2per != 0) {
					if (sale2 == agency) isPrimary = true;
				}
				else if (sale3per != 0) {
					if (sale3 == agency) isPrimary = true;
				}
				//if (sale1 == agency && sale1per != 0) isPrimary = true;
				//else if (sale2 == agency && sale2per != 0) isPrimary = true;
				//else if (sale3 == agency && sale3per != 0) isPrimary = true;
				ord.TotalComm = isPrimary ? tRegComm + ord.vcamount.GetValueOrDefault() + ord.commadjust.GetValueOrDefault() : tRegComm;
			}
			return ord;
		}

		public hord GetAgencyOrder(int agencyNo, int orderNo) {
			var qTime = DateTime.Now;
			var sql = $"select * from hord where orderno={orderNo} and (sale1={agencyNo} or sale2={agencyNo})";
			var entity = GetEntitySql<hord>(sql);
			QueryDebugEnd(qTime, $"GetAgencyOrder - {sql}");
			return entity;
		}

		public hord GetOrder(int parentNo, int orderNo) {
			var qTime = DateTime.Now;
			var parent = CheckParentAgency(parentNo);
			var sql = $"select * from hord where orderno={orderNo}{parent}";
			var entity = GetEntitySql<hord>(sql);
			if (entity != null) {
				//entity.Customer = GetCustomer(entity.custno);
				//entity.Details = GetOrderDetails(entity.orderno);
				//entity.Agency = GetAgency(entity.sale1.GetValueOrDefault());
				//entity.ProNums = GetOrderPronums(agencyNo);
				//entity.ProNum = entity.ProNums.Any() ? entity.ProNums.First().pronum : "";
			}
			//entity.Details = GetOrderDetails(agencyNo);
			//foreach (var detail in entity.Details) {
			//	entity.Cartons += detail.NoCarton;
			//	entity.Weight += (detail.NoCarton * detail.WtCarton);
			//	entity.CubicFeet += (detail.Finished.cuft.GetValueOrDefault() * detail.ShipQty);
			//}
			//entity.FloorSpace = Math.Round(entity.CubicFeet / 66, 2);
			QueryDebugEnd(qTime, $"GetOrder - {sql}");
			return entity;
		}

		public IList<hord> GetParentAgencyOpenInHouseSearchOrdersDuring(int parentNo, DateTime start, DateTime end, string searchText) {
			var qTime = DateTime.Now;
			var entities = new List<hord>();
			if (string.IsNullOrEmpty(searchText)) {
				var openOrders = GetParentAgencyOpenOrdersDuring(parentNo, start, end);
				entities.AddRange(openOrders);
				//var inhouseOrders = GetParentAgencyInHouseOrdersDuring(parentNo, start, end);
				//entities.AddRange(inhouseOrders);
			}
			else {
				var searchOrders = GetParentAgencySearchOrdersDuring(parentNo, start, end, searchText);
				entities.AddRange(searchOrders);
			}
			QueryDebugEnd(qTime, $"GetParentAgencyOpenInHouseSearchOrdersDuring");
			return entities;
		}

		public IList<hord> GetParentAgencyOpenOrdersDuring(int parentNo, DateTime start, DateTime end) {
			var qTime = DateTime.Now;
			var parentQry = CheckParentAgency(parentNo);
			var entities = new List<hord>();
			Conn.Open();
			var cmd = Conn.CreateCommand();
			var sql = $"select * from hord where empty(invdate){parentQry}";
			cmd.CommandText = sql;
			var reader = cmd.ExecuteReader();
			while (reader.Read()) {
				var ordtype = reader.ReadString("ordtype");
				var status = reader.ReadString("status");
				if ("9C".Contains(status)) continue;
				if (!"SCTB".Contains(ordtype)) continue;
				var entity = new hord();
				entity.FillFromReader(reader);
				entities.Add(entity);
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetParentAgencyOpenOrdersDuring - {sql}");
			return entities;
		}

		public IList<hord> GetParentAgencyOpenOrdersDuring2(int parentNo, DateTime start, DateTime end) {
			var qTime = DateTime.Now;
			var parentQry = CheckParentAgency(parentNo);
			var entities = new List<hord>();
			Conn.Open();
			var cmd = Conn.CreateCommand();
			var sql = $"select * from hord where empty(invdate){parentQry}";
			cmd.CommandText = sql;
			var reader = cmd.ExecuteReader();
			while (reader.Read()) {
				var ordtype = reader.ReadString("ordtype");
				var status = reader.ReadString("status");
				if ("9C".Contains(status)) continue;
				if (!"SCTB".Contains(ordtype)) continue;
				//var custno = reader.ReadInt("custno");
				//var cust = GetCustomer(custno);
				//if (cust != null) entity.sname = cust.name;
				var entity = new hord();
				entity.FillFromReader(reader);
				entities.Add(entity);
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetParentAgencyOpenOrdersDuring - {sql}");
			return entities;
		}

		public IList<hord> GetParentAgencyInHouseOrdersDuring(int parentNo, DateTime start, DateTime end) {
			var qTime = DateTime.Now;
			var parentQry = CheckParentAgency(parentNo);
			var datesQry = $"and (invdate>='{start.ToShortDateString()}' and invdate<='{end.ToShortDateString()}')";
			var entities = new List<hord>();
			Conn.Open();
			var cmd = Conn.CreateCommand();
			var sql = $"select * from hord where status <> 'C' {datesQry}{parentQry}";
			cmd.CommandText = sql;
			var reader = cmd.ExecuteReader();
			while (reader.Read()) {
				var ordtype = reader.ReadString(reader.GetOrdinal("ordtype"));
				var status = reader.ReadString("status");
				if ("9C".Contains(status)) continue;
				if (!"SCTB".Contains(ordtype)) continue;
				var entity = new hord();
				entity.FillFromReader(reader);
				entities.Add(entity);
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetParentAgencyInHouseOrdersDuring - {sql}");
			return entities;
		}

		public IList<hord> GetParentAgencySearchOrdersDuring(int parentNo, DateTime start, DateTime end, string searchText) {
			var qTime = DateTime.Now;
			var search = searchText.ToUpper();
			var emptySearch = string.IsNullOrEmpty(search);
			int searchNum;
			var isNumeric = int.TryParse(searchText, out searchNum);
			//var statusQry = "(status <> 'C')";
			var datesQry = "";
			var whereQry = "";
			if (isNumeric && !string.IsNullOrEmpty(searchText) && end == DateTime.Today) { // && start == DateTime.Today.AddDays(-30)
				//end = DateTime.Today;
				//start = DateTime.Today.AddDays(-183);
			}
			datesQry = $" and ([rel_date]>='{start.ToShortDateString()}' and [rel_date]<='{end.ToShortDateString()}')";
			if (isNumeric && (search.Length == 6 || search.Length == 7)) {
				//	whereQry = 
				//		//parentNo == 0 ?
				//		//$"(orderno={search})" :
				//		$"((pono = '{search}' and [rel_date]>='{start.ToShortDateString()}' and [rel_date]<='{end.ToShortDateString()}') or orderno={search})";
				//	//whereQry = $"((pono like '{search}%' and [rel_date]>='{start.ToShortDateString()}' and [rel_date]<='{end.ToShortDateString()}') or orderno={search})";
				//	datesQry = "";
				//	//whereQry = $"(orderno={search})";
				whereQry = $"(pono like '{search}%' or mark like '%{search}%' or orderno={search})";
			}
			else if (isNumeric && search.Length == 10 && (search.StartsWith("19") || search.StartsWith("20"))) {
				//	//whereQry = $"(pono like '{search}%' or mark like '%{search}%' or invno={search})";
				//	whereQry = $"(invno={search})";
				//	datesQry = "";
				whereQry = $"(pono like '{search}%' or mark like '%{search}%' or invno={search})";
			}
			else {
				whereQry = $"(pono like '{search}%' or mark like '%{search}%')";
			}
			var parentQry = CheckParentAgency(parentNo);
			//if (isNumeric && (search.Length == 6 || search.Length == 10)) {
			//	datesQry = "";
			//}
			var entities = new List<hord>();
			Conn.Open();
			var cmd = Conn.CreateCommand();
			var sql = $"select * from hord where {whereQry}{datesQry}{parentQry}";
			cmd.CommandText = sql;
			var reader = cmd.ExecuteReader();
			while (reader.Read()) {
				var ordtype = reader.ReadString(reader.GetOrdinal("ordtype"));
				var status = reader.ReadString("status");
				if (status == "C") continue;
				if (!isNumeric && !"SCTB".Contains(ordtype)) continue;
				//if (!isNumeric && "9".Contains(status)) continue;
				var entity = new hord();
				entity.FillFromReader(reader);
				entities.Add(entity);
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetParentAgencyOpenInHouseSearchOrdersDuring - {sql}");
			return entities;
		}

		public IList<hord> GetParentAgencyOpenInHouseSearchOrdersDuring2(int parentNo, DateTime start, DateTime end, string searchText) {
			var qTime = DateTime.Now;
			var search = searchText.ToUpper();
			var emptySearch = string.IsNullOrEmpty(search);
			int searchNum;
			var isNumeric = int.TryParse(searchText, out searchNum);
			var status = isNumeric ?
				"(status <> 'C')" :
				"(status <> 'C' and status <> '9' and (ordtype='S' or ordtype='C' or ordtype='T' or ordtype='B'))";
			var where = emptySearch ? "" : isNumeric ?
				$" and (pono like '{search}%' or mark like '{search}%' or orderno={search} or invno={search})" :
				$" and (pono like '{search}%' or mark like '%{search}%')";
			var parent = CheckParentAgency(parentNo);
			if (!isNumeric && !string.IsNullOrEmpty(searchText) && end == DateTime.Today && start == DateTime.Today.AddDays(-30)) {
				end = DateTime.Today;
				start = DateTime.Today.AddDays(-365);
				status = "(status <> 'C')";
			}
			var dates = $"and (empty(invdate) or (invdate>='{start.ToShortDateString()}' and invdate<='{end.ToShortDateString()}'))";
			var entities = new List<hord>();
			Conn.Open();
			var cmd = Conn.CreateCommand();
			var sql = $"select * from hord where {status}{where}{dates}{parent}";
			cmd.CommandText = sql;
			var reader = cmd.ExecuteReader();
			while (reader.Read()) {
				var ordtype = reader.ReadString(reader.GetOrdinal("ordtype"));
				if (!"SCTB".Contains(ordtype)) continue;
				var entity = new hord();
				entity.FillFromReader(reader);
				entities.Add(entity);
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetParentAgencyOpenInHouseSearchOrdersDuring - {sql}");
			return entities;
		}

		public IList<hord> GetParentAgencyInvoiceNumbersDuring(int parentNo, DateTime start, DateTime end) {
			var qTime = DateTime.Now;
			var parent = CheckParentAgency(parentNo);
			var dates = $"invdate>='{start.ToShortDateString()}' and invdate<='{end.ToShortDateString()}'";
			var entities = new List<hord>();
			Conn.Open();
			var cmd = Conn.CreateCommand();
			var sql = $"select * from hord where {dates}{parent}";
			cmd.CommandText = sql;
			var reader = cmd.ExecuteReader();
			while (reader.Read()) {
				var entity = new hord { invno = reader.ReadInt(reader.GetOrdinal("invno")) };
				entities.Add(entity);
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetParentAgencyInvoiceNumbersDuring - {sql}");
			return entities;
		}

		public IList<hord> GetParentAgencyInvoiceNumbersForOrder(int parentNo, string custNo, string pono) {
			var qTime = DateTime.Now;
			var parent = CheckParentAgency(parentNo);
			Conn.Open();
			var entities = new List<hord>();
			var cmd = Conn.CreateCommand();
			var sql = $"select * from hord where pono='{pono}' and custno={custNo}{parent}";
			cmd.CommandText = sql;
			var reader = cmd.ExecuteReader();
			while (reader.Read()) {
				var entity = new hord { invno = reader.ReadInt(reader.GetOrdinal("invno")) };
				entities.Add(entity);
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetParentAgencyInvoiceNumbersForOrder - {sql}");
			return entities;
		}

		public hord GetInvoice(int agencyNo, int invNo) {
			var qTime = DateTime.Now;
			var agencyNo2 = agencyNo;
			if (agencyNo == 915) agencyNo2 = 916;
			if (agencyNo == 916) agencyNo2 = 915;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			//cmd.CommandText = $"select * from hord where invno={invNo} and (sale1={agencyNo} or sale2={agencyNo} or sale1={agencyNo2} or sale2={agencyNo2})";
			//var sql = $"select * from hord where invno={invNo} and (sale1={agencyNo} or sale1={agencyNo2})";
			var sql = $"select * from hord where invno={invNo}";
			cmd.CommandText = sql;
			var reader = cmd.ExecuteReader();
			hord order = null;
			while (reader.Read()) {
				var sale1 = reader.ReadInt(reader.GetOrdinal("sale1"));
				if (sale1 / 10 == agencyNo || sale1 / 10 == agencyNo2) {
					order = new hord();
					order.FillFromReader(reader);
				}
			}
			reader.Close();
			Conn.Close();
			if (order != null) {
				//order.Customer = GetCustomer(order.custno);
				//order.Details = GetOrderDetails(order.orderno);
				
				//order.Agency = GetAgency(order.sale1.GetValueOrDefault());
				//order.ProNums = GetOrderPronums(agencyNo);
				//order.ProNum = order.ProNums.Any() ? order.ProNums.First().pronum : "";
			}
			//foreach (var detail in order.Details) {
			//	order.Cartons += detail.NoCarton;
			//	order.Weight += (detail.NoCarton * detail.WtCarton);
			//	order.CubicFeet += (detail.Finished.cuft.GetValueOrDefault() * detail.ShipQty);
			//}
			//order.FloorSpace = Math.Round(order.CubicFeet / 66, 2);
			QueryDebugEnd(qTime, $"GetInvoice - {sql}");
			return order;
		}

		public IList<hord> GetAgencyOpenOrders(int no) {
			var qTime = DateTime.Now;
			var sql = $"select * from hord where sale1={no} and status<='7'";
			var entities = GetEntities<hord>(sql);
			QueryDebugEnd(qTime, $"GetAgencyOpenOrders - {sql}");
			return entities;
		}

		public IList<hord> GetAgencyHoldOrders(int no) {
			var qTime = DateTime.Now;
			var sql = $"select * from hord where sale1={no} and status=' '";
			var entities = GetEntities<hord>(sql);
			QueryDebugEnd(qTime, $"GetAgencyHoldOrders - {sql}");
			return entities;
		}

		public void GetAgencyOpenHoldOrders(int no, ref decimal hold, ref decimal open) {
			var qTime = DateTime.Now;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hord";
			var reader = cmd.ExecuteExtendedReader();
			reader.ActiveIndex = "sale1stat";
			var found = reader.Seek(new object[] { no, " " }, AdsExtendedReader.SeekType.HardSeek);
			if (!found) {
				found = reader.Seek(new object[] { no, " " }, AdsExtendedReader.SeekType.SeekGT);
			}
			if (found) {
				var valid = true;
				while (valid) {
					var status = reader.ReadString(reader.GetOrdinal("status"));
					var sale1 = reader.ReadInt(reader.GetOrdinal("sale1"));
					var subtotal = reader.ReadDecimal(reader.GetOrdinal("subtotal"));
					if (sale1 != no) break;
					if (string.IsNullOrEmpty(status)) hold = hold + subtotal;
					else if ("1234567".Contains(status)) open = open + subtotal;
					else break;
					valid = reader.Read();
				}
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetAgencyOpenHoldOrders");
		}

		public int InsertOrder(hord ord) {
			var orderno = 0;

			return orderno;
		}

	}

}

