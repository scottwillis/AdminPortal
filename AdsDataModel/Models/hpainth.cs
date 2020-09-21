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

	public class hpainth : FoxProEntity {

		public hpainth() {
			Key = "";
		}

		private DateTime? _rundate;
		private string _runtime;
		private DateTime? _fabdate;
		private string _partno;
		private int _qty;

		[Display(AutoGenerateField = false)]
		public DateTime? rundate { get => _rundate; set => SetProperty(ref _rundate, value); }

		[Display(AutoGenerateField = false)]
		public string runtime { get => _runtime; set => SetProperty(ref _runtime, value); }

		[Display(AutoGenerateField = false)]
		public DateTime? fabdate { get => _fabdate; set => SetProperty(ref _fabdate, value); }


		[Display(Name = "Part Num.", Order = 11)]
		[MyCustom(Width = "*")]
		public string partno { get => _partno; set => SetProperty(ref _partno, value); }

		[Display(Name = "Qty", Order = 20)]
		[MyCustom(Width = "*")]
		public int qty { get => _qty; set => SetProperty(ref _qty, value); }

		[Display(Name = "Run Time", Order = 10)]
		[MyCustom(Width = "*", AdsIgnore = true)]
		public DateTime rundatetime{
			get{
				var paintDate = rundate.GetValueOrDefault();
				if(!runtime.Contains(":")) return paintDate;
				var runTimeSplit = runtime.Split(':');
				var hour = Convert.ToInt32(runTimeSplit[0]);
				var min = Convert.ToInt32(runTimeSplit[1]);
				var sec = Convert.ToInt32(runTimeSplit[2]);

				return new DateTime(paintDate.Year, paintDate.Month, paintDate.Day, hour,min, sec);
			}
		}

		[Display(Name = "Desc", Order = 12)]
		[MyCustom(Width = "*", AdsIgnore = true)]
		public String Desc { get; set; }



		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { partno, $"{rundate?.Year}{rundate?.Month}{rundate?.Day}" };




		public override void FillFromReader(AdsDataReader reader) {
			rundate = reader.ReadDate("rundate");
			runtime = reader.ReadString("runtime");
			fabdate = reader.ReadDate("fabdate");
			partno = reader.ReadString("partno");
			qty = reader.ReadInt("qty");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public IList<hpainth> GetPaintHistory(DateTime runDate){
			var qTime = DateTime.Now;
			Conn.Open();
			var entities = new List<hpainth>();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hpainth";
			var reader = cmd.ExecuteExtendedReader();
			reader.ActiveIndex = "rundate";

			var monthStr = runDate.Month.ToString().Length == 2 ? runDate.Month.ToString() : $"0{runDate.Month.ToString()}";
			var dayStr = runDate.Day.ToString().Length == 2 ? runDate.Day.ToString() : $"0{runDate.Day.ToString()}";

			var found = reader.Seek(new object[] { runDate }, AdsExtendedReader.SeekType.HardSeek);
			if (found){
				var valid = true;
				while (valid){
					var entity = new hpainth();
					entity.FillFromReader(reader);
					if (entity.rundate != null){
						if (entity.rundate != runDate) break;
						entities.Add(entity);
					}
					valid = reader.Read();
				}
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, "GetPaintHistory");
			return entities;
		}

	}

}
