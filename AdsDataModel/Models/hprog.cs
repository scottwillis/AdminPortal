using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdsDataModel {

	public class hprog {
		public int sqlid { get; set; }
		public int foxid { get; set; }
		public string queop { get; set; }
		public string emp_no { get; set; }
		public DateTime? date { get; set; }
		public DateTime? prog_date { get; set; }
		public string union { get; set; }
		public decimal base_rate { get; set; }
		public decimal new_base { get; set; }
		public decimal or_old { get; set; }
		public decimal or_new { get; set; }
		public string type { get; set; }
		public string auth { get; set; }
		public string comments { get; set; }
	}

}
