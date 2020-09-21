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

	public class hwpdet : FoxProEntity {

		public hwpdet() {
			Key = "partno";
		}

		private string _partno;
		private string _op;
		private string _desc;
		private int? _m1;
		private int? _m2;
		private string _toolno;
		private string _loc;
		private decimal? _min;
		private string _dept;
		private decimal? _fifolabor;
		private decimal? _fifomat;
		private string _code;
		private int? _onhand;
		private int? _alloc;
		private int? _ropoint;
		private int? _roqty;
		private string _partgroup;
		private decimal? _lprice;
		private decimal? _price;
		private decimal? _qprice;
		private int? _on_order;
		private string _notes;
		private int? _avg3mo;
		private int? _avg6mo;
		private int? _avg12mo;
		private decimal? _stdmin;
		private string _partop;
		private string _tdesc;
		private string _kanban;
		private string _phantom;
		private int? _safeqty;
		private int? _on_order2;
		private string _borp;
		private string _rev;
		private int? _ord_pt;
		private int? _ord_qty;
		private string _pvendor;
		private string _autopo;
		private decimal? _bestavgmin;
		private string _pwunit;
		private string _lotreq;

		public string partno { get => _partno; set => SetProperty(ref _partno, value); }

		public string op { get => _op; set => SetProperty(ref _op, value); }

		public string desc { get => _desc; set => SetProperty(ref _desc, value); }

		public int? m1 { get => _m1; set => SetProperty(ref _m1, value); }

		public int? m2 { get => _m2; set => SetProperty(ref _m2, value); }

		public string toolno { get => _toolno; set => SetProperty(ref _toolno, value); }

		public string loc { get => _loc; set => SetProperty(ref _loc, value); }

		public decimal? min { get => _min; set => SetProperty(ref _min, value); }

		public string dept { get => _dept; set => SetProperty(ref _dept, value); }

		public decimal? fifolabor { get => _fifolabor; set => SetProperty(ref _fifolabor, value); }

		public decimal? fifomat { get => _fifomat; set => SetProperty(ref _fifomat, value); }

		public string code { get => _code; set => SetProperty(ref _code, value); }

		public int? onhand { get => _onhand; set => SetProperty(ref _onhand, value); }

		public int? alloc { get => _alloc; set => SetProperty(ref _alloc, value); }

		public int? ropoint { get => _ropoint; set => SetProperty(ref _ropoint, value); }

		public int? roqty { get => _roqty; set => SetProperty(ref _roqty, value); }

		public string partgroup { get => _partgroup; set => SetProperty(ref _partgroup, value); }

		public decimal? lprice { get => _lprice; set => SetProperty(ref _lprice, value); }

		public decimal? price { get => _price; set => SetProperty(ref _price, value); }

		public decimal? qprice { get => _qprice; set => SetProperty(ref _qprice, value); }

		public int? on_order { get => _on_order; set => SetProperty(ref _on_order, value); }

		public string notes { get => _notes; set => SetProperty(ref _notes, value); }

		public int? avg3mo { get => _avg3mo; set => SetProperty(ref _avg3mo, value); }

		public int? avg6mo { get => _avg6mo; set => SetProperty(ref _avg6mo, value); }

		public int? avg12mo { get => _avg12mo; set => SetProperty(ref _avg12mo, value); }

		public decimal? stdmin { get => _stdmin; set => SetProperty(ref _stdmin, value); }

		public string partop { get => _partop; set => SetProperty(ref _partop, value); }

		public string tdesc { get => _tdesc; set => SetProperty(ref _tdesc, value); }

		public string kanban { get => _kanban; set => SetProperty(ref _kanban, value); }

		public string phantom { get => _phantom; set => SetProperty(ref _phantom, value); }

		public int? safeqty { get => _safeqty; set => SetProperty(ref _safeqty, value); }

		public int? on_order2 { get => _on_order2; set => SetProperty(ref _on_order2, value); }

		public string borp { get => _borp; set => SetProperty(ref _borp, value); }

		public string rev { get => _rev; set => SetProperty(ref _rev, value); }

		public int? ord_pt { get => _ord_pt; set => SetProperty(ref _ord_pt, value); }

		public int? ord_qty { get => _ord_qty; set => SetProperty(ref _ord_qty, value); }

		public string pvendor { get => _pvendor; set => SetProperty(ref _pvendor, value); }

		public string autopo { get => _autopo; set => SetProperty(ref _autopo, value); }

		public decimal? bestavgmin { get => _bestavgmin; set => SetProperty(ref _bestavgmin, value); }

		public string pwunit { get => _pwunit; set => SetProperty(ref _pwunit, value); }

		public string lotreq { get => _lotreq; set => SetProperty(ref _lotreq, value); }

		public sealed override string Key { get; set; }

		public sealed override object[] KeyValue => new object[] { partno};

		public override void FillFromReader(AdsDataReader reader) {
			partno = reader.ReadString(reader.GetOrdinal("partno"));
			op = reader.ReadString(reader.GetOrdinal("op"));
			desc = reader.ReadString(reader.GetOrdinal("desc"));
			m1 = reader.ReadInt(reader.GetOrdinal("m1"));
			m2 = reader.ReadInt(reader.GetOrdinal("m2"));
			toolno = reader.ReadString(reader.GetOrdinal("toolno"));
			loc = reader.ReadString(reader.GetOrdinal("loc"));
			min = reader.ReadDecimal(reader.GetOrdinal("min"));
			dept = reader.ReadString(reader.GetOrdinal("dept"));
			fifolabor = reader.ReadDecimal(reader.GetOrdinal("fifolabor"));
			fifomat = reader.ReadDecimal(reader.GetOrdinal("fifomat"));
			code = reader.ReadString(reader.GetOrdinal("code"));
			onhand = reader.ReadInt(reader.GetOrdinal("onhand"));
			alloc = reader.ReadInt(reader.GetOrdinal("alloc"));
			ropoint = reader.ReadInt(reader.GetOrdinal("ropoint"));
			roqty = reader.ReadInt(reader.GetOrdinal("roqty"));
			partgroup = reader.ReadString(reader.GetOrdinal("partgroup"));
			lprice = reader.ReadDecimal(reader.GetOrdinal("lprice"));
			price = reader.ReadDecimal(reader.GetOrdinal("price"));
			qprice = reader.ReadDecimal(reader.GetOrdinal("qprice"));
			on_order = reader.ReadInt(reader.GetOrdinal("on_order"));
			notes = reader.ReadString(reader.GetOrdinal("notes"));
			avg3mo = reader.ReadInt(reader.GetOrdinal("avg3mo"));
			avg6mo = reader.ReadInt(reader.GetOrdinal("avg6mo"));
			avg12mo = reader.ReadInt(reader.GetOrdinal("avg12mo"));
			stdmin = reader.ReadDecimal(reader.GetOrdinal("stdmin"));
			partop = reader.ReadString(reader.GetOrdinal("partop"));
			tdesc = reader.ReadString(reader.GetOrdinal("tdesc"));
			kanban = reader.ReadString(reader.GetOrdinal("kanban"));
			phantom = reader.ReadString(reader.GetOrdinal("phantom"));
			safeqty = reader.ReadInt(reader.GetOrdinal("safeqty"));
			on_order2 = reader.ReadInt(reader.GetOrdinal("on_order2"));
			borp = reader.ReadString(reader.GetOrdinal("borp"));
			rev = reader.ReadString(reader.GetOrdinal("rev"));
			ord_pt = reader.ReadInt(reader.GetOrdinal("ord_pt"));
			ord_qty = reader.ReadInt(reader.GetOrdinal("ord_qty"));
			pvendor = reader.ReadString(reader.GetOrdinal("pvendor"));
			autopo = reader.ReadString(reader.GetOrdinal("autopo"));
			bestavgmin = reader.ReadDecimal(reader.GetOrdinal("bestavgmin"));
			pwunit = reader.ReadString(reader.GetOrdinal("pwunit"));
			lotreq = reader.ReadString(reader.GetOrdinal("lotreq"));
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public string GetWipDetailInventoryDesc(string _partop, ref decimal _cost) {
			var qTime = DateTime.Now;
			Conn.Open();
			var desc = "";
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hwpdet";
			var reader = cmd.ExecuteExtendedReader();
			reader.ActiveIndex = "partop";
			var found = reader.Seek(new object[] { _partop }, AdsExtendedReader.SeekType.HardSeek);
			if (found) {
				//var valid = true;
				//while (valid) {
				//var itemno = reader.ReadString("itemno");
				var fifolabor = reader.ReadDecimal("fifolabor");
				var fifomat = reader.ReadDecimal("fifomat");
				_cost = Math.Round(fifolabor + fifomat, 2);
				desc = reader.ReadString("tdesc");
				//if (itemno != _itemno) break;
				//var entity = new hfinvbm();
				//entity.FillFromReader(reader);
				//entities.Add(entity);
				//valid = reader.Read();
				//}
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetWipDetailInventoryDesc");
			return desc;
		}

		public hwpdet GetWipDetail(string partno, string opno) {
			var sql = $"select * from hwpdet where partno='{partno}' AND op = '{opno}'";
			var entity = GetEntitySql<hwpdet>(sql);
			return entity;
		}

	}

}
