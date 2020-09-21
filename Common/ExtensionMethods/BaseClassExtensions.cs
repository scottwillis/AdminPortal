using System;
using System.Text;
using System.Text.RegularExpressions;
//using System.Data.Entity.Design.PluralizationServices;
using System.Globalization;
using Humanizer;

namespace Common {

	public static class BaseClassExtensions {

		//static readonly PluralizationService PluralizationService = PluralizationService.CreateService(CultureInfo.GetCultureInfo("en-us"));

		public static int ToInt(this string value) {
			if (string.IsNullOrEmpty(value)) return 0;
			var valid = int.TryParse(value, out var x);
			return valid ? x : 0;
		}

		#region String

		public static string Between(this string value, string left, string right) {
			var i1 = value.IndexOf(left) + 1;
			var i2 = value.IndexOf(right);
			var l = i2 - i1;
			return value.Substring(i1, l);
		}
		public static string Left(this string value, int max) {
			return value == null ? "" : value.Length > max ? value.Substring(0, max) : value;
		}

		public static string Truncate(this string value, int maxLength) {
			if (string.IsNullOrEmpty(value)) return value;
			return value.Length <= maxLength ? value : value.Substring(0, maxLength);
		}

		public static bool ToBoolean(this string value) {
			return (value == "Y" || value == "T");
		}

		public static string ToFoxProBooleanYn(this string value) {
			return (value == "1") ? "Y" : "N";
		}

		public static string ToFoxProReg(this string value) {
			return (value == "0") ? "R" : "T";
		}

		public static string ToFoxProMarital(this string value) {
			return (value == "1") ? "M" : "S";
		}

		public static string ToFoxProSex(this string value) {
			return (value == "1") ? "F" : "M";
		}

		public static string ToFoxProBoolean(this string value) {
			return (value == "1") ? "T" : "F";
		}

		public static Gender ToGender(this string value) {
			return (value == "M") ? Gender.Male : Gender.Female;
		}

		public static Marital ToMarital(this string value) {
			return (value == "S") ? Marital.Single : Marital.Married;
		}

		public static StatusType ToStatusType(this string value) {
			return (value == "T" || value == "I") ? StatusType.Inactive : StatusType.Active;
		}

		public static DateTime? ToDateFromCSVString(this string myDate) {
			var newDate = (myDate == null) ? (DateTime?)null : new DateTime(Convert.ToInt32(myDate.Substring(0, 4)), Convert.ToInt32(myDate.Substring(4, 2)), Convert.ToInt32(myDate.Substring(6, 2)));
			if (newDate < new DateTime(1900, 1, 1) || newDate > new DateTime(2100, 1, 1)) newDate = null;
			return newDate;
		}

		public static string ToFoxSQLCompare(this string myString) {
			myString = myString.Replace("\"", "").ToLower();
			return myString;
		}

		public static string ToSingular(this string plural) {
			return plural.Singularize();
			//return PluralizationService.Singularize(plural);
		}

		public static string ToPlural(this string singular) {
			return singular != null ? singular.EndsWith("Status")? singular : singular.Pluralize() : string.Empty;
			//return (singular != null) ? PluralizationService.Pluralize(singular) : string.Empty;
		}

		public static string ToSentenceCase(this string message) {
			if (!string.IsNullOrEmpty(message)) {
				const string pattern = @"[^\s]\.[\s\\n\\r]+[a-z]";
				message = message.ToLower();
				int capturePosition;
				Capture capture;
				var messageArray = message.ToCharArray();
				var ms = Regex.Matches(message, pattern);
				for (int i = 0; i < ms.Count; i++) {
					capture = ms[i].Captures[0];
					capturePosition = capture.Index + capture.Value.Length - 1;
					messageArray[capturePosition] = char.ToUpper(messageArray[capturePosition]);
				}
				ms = Regex.Matches(message, @"^[\s\\r]*[a-z]");
				if (ms.Count > 0) {
					capture = ms[0].Captures[0];
					capturePosition = capture.Index + capture.Value.Length - 1;
					messageArray[capturePosition] = char.ToUpper(messageArray[capturePosition]);
				}
				message = new string(messageArray);
				message = message.Replace(" rO", " Ro").Replace(" rU", " Ru").Replace(" pO", " Po"); //quick fix. Regex messed up???
			}
			return message;
		}

		public static string ToTitleCase(this string myString) {
			myString = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(myString.ToLower());
			myString = myString.Replace("Cr ", "CR ").Replace("Nd ", "nd ").Replace("Rd ", "rd ").Replace("Th ", "th ").Replace("Po ", "PO ");
			//if (myString.StartsWith("Mc")) myString = 
			return myString;
		}

		public static string ToSpacedWordsFromPascalCase(this string value) {
			var space = " ";
			if (value.Length == 0) return value;
			var stringBuilder = new StringBuilder(value.Length);
			stringBuilder.Append(value[0]);
			for (var index = 1; index < value.Length; index++) {
				var c = value[index];
				if (char.IsUpper(c)) stringBuilder.Append(space);
				stringBuilder.Append(c);
			}
			return stringBuilder.ToString().Replace("DataModel.", "");
		}

		#endregion String

		public static DateTime? ToNullIfInvalidFoxDate(this DateTime? myDate) {
			return (myDate <= new DateTime(1899, 12, 30)) ? null : myDate;
		}

		public static decimal? ToNullIfZero(this decimal? value) {
			if (value == 0) return null;
			return value != null ? Math.Round(value.Value, 0) : value;
		}

	}

}
