using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Advantage.Data.Provider;
using Common;

namespace AdsDataModel {

	public class hpronum : FoxProEntity {

		public hpronum() {
			Key = "pronum";
		}

		private string _pronum;
		private string _fvendor;
		private int _orderno;
		private int _apNo;
		private string _paid;

		[Display(AutoGenerateField = false)]
		public string pronum { get => _pronum; set => SetProperty(ref _pronum, value); }

		[Display(AutoGenerateField = false)]
		public string fvendor { get => _fvendor; set => SetProperty(ref _fvendor, value); }

		[Display(AutoGenerateField = false)]
		public int orderno { get => _orderno; set => SetProperty(ref _orderno, value); }

		[Display(AutoGenerateField = false)]
		public int ap_no { get => _apNo; set => SetProperty(ref _apNo, value); }

		[Display(AutoGenerateField = false)]
		public string paid { get => _paid; set => SetProperty(ref _paid, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { ap_no };

		public override void FillFromReader(AdsDataReader reader) {
			pronum = reader.ReadString("pronum");
			fvendor = reader.ReadString("fvendor");
			orderno = reader.ReadInt("orderno");
			ap_no = reader.ReadInt("ap_no");
			paid = reader.ReadString("paid");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public IList<hpronum> GetOrderPronums(int no) {
			var qTime = DateTime.Now;
			var sql = $"select * from hpronum where orderno={no} order by pronum";
			var entities = GetEntities<hpronum>(sql);
			QueryDebugEnd(qTime, $"GetOrderPronums - {sql}");
			return entities;
		}

	}

}
