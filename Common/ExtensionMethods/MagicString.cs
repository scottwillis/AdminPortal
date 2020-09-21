using System;
using System.Text.RegularExpressions;

namespace Common {

	public static class MagicString {

		public const string CannotBeBlank = "Cannot be blank.";
		public const string AdsDataModel = "AdsDataModel";
		public const string DataModel = "DataModel";
		public const string EntityDataModel = "EntityDataModel";
		public const string OpenLookup = "OpenLookup";
		public const string OpenLookupCommand = "OpenLookupCommand";

		public const string CurrencyFormat = "{0:$0.00;($0.00);#.##}";
		public const string StandardCurrencyFormat = "{0:C}";
		public const string StandardCurrencyFormatNoDecimal = "{0:C0}";
        public const string TDPCurrency = "{0:n0}";

		public const string StandardCurrencyFormatDoDecimalNoZero = "{0:$0;($0);#}";

		//public const String Currency3Format = "{0:$0,0.000;($0,0.000);#.###}";
		public const string Currency3Format = "{0:$0.000;($0.000);#.###}";
		public const string IntNoZeroFormat = "{0:#}";
		public const string Percentage2Format = "{0:##.##%}";
		public const string Percentage1Format = "{0:#.#}";
		public const string DecimalNoZeroFormat = "{0:0;(0);#}";
		public const string Decimal2NoZeroFormat = "{0:0.00;(0.00);#.##}";
		public const string Decimal3NoZeroFormat = "{0:0.000;(0.000);#.###}";
		public const string SmallDateFormat = "{0:d}";
		public const string SmallDateFormat_TimeDay = "{0:g}";

		public const string CurrencyFormatString = "$0.00;($0.00);0.00";
		public const string CurrencyZeroFormatString = "$0.00;($0.00);#.##";
		public const string Percent1FormatString = "0.0;(0.0);#";
		public const string IntFormatString = "#";
		public const string PhoneMask = "###-###-####";
		public const string SsnMask = "###-##-####";

		public const string DateColumnWidth = "90";

		public const string ReSaveCurrentLayout = "-ReSave Current Layout";
		public const string SaveCurrentLayoutAs = "-Save Current Layout As...";
		public const string ResetLayoutToDefault = "-Reset Layout...";

		public const string EmailServer = "hew-com.mail.protection.outlook.com";
		public const string EmailUsername = "hewrelay@hew.com";
		public const string EmailPW = "k$=8s#&M@S6V@f";
		public const string EmailDomain = "hew.com";

		public const string ProdTrackingConnStr = "Data Source=sqlsrv08;Initial Catalog=ProductionTracking;Integrated Security=True";

		//shouldn't be here.  need another place for this....
		public static bool CompareBase(string base1, string wildCardBase) {
			if (wildCardBase == null || base1 == null) return false;
			return Regex.IsMatch(base1, WildCardToRegular(wildCardBase));
		}

		private static string WildCardToRegular(string value) {
			return "^" + Regex.Escape(value).Replace("\\?", ".").Replace("\\*", ".*").Replace("\\(","(").Replace("\\)", ")").Replace("\\|", "|") + "$";
		}

	}

}
