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

	public class hprod : FoxProEntity {

		public hprod() {
			Key = "";
		}

		private int? _orderno;
		private int? _itemno;
		private DateTime? _date;
		private string _start;
		private string _stop;
		private int? _no_emps;
		private string _line;
		private string _shift;
		private int? _qty;
		private int? _p1qty;
		private int? _p2qty;
		private string _wasprod;
		private string _finpartno;
		private string _plasman;
		private string _empno;
		private string _partused;
		private string _partused2;
		private string _partused3;

		public int? orderno { get => _orderno; set => SetProperty(ref _orderno, value); }

		public int? itemno { get => _itemno; set => SetProperty(ref _itemno, value); }

		public DateTime? date { get => _date; set => SetProperty(ref _date, value); }

		public string start { get => _start; set => SetProperty(ref _start, value); }

		public string stop { get => _stop; set => SetProperty(ref _stop, value); }

		public int? no_emps { get => _no_emps; set => SetProperty(ref _no_emps, value); }

		public string line { get => _line; set => SetProperty(ref _line, value); }

		public string shift { get => _shift; set => SetProperty(ref _shift, value); }

		public int? qty { get => _qty; set => SetProperty(ref _qty, value); }

		public int? p1qty { get => _p1qty; set => SetProperty(ref _p1qty, value); }

		public int? p2qty { get => _p2qty; set => SetProperty(ref _p2qty, value); }

		public string wasprod { get => _wasprod; set => SetProperty(ref _wasprod, value); }

		public string finpartno { get => _finpartno; set => SetProperty(ref _finpartno, value); }

		public string plasman { get => _plasman; set => SetProperty(ref _plasman, value); }

		public string empno { get => _empno; set => SetProperty(ref _empno, value); }

		public string partused { get => _partused; set => SetProperty(ref _partused, value); }

		public string partused2 { get => _partused2; set => SetProperty(ref _partused2, value); }

		public string partused3 { get => _partused3; set => SetProperty(ref _partused3, value); }

		[MyCustom(AdsIgnore = true)]
		public DateTime StartTime{
			get{
				var hour = start.Substring(0, 2);
				var min = start.Substring(2, 2);

				return new DateTime(date.GetValueOrDefault().Year, date.GetValueOrDefault().Month, date.GetValueOrDefault().Day, Convert.ToInt32(hour), Convert.ToInt32(min), 0);
			}
		}

		[MyCustom(AdsIgnore = true)]
		public DateTime StopTime {
			get {
				var hour = stop.Substring(0, 2);
				var min = stop.Substring(2, 2);

				return new DateTime(date.GetValueOrDefault().Year, date.GetValueOrDefault().Month, date.GetValueOrDefault().Day, Convert.ToInt32(hour), Convert.ToInt32(min), 0);
			}
		}



		public sealed override string Key { get; set; }

		public sealed override object[] KeyValue => new object[] { itemno };

		public override void FillFromReader(AdsDataReader reader) {
			orderno = reader.ReadInt(reader.GetOrdinal("orderno"));
			itemno = reader.ReadInt(reader.GetOrdinal("itemno"));
			date = reader.ReadDate(reader.GetOrdinal("date"));
			start = reader.ReadString(reader.GetOrdinal("start"));
			stop = reader.ReadString(reader.GetOrdinal("stop"));
			no_emps = reader.ReadInt(reader.GetOrdinal("no_emps"));
			line = reader.ReadString(reader.GetOrdinal("line"));
			shift = reader.ReadString(reader.GetOrdinal("shift"));
			qty = reader.ReadInt(reader.GetOrdinal("qty"));
			p1qty = reader.ReadInt(reader.GetOrdinal("p1qty"));
			p2qty = reader.ReadInt(reader.GetOrdinal("p2qty"));
			wasprod = reader.ReadString(reader.GetOrdinal("wasprod"));
			finpartno = reader.ReadString(reader.GetOrdinal("finpartno"));
			plasman = reader.ReadString(reader.GetOrdinal("plasman"));
			empno = reader.ReadString(reader.GetOrdinal("empno"));
			partused = reader.ReadString(reader.GetOrdinal("partused"));
			partused2 = reader.ReadString(reader.GetOrdinal("partused2"));
			partused3 = reader.ReadString(reader.GetOrdinal("partused3"));
			MakeClean();
		}

	}

	public partial class FoxProDataContext{
		public IList<hprod> GetAssyLineProdRecords(DateTime date, string assyLine, string shift){
			var qTime = DateTime.Now;
			Conn.Open();
			var entities = new List<hprod>();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hprod";
			var reader = cmd.ExecuteExtendedReader();
			reader.ActiveIndex = "datelnsh";

			var found = reader.Seek(new object[] { date, assyLine, shift }, AdsExtendedReader.SeekType.HardSeek);
			if (found){
				var valid = true;
				while (valid){
					var entity = new hprod();
					entity.FillFromReader(reader);
					if(entity.date != null && !String.IsNullOrEmpty(entity.line) && !String.IsNullOrEmpty(entity.shift)){
						if (entity.date.GetValueOrDefault().Date != date.Date || entity.line.Trim() != assyLine.Trim() || entity.shift.Trim() != shift.Trim()) break;
						entities.Add(entity);


					}
					valid = reader.Read();
				}
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, "GetAssyLineProdRecords");
			return entities;
		}

		public IList<hprod> GetAssyLineProdRecords(int orderNo, int orderLineNo){
			var qTime = DateTime.Now;
			Conn.Open();
			var entities = new List<hprod>();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hprod";
			var reader = cmd.ExecuteExtendedReader();
			reader.ActiveIndex = "orditem";

			var found = reader.Seek(new object[] { orderNo, orderLineNo }, AdsExtendedReader.SeekType.HardSeek);
			if (found){
				var valid = true;
				while (valid){
					var entity = new hprod();
					entity.FillFromReader(reader);
					if (entity.orderno != null && entity.itemno != null){
						if (entity.orderno == orderNo && entity.itemno == orderLineNo) entities.Add(entity);
						else break;
					}
					valid = reader.Read();
				}
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, "GetAssyLineProdRecords");
			return entities;



		}

	}


}
