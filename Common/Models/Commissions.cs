using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common {

	public static class Commissions {

		public static List<CommissionCode> CommissionCodes { get; set; } = new List<CommissionCode> {
			new CommissionCode { Code = "D", Percent = 1 },
			new CommissionCode { Code = "E", Percent = 2 },
			new CommissionCode { Code = "F", Percent = 3 },
			new CommissionCode { Code = "G", Percent = 4 },
			new CommissionCode { Code = "H", Percent = 5 },
			new CommissionCode { Code = "I", Percent = 6 },
			new CommissionCode { Code = "J", Percent = 7 },
			new CommissionCode { Code = "K", Percent = 8 },
			new CommissionCode { Code = "L", Percent = 9 },
			new CommissionCode { Code = "M", Percent = 10 },
			new CommissionCode { Code = "X", Percent = 0 },
		};

		public static decimal GetCommission(string code, int qty, decimal price) {
			if (string.IsNullOrEmpty(code)) return 0m;
			var pct = GetCommissionPercentFromCode(code.ToUpper()) / 100m;
			var com = price == 0 ? 0 : pct * (price * qty);
			return Math.Round(com, 2);
		}

		public static string GetCommissionCodeFromPercent(decimal percent) {
			return CommissionCodes.First(x => x.Percent == percent).Code;
		}

		public static int GetCommissionPercentFromCode(string code) {
			return string.IsNullOrEmpty(code) ? 0 : CommissionCodes.First(x => x.Code == code).Percent;
		}

		public static decimal GetOverage(decimal price, decimal priceBase, int qty, int pct) {
			var total = 0m;
			if (price > priceBase && priceBase > 0) { // && CommissionCode.Percent >= OvgPercentBase) {
				var ovgAmount = (price - priceBase) * qty;
				var comper = .9m;
				if (pct > 0) comper = (decimal) pct / 100;
				total = Math.Round(ovgAmount * comper, 2);
			}
			return total;
		}

		public static decimal GetTotalOverage(decimal price, decimal priceBase, int qty) {
			var total = 0m;
			if (price > priceBase && priceBase > 0) {
				total = (price - priceBase) * qty;
			}
			return total;
		}

		public static int GetMargin(string code, int qty, decimal price, decimal cost) {
			if (string.IsNullOrEmpty(code)) return 0;
			var pct = GetCommissionPercentFromCode(code.ToUpper());
			var mar = qty == 0 || price == 0 ? 0 : ((1 - (((decimal)pct / 100 * price) + cost) / price) * 100);
			var extCost = Math.Round((qty * cost), 2);
			if (extCost == 0) mar = 0;
			return (int)Math.Round(mar, 0);
		}

	}

}
