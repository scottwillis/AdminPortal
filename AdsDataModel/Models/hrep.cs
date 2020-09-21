using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Windows;
using Advantage.Data.Provider;
using Common;

namespace AdsDataModel {

	public class hrep : FoxProEntity {

		public hrep() {
			Key = "salesno";
		}

		private int _agencyid;
		private int _salesno;
		private int _newsalesno;
		private string _repstatus = "A";
		private string _custserv;
		private string _custservi;
		private string _csq;
		private string _csqb;
		private string _name;
		private string _address;
		private string _address2;
		private string _city;
		private string _state;
		private string _zip;
		private string _contact;
		private string _phone;
		private string _phone2;
		private string _phone3;
		private decimal? _csales;
		private decimal? _ccomm;
		private decimal? _ytdsales;
		private decimal? _ytdcomm;
		private decimal? _pysales;
		private decimal? _pycomm;
		private DateTime? _hiredate;
		private DateTime? _termdate;
		private string _warehouse;
		private string _region;
		private string _regionrep;
		private decimal? _s1jan;
		private decimal? _s1feb;
		private decimal? _s1mar;
		private decimal? _s1apr;
		private decimal? _s1may;
		private decimal? _s1jun;
		private decimal? _s1jul;
		private decimal? _s1aug;
		private decimal? _s1sep;
		private decimal? _s1oct;
		private decimal? _s1nov;
		private decimal? _s1dec;
		private decimal? _s2jan;
		private decimal? _s2feb;
		private decimal? _s2mar;
		private decimal? _s2apr;
		private decimal? _s2may;
		private decimal? _s2jun;
		private decimal? _s2jul;
		private decimal? _s2aug;
		private decimal? _s2sep;
		private decimal? _s2oct;
		private decimal? _s2nov;
		private decimal? _s2dec;
		private decimal? _c1jan;
		private decimal? _c1feb;
		private decimal? _c1mar;
		private decimal? _c1apr;
		private decimal? _c1may;
		private decimal? _c1jun;
		private decimal? _c1jul;
		private decimal? _c1aug;
		private decimal? _c1sep;
		private decimal? _c1oct;
		private decimal? _c1nov;
		private decimal? _c1dec;
		private decimal? _c2jan;
		private decimal? _c2feb;
		private decimal? _c2mar;
		private decimal? _c2apr;
		private decimal? _c2may;
		private decimal? _c2jun;
		private decimal? _c2jul;
		private decimal? _c2aug;
		private decimal? _c2sep;
		private decimal? _c2oct;
		private decimal? _c2nov;
		private decimal? _c2dec;
		private bool? _hofaxinv = false;
		private int? _aipl1;
		private int? _aipl2;
		private int? _aipl3;
		private int? _aipl4;
		private decimal? _aipl1per;
		private decimal? _aipl2per;
		private decimal? _aipl3per;
		private decimal? _aipl4per;
		private string _otherman;
		private DateTime? _entrydate;
		private DateTime? _lastupdate;
		private int _parent;
		private int? _qs;
		private int? _qsytd;
		private int? _payoutL1;
		private int? _payoutL2;
		private int? _payoutL3;
		private int? _payoutL4;
		private int? _qtr1Sales;
		private int? _qtr2Sales;
		private int? _qtr3Sales;
		private int? _qtr4Sales;
		private string _software;

		private hregion _hregion;
		private hcstsrv _cs;
		private hcstsrv _csAlt;
		private hcstsrv _qu;
		private hcstsrv _quAlt;
		private IList<hrepemp> _contacts;
		private IList<hreplin> _lines;
		private IList<hcust> _customers;

		[Display(Name = "AgencyId")]
		[MyCustom(Width = "*")]
		public int agencyid { get => _agencyid; set => SetProperty(ref _agencyid, value); }

		[Display(Name = "No")]
		[DisplayFormat(DataFormatString = MagicString.IntFormatString)]
		[MyCustom(Width = "*", FormatString = MagicString.IntNoZeroFormat, IsVisible = true, Aggregate = AggregateType.Count)]
		public int salesno { get => _salesno; set => SetProperty(ref _salesno, value); }

		[Display(Name = "Parent")]
		[DisplayFormat(DataFormatString = MagicString.IntFormatString)]
		[MyCustom(Width = "*", FormatString = MagicString.IntNoZeroFormat, IsVisible = true)]
		public int parent { get => _parent; set => SetProperty(ref _parent, value); }

		[Display(Name = "New No")]
		[DisplayFormat(DataFormatString = MagicString.IntFormatString)]
		[MyCustom(Width = "*", FormatString = MagicString.IntNoZeroFormat)]
		public int newsalesno { get => _newsalesno; set => SetProperty(ref _newsalesno, value); }

		public string repstatus { get => _repstatus; set => SetProperty(ref _repstatus, value); }

		[Display(Name = "Name")]
		[MyCustom(Width = "*", IsUpper = true, IsVisible = true)]
		public string name { get => _name; set => SetProperty(ref _name, value); }

		[Display(Name = "Address")]
		[MyCustom(Width = "*", IsUpper = true)]
		public string address { get => _address; set => SetProperty(ref _address, value); }

		[Display(Name = "Address2")]
		[MyCustom(Width = "*", IsUpper = true)]
		public string address2 { get => _address2; set => SetProperty(ref _address2, value); }

		[Display(Name = "City")]
		[MyCustom(Width = "*", IsUpper = true, IsVisible = true)]
		public string city { get => _city; set => SetProperty(ref _city, value); }

		[Display(Name = "ST")]
		[MyCustom(Width = "*", IsUpper = true, IsVisible = true)]
		public string state { get => _state; set => SetProperty(ref _state, value); }

		[Display(Name = "Zip")]
		[MyCustom(Width = "*", IsUpper = true)]
		public string zip { get => _zip; set => SetProperty(ref _zip, value); }

		[Display(Name = "Web")]
		[MyCustom(Width = "*", IsUpper = true)]
		public string contact { get => _contact; set => SetProperty(ref _contact, value); }

		[Display(Name = "Phone")]
		[MyCustom(Mask = MagicString.PhoneMask, Width = "90", IsVisible = true)]
		public string phone { get => _phone; set => SetProperty(ref _phone, value); }

		[Display(Name = "Fax")]
		[MyCustom(Mask = MagicString.PhoneMask, Width = "90")]
		public string phone2 { get => _phone2; set => SetProperty(ref _phone2, value); }

		[Display(Name = "Home Office Fax")]
		[MyCustom(Mask = MagicString.PhoneMask, Width = "90")]
		public string phone3 { get => _phone3; set => SetProperty(ref _phone3, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? csales { get => _csales; set => SetProperty(ref _csales, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? ccomm { get => _ccomm; set => SetProperty(ref _ccomm, value); }

		[Display(Name = "CS")]
		[MyCustom(Width = "*", LookupKey = "CsUser", AdsLookupProperty = "Cs.name", SelectedValuePath = "custserv", DataFormDisplayMemberPath = "name", GridViewDisplayMemberPath = "name", IsUserMaintainable = false, IsVisible = true)]
		public string custserv { get => _custserv; set => SetProperty(ref _custserv, value); }

		[Display(Name = "CS alt")]
		[MyCustom(Width = "*", LookupKey = "CsAltUser", AdsLookupProperty = "CsAlt.name", SelectedValuePath = "custserv", DataFormDisplayMemberPath = "name", GridViewDisplayMemberPath = "name", IsUserMaintainable = false, IsVisible = true)]
		public string custservi { get => _custservi; set => SetProperty(ref _custservi, value); }

		[Display(Name = "QU")]
		[MyCustom(Width = "*", LookupKey = "QuUser", AdsLookupProperty = "Qu.name", SelectedValuePath = "custserv", DataFormDisplayMemberPath = "name", GridViewDisplayMemberPath = "name", IsUserMaintainable = false, IsVisible = true)]
		public string csq { get => _csq; set => SetProperty(ref _csq, value); }

		[Display(Name = "QU alt")]
		[MyCustom(Width = "*", LookupKey = "QuAltUser", AdsLookupProperty = "QuAlt.name", SelectedValuePath = "custserv", DataFormDisplayMemberPath = "name", GridViewDisplayMemberPath = "name", IsUserMaintainable = false, IsVisible = true)]
		public string csqb { get => _csqb; set => SetProperty(ref _csqb, value); }

		[Display(Name = "Curr YTD Sales")]
		[DisplayFormat(DataFormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero)]
		[MyCustom(Mask = "", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, Alignment = TextAlignment.Right, Aggregate = AggregateType.SumCurrency, AdsReadOnly = true)]
		public decimal? ytdsales { get => _ytdsales; set => SetProperty(ref _ytdsales, value); }

		[Display(Name = "Curr YTD Comm")]
		[DisplayFormat(DataFormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero)]
		[MyCustom(Mask = "", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, Alignment = TextAlignment.Right, Aggregate = AggregateType.SumCurrency, AdsReadOnly = true)]
		public decimal? ytdcomm { get => _ytdcomm; set => SetProperty(ref _ytdcomm, value); }

		[Display(Name = "Prev Year Sales")]
		[DisplayFormat(DataFormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero)]
		[MyCustom(Mask = "", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, Alignment = TextAlignment.Right, Aggregate = AggregateType.SumCurrency, AdsReadOnly = true)]
		public decimal? pysales { get => _pysales; set => SetProperty(ref _pysales, value); }

		[Display(Name = "Prev Year Comm")]
		[DisplayFormat(DataFormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero)]
		[MyCustom(Mask = "", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, Alignment = TextAlignment.Right, Aggregate = AggregateType.SumCurrency, AdsReadOnly = true)]
		public decimal? pycomm { get => _pycomm; set => SetProperty(ref _pycomm, value); }

		[Display(Name = "HireDate")]
		[DataType(DataType.Date), DisplayFormat(DataFormatString = MagicString.SmallDateFormat, ApplyFormatInEditMode = true)]
		[MyCustom(IsVisible = true, Width = MagicString.DateColumnWidth)]
		public DateTime? hiredate { get => _hiredate; set => SetProperty(ref _hiredate, value); }

		[Display(Name = "TermDate")]
		[DataType(DataType.Date), DisplayFormat(DataFormatString = MagicString.SmallDateFormat, ApplyFormatInEditMode = true)]
		[MyCustom(IsVisible = true, Width = MagicString.DateColumnWidth)]
		public DateTime? termdate { get => _termdate; set => SetProperty(ref _termdate, value); }

		[Display(Name = "Warehouse")]
		public string warehouse { get => _warehouse; set => SetProperty(ref _warehouse, value); }

		[Display(Name = "Region")]
		[MyCustom(LookupKey = "AgencyRegion", AdsLookupProperty = "RegionName", SelectedValuePath = "code", DataFormDisplayMemberPath = "name", GridViewDisplayMemberPath = "name", IsUserMaintainable = false, IsVisible = true)]
		public string region { get => _region; set => SetProperty(ref _region, value); }

		//[Display(Name = "RegionRep")]
		//[MyCustom(LookupKey = "AgencyRegion", AdsLookupProperty = "Regional", SelectedValuePath = "login", DataFormDisplayMemberPath = "regional", GridViewDisplayMemberPath = "regional", IsUserMaintainable = false, IsVisible = true)]
		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public string regionrep { get => _regionrep; set => SetProperty(ref _regionrep, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? s1jan { get => _s1jan; set => SetProperty(ref _s1jan, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? s1feb { get => _s1feb; set => SetProperty(ref _s1feb, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? s1mar { get => _s1mar; set => SetProperty(ref _s1mar, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? s1apr { get => _s1apr; set => SetProperty(ref _s1apr, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? s1may { get => _s1may; set => SetProperty(ref _s1may, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? s1jun { get => _s1jun; set => SetProperty(ref _s1jun, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? s1jul { get => _s1jul; set => SetProperty(ref _s1jul, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? s1aug { get => _s1aug; set => SetProperty(ref _s1aug, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? s1sep { get => _s1sep; set => SetProperty(ref _s1sep, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? s1oct { get => _s1oct; set => SetProperty(ref _s1oct, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? s1nov { get => _s1nov; set => SetProperty(ref _s1nov, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? s1dec { get => _s1dec; set => SetProperty(ref _s1dec, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? s2jan { get => _s2jan; set => SetProperty(ref _s2jan, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? s2feb { get => _s2feb; set => SetProperty(ref _s2feb, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? s2mar { get => _s2mar; set => SetProperty(ref _s2mar, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? s2apr { get => _s2apr; set => SetProperty(ref _s2apr, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? s2may { get => _s2may; set => SetProperty(ref _s2may, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? s2jun { get => _s2jun; set => SetProperty(ref _s2jun, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? s2jul { get => _s2jul; set => SetProperty(ref _s2jul, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? s2aug { get => _s2aug; set => SetProperty(ref _s2aug, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? s2sep { get => _s2sep; set => SetProperty(ref _s2sep, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? s2oct { get => _s2oct; set => SetProperty(ref _s2oct, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? s2nov { get => _s2nov; set => SetProperty(ref _s2nov, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? s2dec { get => _s2dec; set => SetProperty(ref _s2dec, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? c1jan { get => _c1jan; set => SetProperty(ref _c1jan, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? c1feb { get => _c1feb; set => SetProperty(ref _c1feb, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? c1mar { get => _c1mar; set => SetProperty(ref _c1mar, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? c1apr { get => _c1apr; set => SetProperty(ref _c1apr, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? c1may { get => _c1may; set => SetProperty(ref _c1may, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? c1jun { get => _c1jun; set => SetProperty(ref _c1jun, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? c1jul { get => _c1jul; set => SetProperty(ref _c1jul, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? c1aug { get => _c1aug; set => SetProperty(ref _c1aug, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? c1sep { get => _c1sep; set => SetProperty(ref _c1sep, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? c1oct { get => _c1oct; set => SetProperty(ref _c1oct, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? c1nov { get => _c1nov; set => SetProperty(ref _c1nov, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? c1dec { get => _c1dec; set => SetProperty(ref _c1dec, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? c2jan { get => _c2jan; set => SetProperty(ref _c2jan, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? c2feb { get => _c2feb; set => SetProperty(ref _c2feb, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? c2mar { get => _c2mar; set => SetProperty(ref _c2mar, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? c2apr { get => _c2apr; set => SetProperty(ref _c2apr, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? c2may { get => _c2may; set => SetProperty(ref _c2may, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? c2jun { get => _c2jun; set => SetProperty(ref _c2jun, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? c2jul { get => _c2jul; set => SetProperty(ref _c2jul, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? c2aug { get => _c2aug; set => SetProperty(ref _c2aug, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? c2sep { get => _c2sep; set => SetProperty(ref _c2sep, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? c2oct { get => _c2oct; set => SetProperty(ref _c2oct, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? c2nov { get => _c2nov; set => SetProperty(ref _c2nov, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsReadOnly = true)]
		public decimal? c2dec { get => _c2dec; set => SetProperty(ref _c2dec, value); }

		[Display(Name = "Fax to Home Office?")]
		public bool? hofaxinv { get => _hofaxinv; set => SetProperty(ref _hofaxinv, value); }

		[Display(Name = "AIP L1")]
		[DisplayFormat(DataFormatString = MagicString.CurrencyZeroFormatString)]
		[MyCustom(Width = "60", Mask = "#########", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, MinValue = "0", MaxValue = "999999999", Type = MaskType.Currency, Alignment = TextAlignment.Right)]
		public int? aipl1 { get => _aipl1; set => SetProperty(ref _aipl1, value); }

		[Display(Name = "AIP L2")]
		[DisplayFormat(DataFormatString = MagicString.CurrencyZeroFormatString)]
		[MyCustom(Width = "60", Mask = "#########", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, MinValue = "0", MaxValue = "999999999", Type = MaskType.Currency, Alignment = TextAlignment.Right)]
		public int? aipl2 { get => _aipl2; set => SetProperty(ref _aipl2, value); }

		[Display(Name = "AIP L3")]
		[DisplayFormat(DataFormatString = MagicString.CurrencyZeroFormatString)]
		[MyCustom(Width = "60", Mask = "#########", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, MinValue = "0", MaxValue = "999999999", Type = MaskType.Currency, Alignment = TextAlignment.Right)]
		public int? aipl3 { get => _aipl3; set => SetProperty(ref _aipl3, value); }

		[Display(Name = "AIP L4")]
		[DisplayFormat(DataFormatString = MagicString.CurrencyZeroFormatString)]
		[MyCustom(Width = "60", Mask = "#########", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, MinValue = "0", MaxValue = "999999999", Type = MaskType.Currency, Alignment = TextAlignment.Right)]
		public int? aipl4 { get => _aipl4; set => SetProperty(ref _aipl4, value); }

		[Display(Name = "AIP L1 Per")]
		[DisplayFormat(DataFormatString = MagicString.Percent1FormatString)]
		[MyCustom(Width = "60", FormatString = MagicString.Percentage1Format, Mask = "#.#", MinValue = "0", MaxValue = "9.9", Type = MaskType.Numeric, Alignment = TextAlignment.Right)]
		public decimal? aipl1per { get => _aipl1per; set => SetProperty(ref _aipl1per, value); }

		[Display(Name = "AIP L2 Per")]
		[DisplayFormat(DataFormatString = MagicString.Percent1FormatString)]
		[MyCustom(Width = "60", FormatString = MagicString.Percentage1Format, Mask = "#.#", MinValue = "0", MaxValue = "9.9", Type = MaskType.Numeric, Alignment = TextAlignment.Right)]
		public decimal? aipl2per { get => _aipl2per; set => SetProperty(ref _aipl2per, value); }

		[Display(Name = "AIP L3 Per")]
		[DisplayFormat(DataFormatString = MagicString.Percent1FormatString)]
		[MyCustom(Width = "60", FormatString = MagicString.Percentage1Format, Mask = "#.#", MinValue = "0", MaxValue = "9.9", Type = MaskType.Numeric, Alignment = TextAlignment.Right)]
		public decimal? aipl3per { get => _aipl3per; set => SetProperty(ref _aipl3per, value); }

		[Display(Name = "AIP L4 Per")]
		[DisplayFormat(DataFormatString = MagicString.Percent1FormatString)]
		[MyCustom(Width = "60", FormatString = MagicString.Percentage1Format, Mask = "#.#", MinValue = "0", MaxValue = "9.9", Type = MaskType.Numeric, Alignment = TextAlignment.Right)]
		public decimal? aipl4per { get => _aipl4per; set => SetProperty(ref _aipl4per, value); }

		[Display(Name = "QS")]
		[DisplayFormat(DataFormatString = MagicString.CurrencyZeroFormatString)]
		[MyCustom(Width = "60", Mask = "#########", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, MinValue = "0", MaxValue = "999999999", Type = MaskType.Currency, Alignment = TextAlignment.Right)]
		public int? qs { get => _qs; set => SetProperty(ref _qs, value); }

		[Display(Name = "QSYtd")]
		[DisplayFormat(DataFormatString = MagicString.CurrencyZeroFormatString)]
		[MyCustom(Width = "60", Mask = "#########", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, MinValue = "0", MaxValue = "999999999", Type = MaskType.Currency, Alignment = TextAlignment.Right)]
		public int? qsytd { get => _qsytd; set => SetProperty(ref _qsytd, value); }

		[Display(Name = "Payout L1")]
		[DisplayFormat(DataFormatString = MagicString.CurrencyZeroFormatString)]
		[MyCustom(Width = "60", Mask = "#########", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, MinValue = "0", MaxValue = "999999999", Type = MaskType.Currency, Alignment = TextAlignment.Right)]
		public int? payoutL1 { get => _payoutL1; set => SetProperty(ref _payoutL1, value); }

		[Display(Name = "Payout L2")]
		[DisplayFormat(DataFormatString = MagicString.CurrencyZeroFormatString)]
		[MyCustom(Width = "60", Mask = "#########", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, MinValue = "0", MaxValue = "999999999", Type = MaskType.Currency, Alignment = TextAlignment.Right)]
		public int? payoutL2 { get => _payoutL2; set => SetProperty(ref _payoutL2, value); }

		[Display(Name = "Payout L3")]
		[DisplayFormat(DataFormatString = MagicString.CurrencyZeroFormatString)]
		[MyCustom(Width = "60", Mask = "#########", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, MinValue = "0", MaxValue = "999999999", Type = MaskType.Currency, Alignment = TextAlignment.Right)]
		public int? payoutL3 { get => _payoutL3; set => SetProperty(ref _payoutL3, value); }

		[Display(Name = "Payout L4")]
		[DisplayFormat(DataFormatString = MagicString.CurrencyZeroFormatString)]
		[MyCustom(Width = "60", Mask = "#########", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, MinValue = "0", MaxValue = "999999999", Type = MaskType.Currency, Alignment = TextAlignment.Right)]
		public int? payoutL4 { get => _payoutL4; set => SetProperty(ref _payoutL4, value); }

		[Display(Name = "Q1Sales")]
		[DisplayFormat(DataFormatString = MagicString.CurrencyZeroFormatString)]
		[MyCustom(Width = "60", Mask = "#########", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, MinValue = "0", MaxValue = "999999999", Type = MaskType.Currency, Alignment = TextAlignment.Right)]
		public int? qtr1Sales { get => _qtr1Sales; set => SetProperty(ref _qtr1Sales, value); }

		[Display(Name = "Q2Sales")]
		[DisplayFormat(DataFormatString = MagicString.CurrencyZeroFormatString)]
		[MyCustom(Width = "60", Mask = "#########", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, MinValue = "0", MaxValue = "999999999", Type = MaskType.Currency, Alignment = TextAlignment.Right)]
		public int? qtr2Sales { get => _qtr2Sales; set => SetProperty(ref _qtr2Sales, value); }

		[Display(Name = "Q3Sales")]
		[DisplayFormat(DataFormatString = MagicString.CurrencyZeroFormatString)]
		[MyCustom(Width = "60", Mask = "#########", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, MinValue = "0", MaxValue = "999999999", Type = MaskType.Currency, Alignment = TextAlignment.Right)]
		public int? qtr3Sales { get => _qtr3Sales; set => SetProperty(ref _qtr3Sales, value); }

		[Display(Name = "Q4Sales")]
		[DisplayFormat(DataFormatString = MagicString.CurrencyZeroFormatString)]
		[MyCustom(Width = "60", Mask = "#########", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, MinValue = "0", MaxValue = "999999999", Type = MaskType.Currency, Alignment = TextAlignment.Right)]
		public int? qtr4Sales { get => _qtr4Sales; set => SetProperty(ref _qtr4Sales, value); }

		[Display(Name = "Payout Total")]
		[DisplayFormat(DataFormatString = MagicString.CurrencyZeroFormatString)]
		[MyCustom(Width = "60", Mask = "#########", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, MinValue = "0", MaxValue = "999999999", Type = MaskType.Currency, Alignment = TextAlignment.Right, IsReadOnly = true, AdsIgnore = true)]
		public int? payoutTotal => _payoutL1 + _payoutL2 + _payoutL3 + _payoutL4;

		[Display(Name = "Min Payout L1")]
		[DisplayFormat(DataFormatString = MagicString.CurrencyZeroFormatString)]
		[MyCustom(Width = "60", Mask = "#########", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, MinValue = "0", MaxValue = "999999999", Type = MaskType.Currency, Alignment = TextAlignment.Right, IsReadOnly = true, AdsIgnore = true)]
		public decimal? MinPayoutL1 => aipl1.GetValueOrDefault() * aipl1per.GetValueOrDefault() / 100;

		[Display(Name = "Min Payout L2")]
		[DisplayFormat(DataFormatString = MagicString.CurrencyZeroFormatString)]
		[MyCustom(Width = "60", Mask = "#########", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, MinValue = "0", MaxValue = "999999999", Type = MaskType.Currency, Alignment = TextAlignment.Right, IsReadOnly = true, AdsIgnore = true)]
		public decimal? MinPayoutL2 => aipl2.GetValueOrDefault() * aipl2per.GetValueOrDefault() / 100;

		[Display(Name = "Min Payout L3")]
		[DisplayFormat(DataFormatString = MagicString.CurrencyZeroFormatString)]
		[MyCustom(Width = "60", Mask = "#########", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, MinValue = "0", MaxValue = "999999999", Type = MaskType.Currency, Alignment = TextAlignment.Right, IsReadOnly = true, AdsIgnore = true)]
		public decimal? MinPayoutL3 => aipl3.GetValueOrDefault() * aipl3per.GetValueOrDefault() / 100;

		[Display(Name = "Min Payout L4")]
		[DisplayFormat(DataFormatString = MagicString.CurrencyZeroFormatString)]
		[MyCustom(Width = "60", Mask = "#########", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, MinValue = "0", MaxValue = "999999999", Type = MaskType.Currency, Alignment = TextAlignment.Right, IsReadOnly = true, AdsIgnore = true)]
		public decimal? MinPayoutL4 => aipl4.GetValueOrDefault() * aipl4per.GetValueOrDefault() / 100;

		public string otherman { get => _otherman; set => SetProperty(ref _otherman, value); }

		[Display(Name = "Entered")]
		[DataType(DataType.Date), DisplayFormat(DataFormatString = MagicString.SmallDateFormat, ApplyFormatInEditMode = true)]
		[MyCustom(Width = MagicString.DateColumnWidth, IsReadOnly = true)]
		public DateTime? entrydate { get => _entrydate; set => SetProperty(ref _entrydate, value); }

		[Display(Name = "Updated")]
		[DataType(DataType.Date), DisplayFormat(DataFormatString = MagicString.SmallDateFormat, ApplyFormatInEditMode = true)]
		[MyCustom(Width = MagicString.DateColumnWidth, IsReadOnly = true)]
		public DateTime? lastupdate { get => _lastupdate; set => SetProperty(ref _lastupdate, value); }

		[Display(Name = "Software")]
		[MyCustom(IsUpper = true)]
		public string software { get => _software; set => SetProperty(ref _software, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { salesno };

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public string VendorNo => salesno.ToString().PadLeft(5, '0');

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public string NoName => $"{salesno} - {name}";

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

		[MyCustom(AdsIgnore = true)]
		public bool Active { get => repstatus == "A"; set { repstatus = value ? "A" : "I"; OnPropertyChanged(); } }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public hregion hregion {
			get => _hregion;
			set {
				if (SetProperty(ref _hregion, value)) {
					//hregion = GetRegion(region);
					OnPropertyChanged("RegionName");
					OnPropertyChanged("Regional");
					OnPropertyChanged("RegionalEmail");
				}
			}
		}

		[MyCustom(AdsIgnore = true, IsReadOnly = true)]
		public string RegionName => hregion?.name;

		[MyCustom(AdsIgnore = true, IsReadOnly = true)]
		public string Regional => hregion?.regional;

		[MyCustom(AdsIgnore = true, IsReadOnly = true)]
		public string RegionalEmail => hregion?.Email;

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public hcstsrv Cs { get => _cs; set => SetProperty(ref _cs, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public hcstsrv CsAlt { get => _csAlt; set => SetProperty(ref _csAlt, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public hcstsrv Qu { get => _qu; set => SetProperty(ref _qu, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public hcstsrv QuAlt { get => _quAlt; set => SetProperty(ref _quAlt, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public IList<hcust> Customers {
			get {
				if (_customers == null) {
					_customers = GetCustomers();
					OnPropertyChanged();
				}
				return _customers;
			}
			set => SetProperty(ref _customers, value);
		}

		public IList<hcust> GetCustomers() {
			var context = new FoxProDataContext();
			return context.GetAgencyCustomers(salesno);
		}

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public IList<hrepemp> Contacts {
			get {
				if (_contacts == null) {
					_contacts = GetContacts();
					OnPropertyChanged();
				}
				return _contacts;
			}
			set => SetProperty(ref _contacts, value);
		}

		public IList<hrepemp> GetContacts() {
			var context = new FoxProDataContext();
			return context.GetAgencyContacts(salesno);
		}

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public IList<hreplin> Lines {
			get {
				if (_lines == null) {
					_lines = GetLines();
					OnPropertyChanged();
				}
				return _lines;
			}
			set => SetProperty(ref _lines, value);
		}

		public IList<hreplin> GetLines() {
			var context = new FoxProDataContext();
			return context.GetAgencyProdLines(salesno);
		}

		public hregion GetRegion(string value) {
			if (string.IsNullOrEmpty(value)) return null;
			if (string.IsNullOrEmpty(value)) return null;
			var context = new FoxProDataContext();
			var entity = context.GetEntity<hregion>(value);

			//var context = new FoxProDataContext();
			//var entity = context.GetRegionByLogin(value);
			return entity;
		}

		public hcstsrv GetCs(string value) {
			if (string.IsNullOrEmpty(value)) return null;
			var context = new FoxProDataContext();
			var entity = context.GetEntity<hcstsrv>(value);
			return entity;
		}

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public bool InReader { get; set; }

		public override int Insert() {
			var context = new FoxProDataContext();
			agencyid = context.GetNextAgencyId();
			entrydate = DateTime.Today;
			var recno = context.Insert(this);
			if (recno > 0) {
				UpdateCustomer(context);
				UpdateVendor(context);
			}
			return recno;
		}

		public override bool Update() {
			var context = new FoxProDataContext();
			var oldrep = context.GetAgency(salesno);
			var oldstatus = oldrep.repstatus;
			if (DirtyList.Any()) lastupdate = DateTime.Today;
			var updated = context.Update(this);
			if (updated) {
				UpdateCustomer(context);
				UpdateVendor(context);
				if (oldstatus.Equals("A") && repstatus.Equals("I") && newsalesno != 0) {
					var switched = context.CustomerAgencySwitch(salesno, newsalesno);
				}
			}
			return updated;
		}

		public override bool Delete() {
			var context = new FoxProDataContext();
			var deleted = context.Delete(this);
			if (deleted) {
			}
			return deleted;
		}

		//public void AddVendor(FoxProDataContext context) {
		//	var vendor = context.GetVendor(VendorNo);
		//	if (vendor == null) {
		//	}
		//	UpdateVendor(context, vendor);
		//}

		public void UpdateVendor(FoxProDataContext context) {
			var vendor = context.GetVendor(VendorNo);
			if (vendor == null) {
				vendor = new hvendor {
					vendor_no = VendorNo,
					bname = name.Replace("CNCL-", ""),
					baddr1 = address,
					baddr2 = address2,
					bcity = city,
					bstate = state,
					bzip = zip,
					pname = "H.E. WILLIAMS, INC.",
					paddr1 = "831 WEST FAIRVIEW AVE.",
					paddr2 = "",
					pcity = "CARTHAGE",
					pstate = "MO",
					pzip = "64836",
					terms = "A",
					corp = true
				};
				context.Insert(vendor);
			}
			if (vendor.vname != name) vendor.vname = name;
			if (vendor.vaddr1 != address) vendor.vaddr1 = address;
			if (vendor.vaddr2 != address2) vendor.vaddr2 = address2;
			if (vendor.vcity != city) vendor.vcity = city;
			if (vendor.vstate != state) vendor.vstate = state;
			if (vendor.vzip != zip) vendor.vzip = zip;
			if (vendor.phone != phone) vendor.phone = phone;
			if (vendor.faxphone != phone2) vendor.faxphone = phone2;
			context.Update(vendor);
		}

		public void UpdateCustomer(FoxProDataContext context) {
			var cust = context.GetCustomer(salesno);
			if (cust == null) {
				cust = new hcust {
					custno = salesno,
					dbrate = "AGEN2",
					stocking = "N",
					oembl = "N",
					oemlabel = "N",
					credlimit = 2500,
					ppfrtmin = 2000
				};
				context.Insert(cust);
			}
			if (cust.name != name) cust.name = name;
			if (cust.saleno != salesno) cust.saleno = salesno;
			if (cust.address != address) cust.address = address;
			if (cust.address2 != address2) cust.address2 = address2;
			if (cust.city != city) cust.city = city;
			if (cust.state != state) cust.state = state;
			if (cust.zip != zip) cust.zip = zip;
			if (cust.phone != phone) cust.phone = phone;
			if (cust.phone2 != phone2) cust.phone2 = phone2;
			var sname = name.Replace("CNCL-", "");
			if (cust.sname != sname) cust.sname = sname;
			if (cust.saddress != address) cust.saddress = address;
			if (cust.saddress2 != address2) cust.saddress2 = address2;
			if (cust.scity != city) cust.scity = city;
			if (cust.sstate != state) cust.sstate = state;
			if (cust.szip != zip) cust.szip = zip;
			context.Update(cust);
		}

		public override void Refresh() {
			if (salesno == 0) return;
			var context = new FoxProDataContext();
			var entity = context.GetEntity<hrep>(salesno);
			if (parent != entity.parent) parent = entity.parent;
			if (newsalesno != entity.newsalesno) newsalesno = entity.newsalesno;
			if (repstatus != entity.repstatus) repstatus = entity.repstatus;
			if (custserv != entity.custserv) custserv = entity.custserv;
			if (custservi != entity.custservi) custservi = entity.custservi;
			if (csq != entity.csq) csq = entity.csq;
			if (csqb != entity.csqb) csqb = entity.csqb;
			if (name != entity.name) name = entity.name;
			if (address != entity.address) address = entity.address;
			if (address2 != entity.address2) address2 = entity.address2;
			if (city != entity.city) city = entity.city;
			if (state != entity.state) state = entity.state;
			if (zip != entity.zip) zip = entity.zip;
			if (contact != entity.contact) contact = entity.contact;
			if (phone != entity.phone) phone = entity.phone;
			if (phone2 != entity.phone2) phone2 = entity.phone2;
			if (phone3 != entity.phone3) phone3 = entity.phone3;
			if (hiredate != entity.hiredate) hiredate = entity.hiredate;
			if (termdate != entity.termdate) termdate = entity.termdate;
			if (warehouse != entity.warehouse) warehouse = entity.warehouse;
			if (region != entity.region) region = entity.region;
			if (regionrep != entity.regionrep) regionrep = entity.regionrep;
			if (hofaxinv != entity.hofaxinv) hofaxinv = entity.hofaxinv;
			if (aipl1 != entity.aipl1) aipl1 = entity.aipl1;
			if (aipl2 != entity.aipl2) aipl2 = entity.aipl2;
			if (otherman != entity.otherman) otherman = entity.otherman;
			if (entrydate != entity.entrydate) entrydate = entity.entrydate;
			if (lastupdate != entity.lastupdate) lastupdate = entity.lastupdate;
			if (software != entity.software) software = entity.software;
			MakeClean();
		}

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("agencyid")) agencyid = reader.ReadInt("agencyid");
			if (InFieldList("salesno")) salesno = reader.ReadInt("salesno");
			if (InFieldList("parent")) parent = reader.ReadInt("parent");
			if (InFieldList("newsalesno")) newsalesno = reader.ReadInt("newsalesno");
			if (InFieldList("repstatus")) repstatus = reader.ReadString("repstatus");
			if (InFieldList("custserv")) custserv = reader.ReadString("custserv");
			if (InFieldList("custservi")) custservi = reader.ReadString("custservi");
			if (InFieldList("csq")) csq = reader.ReadString("csq");
			if (InFieldList("csqb")) csqb = reader.ReadString("csqb");
			if (InFieldList("name")) name = reader.ReadString("name");
			if (InFieldList("address")) address = reader.ReadString("address");
			if (InFieldList("address2")) address2 = reader.ReadString("address2");
			if (InFieldList("city")) city = reader.ReadString("city");
			if (InFieldList("state")) state = reader.ReadString("state");
			if (InFieldList("zip")) zip = reader.ReadString("zip");
			if (InFieldList("contact")) contact = reader.ReadString("contact");
			if (InFieldList("phone")) phone = reader.ReadString("phone");
			if (InFieldList("phone2")) phone2 = reader.ReadString("phone2");
			if (InFieldList("phone3")) phone3 = reader.ReadString("phone3");
			if (InFieldList("csales")) csales = reader.ReadDecimal("csales");
			if (InFieldList("ccomm")) ccomm = reader.ReadDecimal("ccomm");
			if (InFieldList("ytdsales")) ytdsales = reader.ReadDecimal("ytdsales");
			if (InFieldList("ytdcomm")) ytdcomm = reader.ReadDecimal("ytdcomm");
			if (InFieldList("pysales")) pysales = reader.ReadDecimal("pysales");
			if (InFieldList("pycomm")) pycomm = reader.ReadDecimal("pycomm");
			if (InFieldList("hiredate")) hiredate = reader.ReadDate("hiredate");
			if (InFieldList("termdate")) termdate = reader.ReadDate("termdate");
			if (InFieldList("warehouse")) warehouse = reader.ReadString("warehouse");
			if (InFieldList("region")) region = reader.ReadString("region");
			if (InFieldList("regionrep")) regionrep = reader.ReadString("regionrep");
			if (InFieldList("s1jan")) s1jan = reader.ReadDecimal("s1jan");
			if (InFieldList("s1feb")) s1feb = reader.ReadDecimal("s1feb");
			if (InFieldList("s1mar")) s1mar = reader.ReadDecimal("s1mar");
			if (InFieldList("s1apr")) s1apr = reader.ReadDecimal("s1apr");
			if (InFieldList("s1may")) s1may = reader.ReadDecimal("s1may");
			if (InFieldList("s1jun")) s1jun = reader.ReadDecimal("s1jun");
			if (InFieldList("s1jul")) s1jul = reader.ReadDecimal("s1jul");
			if (InFieldList("s1aug")) s1aug = reader.ReadDecimal("s1aug");
			if (InFieldList("s1sep")) s1sep = reader.ReadDecimal("s1sep");
			if (InFieldList("s1oct")) s1oct = reader.ReadDecimal("s1oct");
			if (InFieldList("s1nov")) s1nov = reader.ReadDecimal("s1nov");
			if (InFieldList("s1dec")) s1dec = reader.ReadDecimal("s1dec");
			if (InFieldList("s2jan")) s2jan = reader.ReadDecimal("s2jan");
			if (InFieldList("s2feb")) s2feb = reader.ReadDecimal("s2feb");
			if (InFieldList("s2mar")) s2mar = reader.ReadDecimal("s2mar");
			if (InFieldList("s2apr")) s2apr = reader.ReadDecimal("s2apr");
			if (InFieldList("s2may")) s2may = reader.ReadDecimal("s2may");
			if (InFieldList("s2jun")) s2jun = reader.ReadDecimal("s2jun");
			if (InFieldList("s2jul")) s2jul = reader.ReadDecimal("s2jul");
			if (InFieldList("s2aug")) s2aug = reader.ReadDecimal("s2aug");
			if (InFieldList("s2sep")) s2sep = reader.ReadDecimal("s2sep");
			if (InFieldList("s2oct")) s2oct = reader.ReadDecimal("s2oct");
			if (InFieldList("s2nov")) s2nov = reader.ReadDecimal("s2nov");
			if (InFieldList("s2dec")) s2dec = reader.ReadDecimal("s2dec");
			if (InFieldList("c1jan")) c1jan = reader.ReadDecimal("c1jan");
			if (InFieldList("c1feb")) c1feb = reader.ReadDecimal("c1feb");
			if (InFieldList("c1mar")) c1mar = reader.ReadDecimal("c1mar");
			if (InFieldList("c1apr")) c1apr = reader.ReadDecimal("c1apr");
			if (InFieldList("c1may")) c1may = reader.ReadDecimal("c1may");
			if (InFieldList("c1jun")) c1jun = reader.ReadDecimal("c1jun");
			if (InFieldList("c1jul")) c1jul = reader.ReadDecimal("c1jul");
			if (InFieldList("c1aug")) c1aug = reader.ReadDecimal("c1aug");
			if (InFieldList("c1sep")) c1sep = reader.ReadDecimal("c1sep");
			if (InFieldList("c1oct")) c1oct = reader.ReadDecimal("c1oct");
			if (InFieldList("c1nov")) c1nov = reader.ReadDecimal("c1nov");
			if (InFieldList("c1dec")) c1dec = reader.ReadDecimal("c1dec");
			if (InFieldList("c2jan")) c2jan = reader.ReadDecimal("c2jan");
			if (InFieldList("c2feb")) c2feb = reader.ReadDecimal("c2feb");
			if (InFieldList("c2mar")) c2mar = reader.ReadDecimal("c2mar");
			if (InFieldList("c2apr")) c2apr = reader.ReadDecimal("c2apr");
			if (InFieldList("c2may")) c2may = reader.ReadDecimal("c2may");
			if (InFieldList("c2jun")) c2jun = reader.ReadDecimal("c2jun");
			if (InFieldList("c2jul")) c2jul = reader.ReadDecimal("c2jul");
			if (InFieldList("c2aug")) c2aug = reader.ReadDecimal("c2aug");
			if (InFieldList("c2sep")) c2sep = reader.ReadDecimal("c2sep");
			if (InFieldList("c2oct")) c2oct = reader.ReadDecimal("c2oct");
			if (InFieldList("c2nov")) c2nov = reader.ReadDecimal("c2nov");
			if (InFieldList("c2dec")) c2dec = reader.ReadDecimal("c2dec");
			if (InFieldList("hofaxinv")) hofaxinv = reader.ReadBool("hofaxinv");
			if (InFieldList("aipl1")) aipl1 = reader.ReadInt("aipl1");
			if (InFieldList("aipl2")) aipl2 = reader.ReadInt("aipl2");
			if (InFieldList("aipl3")) aipl3 = reader.ReadInt("aipl3");
			if (InFieldList("aipl4")) aipl4 = reader.ReadInt("aipl4");
			if (InFieldList("aipl1per")) aipl1per = reader.ReadDecimal("aipl1per");
			if (InFieldList("aipl2per")) aipl2per = reader.ReadDecimal("aipl2per");
			if (InFieldList("aipl3per")) aipl3per = reader.ReadDecimal("aipl3per");
			if (InFieldList("aipl4per")) aipl4per = reader.ReadDecimal("aipl4per");
			if (InFieldList("otherman")) otherman = reader.ReadString("otherman");
			if (InFieldList("entrydate")) entrydate = reader.ReadDate("entrydate");
			if (InFieldList("lastupdate")) lastupdate = reader.ReadDate("lastupdate");
			if (InFieldList("qs")) qs = reader.ReadInt("qs");
			if (InFieldList("payoutL1")) payoutL1 = reader.ReadInt("payoutL1");
			if (InFieldList("payoutL2")) payoutL2 = reader.ReadInt("payoutL2");
			if (InFieldList("payoutL3")) payoutL3 = reader.ReadInt("payoutL3");
			if (InFieldList("payoutL4")) payoutL4 = reader.ReadInt("payoutL4");
			if (InFieldList("qtr1Sales")) qtr1Sales = reader.ReadInt("qtr1Sales");
			if (InFieldList("qtr2Sales")) qtr2Sales = reader.ReadInt("qtr2Sales");
			if (InFieldList("qtr3Sales")) qtr3Sales = reader.ReadInt("qtr3Sales");
			if (InFieldList("qtr4Sales")) qtr4Sales = reader.ReadInt("qtr4Sales");
			if (InFieldList("qsytd")) qsytd = reader.ReadInt("qsytd");
			if (InFieldList("software")) software = reader.ReadString("software");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public int GetNextAgencyId() {
			var qTime = DateTime.Now;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandText = "hrep";
			cmd.CommandType = CommandType.TableDirect;
			var rdr = cmd.ExecuteExtendedReader();
			rdr.ActiveIndex = "agencyid";
			rdr.GotoBottom();
			var nextNo = rdr.ReadInt("agencyid") + 1;
			rdr.Close();
			Conn.Close();
			QueryDebugEnd(qTime, "GetNextAgencyId");
			return nextNo;
		}

		public IList<hrep> GetAgenciesNoName() {
			var qTime = DateTime.Now;
			var entities = new List<hrep>();
			Conn.Open();
			var cmd = Conn.CreateCommand();
			var sql = "select salesno, name from hrep where repstatus <> 'I' order by name";
			cmd.CommandText = sql;
			try {
				var reader = cmd.ExecuteReader();
				while (reader.Read()) {
					var entity = new hrep {
						salesno = reader.ReadInt(reader.GetOrdinal("salesno")),
						name = reader.ReadString(reader.GetOrdinal("name"))
					};
					entities.Add(entity);
				}
				reader.Close();
			}
			catch (Exception e) {
				Console.WriteLine(e);
			}
			Conn.Close();
			QueryDebugEnd(qTime, $"GetAgenciesNoName - {sql}");
			return entities;
		}

		public IList<hrep> GetAgencies(string searchValue, string orderValue, bool all) {
			var qTime = DateTime.Now;
			var allString = all ? "" : string.IsNullOrEmpty(searchValue) ? "repstatus<>'I'" : " and repstatus<>'I'";
			var isInt = int.TryParse(searchValue, out var x);
			var whereValue = "";
			if (string.IsNullOrEmpty(searchValue)) {
				whereValue = allString;
			}
			else {
				if (searchValue.Contains(":")) {
					var left = searchValue.ToLower().Split(':').First().Trim();
					var right = searchValue.Split(':').Last().Trim();
					if (right.Equals("true") || right.Equals("false")) {
						whereValue = $"{left} = {right}";
					}
					else {
						whereValue = $"UPPER({left}) like '{right.ToUpper()}%'";
					}
				}
				else {
					if (isInt) {
						var len = searchValue.StartsWith("1") ? 4 : 3;
						whereValue = searchValue.Length == len ? $"TRUNCATE(salesno/10,0)={searchValue}" : $"salesno={searchValue}";
					}
					else {
						whereValue = $"UPPER(name) like '{searchValue.ToUpper()}%'{allString}";
					}
				}
			}
			var entities = GetEntities<hrep>(whereValue, "salesno", 0).ToList();
			//foreach (var entity in entities) {
			//	entity.hregion = GetEntity<hregion>(entity.region);
			//	entity.Cs = GetEntity<hcstsrv>(entity.custserv);
			//	entity.CsAlt = GetEntity<hcstsrv>(entity.custservi);
			//	entity.Qu = GetEntity<hcstsrv>(entity.csq);
			//	entity.QuAlt = GetEntity<hcstsrv>(entity.csqb);
			//	entity.MakeClean();
			//}
			QueryDebugEnd(qTime, $"GetAgencies");
			return entities;
		}

		public IList<hrep> GetAllAgencies(bool all) {
			var qTime = DateTime.Now;
			var allString = all ? "" : " where repstatus<>'I'";
			Conn.Open();
			var entities = new List<hrep>();
			var fields = new List<string> { "agencyid", "salesno", "newsalesno", "repstatus", "custserv", "custservi", "csq", "csqb", "name", "address", "address2", "city", "state", "zip", "contact", "phone", "phone2", "phone3", "csales", "ccomm", "ytdsales", "ytdcomm", "pysales", "pycomm", "hiredate", "termdate", "warehouse", "region" };
			var cmd = Conn.CreateCommand();
			var sql = $"select {string.Join(", ", fields)} from hrep{allString}";
			cmd.CommandText = sql;
			var reader = cmd.ExecuteReader();
			while (reader.Read()) {
				var entity = new hrep();
				entity.FillFromReaderList(reader, fields);
				entities.Add(entity);
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetAllAgencies");
			return entities;
		}

		public hrep GetAgencyAddress(int agencyNo) {
			var qTime = DateTime.Now;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			var sql = $"select address, address2, city, state, zip from hrep where salesno={agencyNo}";
			cmd.CommandText = sql;
			var reader = cmd.ExecuteReader();
			var entity = new hrep();
			while (reader.Read()) {
				entity.FillFromReader(reader);
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetAgencyAddress - {sql}");
			return entity;
		}

		public void GetAgencyOpenHoldOrders3(int no, ref decimal hold, ref decimal open) {
			Conn.Open();

			var cmd = Conn.CreateCommand();
			cmd.CommandText = $"select  sum(subtotal) from hord where sale1 = {no} and status > ' ' and status < '8' and date > '{DateTime.Now.AddYears(-1).ToShortDateString()}' ";
			var reader = cmd.ExecuteReader();
			while (reader.Read()) open = reader.ReadDecimal(0);
			reader.Close();

			var cmd1 = Conn.CreateCommand();
			cmd1.CommandText = $"select  sum(subtotal) from hord where sale1 = {no} and status=' ' and date > '{DateTime.Now.AddYears(-1).ToShortDateString()}' ";
			var reader1 = cmd1.ExecuteReader();
			while (reader1.Read()) hold = reader1.ReadDecimal(0);
			reader1.Close();

			Conn.Close();

		}

		public hrep GetAgencyMainOfficeIncludingSubAgencySalesTotals(int no) {
			var qTime = DateTime.Now;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandText = $"select * from hrep where salesno={no}";
			var reader = cmd.ExecuteReader();
			var entity = new hrep();
			while (reader.Read()) {
				entity.FillFromReader(reader);
				var region = GetEntity<hregion>(entity.region);
				entity.hregion = region;
			}
			reader.Close();
			var sql = $"select * from hrep where parent={entity.parent}";
			cmd.CommandText = sql;
			reader = cmd.ExecuteReader();
			while (reader.Read()) {
				var parent = reader.ReadInt(reader.GetOrdinal("parent"));
				var salesno = reader.ReadInt(reader.GetOrdinal("salesno"));
				//if (parent * 10 == salesno) continue;
				if (entity.salesno == salesno) continue;
				entity.ytdsales += reader.ReadDecimal(reader.GetOrdinal("ytdsales"));
				entity.ytdcomm += reader.ReadDecimal(reader.GetOrdinal("ytdcomm"));
			}
			reader.Close();
			Conn.Close();
			entity.MakeClean();
			QueryDebugEnd(qTime, $"GetAgencyMainOfficeIncludingSubAgencySalesTotals - {sql}");
			return entity;
		}

		public hrep GetAgencyMainOfficeIncludingSubAgencySalesTotalsTDP(int no) {
			Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandText = $"select * from hrep where salesno={no}";
			var reader = cmd.ExecuteReader();
			var entity = new hrep();
			while (reader.Read()) {
				entity.FillFromReader(reader);
				var region = GetEntity<hregion>(entity.region);
				entity.hregion = region;
			}
			reader.Close();
			cmd.CommandText = $"select * from hrep where parent={entity.parent}";
			reader = cmd.ExecuteReader();
			while (reader.Read()) {
				var parent = reader.ReadInt(reader.GetOrdinal("parent"));
				var salesno = reader.ReadInt(reader.GetOrdinal("salesno"));
				if (salesno == no) continue; //don't count the original agency again
				//if (parent * 10 == salesno) continue;
				entity.ytdsales += reader.ReadDecimal(reader.GetOrdinal("ytdsales"));
				entity.ytdcomm += reader.ReadDecimal(reader.GetOrdinal("ytdcomm"));
				entity.pysales += reader.ReadDecimal(reader.GetOrdinal("pysales"));
				entity.pycomm += reader.ReadDecimal(reader.GetOrdinal("pycomm"));
				entity.s2jan += reader.ReadDecimal(reader.GetOrdinal("s2jan"));
				entity.s2feb += reader.ReadDecimal(reader.GetOrdinal("s2feb"));
				entity.s2mar += reader.ReadDecimal(reader.GetOrdinal("s2mar"));
				entity.s2apr += reader.ReadDecimal(reader.GetOrdinal("s2apr"));
				entity.s2may += reader.ReadDecimal(reader.GetOrdinal("s2may"));
				entity.s2jun += reader.ReadDecimal(reader.GetOrdinal("s2jun"));
				entity.s2jul += reader.ReadDecimal(reader.GetOrdinal("s2jul"));
				entity.s2aug += reader.ReadDecimal(reader.GetOrdinal("s2aug"));
				entity.s2sep += reader.ReadDecimal(reader.GetOrdinal("s2sep"));
				entity.s2oct += reader.ReadDecimal(reader.GetOrdinal("s2oct"));
				entity.s2nov += reader.ReadDecimal(reader.GetOrdinal("s2nov"));
				entity.s2dec += reader.ReadDecimal(reader.GetOrdinal("s2dec"));
				entity.aipl1 += reader.ReadInt(reader.GetOrdinal("aipl1"));
				entity.aipl1per += reader.ReadDecimal(reader.GetOrdinal("aipl1per"));
				entity.aipl2 += reader.ReadInt(reader.GetOrdinal("aipl2"));
				entity.aipl2per += reader.ReadDecimal(reader.GetOrdinal("aipl2per"));
				entity.aipl3 += reader.ReadInt(reader.GetOrdinal("aipl3"));
				entity.aipl3per += reader.ReadDecimal(reader.GetOrdinal("aipl3per"));
			}
			reader.Close();
			Conn.Close();
			entity.MakeClean();
			return entity;
		}

		public hrep GetAgency(int salesno) {
			var entity = GetAgency(salesno, new List<string> { "*" });
			return entity;
		}

		public hrep GetActiveAgency(int salesno) {
			var entity = GetActiveAgency(salesno, new List<string> { "*" });
			return entity;
		}

		public hrep GetAgency(int salesno, List<string> fieldList) {
			var qTime = DateTime.Now;
			var sql = $"select {GetFields(fieldList)} from hrep where salesno={salesno}";
			var entity = GetEntitySql<hrep>(sql, fieldList);
			if (entity != null) {
				var region = GetEntity<hregion>(entity.region);
				entity.hregion = region;
			}
			QueryDebugEnd(qTime, $"GetAgency - {sql}");
			return entity;
		}

		public hrep GetActiveAgency(int salesno, List<string> fieldList) {
			var qTime = DateTime.Now;
			var sql = $"select {GetFields(fieldList)} from hrep where repstatus='A' and salesno={salesno}";
			var entity = GetEntitySql<hrep>(sql, fieldList);
			if (entity != null) {
				var region = GetEntity<hregion>(entity.region);
				entity.hregion = region;
			}
			QueryDebugEnd(qTime, $"GetAgency - {sql}");
			return entity;
		}

		public IList<AgencyParent> GetAgencyParents() {
			var qTime = DateTime.Now;
			var entities = new List<AgencyParent>();
			Conn.Open();
			var cmd = Conn.CreateCommand();
			var sql = "select salesno, parent, repstatus from hrep";
			cmd.CommandText = sql;
			try {
				var reader = cmd.ExecuteReader();
				while (reader.Read()) {
					var repstatus = reader.ReadString("repstatus");
					if (repstatus == "I") continue;
					var entity = new AgencyParent {
						AgencyNo = reader.ReadInt(reader.GetOrdinal("salesno")),
						ParentNo = reader.ReadInt("parent")
					};
					entities.Add(entity);
				}
				reader.Close();
			}
			catch (Exception e) {
				Console.WriteLine(e);
			}
			Conn.Close();
			QueryDebugEnd(qTime, $"GetAgencyParent - {sql}");
			return entities;
		}

		public decimal GetAgencyOrderSubtotalByDate(DateTime start, DateTime end, int agencyNo) {
			var sql = $"select sum(subtotal) as subtotal from hord where sale1 = {agencyNo} and date >= '{start.ToShortDateString()}' and date< '{end.ToShortDateString()}'";
			var subTotal = 0m;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandText = sql;
			var reader = cmd.ExecuteReader();
			while (reader.Read()) {
				subTotal = reader.ReadDecimal("subtotal");
			}
			reader.Close();
			Conn.Close();
			return subTotal;
		}
	
		public List<int> GetSubAgenciesList(int parent) {
			Conn.Open();
			var cmd = Conn.CreateCommand();
			var parentList = new List<Int32>();
			cmd.CommandText = $"select * from hrep where parent={parent}";
			var reader = cmd.ExecuteReader();
			while (reader.Read()) {
				var salesno = reader.ReadInt(reader.GetOrdinal("salesno"));
				parentList.Add(salesno);
			}
			reader.Close();
			Conn.Close();
			return parentList;
		}

		private string CheckParentAgency(int no) {
			if (no == 0) return "";
			if (AgencyParents == null) AgencyParents = GetAgencyParents();
			var subList = AgencyParents.Where(x => x.ParentNo == no);
			var str = " and (";
			foreach (var sub in subList) {
				if (str != " and (") str = $"{str} or ";
				str = $"{str}sale1={sub.AgencyNo} or sale2={sub.AgencyNo}";
			}
			str = $"{str})";
			return str;
		}

		private int GetParentNo(int no) {
			if (no == 0) return 0;
			if (AgencyParents == null) AgencyParents = GetAgencyParents();
			var agency = AgencyParents.SingleOrDefault(x => x.AgencyNo == no);
			var parentNo = agency?.ParentNo;
			return parentNo.GetValueOrDefault();
		}

		public decimal GetAgencyYtd(int salesno) {
			var qTime = DateTime.Now;
			decimal ytdTotal = 0;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			var sql = $"select ytdsales from hrep where salesno={salesno}";
			cmd.CommandText = sql;
			try {
				var reader = cmd.ExecuteReader();
				while (reader.Read()) {
					var ytd = reader.ReadDecimal("ytdsales");
					ytdTotal += ytd;
				}
				reader.Close();
			}
			catch (Exception e) {
				Console.WriteLine(e);
			}
			Conn.Close();
			QueryDebugEnd(qTime, $"GetAgencyYtd - {sql}");
			return ytdTotal;
		}

		public decimal GetAgencyYtdParent(int salesno) {
			var qTime = DateTime.Now;
			decimal ytdTotal = 0;
			var parent = GetParentNo(salesno);
			Conn.Open();
			var cmd = Conn.CreateCommand();
			var sql = $"select sum(ytdsales) as ytdsales from (select ytdsales from hrep where parent={parent}) src";
			cmd.CommandText = sql;
			try {
				var reader = cmd.ExecuteReader();
				while (reader.Read()) {
					var ytd = reader.ReadDecimal("ytdsales");
					ytdTotal += ytd;
				}
				reader.Close();
			}
			catch (Exception e) {
				Console.WriteLine(e);
			}
			Conn.Close();
			QueryDebugEnd(qTime, $"GetAgencyYtdParent - {sql}");
			return ytdTotal;
		}

		//public void UpdateHewisHrep() {
		//	var hewis = new HewisEntityRepository();
		//	var qTime = DateTime.Now;
		//	Conn.Open();
		//	var cmd = Conn.CreateCommand();
		//	cmd.CommandText = "hrep";
		//	cmd.CommandType = CommandType.TableDirect;
		//	var rdr = cmd.ExecuteExtendedReader();
		//	rdr.GotoTop();
		//	while (!rdr.EOF) {
		//		if (rdr.ReadString("repstatus") == "A") {
		//			var recno = rdr.RecordNumber;
		//			var hrep = new hrep();
		//			hrep.FillFromReader(rdr);
		//			var entity = hewis.GetEntities<Hrep>().SingleOrDefault(x => x.AgencyId == hrep.agencyid);
		//			if (entity == null) {
		//				entity = new Hrep();
		//				hewis.InsertOnSubmit(entity);
		//			}
		//			UpdateHrepFromAds(ref entity, hrep);
		//			hewis.SubmitChanges();
		//			if (hrep.agencyid == 0) {
		//				if (rdr.FoxRecordLock()) {
		//					rdr.SetInt32(rdr.GetOrdinal("agencyid"), entity.Id);
		//					rdr.WriteRecord();
		//					rdr.UnlockRecord();
		//				}
		//			}
		//			Console.WriteLine($"{recno} {entity.AgencyNo} {entity.AgencyName}");
		//		}
		//		rdr.Read();
		//	}
		//	rdr.Close();
		//	Conn.Close();
		//	QueryDebugEnd(qTime, $"GetAllAgencies");
		//}

		//public void UpdateHrepFromAds(ref Hrep entity, hrep ads) {
		//	entity.AgencyNo = ads.salesno;
		//	entity.NewAgencyNo = ads.newsalesno;
		//	entity.RepStatus = ads.repstatus;
		//	entity.CustServ = ads.custserv;
		//	entity.CustServI = ads.custservi;
		//	entity.AgencyName = ads.name;
		//	entity.AgencyAddr1 = ads.address;
		//	entity.AgencyAddr2 = ads.address2;
		//	entity.AgencyCity = ads.city;
		//	entity.AgencyState = ads.state;
		//	entity.AgencyZip = ads.zip;
		//	entity.Contact = ads.contact;
		//	entity.Phone = ads.phone;
		//	entity.Fax = ads.phone2;
		//	entity.HoFax = ads.phone3;
		//	entity.CSales = ads.csales;
		//	entity.CComm = ads.csales;
		//	entity.YtdSales = ads.ytdsales;
		//	entity.YtdComm = ads.ytdsales;
		//	entity.PySales = ads.pysales;
		//	entity.PyComm = ads.pycomm;
		//	entity.HireDate = ads.hiredate;
		//	entity.TermDate = ads.termdate;
		//	entity.Warehouse = ads.warehouse;
		//	entity.Region = ads.region;
		//	entity.RegionRep = ads.regionrep;
		//	entity.S1Jan = ads.s1jan;
		//	entity.S1Feb = ads.s1feb;
		//	entity.S1Mar = ads.s1mar;
		//	entity.S1Apr = ads.s1apr;
		//	entity.S1May = ads.s1may;
		//	entity.S1Jun = ads.s1jun;
		//	entity.S1Jul = ads.s1jul;
		//	entity.S1Aug = ads.s1aug;
		//	entity.S1Sep = ads.s1sep;
		//	entity.S1Oct = ads.s1oct;
		//	entity.S1Nov = ads.s1nov;
		//	entity.S1Dec = ads.s1dec;
		//	entity.S2Jan = ads.s2jan;
		//	entity.S2Feb = ads.s2jan;
		//	entity.S2Mar = ads.s2mar;
		//	entity.S2Apr = ads.s2apr;
		//	entity.S2May = ads.s2may;
		//	entity.S2Jun = ads.s2may;
		//	entity.S2Jul = ads.s2jul;
		//	entity.S2Aug = ads.s2aug;
		//	entity.S2Sep = ads.s2sep;
		//	entity.S2Oct = ads.s2oct;
		//	entity.S2Nov = ads.s2nov;
		//	entity.S2Dec = ads.s2dec;
		//	entity.C1Jan = ads.s2dec;
		//	entity.C1Feb = ads.c1feb;
		//	entity.C1Mar = ads.c1feb;
		//	entity.C1Apr = ads.c1apr;
		//	entity.C1May = ads.c1apr;
		//	entity.C1Jun = ads.c1jun;
		//	entity.C1Jul = ads.c1jul;
		//	entity.C1Aug = ads.c1aug;
		//	entity.C1Sep = ads.c1sep;
		//	entity.C1Oct = ads.c1oct;
		//	entity.C1Nov = ads.c1nov;
		//	entity.C1Dec = ads.c1dec;
		//	entity.C2Jan = ads.c2jan;
		//	entity.C2Feb = ads.c2feb;
		//	entity.C2Mar = ads.c2mar;
		//	entity.C2Apr = ads.c2apr;
		//	entity.C2May = ads.c2may;
		//	entity.C2Jun = ads.c2jun;
		//	entity.C2Jul = ads.c2jul;
		//	entity.C2Aug = ads.c2aug;
		//	entity.C2Sep = ads.c2sep;
		//	entity.C2Oct = ads.c2oct;
		//	entity.C2Nov = ads.c2nov;
		//	entity.C2Dec = ads.c2dec;
		//	entity.HoFaxInv = ads.hofaxinv;
		//	entity.OtherMan = ads.otherman;
		//	entity.Csq = ads.csq;
		//	entity.CsqB = ads.csqb;
		//	entity.EntryDate = ads.entrydate;
		//	entity.LastUpdate = ads.lastupdate;
		//	entity.AipL1Per = ads.aipl1per;
		//	entity.AipL2Per = ads.aipl2per;
		//	entity.AipL3Per = ads.aipl3per;
		//	entity.AipL1 = ads.aipl1;
		//	entity.AipL2 = ads.aipl2;
		//	entity.AipL3 = ads.aipl3;
		//	entity.AgencyId = ads.agencyid;
		//	entity.Parent = ads.parent;
		//	entity.PayoutL1 = ads.payoutL1;
		//	entity.PayoutL2 = ads.payoutL2;
		//	entity.Qs = ads.qs;
		//	entity.Qtr1Sales = ads.qtr1Sales;
		//	entity.Qtr2Sales = ads.qtr2Sales;
		//	entity.Qtr3Sales = ads.qtr3Sales;
		//	entity.Qtr4Sales = ads.qtr4Sales;
		//	entity.QsYtd = ads.qsytd;
		//}

	}

	public class AgencyParent {

		public int AgencyNo;
		public int ParentNo;

	}

}
