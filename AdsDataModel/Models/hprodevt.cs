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

	public class hprodevt : FoxProEntity {

		public hprodevt() {
			Key = "";
		}

		private int? _orderno;
		private int? _lineno;
		private DateTime? _eventdate;
		private string _eventtime;
		private string _reportedby;
		private string _detection;
		private string _category1;
		private string _category2;
		private string _comment;
		private string _aline;

		public int? orderno { get => _orderno; set => SetProperty(ref _orderno, value); }
		public int? lineno { get => _lineno; set => SetProperty(ref _lineno, value); }
		public DateTime? eventdate { get => _eventdate; set => SetProperty(ref _eventdate, value); }
		public string eventtime { get => _eventtime; set => SetProperty(ref _eventtime, value); }
		public string reportedby { get => _reportedby; set => SetProperty(ref _reportedby, value); }
		public string detection { get => _detection; set => SetProperty(ref _detection, value); }
		public string category1 { get => _category1; set => SetProperty(ref _category1, value); }
		public string category2 { get => _category2; set => SetProperty(ref _category2, value); }
		public string comment { get => _comment; set => SetProperty(ref _comment, value); }
		public string aline { get => _aline; set => SetProperty(ref _aline, value); }

		[MyCustom(AdsIgnore = true)]
		public DateTime? eventDateTime{
			get{
				if (eventdate == null || String.IsNullOrEmpty(eventtime)) return null;
				var timeSplit = eventtime.Split(':');

				return new DateTime(eventdate.Value.Year, eventdate.Value.Month, eventdate.Value.Day, Convert.ToInt32(timeSplit[0]), Convert.ToInt32(timeSplit[1]), Convert.ToInt32(timeSplit[2]));
			}
		}

		[MyCustom(AdsIgnore = true)]
		public string desc { get; set; }

		[MyCustom(AdsIgnore = true)]
		public string finItemNum { get; set; }
		[MyCustom(AdsIgnore = true)]
		public string prodSeries { get; set; }



		public sealed override string Key { get; set; }

		public sealed override object[] KeyValue => new object[] {  };

		public override void FillFromReader(AdsDataReader reader) {
			orderno = reader.ReadInt(reader.GetOrdinal("orderno"));
			lineno = reader.ReadInt(reader.GetOrdinal("lineno"));
			eventdate = reader.ReadDate(reader.GetOrdinal("eventdate"));
			eventtime = reader.ReadString(reader.GetOrdinal("eventtime"));
			reportedby = reader.ReadString(reader.GetOrdinal("reportedby"));
			detection = reader.ReadString(reader.GetOrdinal("detection"));
			category1 = reader.ReadString(reader.GetOrdinal("category1"));
			category2 = reader.ReadString(reader.GetOrdinal("category2"));
			comment = reader.ReadString(reader.GetOrdinal("comment"));
			aline = reader.ReadString(reader.GetOrdinal("aline"));
			MakeClean();
		}

	}

	public partial class FoxProDataContext{
		public IList<hprodevt> GetProdDisruptEvents(DateTime startDate, DateTime endDate){
			//May need to add an index on the event date field in the future to allow direct reading using a hardseek.
			var sql = $"select * from hprodevt where eventdate >= ctod('{startDate.Month}/{startDate.Day}/{startDate.Year}') and eventdate <= ctod('{endDate.Month}/{endDate.Day}/{endDate.Year}')";
			return GetEntitiesSql<hprodevt>(sql, new List<string>(){"*"});
		}


		public IList<hprodevt> GetProdDisruptEvents(int orderNum, int orderLineNum){
			var sql = $"select * from hprodevt where orderno = {orderNum} and lineno = {orderLineNum}";
			return GetEntitiesSql<hprodevt>(sql, new List<string>() { "*" });
		}

	}


}
