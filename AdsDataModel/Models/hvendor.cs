using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Windows;
using Advantage.Data.Provider;
using Common;

namespace AdsDataModel {

	public class hvendor : FoxProEntity {

		public hvendor() {
			Key = "vendor_no";
		}

		private string _vendor_no;
		private string _vname;
		private string _vaddr1;
		private string _vaddr2;
		private string _vcity;
		private string _vstate;
		private string _vzip;
		private string _contact;
		private string _pname;
		private string _paddr1;
		private string _paddr2;
		private string _pcity;
		private string _pstate;
		private string _pzip;
		private DateTime? _lorder;
		private DateTime? _lreceived;
		private int? _ytdpaid;
		private int? _lytdpaid;
		private string _fob;
		private string _shipvia;
		private string _terms;
		private bool? _corp;
		private string _tax_no;
		private string _phone;
		private string _bname;
		private string _baddr1;
		private string _baddr2;
		private string _bcity;
		private string _bstate;
		private string _bzip;
		private string _freightco;
		private string _faxphone;
		private string _multipro;
		private int? _discount;
		private int? _discdays;
		private int? _netdays;
		private bool? _prox;
		private string _certneed;
		private DateTime? _certdate;
		private string _glacct;
		private string _notes;
		private bool _vendhold;
		private string _pro_next;
		private string _pro_end;
		private string _pro_seqs;
		private string _pro_seqe;
		private string _pro_chk;
		private string _oldkey;
		private int? _vlead;
		private string _mnda;
		private DateTime? _mndadate;

		public string vendor_no { get => _vendor_no; set => SetProperty(ref _vendor_no, value); }

		public string vname { get => _vname; set => SetProperty(ref _vname, value); }

		public string vaddr1 { get => _vaddr1; set => SetProperty(ref _vaddr1, value); }

		public string vaddr2 { get => _vaddr2; set => SetProperty(ref _vaddr2, value); }

		public string vcity { get => _vcity; set => SetProperty(ref _vcity, value); }

		public string vstate { get => _vstate; set => SetProperty(ref _vstate, value); }

		public string vzip { get => _vzip; set => SetProperty(ref _vzip, value); }

		public string contact { get => _contact; set => SetProperty(ref _contact, value); }

		public string pname { get => _pname; set => SetProperty(ref _pname, value); }

		public string paddr1 { get => _paddr1; set => SetProperty(ref _paddr1, value); }

		public string paddr2 { get => _paddr2; set => SetProperty(ref _paddr2, value); }

		public string pcity { get => _pcity; set => SetProperty(ref _pcity, value); }

		public string pstate { get => _pstate; set => SetProperty(ref _pstate, value); }

		public string pzip { get => _pzip; set => SetProperty(ref _pzip, value); }

		public DateTime? lorder { get => _lorder; set => SetProperty(ref _lorder, value); }

		public DateTime? lreceived { get => _lreceived; set => SetProperty(ref _lreceived, value); }

		public int? ytdpaid { get => _ytdpaid; set => SetProperty(ref _ytdpaid, value); }

		public int? lytdpaid { get => _lytdpaid; set => SetProperty(ref _lytdpaid, value); }

		public string fob { get => _fob; set => SetProperty(ref _fob, value); }

		public string shipvia { get => _shipvia; set => SetProperty(ref _shipvia, value); }

		public string terms { get => _terms; set => SetProperty(ref _terms, value); }

		public bool? corp { get => _corp; set => SetProperty(ref _corp, value); }

		public string tax_no { get => _tax_no; set => SetProperty(ref _tax_no, value); }

		public string phone { get => _phone; set => SetProperty(ref _phone, value); }

		public string bname { get => _bname; set => SetProperty(ref _bname, value); }

		public string baddr1 { get => _baddr1; set => SetProperty(ref _baddr1, value); }

		public string baddr2 { get => _baddr2; set => SetProperty(ref _baddr2, value); }

		public string bcity { get => _bcity; set => SetProperty(ref _bcity, value); }

		public string bstate { get => _bstate; set => SetProperty(ref _bstate, value); }

		public string bzip { get => _bzip; set => SetProperty(ref _bzip, value); }

		public string freightco { get => _freightco; set => SetProperty(ref _freightco, value); }

		public string faxphone { get => _faxphone; set => SetProperty(ref _faxphone, value); }

		public string multipro { get => _multipro; set => SetProperty(ref _multipro, value); }

		public int? discount { get => _discount; set => SetProperty(ref _discount, value); }

		public int? discdays { get => _discdays; set => SetProperty(ref _discdays, value); }

		public int? netdays { get => _netdays; set => SetProperty(ref _netdays, value); }

		public bool? prox { get => _prox; set => SetProperty(ref _prox, value); }

		public string certneed { get => _certneed; set => SetProperty(ref _certneed, value); }

		public DateTime? certdate { get => _certdate; set => SetProperty(ref _certdate, value); }

		public string glacct { get => _glacct; set => SetProperty(ref _glacct, value); }

		public string notes { get => _notes; set => SetProperty(ref _notes, value); }

		public bool vendhold { get => _vendhold; set => SetProperty(ref _vendhold, value); }

		public string pro_next { get => _pro_next; set => SetProperty(ref _pro_next, value); }

		public string pro_end { get => _pro_end; set => SetProperty(ref _pro_end, value); }

		public string pro_seqs { get => _pro_seqs; set => SetProperty(ref _pro_seqs, value); }

		public string pro_seqe { get => _pro_seqe; set => SetProperty(ref _pro_seqe, value); }

		public string pro_chk { get => _pro_chk; set => SetProperty(ref _pro_chk, value); }

		public string oldkey { get => _oldkey; set => SetProperty(ref _oldkey, value); }

		public int? vlead { get => _vlead; set => SetProperty(ref _vlead, value); }

		public string mnda { get => _mnda; set => SetProperty(ref _mnda, value); }

		public DateTime? mndadate { get => _mndadate; set => SetProperty(ref _mndadate, value); }

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public sealed override string Key { get; set; }

		[MyCustom(AdsIgnore = true)]
		[Display(AutoGenerateField = false)]
		public sealed override object[] KeyValue => new object[] { vendor_no };

		public override bool Update() {
			var context = new FoxProDataContext();
			var updated = context.Update(this);
			if (updated) {

			}
			return updated;
		}

		public override void Refresh() {
			var context = new FoxProDataContext();
			var entity = context.GetEntity<hvendor>(vendor_no);
			if (vname != entity.vname) vname = entity.vname;
			if (vaddr1 != entity.vaddr1) vaddr1 = entity.vaddr1;
			if (vaddr2 != entity.vaddr2) vaddr2 = entity.vaddr2;
			if (vcity != entity.vcity) vcity = entity.vcity;
			if (vstate != entity.vstate) vstate = entity.vstate;
			if (vzip != entity.vzip) vzip = entity.vzip;
			MakeClean();
		}

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("vendor_no")) vendor_no = reader.ReadString("vendor_no");
			if (InFieldList("vname")) vname = reader.ReadString("vname");
			if (InFieldList("vaddr1")) vaddr1 = reader.ReadString("vaddr1");
			if (InFieldList("vaddr2")) vaddr2 = reader.ReadString("vaddr2");
			if (InFieldList("vcity")) vcity = reader.ReadString("vcity");
			if (InFieldList("vstate")) vstate = reader.ReadString("vstate");
			if (InFieldList("vzip")) vzip = reader.ReadString("vzip");
			if (InFieldList("contact")) contact = reader.ReadString("contact");
			if (InFieldList("pname")) pname = reader.ReadString("pname");
			if (InFieldList("paddr1")) paddr1 = reader.ReadString("paddr1");
			if (InFieldList("paddr2")) paddr2 = reader.ReadString("paddr2");
			if (InFieldList("pcity")) pcity = reader.ReadString("pcity");
			if (InFieldList("pstate")) pstate = reader.ReadString("pstate");
			if (InFieldList("pzip")) pzip = reader.ReadString("pzip");
			if (InFieldList("lorder")) lorder = reader.ReadDate("lorder");
			if (InFieldList("lreceived")) lreceived = reader.ReadDate("lreceived");
			if (InFieldList("ytdpaid")) ytdpaid = reader.ReadInt("ytdpaid");
			if (InFieldList("lytdpaid")) lytdpaid = reader.ReadInt("lytdpaid");
			if (InFieldList("fob")) fob = reader.ReadString("fob");
			if (InFieldList("shipvia")) shipvia = reader.ReadString("shipvia");
			if (InFieldList("terms")) terms = reader.ReadString("terms");
			if (InFieldList("corp")) corp = reader.ReadBool("corp");
			if (InFieldList("tax_no")) tax_no = reader.ReadString("tax_no");
			if (InFieldList("phone")) phone = reader.ReadString("phone");
			if (InFieldList("bname")) bname = reader.ReadString("bname");
			if (InFieldList("baddr1")) baddr1 = reader.ReadString("baddr1");
			if (InFieldList("baddr2")) baddr2 = reader.ReadString("baddr2");
			if (InFieldList("bcity")) bcity = reader.ReadString("bcity");
			if (InFieldList("bstate")) bstate = reader.ReadString("bstate");
			if (InFieldList("bzip")) bzip = reader.ReadString("bzip");
			if (InFieldList("freightco")) freightco = reader.ReadString("freightco");
			if (InFieldList("faxphone")) faxphone = reader.ReadString("faxphone");
			if (InFieldList("multipro")) multipro = reader.ReadString("multipro");
			if (InFieldList("discount")) discount = reader.ReadInt("discount");
			if (InFieldList("discdays")) discdays = reader.ReadInt("discdays");
			if (InFieldList("netdays")) netdays = reader.ReadInt("netdays");
			if (InFieldList("prox")) prox = reader.ReadBool("prox");
			if (InFieldList("certneed")) certneed = reader.ReadString("certneed");
			if (InFieldList("certdate")) certdate = reader.ReadDate("certdate");
			if (InFieldList("glacct")) glacct = reader.ReadString("glacct");
			if (InFieldList("notes")) notes = reader.ReadString("notes");
			if (InFieldList("vendhold")) vendhold = reader.ReadBool("vendhold");
			if (InFieldList("pro_next")) pro_next = reader.ReadString("pro_next");
			if (InFieldList("pro_end")) pro_end = reader.ReadString("pro_end");
			if (InFieldList("pro_seqs")) pro_seqs = reader.ReadString("pro_seqs");
			if (InFieldList("pro_seqe")) pro_seqe = reader.ReadString("pro_seqe");
			if (InFieldList("pro_chk")) pro_chk = reader.ReadString("pro_chk");
			if (InFieldList("oldkey")) oldkey = reader.ReadString("oldkey");
			if (InFieldList("vlead")) vlead = reader.ReadInt("vlead");
			if (InFieldList("mnda")) mnda = reader.ReadString("mnda");
			if (InFieldList("mndadate")) mndadate = reader.ReadDate("mndadate");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public hvendor GetVendor(string no) {
			var qTime = DateTime.Now;
			var sql = $"select * from hvendor where vendor_no='{no}'";
			var entity = GetEntitySql<hvendor>(sql);
			QueryDebugEnd(qTime, $"GetVendor - {sql}");
			return entity;
		}

	}

}
