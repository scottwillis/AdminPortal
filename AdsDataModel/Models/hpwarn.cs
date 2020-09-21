using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdsDataModel {

	public class hpwarn {
		public int sqlid { get; set; }
		public int foxid { get; set; }
		public string queop { get; set; }
		public string emp_no { get; set; }
		public string lname { get; set; }
		public string dept { get; set; }
		public DateTime? date { get; set; }
		public int rule { get; set; }
		public string descr { get; set; }
		public string descr2 { get; set; }
		public string descr3 { get; set; }
		public string descr4 { get; set; }
		public string descr5 { get; set; }
		public string descr6 { get; set; }
		public DateTime? warndate { get; set; }
		public string warn_no { get; set; }
		public string issuedby { get; set; }
		public DateTime? suspdate { get; set; }
		public DateTime? backdate { get; set; }
		public DateTime? invaldate { get; set; }
		public decimal apoints { get; set; }
	}

}
