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

	public class hrepemp : FoxProEntity, IAgencyCollection {

		public hrepemp() {
			Key = "empid";
		}

		private int _empid;
		private int _salesno;
		private string _name;
		private string _email;
		private string _email2;
		private string _title;
		private string _ext;
		private string _phone;
		private string _fax;
		private string _cell;
		private string _password;
		private string _code;
		private bool? _active = false;
		private bool? _emailinv = false;
		private bool? _emailack = false;
		private bool? _emailpast = false;
		private bool? _aip = false;
		private bool? _aipUpdate = false;
		private bool? _etooladmin = false;
		private int? _logoncount;
		private DateTime? _lastlogon;
		private DateTime? _lastupdate;
		private DateTime? _entrydate;
		private int? _role = 3;
		private hrep _hrep;

		[Display(Name = "EmpId")]
		[MyCustom(Width = "*")]
		public int empid { get => _empid; set => SetProperty(ref _empid, value); }

		[Display(Name = "Agency")]
		[MyCustom(Width = "*", IsVisible = true)]
		public int salesno { get => _salesno; set => SetProperty(ref _salesno, value); }

		[Display(Name = "Name")]
		[MyCustom(Width = "*", IsVisible = true)]
		public string name { get => _name; set => SetProperty(ref _name, value); }

		[Display(Name = "Email")]
		[MyCustom(Width = "*", IsVisible = true)]
		public string email { get => _email; set => SetProperty(ref _email, value); }

		[Display(Name = "Email2")]
		[MyCustom(Width = "*")]
		public string email2 { get => _email2; set => SetProperty(ref _email2, value); }

		[Display(Name = "Title")]
		[MyCustom(Width = "*", IsVisible = true)]
		public string title { get => _title; set => SetProperty(ref _title, value); }

		[Display(Name = "Ext")]
		[MyCustom(Width = "*", IsVisible = true)]
		public string ext { get => _ext; set => SetProperty(ref _ext, value); }

		[Display(Name = "HomePhone")]
		[MyCustom(Mask = MagicString.PhoneMask, Width = "90", IsVisible = true)]
		public string phone { get => _phone; set => SetProperty(ref _phone, value); }

		[Display(Name = "HomeFax")]
		[MyCustom(Mask = MagicString.PhoneMask, Width = "90", IsVisible = true)]
		public string fax { get => _fax; set => SetProperty(ref _fax, value); }

		[Display(Name = "Cell")]
		[MyCustom(Mask = MagicString.PhoneMask, Width = "90", IsVisible = true)]
		public string cell { get => _cell; set => SetProperty(ref _cell, value); }

		[Display(Name = "Password")]
		[MyCustom(Width = "*")]
		public string password { get => _password; set => SetProperty(ref _password, value); }

		[Display(Name = "Code")]
		[MyCustom(Width = "*")]
		public string code { get => _code; set => SetProperty(ref _code, value); }

		[Display(Name = "RepNet")]
		[MyCustom(Width = "*", IsVisible = true)]
		public bool? active { get => _active; set => SetProperty(ref _active, value); }

		[Display(Name = "EmailInv")]
		[MyCustom(Width = "*", IsVisible = true)]
		public bool? emailinv {
			get => _emailinv;
			set {
				if (SetProperty(ref _emailinv, value)) {
					if (_emailinv.GetValueOrDefault() && !code.Contains("I")) code = $"I{code}";
					if (!_emailinv.GetValueOrDefault() && code.Contains("I")) code = code.Replace("I", "");
				}
			}
		}

		[Display(Name = "EmailAck")]
		[MyCustom(Width = "*", IsVisible = true)]
		public bool? emailack {
			get => _emailack;
			set {
				if (SetProperty(ref _emailack, value)) {
					if (_emailack.GetValueOrDefault() && !code.Contains("A")) code = $"{code}A";
					if (!_emailack.GetValueOrDefault() && code.Contains("A")) code = code.Replace("A", "");
				}
			}
		}

		[Display(Name = "EmailPastDue")]
		[MyCustom(Width = "*", IsVisible = true)]
		public bool? emailpast {
			get => _emailpast;
			set {
				if (SetProperty(ref _emailpast, value)) {
					if (_emailpast.GetValueOrDefault() && !code.Contains("P")) code = $"P{code}";
					if (!_emailpast.GetValueOrDefault() && code.Contains("P")) code = code.Replace("P", "");
				}
			}
		}

		[Display(Name = "AIPLetter")]
		public bool? aip { get => _aip; set => SetProperty(ref _aip, value); }

		[Display(Name = "AIPUpdate")]
		public bool? aipUpdate { get => _aipUpdate; set => SetProperty(ref _aipUpdate, value); }

		[Display(Name = "eTool")]
		public bool? etooladmin { get => _etooladmin; set => SetProperty(ref _etooladmin, value); }

		[Display(Name = "LogonCount")]
		[MyCustom(AdsIgnore = true, IsReadOnly = true)]
		public int? logoncount { get => _logoncount; set => SetProperty(ref _logoncount, value); }

		[Display(Name = "LastLogon")]
		[DataType(DataType.Date), DisplayFormat(DataFormatString = MagicString.SmallDateFormat, ApplyFormatInEditMode = true)]
		[MyCustom(Width = MagicString.DateColumnWidth, AdsIgnore = true, IsReadOnly = true)]
		public DateTime? lastlogon { get => _lastlogon; set => SetProperty(ref _lastlogon, value); }

		[Display(Name = "Updated")]
		[DataType(DataType.Date), DisplayFormat(DataFormatString = MagicString.SmallDateFormat, ApplyFormatInEditMode = true)]
		[MyCustom(Width = MagicString.DateColumnWidth, IsReadOnly = true)]
		public DateTime? lastupdate { get => _lastupdate; set => SetProperty(ref _lastupdate, value); }

		[Display(Name = "Entered")]
		[DataType(DataType.Date), DisplayFormat(DataFormatString = MagicString.SmallDateFormat, ApplyFormatInEditMode = true)]
		[MyCustom(Width = MagicString.DateColumnWidth, IsReadOnly = true)]
		public DateTime? entrydate { get => _entrydate; set => SetProperty(ref _entrydate, value); }

		public int? role { get => _role; set => SetProperty(ref _role, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { empid };

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public hrep Agency { get => _hrep; set => SetProperty(ref _hrep, value); }

		[Display(Name = "Name-Email")]
		[MyCustom(AdsIgnore = true, IsReadOnly = true)]
		public string NameEmail => $"{name} - {email}";

		[Display(Name = "Agency Name")]
		[MyCustom(AdsIgnore = true, IsReadOnly = true)]
		public string AgencyName => Agency?.name;

		[Display(Name = "Agency Addr")]
		[MyCustom(AdsIgnore = true, IsReadOnly = true)]
		public string AgencyAddr => Agency?.address;

		[Display(Name = "Agency CSZ")]
		[MyCustom(AdsIgnore = true, IsReadOnly = true)]
		public string AgencyCsz => $"{Agency?.city}, {Agency?.state}  {Agency?.zip}";

		[Display(Name = "AIP L1")]
		[DisplayFormat(DataFormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero)]
		[MyCustom(Mask = "", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, Alignment = TextAlignment.Right, AdsReadOnly = true, AdsIgnore = true, IsReadOnly = true)]
		public int? AgencyAipL1=> Agency?.aipl1;

		[Display(Name = "AIP L2")]
		[DisplayFormat(DataFormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero)]
		[MyCustom(Mask = "", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, Alignment = TextAlignment.Right, AdsReadOnly = true, AdsIgnore = true, IsReadOnly = true)]
		public int? AgencyAipL2 => Agency?.aipl2;

		[Display(Name = "AIP L3")]
		[DisplayFormat(DataFormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero)]
		[MyCustom(Mask = "", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, Alignment = TextAlignment.Right, AdsReadOnly = true, AdsIgnore = true, IsReadOnly = true)]
		public int? AgencyAipL3 => Agency?.aipl3;

		[Display(Name = "AIP L4")]
		[DisplayFormat(DataFormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero)]
		[MyCustom(Mask = "", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, Alignment = TextAlignment.Right, AdsReadOnly = true, AdsIgnore = true, IsReadOnly = true)]
		public int? AgencyAipL4 => Agency?.aipl4;

		[Display(Name = "AIP L1 Per")]
		[DisplayFormat(DataFormatString = MagicString.Percent1FormatString)]
		[MyCustom(Width = "60", FormatString = MagicString.Percentage1Format, Mask = "#.#", MinValue = "0", MaxValue = "9.9", Type = MaskType.Numeric, Alignment = TextAlignment.Right)]
		public decimal? Aipl1per => Agency?.aipl1per;

		[Display(Name = "AIP L2 Per")]
		[DisplayFormat(DataFormatString = MagicString.Percent1FormatString)]
		[MyCustom(Width = "60", FormatString = MagicString.Percentage1Format, Mask = "#.#", MinValue = "0", MaxValue = "9.9", Type = MaskType.Numeric, Alignment = TextAlignment.Right)]
		public decimal? Aipl2per => Agency?.aipl2per;

		[Display(Name = "AIP L3 Per")]
		[DisplayFormat(DataFormatString = MagicString.Percent1FormatString)]
		[MyCustom(Width = "60", FormatString = MagicString.Percentage1Format, Mask = "#.#", MinValue = "0", MaxValue = "9.9", Type = MaskType.Numeric, Alignment = TextAlignment.Right)]
		public decimal? Aipl3per => Agency?.aipl3per;

		[Display(Name = "AIP L4 Per")]
		[DisplayFormat(DataFormatString = MagicString.Percent1FormatString)]
		[MyCustom(Width = "60", FormatString = MagicString.Percentage1Format, Mask = "#.#", MinValue = "0", MaxValue = "9.9", Type = MaskType.Numeric, Alignment = TextAlignment.Right)]
		public decimal? Aipl4per => Agency?.aipl4per;

		[Display(Name = "QS")]
		[DisplayFormat(DataFormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero)]
		[MyCustom(Mask = "", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, Alignment = TextAlignment.Right, AdsReadOnly = true, AdsIgnore = true, IsReadOnly = true)]
		public decimal? Qs => Agency?.qs;

		[Display(Name = "Payout L1")]
		[DisplayFormat(DataFormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero)]
		[MyCustom(Mask = "", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, Alignment = TextAlignment.Right, AdsReadOnly = true, AdsIgnore = true, IsReadOnly = true)]
		public decimal? PayoutL1 => Agency?.payoutL1;

		[Display(Name = "Payout L2")]
		[DisplayFormat(DataFormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero)]
		[MyCustom(Mask = "", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, Alignment = TextAlignment.Right, AdsReadOnly = true, AdsIgnore = true, IsReadOnly = true)]
		public decimal? PayoutL2 => Agency?.payoutL2;

		[Display(Name = "Payout L3")]
		[DisplayFormat(DataFormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero)]
		[MyCustom(Mask = "", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, Alignment = TextAlignment.Right, AdsReadOnly = true, AdsIgnore = true, IsReadOnly = true)]
		public decimal? PayoutL3 => Agency?.payoutL3;

		[Display(Name = "Payout L4")]
		[DisplayFormat(DataFormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero)]
		[MyCustom(Mask = "", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, Alignment = TextAlignment.Right, AdsReadOnly = true, AdsIgnore = true, IsReadOnly = true)]
		public decimal? PayoutL4 => Agency?.payoutL4;

		[Display(Name = "Min Payout L1")]
		[DisplayFormat(DataFormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero)]
		[MyCustom(Mask = "", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, Alignment = TextAlignment.Right, AdsReadOnly = true, AdsIgnore = true, IsReadOnly = true)]
		public decimal? MinPayoutL1 => Agency?.MinPayoutL1;

		[Display(Name = "Min Payout L2")]
		[DisplayFormat(DataFormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero)]
		[MyCustom(Mask = "", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, Alignment = TextAlignment.Right, AdsReadOnly = true, AdsIgnore = true, IsReadOnly = true)]
		public decimal? MinPayoutL2 => Agency?.MinPayoutL2;

		[Display(Name = "Min Payout L3")]
		[DisplayFormat(DataFormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero)]
		[MyCustom(Mask = "", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, Alignment = TextAlignment.Right, AdsReadOnly = true, AdsIgnore = true, IsReadOnly = true)]
		public decimal? MinPayoutL3 => Agency?.MinPayoutL3;

		[Display(Name = "Min Payout L4")]
		[DisplayFormat(DataFormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero)]
		[MyCustom(Mask = "", FormatString = MagicString.StandardCurrencyFormatDoDecimalNoZero, Alignment = TextAlignment.Right, AdsReadOnly = true, AdsIgnore = true, IsReadOnly = true)]
		public decimal? MinPayoutL4 => Agency?.MinPayoutL4;

		[Display(Name = "Region Name")]
		[MyCustom(AdsIgnore = true, IsReadOnly = true)]
		public string AgencyRegionName => Agency?.RegionName;

		[Display(Name = "Regional")]
		[MyCustom(AdsIgnore = true, IsReadOnly = true)]
		public string AgencyRegional => Agency?.Regional;

		[Display(Name = "Regional Email")]
		[MyCustom(AdsIgnore = true, IsReadOnly = true)]
		public string AgencyRegionalEmail => Agency?.RegionalEmail;

		[Display(Name = "Curr YTD Sales")]
		[DisplayFormat(DataFormatString = MagicString.CurrencyFormat)]
		[MyCustom(Mask = "", FormatString = MagicString.CurrencyFormatString, Alignment = TextAlignment.Right, AdsReadOnly = true, AdsIgnore = true, IsReadOnly = true)]
		public decimal? AgencyCurrYtdSales => Agency?.ytdsales;

		[Display(Name = "Prev YTD Sales")]
		[DisplayFormat(DataFormatString = MagicString.CurrencyFormat)]
		[MyCustom(Mask = "", FormatString = MagicString.CurrencyFormatString, Alignment = TextAlignment.Right, AdsReadOnly = true, AdsIgnore = true, IsReadOnly = true)]
		public decimal? AgencyPrevYtdSales => Agency?.pysales;

		[Display(Name = "Curr YTD Comm")]
		[DisplayFormat(DataFormatString = MagicString.CurrencyFormat)]
		[MyCustom(Mask = "", FormatString = MagicString.CurrencyFormatString, Alignment = TextAlignment.Right, AdsReadOnly = true, AdsIgnore = true, IsReadOnly = true)]
		public decimal? AgencyCurrYtdComm => Agency?.ytdcomm;

		[Display(Name = "Prev YTD Comm")]
		[DisplayFormat(DataFormatString = MagicString.CurrencyFormat)]
		[MyCustom(Mask = "", FormatString = MagicString.CurrencyFormatString, Alignment = TextAlignment.Right, AdsReadOnly = true, AdsIgnore = true, IsReadOnly = true)]
		public decimal? AgencyPrevYtdComm => Agency?.pycomm;

		public decimal? AgencyCurrAipYtdPct => AgencyCurrYtdSales / AgencyAipL1;

		public override int Insert() {
			var context = new FoxProDataContext();
			empid = context.GetNextEmpId();
			entrydate = DateTime.Today;
			var recno = context.Insert(this);
			if (recno > 0) {
			}
			return recno;
		}

		public override bool Update() {
			var context = new FoxProDataContext();
			if (DirtyList.Any()) lastupdate = DateTime.Today;
			var updated = context.Update(this);
			if (updated) {
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

		public override void Refresh() {
			var context = new FoxProDataContext();
			var entity = context.GetAgencyEmployeeById(empid);
			if (name != entity.name) name = entity.name;
			if (email != entity.email) email = entity.email;
			if (email2 != entity.email2) email2 = entity.email2;
			if (title != entity.title) title = entity.title;
			if (ext != entity.ext) ext = entity.ext;
			if (phone != entity.phone) phone = entity.phone;
			if (fax != entity.fax) fax = entity.fax;
			if (cell != entity.cell) cell = entity.cell;
			if (password != entity.password) password = entity.password;
			if (code != entity.code) code = entity.code;
			if (emailinv != entity.emailinv) emailinv = entity.emailinv;
			if (emailack != entity.emailack) emailack = entity.emailack;
			if (emailpast != entity.emailpast) emailpast = entity.emailpast;
			if (aip != entity.aip) aip = entity.aip;
			if (aipUpdate != entity.aipUpdate) aipUpdate = entity.aipUpdate;
			if (etooladmin != entity.etooladmin) etooladmin = entity.etooladmin;
			if (logoncount != entity.logoncount) logoncount = entity.logoncount;
			if (lastlogon != entity.lastlogon) lastlogon = entity.lastlogon;
			if (lastupdate != entity.lastupdate) lastupdate = entity.lastupdate;
			if (entrydate != entity.entrydate) entrydate = entity.entrydate;
			if (role != entity.role) role = entity.role;
			if (active != entity.active) active = entity.active;
			MakeClean();
		}

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("empid")) empid = reader.ReadInt("empid");
			if (InFieldList("salesno")) salesno = reader.ReadInt("salesno");
			if (InFieldList("name")) name = reader.ReadString("name");
			if (InFieldList("email")) email = reader.ReadString("email");
			if (InFieldList("email2")) email2 = reader.ReadString("email2");
			if (InFieldList("title")) title = reader.ReadString("title");
			if (InFieldList("ext")) ext = reader.ReadString("ext");
			if (InFieldList("phone")) phone = reader.ReadString("phone");
			if (InFieldList("fax")) fax = reader.ReadString("fax");
			if (InFieldList("cell")) cell = reader.ReadString("cell");
			if (InFieldList("password")) password = reader.ReadString("password");
			if (InFieldList("code")) code = reader.ReadString("code");
			if (InFieldList("active")) active = reader.ReadBool("active");
			if (InFieldList("emailinv")) emailinv = reader.ReadBool("emailinv");
			if (InFieldList("emailack")) emailack = reader.ReadBool("emailack");
			if (InFieldList("emailpast")) emailpast = reader.ReadBool("emailpast");
			if (InFieldList("aip")) aip = reader.ReadBool("aip");
			if (InFieldList("aipupdate")) aipUpdate = reader.ReadBool("aipupdate");
			if (InFieldList("etooladmin")) etooladmin = reader.ReadBool("etooladmin");
			if (InFieldList("logoncount")) logoncount = reader.ReadInt("logoncount");
			if (InFieldList("lastlogon")) lastlogon = reader.ReadDate("lastlogon");
			if (InFieldList("lastupdate")) lastupdate = reader.ReadDate("lastupdate");
			if (InFieldList("entrydate")) entrydate = reader.ReadDate("entrydate");
			if (InFieldList("role")) role = reader.ReadInt("role");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public IList<hrepemp> GetAllContacts() {
			var qTime = DateTime.Now;
			var sql = "select * from hrepemp";
			var entities = GetEntities<hrepemp>(sql);
			QueryDebugEnd(qTime, $"GetAllContacts - {sql}");
			return entities;
		}

		public int GetNextEmpId() {
			var qTime = DateTime.Now;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandText = "hrepemp";
			cmd.CommandType = CommandType.TableDirect;
			var rdr = cmd.ExecuteExtendedReader();
			rdr.ActiveIndex = "empid";
			rdr.GotoBottom();
			var nextNo = rdr.ReadInt("empid") + 1;
			rdr.Close();
			Conn.Close();
			QueryDebugEnd(qTime, "GetNextEmpId");
			return nextNo;
		}

		public hrepemp GetAgencyEmployeeById(int id) {
			var qTime = DateTime.Now;
			var sql = $"select * from hrepemp where empid={id}";
			var entity = GetEntitySql<hrepemp>(sql);
			QueryDebugEnd(qTime, $"GetAgencyEmployeeById - {sql}");
			return entity;
		}

		public hrepemp GetAgencyEmployeeByEmail(string email) {
			var qTime = DateTime.Now;
			var sql = $"select * from hrepemp where email='{email}' and active";
			var entity = GetEntitySql<hrepemp>(sql);
			QueryDebugEnd(qTime, $"GetAgencyEmployeeByEmail - {sql}");
			return entity;
		}

		public hrepemp GetAgencyEmployeeByEmailPassword(string email, string password) {
			var qTime = DateTime.Now;
			var sql = $"select * from hrepemp where email='{email.ToLower()}' and password='{password}' and active";
			var entity = GetEntitySql<hrepemp>(sql);
			QueryDebugEnd(qTime, $"GetAgencyEmployeeByEmailPassword - {sql}");
			return entity;
		}

		public hrepemp GetAgencyEmployeeManager(int agencyNo) {
			var qTime = DateTime.Now;
			var sql = $"select * from hrepemp where salesno={agencyNo} and role=2 and active";
			var entity = GetEntity<hrepemp>(sql);
			QueryDebugEnd(qTime, $"GetAgencyEmployeeManager - {sql}");
			return entity;
		}

		public IList<hrepemp> GetAgencyContacts(int no) {
			var qTime = DateTime.Now;
			var sql = $"select * from hrepemp where salesno={no} order by name";
			var entities = GetEntities<hrepemp>(sql);
			QueryDebugEnd(qTime, $"GetAgencyContacts - {sql}");
			return entities;
		}

		public IList<hrepemp> GetAgencyEmployees(string searchValue, string orderValue, int top) {
			var qTime = DateTime.Now;
			var isInt = int.TryParse(searchValue, out var no);
			var whereValue = "";
			var isAip = false;
			if (!string.IsNullOrEmpty(searchValue)) {
				if (searchValue.Equals("aip")) {
					whereValue = "aip = true or aipupdate = true";
					isAip = true;
				}
				else if (searchValue.Equals("aipletter")) {
					whereValue = "aip = true";
					isAip = true;
				}
				else if (searchValue.Equals("aipupdate")) {
					whereValue = "aipupdate = true";
					isAip = true;
				}
				else if (searchValue.Contains(":")) {
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
						whereValue = $"UPPER(name) like '{searchValue.ToUpper()}%' or UPPER(email) like '{searchValue.ToUpper()}%'";
					}
				}
			}
			var entities = GetEntities<hrepemp>(whereValue, "name", top).ToList();
			foreach (var entity in entities) {
				hrep rep;
				if (isAip) {
					var x = entity.salesno.ToString();
					if (!x.EndsWith("0")) {
						entity.salesno = Convert.ToInt32($"{x.Substring(0, x.Length - 1)}0");
					}
					rep = GetAgencyMainOfficeIncludingSubAgencySalesTotals(entity.salesno);
				}
				else {
					rep = GetAgency(entity.salesno);
				}
				entity.Agency = rep;
			}
			QueryDebugEnd(qTime, $"GetAgencyEmployees");
			return entities;
		}

	}

}
