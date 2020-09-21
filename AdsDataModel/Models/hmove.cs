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

	public class hmove : FoxProEntity {

		public hmove() {
			Key = "date";
		}

		private int? _orderno;
		private string _fr;
		private string _to;
		private string _start;
		private string _stop;
		private int? _made;
		private int? _scrap;
		private string _reasonscr;
		private int? _adjamt;
		private string _empno;
		private int? _no_emps;
		private DateTime? _date;
		private string _partno;
		private string _usedscrap;
		private string _timestamp;
		private string _locto;
		private string _locfrom;
		private int? _machused;

		public int? orderno { get => _orderno; set => SetProperty(ref _orderno, value); }
		public string fr { get => _fr; set => SetProperty(ref _fr, value); }
		public string to { get => _to; set => SetProperty(ref _to, value); }
		public string start { get => _start; set => SetProperty(ref _start, value); }
		public string stop { get => _stop; set => SetProperty(ref _stop, value); }
		public int? made { get => _made; set => SetProperty(ref _made, value); }
		public int? scrap { get => _scrap; set => SetProperty(ref _scrap, value); }
		public string reasonscr { get => _reasonscr; set => SetProperty(ref _reasonscr, value); }
		public int? adjamt { get => _adjamt; set => SetProperty(ref _adjamt, value); }
		public string empno { get => _empno; set => SetProperty(ref _empno, value); }
		public int? no_emps { get => _no_emps; set => SetProperty(ref _no_emps, value); }
		public DateTime? date { get => _date; set => SetProperty(ref _date, value); }
		public string partno { get => _partno; set => SetProperty(ref _partno, value); }
		public string usedscrap { get => _usedscrap; set => SetProperty(ref _usedscrap, value); }
		public string timestamp { get => _timestamp; set => SetProperty(ref _timestamp, value); }
		public string locto { get => _locto; set => SetProperty(ref _locto, value); }
		public string locfrom { get => _locfrom; set => SetProperty(ref _locfrom, value); }
		public int? machused { get => _machused; set => SetProperty(ref _machused, value); }

		[MyCustom(AdsIgnore = true)]
		public DateTime? StartTime{
			get{
				if (String.IsNullOrEmpty(start)) return null;
				var hour = start.Substring(0, 2);
				var min = start.Substring(2, 2);

				return new DateTime(date.GetValueOrDefault().Year, date.GetValueOrDefault().Month, date.GetValueOrDefault().Day, Convert.ToInt32(hour), Convert.ToInt32(min), 0);
			}
		}

		[MyCustom(AdsIgnore = true)]
		public DateTime? StopTime {
			get {
				if (String.IsNullOrEmpty(stop)) return null;
				var hour = stop.Substring(0, 2);
				var min = stop.Substring(2, 2);

				return new DateTime(date.GetValueOrDefault().Year, date.GetValueOrDefault().Month, date.GetValueOrDefault().Day, Convert.ToInt32(hour), Convert.ToInt32(min), 0);
			}
		}



		public sealed override string Key { get; set; }

		public sealed override object[] KeyValue => new object[] { date };

		public override void FillFromReader(AdsDataReader reader) {
			orderno = reader.ReadInt(reader.GetOrdinal("orderno"));
			fr = reader.ReadString(reader.GetOrdinal("fr"));
			to = reader.ReadString(reader.GetOrdinal("to"));
			start = reader.ReadString(reader.GetOrdinal("start"));
			stop = reader.ReadString(reader.GetOrdinal("stop"));
			made = reader.ReadInt(reader.GetOrdinal("made"));
			scrap = reader.ReadInt(reader.GetOrdinal("scrap"));
			reasonscr = reader.ReadString(reader.GetOrdinal("reasonscr"));
			adjamt = reader.ReadInt(reader.GetOrdinal("adjamt"));
			empno = reader.ReadString(reader.GetOrdinal("empno"));
			no_emps = reader.ReadInt(reader.GetOrdinal("no_emps"));
			date = reader.ReadDate(reader.GetOrdinal("date"));
			partno = reader.ReadString(reader.GetOrdinal("partno"));
			usedscrap = reader.ReadString(reader.GetOrdinal("usedscrap"));
			timestamp = reader.ReadString(reader.GetOrdinal("timestamp"));
			locto = reader.ReadString(reader.GetOrdinal("locto"));
			locfrom = reader.ReadString(reader.GetOrdinal("locfrom"));
			machused = reader.ReadInt(reader.GetOrdinal("machused"));
			MakeClean();
		}

		

	}

	public partial class FoxProDataContext {

		public IList<hmove> GetMoveRecords(DateTime startDate, DateTime endDate) {
			var qTime = DateTime.Now;
			Conn.Open();
			var entities = new List<hmove>();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hmove";
			var reader = cmd.ExecuteExtendedReader();
			reader.ActiveIndex = "date";
			var found = false;
			while (!found) {
				found = reader.Seek(new object[] { startDate }, AdsExtendedReader.SeekType.HardSeek);
				if (!found) startDate = startDate.AddDays(1);
				if (startDate > endDate) return entities;
			}
			if (found) {
				while (true) {
					var moveDate = reader.ReadDate("date");
					System.Diagnostics.Debug.Print(moveDate.GetValueOrDefault().ToString());
					if (moveDate > endDate) break;
					var entity = new hmove();
					entity.FillFromReader(reader);
					entities.Add(entity);
					var valid = reader.Read();
					if (!valid) break;
				}
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetFinishedInventories");
			return entities;
		}

	}


	}
