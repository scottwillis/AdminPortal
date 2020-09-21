using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using Advantage.Data.Provider;

namespace AdsDataModel {

	public class hnotpart : FoxProEntity {

		public hnotpart() {
			Key = "partno";
		}

		public string desc { get; set; }

		public string partno { get; set; }

		//public string term { get; set; }

		public decimal alloc { get; set; }

		public string note { get; set; }

		public sealed override string Key { get; set; }

		public sealed override object[] KeyValue => new object[] { partno };

		public override void FillFromReader(AdsDataReader reader) {
			desc = reader.ReadString("desc");
			partno = reader.ReadString("partno");
			//term = reader.ReadString("term");
			alloc = reader.ReadDecimal("alloc");
			note = reader.ReadString("note");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		

	}

}
