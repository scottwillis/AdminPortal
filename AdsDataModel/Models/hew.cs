using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Advantage.Data.Provider;
using Common;

namespace AdsDataModel {

	public class hew : FoxProEntity {

		public hew() {
			Key = "orderno";
		}

		private DateTime? _routedate;
		private int? _orderno;
		private int? _qnumber;
		private int? _wipnumber;
		private int? _shopwo;
		private int? _productno;
		private int? _mproductno;
		private int? _invoiceno;
		private int? _cashno;
		private int? _ponumber;
		private int? _recv_no;
		private int? _ap_no;
		private int? _vendor_no;
		private decimal? _salestax;
		private decimal? _sched_out;
		private decimal? _arfuture;
		private decimal? _arcurrent;
		private decimal? _ar1_30;
		private decimal? _ar31_60;
		private decimal? _ar61_90;
		private decimal? _arover90;
		private DateTime? _prlockdate;
		private decimal? _lifolabor;
		private decimal? _fifolabor;
		private decimal? _lifopaint;
		private decimal? _fifopaint;
		private decimal? _lifowaste;
		private decimal? _fifowaste;
		private decimal? _min_sqft;
		private decimal? _frtcost;
		private bool? _ordprint;
		private string _polltype;
		private string _pollpg;
		private string _line1;
		private string _line2;
		private string _line3;
		private string _line4;
		private string _line5;
		private string _line6;
		private DateTime? _glclose;
		private DateTime? _prclose;
		private int? _tt_fedpy;
		private int? _tt_stapy;
		private int? _tt_ficpy;
		private int? _tt_fedmax;
		private int? _tt_stamax;
		private int? _tt_ficmax;
		private int? _tt_medmax;
		private decimal? _tt_ficrate;
		private decimal? _tt_medrate;
		private decimal? _tt_ficlim;
		private int? _tt_sdeds;
		private int? _tt_sdedm;
		private int? _tt_sallow;
		private int? _tt_callow;
		private decimal? _fx_ctax;
		private decimal? _fx_cduty;
		private string _gltime;
		private string _fabcalc;
		private int? _porec;
		private int? _cmno;
		private int? _trkldno;
		private DateTime? _schcutoff;
		private int? _mreplprod;

		public DateTime? routedate { get => _routedate; set => SetProperty(ref _routedate, value); }
		public int? orderno { get => _orderno; set => SetProperty(ref _orderno, value); }
		public int? qnumber { get => _qnumber; set => SetProperty(ref _qnumber, value); }
		public int? wipnumber { get => _wipnumber; set => SetProperty(ref _wipnumber, value); }
		public int? shopwo { get => _shopwo; set => SetProperty(ref _shopwo, value); }
		public int? productno { get => _productno; set => SetProperty(ref _productno, value); }
		public int? mproductno { get => _mproductno; set => SetProperty(ref _mproductno, value); }
		public int? invoiceno { get => _invoiceno; set => SetProperty(ref _invoiceno, value); }
		public int? cashno { get => _cashno; set => SetProperty(ref _cashno, value); }
		public int? ponumber { get => _ponumber; set => SetProperty(ref _ponumber, value); }
		public int? recv_no { get => _recv_no; set => SetProperty(ref _recv_no, value); }
		public int? ap_no { get => _ap_no; set => SetProperty(ref _ap_no, value); }
		public int? vendor_no { get => _vendor_no; set => SetProperty(ref _vendor_no, value); }
		public decimal? salestax { get => _salestax; set => SetProperty(ref _salestax, value); }
		public decimal? sched_out { get => _sched_out; set => SetProperty(ref _sched_out, value); }
		public decimal? arfuture { get => _arfuture; set => SetProperty(ref _arfuture, value); }
		public decimal? arcurrent { get => _arcurrent; set => SetProperty(ref _arcurrent, value); }
		public decimal? ar1_30 { get => _ar1_30; set => SetProperty(ref _ar1_30, value); }
		public decimal? ar31_60 { get => _ar31_60; set => SetProperty(ref _ar31_60, value); }
		public decimal? ar61_90 { get => _ar61_90; set => SetProperty(ref _ar61_90, value); }
		public decimal? arover90 { get => _arover90; set => SetProperty(ref _arover90, value); }
		public DateTime? prlockdate { get => _prlockdate; set => SetProperty(ref _prlockdate, value); }
		public decimal? lifolabor { get => _lifolabor; set => SetProperty(ref _lifolabor, value); }
		public decimal? fifolabor { get => _fifolabor; set => SetProperty(ref _fifolabor, value); }
		public decimal? lifopaint { get => _lifopaint; set => SetProperty(ref _lifopaint, value); }
		public decimal? fifopaint { get => _fifopaint; set => SetProperty(ref _fifopaint, value); }
		public decimal? lifowaste { get => _lifowaste; set => SetProperty(ref _lifowaste, value); }
		public decimal? fifowaste { get => _fifowaste; set => SetProperty(ref _fifowaste, value); }
		public decimal? min_sqft { get => _min_sqft; set => SetProperty(ref _min_sqft, value); }
		public decimal? frtcost { get => _frtcost; set => SetProperty(ref _frtcost, value); }
		public bool? ordprint { get => _ordprint; set => SetProperty(ref _ordprint, value); }
		public string polltype { get => _polltype; set => SetProperty(ref _polltype, value); }
		public string pollpg { get => _pollpg; set => SetProperty(ref _pollpg, value); }
		public string line1 { get => _line1; set => SetProperty(ref _line1, value); }
		public string line2 { get => _line2; set => SetProperty(ref _line2, value); }
		public string line3 { get => _line3; set => SetProperty(ref _line3, value); }
		public string line4 { get => _line4; set => SetProperty(ref _line4, value); }
		public string line5 { get => _line5; set => SetProperty(ref _line5, value); }
		public string line6 { get => _line6; set => SetProperty(ref _line6, value); }
		public DateTime? glclose { get => _glclose; set => SetProperty(ref _glclose, value); }
		public DateTime? prclose { get => _prclose; set => SetProperty(ref _prclose, value); }
		public int? tt_fedpy { get => _tt_fedpy; set => SetProperty(ref _tt_fedpy, value); }
		public int? tt_stapy { get => _tt_stapy; set => SetProperty(ref _tt_stapy, value); }
		public int? tt_ficpy { get => _tt_ficpy; set => SetProperty(ref _tt_ficpy, value); }
		public int? tt_fedmax { get => _tt_fedmax; set => SetProperty(ref _tt_fedmax, value); }
		public int? tt_stamax { get => _tt_stamax; set => SetProperty(ref _tt_stamax, value); }
		public int? tt_ficmax { get => _tt_ficmax; set => SetProperty(ref _tt_ficmax, value); }
		public int? tt_medmax { get => _tt_medmax; set => SetProperty(ref _tt_medmax, value); }
		public decimal? tt_ficrate { get => _tt_ficrate; set => SetProperty(ref _tt_ficrate, value); }
		public decimal? tt_medrate { get => _tt_medrate; set => SetProperty(ref _tt_medrate, value); }
		public decimal? tt_ficlim { get => _tt_ficlim; set => SetProperty(ref _tt_ficlim, value); }
		public int? tt_sdeds { get => _tt_sdeds; set => SetProperty(ref _tt_sdeds, value); }
		public int? tt_sdedm { get => _tt_sdedm; set => SetProperty(ref _tt_sdedm, value); }
		public int? tt_sallow { get => _tt_sallow; set => SetProperty(ref _tt_sallow, value); }
		public int? tt_callow { get => _tt_callow; set => SetProperty(ref _tt_callow, value); }
		public decimal? fx_ctax { get => _fx_ctax; set => SetProperty(ref _fx_ctax, value); }
		public decimal? fx_cduty { get => _fx_cduty; set => SetProperty(ref _fx_cduty, value); }
		public string gltime { get => _gltime; set => SetProperty(ref _gltime, value); }
		public string fabcalc { get => _fabcalc; set => SetProperty(ref _fabcalc, value); }
		public int? porec { get => _porec; set => SetProperty(ref _porec, value); }
		public int? cmno { get => _cmno; set => SetProperty(ref _cmno, value); }
		public int? trkldno { get => _trkldno; set => SetProperty(ref _trkldno, value); }
		public DateTime? schcutoff { get => schcutoff; set => SetProperty(ref _schcutoff, value); }

		public int? mreplprod { get => _mreplprod; set => SetProperty(ref _mreplprod, value); }


		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { orderno };

		public override void FillFromReader(AdsDataReader reader) {
			routedate = reader.ReadDate(reader.GetOrdinal("routedate"));
			orderno = reader.ReadInt(reader.GetOrdinal("orderno"));
			qnumber = reader.ReadInt(reader.GetOrdinal("qnumber"));
			wipnumber = reader.ReadInt(reader.GetOrdinal("wipnumber"));
			shopwo = reader.ReadInt(reader.GetOrdinal("shopwo"));
			productno = reader.ReadInt(reader.GetOrdinal("productno"));
			mproductno = reader.ReadInt(reader.GetOrdinal("mproductno"));
			invoiceno = reader.ReadInt(reader.GetOrdinal("invoiceno"));
			cashno = reader.ReadInt(reader.GetOrdinal("cashno"));
			ponumber = reader.ReadInt(reader.GetOrdinal("ponumber"));
			recv_no = reader.ReadInt(reader.GetOrdinal("recv_no"));
			ap_no = reader.ReadInt(reader.GetOrdinal("ap_no"));
			vendor_no = reader.ReadInt(reader.GetOrdinal("vendor_no"));
			salestax = reader.ReadDecimal(reader.GetOrdinal("salestax"));
			sched_out = reader.ReadDecimal(reader.GetOrdinal("sched_out"));
			arfuture = reader.ReadDecimal(reader.GetOrdinal("arfuture"));
			arcurrent = reader.ReadDecimal(reader.GetOrdinal("arcurrent"));
			ar1_30 = reader.ReadDecimal(reader.GetOrdinal("ar1_30"));
			ar31_60 = reader.ReadDecimal(reader.GetOrdinal("ar31_60"));
			ar61_90 = reader.ReadDecimal(reader.GetOrdinal("ar61_90"));
			arover90 = reader.ReadDecimal(reader.GetOrdinal("arover90"));
			prlockdate = reader.ReadDate(reader.GetOrdinal("prlockdate"));
			lifolabor = reader.ReadDecimal(reader.GetOrdinal("lifolabor"));
			fifolabor = reader.ReadDecimal(reader.GetOrdinal("fifolabor"));
			lifopaint = reader.ReadDecimal(reader.GetOrdinal("lifopaint"));
			fifopaint = reader.ReadDecimal(reader.GetOrdinal("fifopaint"));
			lifowaste = reader.ReadDecimal(reader.GetOrdinal("lifowaste"));
			fifowaste = reader.ReadDecimal(reader.GetOrdinal("fifowaste"));
			min_sqft = reader.ReadDecimal(reader.GetOrdinal("min_sqft"));
			frtcost = reader.ReadDecimal(reader.GetOrdinal("frtcost"));
			ordprint = reader.ReadBool(reader.GetOrdinal("ordprint"));
			polltype = reader.ReadString(reader.GetOrdinal("polltype"));
			pollpg = reader.ReadString(reader.GetOrdinal("pollpg"));
			line1 = reader.ReadString(reader.GetOrdinal("line1"));
			line2 = reader.ReadString(reader.GetOrdinal("line2"));
			line3 = reader.ReadString(reader.GetOrdinal("line3"));
			line4 = reader.ReadString(reader.GetOrdinal("line4"));
			line5 = reader.ReadString(reader.GetOrdinal("line5"));
			line6 = reader.ReadString(reader.GetOrdinal("line6"));
			glclose = reader.ReadDate(reader.GetOrdinal("glclose"));
			prclose = reader.ReadDate(reader.GetOrdinal("prclose"));
			tt_fedpy = reader.ReadInt(reader.GetOrdinal("tt_fedpy"));
			tt_stapy = reader.ReadInt(reader.GetOrdinal("tt_stapy"));
			tt_ficpy = reader.ReadInt(reader.GetOrdinal("tt_ficpy"));
			tt_fedmax = reader.ReadInt(reader.GetOrdinal("tt_fedmax"));
			tt_stamax = reader.ReadInt(reader.GetOrdinal("tt_stamax"));
			tt_ficmax = reader.ReadInt(reader.GetOrdinal("tt_ficmax"));
			tt_medmax = reader.ReadInt(reader.GetOrdinal("tt_medmax"));
			tt_ficrate = reader.ReadDecimal(reader.GetOrdinal("tt_ficrate"));
			tt_medrate = reader.ReadDecimal(reader.GetOrdinal("tt_medrate"));
			tt_ficlim = reader.ReadDecimal(reader.GetOrdinal("tt_ficlim"));
			tt_sdeds = reader.ReadInt(reader.GetOrdinal("tt_sdeds"));
			tt_sdedm = reader.ReadInt(reader.GetOrdinal("tt_sdedm"));
			tt_sallow = reader.ReadInt(reader.GetOrdinal("tt_sallow"));
			tt_callow = reader.ReadInt(reader.GetOrdinal("tt_callow"));
			fx_ctax = reader.ReadDecimal(reader.GetOrdinal("fx_ctax"));
			fx_cduty = reader.ReadDecimal(reader.GetOrdinal("fx_cduty"));
			gltime = reader.ReadString(reader.GetOrdinal("gltime"));
			fabcalc = reader.ReadString(reader.GetOrdinal("fabcalc"));
			porec = reader.ReadInt(reader.GetOrdinal("porec"));
			cmno = reader.ReadInt(reader.GetOrdinal("cmno"));
			trkldno = reader.ReadInt(reader.GetOrdinal("trkldno"));
			schcutoff = reader.ReadDate(reader.GetOrdinal("schcutoff"));
			mreplprod = reader.ReadInt(reader.GetOrdinal("mreplprod"));
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public int GetNextOrderNo() {
			var qTime = DateTime.Now;
			var nextNo = 0;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			var table = "hew";
			cmd.CommandText = table;
			cmd.CommandType = CommandType.TableDirect;
			var rdr = cmd.ExecuteExtendedReader();
			rdr.Read();
			if (rdr.FoxRecordLock(table)) {
				nextNo = rdr.ReadInt("orderno");
				rdr.SetInt32(rdr.GetOrdinal("orderno"), nextNo + 1);
				rdr.WriteRecord();
				rdr.UnlockRecord();
			}
			rdr.Close();
			Conn.Close();
			QueryDebugEnd(qTime, "GetNextOrderNo");
			return nextNo;
		}

		//public int GetNext90ProductNo() {
		//	return GetNext90ProductNo(true);
		//}

		public int GetNext90ProductNo(bool live) {
			var qTime = DateTime.Now;
			var nextNo = 0;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			var table = live ? "hew" : "xew";
			cmd.CommandText = table;
			cmd.CommandType = CommandType.TableDirect;
			var rdr = cmd.ExecuteExtendedReader();
			rdr.Read();
			if (rdr.FoxRecordLock(table)) {
				nextNo = rdr.ReadInt("productno");
				rdr.SetInt32(rdr.GetOrdinal("productno"), nextNo + 1);
				rdr.WriteRecord();
				rdr.UnlockRecord();
			}
			rdr.Close();
			Conn.Close();
			QueryDebugEnd(qTime, "GetNext90ProductNo");
			return nextNo;
		}

		public int GetNext92ProductNo() {
			return GetNext92ProductNo(true);
		}

		public int GetNext92ProductNo(bool live) {
			var qTime = DateTime.Now;
			var nextNo = 0;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			var table = live ? "hew" : "xew";
			cmd.CommandText = table;
			cmd.CommandType = CommandType.TableDirect;
			var rdr = cmd.ExecuteExtendedReader();
			rdr.Read();
			if (rdr.FoxRecordLock(table)) {
				nextNo = rdr.ReadInt("mproductno");
				rdr.SetInt32(rdr.GetOrdinal("mproductno"), nextNo + 1);
				rdr.WriteRecord();
				rdr.UnlockRecord();
			}
			rdr.Close();
			Conn.Close();
			QueryDebugEnd(qTime, "GetNext92ProductNo");
			return nextNo;
		}

		public int GetNext9209ProductNo() {
			return GetNext9209ProductNo(true);
		}

		public int GetNext9209ProductNo(bool live) {
			var qTime = DateTime.Now;
			var nextNo = 0;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			var table = live ? "hew" : "xew";
			cmd.CommandText = table;
			cmd.CommandType = CommandType.TableDirect;
			var rdr = cmd.ExecuteExtendedReader();
			rdr.Read();
			if (rdr.FoxRecordLock(table)) {
				nextNo = rdr.ReadInt("mreplprod");
				rdr.SetInt32(rdr.GetOrdinal("mreplprod"), nextNo + 1);
				rdr.WriteRecord();
				rdr.UnlockRecord();
			}
			rdr.Close();
			Conn.Close();
			QueryDebugEnd(qTime, "GetNext9209ProductNo");
			return nextNo;
		}

	}

}

