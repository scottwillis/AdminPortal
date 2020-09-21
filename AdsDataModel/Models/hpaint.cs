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

	public class hpaint : FoxProEntity {

		public hpaint() {
			Key = "";
		}

		private int _workorder;
		private string _partno;
		private string _desc;
		private int _qtyon;
		private string _comment;
		private string _multline;


		[Display(AutoGenerateField = false)]
		public int workorder { get => _workorder; set => SetProperty(ref _workorder, value); }

		[Display(AutoGenerateField = false)]
		public string partno { get => _partno; set => SetProperty(ref _partno, value); }

		[Display(AutoGenerateField = false)]
		public string desc { get => _desc; set => SetProperty(ref _desc, value); }

		[Display(AutoGenerateField = false)]
		public int qtyon { get => _qtyon; set => SetProperty(ref _qtyon, value); }

		[Display(AutoGenerateField = false)]
		public string comment { get => _comment; set => SetProperty(ref _comment, value); } //Time data

		[Display(AutoGenerateField = false)]
		public string multline { get => _multline; set => SetProperty(ref _multline, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { partno};

		public override void FillFromReader(AdsDataReader reader) {
			workorder = reader.ReadInt("workorder");
			partno = reader.ReadString("partno");
			desc = reader.ReadString("desc");
			qtyon = reader.ReadInt("qtyon");
			comment = reader.ReadString("comment");
			multline = reader.ReadString("multline");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

	}

}
