using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel {

	public class hemphrs {
		public int sqlid { get; set; }
		public int foxid { get; set; }
		public string queop { get; set; }
		public string emp_no { get; set; }
		public string cocode { get; set; }
		public string dept { get; set; }
		public DateTime? prdate { get; set; }
		public decimal reg { get; set; }
		public decimal ot { get; set; }
		public decimal reg_adj { get; set; }
		public decimal ot_adj { get; set; }
		public decimal vachrs { get; set; }
		public decimal holhrs { get; set; }
	}

}
