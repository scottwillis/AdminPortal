using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdsDataModel {

	public class hdashdet {

		public int orderno { get; set; }
		public int lineno { get; set; }
		public string itemno { get; set; }
		public DateTime schday { get; set; }
		public string schline { get; set; }
		public string ordstat { get; set; }
		public decimal? minutes { get; set; }
		public decimal? dollars { get; set; }
		public int? fixtures { get; set; }
		public int? unsch { get; set; }
		public int? rta { get; set; }
		public int? rtan { get; set; }
		public int? tdprdc { get; set; }
		public int? tdprdp { get; set; }
		public int? pdprdc { get; set; }
		public int? pdprdp { get; set; }
		public int? shipc { get; set; }
		public int? shipp { get; set; }
		public string series { get; set; }
		public string finbase { get; set; }
		public string ordermark { get; set; }

	}

}
