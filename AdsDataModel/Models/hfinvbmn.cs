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

	public class hfinvbmn : FoxProEntity {

		public hfinvbmn() {
			Key = "";
		}


		private string _itemno;
		private string _version;
		private string _note;

		[Display(Name = "ItemNo", Order = 10)]
		[MyCustom(Width = "*", IsVisible = true)]
		public string itemno { get => _itemno; set => SetProperty(ref _itemno, value); }

		[Display(Name = "Version", Order = 10)]
		[MyCustom(Width = "*", IsVisible = true)]
		public string version { get => _version; set => SetProperty(ref _version, value); }

		[Display(Name = "Note", Order = 10)]
		[MyCustom(Width = "*", IsVisible = true)]
		public string note { get => _note; set => SetProperty(ref _note, value); }


		public sealed override string Key { get; set; }

		public sealed override object[] KeyValue => new object[] { itemno, version};



		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("itemno")) itemno = reader.ReadString("itemno");
			if (InFieldList("version")) version = reader.ReadString("version");
			if (InFieldList("note")) note = reader.ReadString("note");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

	}

}
