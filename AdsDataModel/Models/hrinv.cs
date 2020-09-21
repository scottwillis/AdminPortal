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

	public class hrinv : FoxProEntity {

		public hrinv() {
			Key = "itemno";
		}

		private string _itemno;
		private string _desc;
		private string _desc2;
		private decimal? _fifo;
		private decimal? _weight;
		private int? _ord_pt;
		private int? _ord_qty;
		private decimal? _on_hand;
		private decimal? _alloc;
		private int? _on_order;
		private int? _avglead;
		private int? _avgmonthly;
		private int? _avgyearly;
		private decimal? _lprice;
		private decimal? _qprice;
		private string _unit;
		private decimal? _sqftprice;
		private decimal? _cuft;
		private decimal? _sqft;
		private string _pvendor;
		private decimal? _thick;
		private string _obsolete;
		private int? _cutlevel;
		private string _msds;
		private DateTime? _msds_date;
		private decimal? _on_handdef;
		private int? _on_order2;
		private string _autopo;
		private string _oldkey;
		private string _location;
		private string _rev;
		private string _glcode;
		private string _dwgname;
		private string _rpent;
		private DateTime? _rpentdt;
		private string _rpchg;
		private DateTime? _rpchgdt;
		private string _notes;
		private string _pwunit;
		private string _ledcomp;
		private string _obsdate;
		//private DateTime? _obsdate;

		public string itemno { get => _itemno; set => SetProperty(ref _itemno, value); }

		public string desc { get => _desc; set => SetProperty(ref _desc, value); }

		public string desc2 { get => _desc2; set => SetProperty(ref _desc2, value); }

		public decimal? fifo { get => _fifo; set => SetProperty(ref _fifo, value); }

		public decimal? weight { get => _weight; set => SetProperty(ref _weight, value); }

		public int? ord_pt { get => _ord_pt; set => SetProperty(ref _ord_pt, value); }

		public int? ord_qty { get => _ord_qty; set => SetProperty(ref _ord_qty, value); }

		public decimal? on_hand { get => _on_hand; set => SetProperty(ref _on_hand, value); }

		public decimal? alloc { get => _alloc; set => SetProperty(ref _alloc, value); }

		public int? on_order { get => _on_order; set => SetProperty(ref _on_order, value); }

		public int? avglead { get => _avglead; set => SetProperty(ref _avglead, value); }

		public int? avgmonthly { get => _avgmonthly; set => SetProperty(ref _avgmonthly, value); }

		public int? avgyearly { get => _avgyearly; set => SetProperty(ref _avgyearly, value); }

		public decimal? lprice { get => _lprice; set => SetProperty(ref _lprice, value); }

		public decimal? qprice { get => _qprice; set => SetProperty(ref _qprice, value); }

		public string unit { get => _unit; set => SetProperty(ref _unit, value); }

		public decimal? sqftprice { get => _sqftprice; set => SetProperty(ref _sqftprice, value); }

		public decimal? cuft { get => _cuft; set => SetProperty(ref _cuft, value); }

		public decimal? sqft { get => _sqft; set => SetProperty(ref _sqft, value); }

		public string pvendor { get => _pvendor; set => SetProperty(ref _pvendor, value); }

		public decimal? thick { get => _thick; set => SetProperty(ref _thick, value); }

		public string obsolete { get => _obsolete; set => SetProperty(ref _obsolete, value); }

		public int? cutlevel { get => _cutlevel; set => SetProperty(ref _cutlevel, value); }

		public string msds { get => _msds; set => SetProperty(ref _msds, value); }

		public DateTime? msds_date { get => _msds_date; set => SetProperty(ref _msds_date, value); }

		public decimal? on_handdef { get => _on_handdef; set => SetProperty(ref _on_handdef, value); }

		public int? on_order2 { get => _on_order2; set => SetProperty(ref _on_order2, value); }

		public string autopo { get => _autopo; set => SetProperty(ref _autopo, value); }

		public string oldkey { get => _oldkey; set => SetProperty(ref _oldkey, value); }

		public string location { get => _location; set => SetProperty(ref _location, value); }

		public string rev { get => _rev; set => SetProperty(ref _rev, value); }

		public string glcode { get => _glcode; set => SetProperty(ref _glcode, value); }

		public string dwgname { get => _dwgname; set => SetProperty(ref _dwgname, value); }

		public string rpent { get => _rpent; set => SetProperty(ref _rpent, value); }

		public DateTime? rpentdt { get => _rpentdt; set => SetProperty(ref _rpentdt, value); }

		public string rpchg { get => _rpchg; set => SetProperty(ref _rpchg, value); }

		public DateTime? rpchgdt { get => _rpchgdt; set => SetProperty(ref _rpchgdt, value); }

		public string notes { get => _notes; set => SetProperty(ref _notes, value); }

		public string pwunit { get => _pwunit; set => SetProperty(ref _pwunit, value); }

		public string ledcomp { get => _ledcomp; set => SetProperty(ref _ledcomp, value); }

		public string obsdate { get => _obsdate; set => SetProperty(ref _obsdate, value); }
		//public DateTime? obsdate { get => _obsdate; set { _obsdate = value; OnPropertyChanged(); } }

		public sealed override string Key { get; set; }

		public sealed override object[] KeyValue => new object[] { itemno };

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("itemno")) itemno = reader.ReadString("itemno");
			if (InFieldList("desc")) desc = reader.ReadString("desc");
			if (InFieldList("desc2")) desc2 = reader.ReadString("desc2");
			if (InFieldList("fifo")) fifo = reader.ReadDecimal("fifo");
			if (InFieldList("weight")) weight = reader.ReadDecimal("weight");
			if (InFieldList("ord_pt")) ord_pt = reader.ReadInt("ord_pt");
			if (InFieldList("ord_qty")) ord_qty = reader.ReadInt("ord_qty");
			if (InFieldList("on_hand")) on_hand = reader.ReadDecimal("on_hand");
			if (InFieldList("alloc")) alloc = reader.ReadDecimal("alloc");
			if (InFieldList("on_order")) on_order = reader.ReadInt("on_order");
			if (InFieldList("avglead")) avglead = reader.ReadInt("avglead");
			if (InFieldList("avgmonthly")) avgmonthly = reader.ReadInt("avgmonthly");
			if (InFieldList("avgyearly")) avgyearly = reader.ReadInt("avgyearly");
			if (InFieldList("lprice")) lprice = reader.ReadDecimal("lprice");
			if (InFieldList("qprice")) qprice = reader.ReadDecimal("qprice");
			if (InFieldList("unit")) unit = reader.ReadString("unit");
			if (InFieldList("sqftprice")) sqftprice = reader.ReadDecimal("sqftprice");
			if (InFieldList("cuft")) cuft = reader.ReadDecimal("cuft");
			if (InFieldList("sqft")) sqft = reader.ReadDecimal("sqft");
			if (InFieldList("pvendor")) pvendor = reader.ReadString("pvendor");
			if (InFieldList("thick")) thick = reader.ReadDecimal("thick");
			if (InFieldList("obsolete")) obsolete = reader.ReadString("obsolete");
			if (InFieldList("cutlevel")) cutlevel = reader.ReadInt("cutlevel");
			if (InFieldList("msds")) msds = reader.ReadString("msds");
			if (InFieldList("msds_date")) msds_date = reader.ReadDate("msds_date");
			if (InFieldList("on_handdef")) on_handdef = reader.ReadDecimal("on_handdef");
			if (InFieldList("on_order2")) on_order2 = reader.ReadInt("on_order2");
			if (InFieldList("autopo")) autopo = reader.ReadString("autopo");
			if (InFieldList("oldkey")) oldkey = reader.ReadString("oldkey");
			if (InFieldList("location")) location = reader.ReadString("location");
			if (InFieldList("rev")) rev = reader.ReadString("rev");
			if (InFieldList("glcode")) glcode = reader.ReadString("glcode");
			if (InFieldList("dwgname")) dwgname = reader.ReadString("dwgname");
			if (InFieldList("rpent")) rpent = reader.ReadString("rpent");
			if (InFieldList("rpentdt")) rpentdt = reader.ReadDate("rpentdt");
			if (InFieldList("rpchg")) rpchg = reader.ReadString("rpchg");
			if (InFieldList("rpchgdt")) rpchgdt = reader.ReadDate("rpchgdt");
			if (InFieldList("notes")) notes = reader.ReadString("notes");
			if (InFieldList("pwunit")) pwunit = reader.ReadString("pwunit");
			if (InFieldList("ledcomp")) ledcomp = reader.ReadString("ledcomp");
			if (InFieldList("obsdate")) obsdate = reader.ReadString("obsdate");
			//if (InFieldList("obsdate")) obsdate = reader.ReadDate("obsdate");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public string GetRawInventoryDesc(string _itemno, ref decimal _cost) {
			var qTime = DateTime.Now;
			Conn.Open();
			var desc = "";
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hrinv";
			var reader = cmd.ExecuteExtendedReader();
			reader.ActiveIndex = "itemno";
			var found = reader.Seek(new object[] { _itemno }, AdsExtendedReader.SeekType.HardSeek);
			if (found) {
				//var valid = true;
				//while (valid) {
					//var itemno = reader.ReadString("itemno");
					var fifo = reader.ReadDecimal("fifo");
					_cost = Math.Round(fifo, 2);
					desc = reader.ReadString("desc2");
					//if (itemno != _itemno) break;
					//var entity = new hfinvbm();
					//entity.FillFromReader(reader);
					//entities.Add(entity);
					//valid = reader.Read();
				//}
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetRawInventoryDesc");
			return desc;
		}

		public hrinv GetRaw(string itemno) {
			Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandText = $"select * from hrinv where itemno='{itemno}'";
			var reader = cmd.ExecuteReader();
			var entity = new hrinv();
			while (reader.Read()) {
				entity.FillFromReader(reader);
				break;
			}
			reader.Close();
			Conn.Close();
			return entity;
		}

	}

}
