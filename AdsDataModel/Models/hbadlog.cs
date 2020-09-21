using System;

namespace AdsDataModel {

	public class hbadlog {
		public int orderno { get; set; }
		public int lineno { get; set; }
		public string aline { get; set; }
		public DateTime schday { get; set; }
		public string partno { get; set; }
		public string parttype { get; set; }
		public string desc { get; set; }
		public int? needed { get; set; }
		public int? onhand { get; set; }
		public int? alloc { get; set; }
	}

}
