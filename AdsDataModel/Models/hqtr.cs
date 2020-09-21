using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using Advantage.Data.Provider;
using Common;

namespace AdsDataModel {

	public class hqtr : FoxProEntity {

		private int _year;
		private int _month;
		private DateTime _date;

		public hqtr() {
			Key = "yrmn";
		}

		public int year { get => _year; set => SetProperty(ref _year, value); }

		public int month { get => _month; set => SetProperty(ref _month, value); }

		public DateTime date { get => _date; set => SetProperty(ref _date, value); }

		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { year, month };

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("year")) year = reader.ReadInt("year");
			if (InFieldList("month")) month = reader.ReadInt("month");
			if (InFieldList("date")) date = reader.ReadDateNotNull("date");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public DateTime GetStartOfYearDate(int year) {
			var qTime = DateTime.Now;
			var date = new DateTime(year, 1,1);
			var sql = $"select * from hqtr where year={year - 1}";
			var entities = GetEntitiesSql<hqtr>(sql, new List<string>()).OrderBy(x => x.month);
			var dec = entities.LastOrDefault();
			if (dec != null) {
				var decLastDay = dec.date;
				if (decLastDay != DateTime.Today) {
					date = decLastDay.AddDays(1);
				}
			}
			QueryDebugEnd(qTime, $"{GetMethodName()} - {sql}");
			return date;
		}

		public Quarters GetQuarters(int year) {
			var qTime = DateTime.Now;
			var quarters = new Quarters();
			quarters.Qtr1Start = GetStartOfYearDate(year);
			var sql = $"select * from hqtr where year={year}";
			var qtrs = GetEntitiesSql<hqtr>(sql, new List<string>()).OrderBy(x => x.month);
			quarters.Qtr1End = qtrs.First(x => x.month == 3).date;
			quarters.Qtr2Start = quarters.Qtr1End.AddDays(1);
			quarters.Qtr2End = qtrs.First(x => x.month == 6).date;
			quarters.Qtr3Start = quarters.Qtr2End.AddDays(1);
			quarters.Qtr3End = qtrs.First(x => x.month == 9).date;
			quarters.Qtr4Start = quarters.Qtr3End.AddDays(1);
			quarters.Qtr4End = qtrs.First(x => x.month == 12).date;
			QueryDebugEnd(qTime, $"{GetMethodName()} - {sql}");
			return quarters;
		}

	}

	public class Quarters {

		public DateTime Qtr1Start { get; set; }

		public DateTime Qtr1End { get; set; }

		public DateTime Qtr2Start { get; set; }

		public DateTime Qtr2End { get; set; }

		public DateTime Qtr3Start { get; set; }

		public DateTime Qtr3End { get; set; }

		public DateTime Qtr4Start { get; set; }

		public DateTime Qtr4End { get; set; }

	}

}
