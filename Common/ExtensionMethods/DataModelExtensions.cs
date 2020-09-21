using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Common {

	public static class DataModelExtensions {

		public static string ToPhone(this string value) {
			return !string.IsNullOrEmpty(value) ? $"{long.Parse(value.FromDash()):###-###-####}" : null;
		}

		public static string ToSsn(this string value) {
			return !string.IsNullOrEmpty(value) ? value.FromDash().Insert(3, "-").Insert(6, "-") : null;
		}

		public static string FromDash(this string value) {
			return !string.IsNullOrEmpty(value) ? value.Replace("-", "") : null;
		}

		public static string ToDateString(this DateTime? value) {
			return value == null ? "" : value.GetValueOrDefault().ToString("d");
		}

		public static List<T> GetAttributes<T>(this ICustomAttributeProvider pi) where T : Attribute {
			return pi.GetCustomAttributes(typeof(T), false).OfType<T>().Select(a => a).ToList();
		}

		public static T GetAttribute<T>(this ICustomAttributeProvider cap) where T : Attribute {
			var atts = cap.GetAttributes<T>();
			return (atts.Count > 0) ? atts[0] : null;
		}

		public static T GetAttribute<T>(PropertyInfo pi) where T : Attribute {
			var atts = pi.GetAttributes<T>();
			return (atts.Count > 0) ? atts[0] : null;
		}

	}

}

