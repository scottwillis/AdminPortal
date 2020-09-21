using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdsDataModel {

	public class hpvac {
		public int sqlid { get; set; }
		public int foxid { get; set; }
		public string queop { get; set; }
		public string emp_no { get; set; }
		public DateTime? start { get; set; }
		public DateTime? end { get; set; }
		public decimal hrs_worked { get; set; }
		public decimal hrs_earned { get; set; }
		public decimal hrs_taken { get; set; }
		public DateTime? wk_end { get; set; }
		public string comments { get; set; }
		public string check_date { get; set; }
		public string check_no { get; set; }
	}

}
