using System;

namespace Common {

	public class CommissionCode {

		public string Code { get; set; }

		public int Percent { get; set; }

		public string CodeAndPercent => string.IsNullOrEmpty(Code) || Code == "X" ? "X" : $"{Code} {Percent}%";

		public double Amount { get; set; }

		public string PercentAndAmount => $"{Code} {Percent}%{(Math.Abs(Amount) > 0 ? $" {Amount:c}" : "")}";

		public string PercentString => $"{Percent}%";

	}

}