using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Advantage.Data.Provider;
using Common;

namespace AdsDataModel {

	public class hqhead : FoxProEntity {

		public hqhead() {
			Key = "quoteno";
		}

		private int _sqlid;
		private int _foxid;
		private int _custno;
		private int _quoteno;
		private DateTime? _date;
		private string _job_name;
		private string _location;
		private string _contractor;
		private string _architect;
		private string _engineer;
		private string _rep;
		private string _sname;
		private string _saddress;
		private string _saddress2;
		private string _scity;
		private string _sstate;
		private string _szip;
		private string _confirmto;
		private string _terms_norm;
		private string _terms_ext;
		private DateTime? _prior_to;
		private int? _rel_days;
		private DateTime? _from;
		private DateTime? _to;
		private int? _add_per;
		private bool? _printed;
		private string _takenby;
		private string _qstatus;
		private DateTime? _refaxdate;
		private int? _orderno;
		private string _reason;
		private string _currency;
		private decimal? _exrate;
		private decimal? _exrate2usd;
		private decimal? _brokefee;
		private decimal? _csubtotal;
		private string _lotprice;
		private int? _oldkey;

		public int sqlid { get => _sqlid; set => SetProperty(ref _sqlid, value); }
		public int foxid { get => _foxid; set => SetProperty(ref _foxid, value); }
		public int custno { get => _custno; set => SetProperty(ref _custno, value); }
		public int quoteno { get => _quoteno; set => SetProperty(ref _quoteno, value); }
		public DateTime? date { get => _date; set => SetProperty(ref _date, value); }
		public string job_name { get => _job_name; set => SetProperty(ref _job_name, value.Left(30)); }
		public string location { get => _location; set => SetProperty(ref _location, value.Left(30)); }
		public string contractor { get => _contractor; set => SetProperty(ref _contractor, value.Left(30)); }
		public string architect { get => _architect; set => SetProperty(ref _architect, value.Left(30)); }
		public string engineer { get => _engineer; set => SetProperty(ref _engineer, value.Left(30)); }
		public string rep { get => _rep; set => SetProperty(ref _rep, value.Left(30)); }
		public string sname { get => _sname; set => SetProperty(ref _sname, value.Left(25)); }
		public string saddress { get => _saddress; set => SetProperty(ref _saddress, value.Left(25)); }
		public string saddress2 { get => _saddress2; set => SetProperty(ref _saddress2, value.Left(25)); }
		public string scity { get => _scity; set => SetProperty(ref _scity, value.Left(20)); }
		public string sstate { get => _sstate; set => SetProperty(ref _sstate, value.Left(2)); }
		public string szip { get => _szip; set => SetProperty(ref _szip, value.Left(10)); }
		public string confirmto { get => _confirmto; set => SetProperty(ref _confirmto, value.Left(30)); }
		public string terms_norm { get => _terms_norm; set => SetProperty(ref _terms_norm, value); }
		public string terms_ext { get => _terms_ext; set => SetProperty(ref _terms_ext, value); }
		public DateTime? prior_to { get => _prior_to; set => SetProperty(ref _prior_to, value); }
		public int? rel_days { get => _rel_days; set => SetProperty(ref _rel_days, value); }
		public DateTime? from { get => _from; set => SetProperty(ref _from, value); }
		public DateTime? to { get => _to; set => SetProperty(ref _to, value); }
		public int? add_per { get => _add_per; set => SetProperty(ref _add_per, value); }
		public bool? printed { get => _printed; set => SetProperty(ref _printed, value); }
		public string takenby { get => _takenby; set => SetProperty(ref _takenby, value); }
		public string qstatus { get => _qstatus; set => SetProperty(ref _qstatus, value); }
		public DateTime? refaxdate { get => _refaxdate; set => SetProperty(ref _refaxdate, value); }
		public int? orderno { get => _orderno; set => SetProperty(ref _orderno, value); }
		public string reason { get => _reason; set => SetProperty(ref _reason, value); }
		public string currency { get => _currency; set => SetProperty(ref _currency, value); }
		public decimal? exrate { get => _exrate; set => SetProperty(ref _exrate, value); }
		public decimal? exrate2usd { get => _exrate2usd; set => SetProperty(ref _exrate2usd, value); }
		public decimal? brokefee { get => _brokefee; set => SetProperty(ref _brokefee, value); }
		public decimal? csubtotal { get => _csubtotal; set => SetProperty(ref _csubtotal, value); }
		public string lotprice { get => _lotprice; set => SetProperty(ref _lotprice, value); }
		public int? oldkey { get => _oldkey; set => SetProperty(ref _oldkey, value); }

		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[MyCustom(AdsIgnore = true)]
		public override object[] KeyValue => new object[] { quoteno };

		[MyCustom(AdsIgnore = true)]
		public hcust Customer { get; set; } = new hcust();

		[MyCustom(AdsIgnore = true)]
		public hrep Agency { get; set; } = new hrep();

		[MyCustom(AdsIgnore = true)]
		public string AgencyNoName => Agency.salesno == 0 ? "" : $"{Agency.salesno} - {Agency.name}";

		[MyCustom(AdsIgnore = true)]
		public IList<hqdet> Details { get; set; } = new List<hqdet>();

		[MyCustom(AdsIgnore = true)]
		public decimal Total { get; set; }

		[MyCustom(AdsIgnore = true)]
		public decimal Cost { get; set; }

		[MyCustom(AdsIgnore = true)]
		public decimal Comm { get; set; }

		[MyCustom(AdsIgnore = true)]
		public decimal AvgComm => Total == 0 ? 0 : Comm / Total;

		[MyCustom(AdsIgnore = true)]
		public decimal Margin => Total == 0 ? 0 : 1 - ((Cost + Comm) / Total);

		[MyCustom(AdsIgnore = true)]
		public string StatusWord {
			get {
				switch (qstatus) {
					case "P":
						return "Pending";
					case "O":
						return "Order";
					case "L":
						return "Loss";
					case "U":
						return "Unknown";
					default:
						return "";
				}
			}
		}

		[MyCustom(AdsIgnore = true)]
		public string StatusColor {
			get {
				switch (qstatus) {
					case "P":
						return "Orange";
					case "O":
						return "Green";
					case "L":
						return "Red";
					case "U":
						return "Blue";
					default:
						return "Black";
				}
			}
		}

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("sqlid")) sqlid = reader.ReadInt("sqlid");
			if (InFieldList("foxid")) foxid = reader.ReadInt("foxid");
			if (InFieldList("custno")) custno = reader.ReadInt("custno");
			if (InFieldList("quoteno")) quoteno = reader.ReadInt("quoteno");
			if (InFieldList("date")) date = reader.ReadDate("date");
			if (InFieldList("job_name")) job_name = reader.ReadString("job_name");
			if (InFieldList("location")) location = reader.ReadString("location");
			if (InFieldList("contractor")) contractor = reader.ReadString("contractor");
			if (InFieldList("architect")) architect = reader.ReadString("architect");
			if (InFieldList("engineer")) engineer = reader.ReadString("engineer");
			if (InFieldList("rep")) rep = reader.ReadString("rep");
			if (InFieldList("sname")) sname = reader.ReadString("sname");
			if (InFieldList("saddress")) saddress = reader.ReadString("saddress");
			if (InFieldList("saddress2")) saddress2 = reader.ReadString("saddress2");
			if (InFieldList("scity")) scity = reader.ReadString("scity");
			if (InFieldList("sstate")) sstate = reader.ReadString("sstate");
			if (InFieldList("szip")) szip = reader.ReadString("szip");
			if (InFieldList("confirmto")) confirmto = reader.ReadString("confirmto");
			if (InFieldList("terms_norm")) terms_norm = reader.ReadString("terms_norm");
			if (InFieldList("terms_ext")) terms_ext = reader.ReadString("terms_ext");
			if (InFieldList("prior_to")) prior_to = reader.ReadDate("prior_to");
			if (InFieldList("rel_days")) rel_days = reader.ReadInt("rel_days");
			if (InFieldList("from")) from = reader.ReadDate("from");
			if (InFieldList("to")) to = reader.ReadDate("to");
			if (InFieldList("add_per")) add_per = reader.ReadInt("add_per");
			if (InFieldList("printed")) printed = reader.ReadBool("printed");
			if (InFieldList("takenby")) takenby = reader.ReadString("takenby");
			if (InFieldList("qstatus")) qstatus = reader.ReadString("qstatus");
			if (InFieldList("refaxdate")) refaxdate = reader.ReadDate("refaxdate");
			if (InFieldList("orderno")) orderno = reader.ReadInt("orderno");
			if (InFieldList("reason")) reason = reader.ReadString("reason");
			if (InFieldList("currency")) currency = reader.ReadString("currency");
			if (InFieldList("exrate")) exrate = reader.ReadDecimal("exrate");
			if (InFieldList("exrate2usd")) exrate2usd = reader.ReadDecimal("exrate2usd");
			if (InFieldList("brokefee")) brokefee = reader.ReadDecimal("brokefee");
			if (InFieldList("csubtotal")) csubtotal = reader.ReadDecimal("csubtotal");
			if (InFieldList("lotprice")) lotprice = reader.ReadString("lotprice");
			if (InFieldList("oldkey")) oldkey = reader.ReadInt("oldkey");
			MakeClean();
		}

	}

}
