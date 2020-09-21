using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToLdap;
using LinqToLdap.Collections;

namespace Common {

	public static class DomainUser {

		private const string Ldap = "OU=HEW Users,DC=Williams,DC=Hew,DC=com";
		private const string DirectoryName = "williams.hew.com";
		private const string Groups = "memberof";
	
		public const string OuCentral = "OU=Central Groups,DC=williams,DC=hew,DC=com";
		public const string OuHewDist = "OU=HEW Distribution Lists,DC=williams,DC=hew,DC=com";
		public const string OuHewGroups = "OU=HEW Groups,DC=williams,DC=hew,DC=com";
		public const string CnUsers = "CN=Users,DC=williams,DC=hew,DC=com";

		public const string CentralAdministration = "Central - Administration";
		public const string CentralHR = "Central - HR";
		public const string CentralMain = "Central - Main";
		public const string CentralLEDCalculatorMaintenance = "Central - LED Calculator Maintenance";
		public const string CentralPackagingMaintenance = "Central - Packaging Maintenance";
		public const string CentralProductMaintenance = "Central - Product Maintenance";
		public const string CentralWebMaintenance = "Central - Web Maintenance";
		public const string CentralSchematicMaintenance = "Central - Schematic Maintenance";
		public const string CentralQuotes = "Central - Quotes";
		public const string CentralAgencies = "Central - Agencies";
		public const string CentralQualityAdmin = "Central - Quality Admin";
		public const string CentralApplications = "Central - Applications";
		public const string CentralLinearJobs = "Central - Linear Jobs";
		public const string CentralPoeJobs = "Central - POE Jobs";
		public const string CentralScheduling = "Central - Scheduling";
		public const string CentralPdmClientAdmin = "Central - PDM Client Admins";

		private static readonly LdapConfiguration Config = new LdapConfiguration();

		//String ldap_HR = String.Format("CN=Central - HR,{0}", ldap);
		//String ldap_Main = String.Format("CN=Central - Main,{0}", ldap);

		static DomainUser() {
			Config.ConfigureFactory(DirectoryName);
		}

		public static List<User> GetDomainUser() {
			var users = new List<User>();
			using (var context = new DirectoryContext(Config)) {
				var adUsers = context.Query(Ldap, objectClass: "User");
				foreach (var adUser in adUsers) {
					if (adUser.GetStrings(Groups).Any(x => x.Contains(OuCentral))) {
						var login = adUser.Where(x => x.Key.Equals("samaccountname")).Select(x => new { x.Key, x.Value }).FirstOrDefault();
						var mail = adUser.Where(x => x.Key.Equals("mail")).Select(x => new { x.Key, x.Value }).FirstOrDefault();
						var fullName = adUser.Where(x => x.Key.Equals("displayname")).Select(x => new { x.Key, x.Value }).FirstOrDefault();
						var surName = adUser.Where(x => x.Key.Equals("sn")).Select(x => new { x.Key, x.Value }).FirstOrDefault();
						var initials = adUser.Where(x => x.Key.Equals("initials")).Select(x => new { x.Key, x.Value }).FirstOrDefault();
						var title = adUser.Where(x => x.Key.Equals("title")).Select(x => new { x.Key, x.Value }).FirstOrDefault();
						var company = adUser.Where(x => x.Key.Equals("company")).Select(x => new { x.Key, x.Value }).FirstOrDefault();
						var mobile = adUser.Where(x => x.Key.Equals("mobile")).Select(x => new { x.Key, x.Value }).FirstOrDefault();
						var phone = adUser.Where(x => x.Key.Equals("telephonenumber")).Select(x => new { x.Key, x.Value }).FirstOrDefault();
						var department = adUser.Where(x => x.Key.Equals("department")).Select(x => new { x.Key, x.Value }).FirstOrDefault();
						var user = new User {
							Login = login?.Value.ToString().ToLower(),
							Mail = mail?.Value.ToString(),
							FullName = fullName?.Value.ToString(),
							SurName = surName?.Value.ToString(),
							Initials = initials?.Value.ToString(),
							Title = title?.Value.ToString(),
							Company = company?.Value.ToString(),
							Mobile = mobile?.Value.ToString(),
							Phone = phone?.Value.ToString(),
							Department = department?.Value.ToString()
						};
						foreach (var userGroup in adUser.GetStrings(Groups).Where(x => !x.Contains(OuHewDist))) {
							var group = userGroup
								.Replace($",{CnUsers}", "")
								.Replace($",{OuCentral}", "")
								.Replace($",{OuHewDist}", "")
								.Replace($",{OuHewGroups}", "")
								.Replace("CN=", "");
							user.Groups.Add(group);
						}
						users.Add(user);
					}
				}
			}
			return users.OrderBy(x => x.Login).ToList();
		}

	}

	public class User {

		public User() {
			Groups = new List<string>();
		}

		public string Login { get; set; }

		public string Mail { get; set; }

		public string FullName { get; set; }

		public string SurName { get; set; }

		public string Initials { get; set; }

		public string Title { get; set; }

		public string Company { get; set; }

		public string Mobile { get; set; }

		public string Phone { get; set; }

		public string Department { get; set; }

		public List<string> Groups { get; set; }

	}

}
