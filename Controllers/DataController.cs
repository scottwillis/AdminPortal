using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AdminPortal.Controllers
{
		[ApiController]
		[Route("[controller]")]
		public class DataController : ControllerBase
		{
				private static readonly string[] Summaries = new[]
				{
						"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
				};

				private readonly ILogger<DataController> _logger;

				public DataController(ILogger<DataController > logger)
				{
						_logger = logger;
				}

				[HttpGet]
				public IEnumerable<WeatherForecast> Get()
				{
						var rng = new Random();
						return Enumerable.Range(1, 5).Select(index => new WeatherForecast
						{
								Date = DateTime.Now.AddDays(index),
								TemperatureC = rng.Next(-20, 55),
								Summary = Summaries[rng.Next(Summaries.Length)]
						})
						.ToArray();
				}
		}
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using AdsDataModel;
using Common;
using DataModel;
using EntityDataModel;
using OasisServices;
using Reports;
using Entity = DataModel.Entity;

namespace repNet.Controllers {

	public class DataServiceController : Controller {

		private readonly FoxProDataContext context = new FoxProDataContext();

		public JsonResult JsonGenerateInvoice(int agency, int no, string where) {
			var filePath = $@"\\websrv01\ws1\{where}\reports\";
			var pdfFile = $@"Invoice-{no}-{agency}-{DateTime.Now:yyyyMMdd-HHmmss}.pdf";
			var pdfPath = $@"{filePath}Temp\";
			var pdfFilePath = $@"{pdfPath}{pdfFile}";

			var filePaths = Directory.GetFiles(pdfPath);
			foreach (var file in filePaths) {
				var fi = new FileInfo(file);
				if (fi.LastAccessTime < DateTime.Today) fi.Delete();
			}

			var doc = new Doc(no.ToString()) { IncludeTerms = true };
			doc.Create("Invoice", pdfFilePath, agency);

			var pdfStream = new MemoryStream();
			using (var input = System.IO.File.OpenRead(pdfFilePath)) {
				input.CopyTo(pdfStream);
			}

			//var oApp = new Application();
			//var oMsg = (MailItem)oApp.CreateItem(OlItemType.olMailItem);

			//oMsg.Subject = "Hew Invoice";
			//oMsg.BodyFormat = OlBodyFormat.olFormatHTML;
			//oMsg.To = "scott@hew.com";
			//oMsg.HTMLBody = "body";
			//oMsg.Attachments.Add(pdfFilePath, OlAttachmentType.olByValue, Type.Missing, Type.Missing);
			//oMsg.Display(false); //In order to displ

			return Json(pdfFile, JsonRequestBehavior.AllowGet);
		}

		public JsonResult JsonGenerateAck(int agency, int no, string where) {
			var filePath = $@"\\websrv01\ws1\{where}\reports\";
			var pdfFile = $@"Ack-{no}-{agency}-{DateTime.Now:yyyyMMdd-HHmmss}.pdf";
			var pdfPath = $@"{filePath}temp\";
			var pdfFilePath = $@"{pdfPath}{pdfFile}";

			var filePaths = Directory.GetFiles(pdfPath);
			foreach (var file in filePaths) {
				var fi = new FileInfo(file);
				if (fi.LastAccessTime < DateTime.Today) fi.Delete();
			}

			var doc = new Doc(no.ToString()) { IncludeTerms = false };
			doc.Create("Ack", pdfFilePath, agency);

			var pdfStream = new MemoryStream();
			using (var input = System.IO.File.OpenRead(pdfFilePath)) {
				input.CopyTo(pdfStream);
			}
			return Json(pdfFile, JsonRequestBehavior.AllowGet);
		}

		public JsonResult JsonGenerateAckCust(int agency, int no, string where) {
			var filePath = $@"\\websrv01\ws1\{where}\reports\";
			var pdfFile = $@"AckCust-{no}-{agency}-{DateTime.Now:yyyyMMdd-HHmmss}.pdf";
			var pdfPath = $@"{filePath}Temp\";
			var pdfFilePath = $@"{pdfPath}{pdfFile}";

			var filePaths = Directory.GetFiles(pdfPath);
			foreach (var file in filePaths) {
				var fi = new FileInfo(file);
				if (fi.LastAccessTime < DateTime.Today) fi.Delete();
			}

			var doc = new Doc(no.ToString()) { IncludeTerms = false };
			doc.Create("AckCust", pdfFilePath, agency);

			var pdfStream = new MemoryStream();
			using (var input = System.IO.File.OpenRead(pdfFilePath)) {
				input.CopyTo(pdfStream);
			}
			return Json(pdfFile, JsonRequestBehavior.AllowGet);
		}

		public JsonResult JsonGeneratePacking(int agency, int no, string where) {
			var filePath = $@"\\websrv01\ws1\{where}\reports\";
			var pdfFile = $@"Packing-{no}-{agency}-{DateTime.Now:yyyyMMdd-HHmmss}.pdf";
			var pdfPath = $@"{filePath}Temp\";
			var pdfFilePath = $@"{pdfPath}{pdfFile}";

			var filePaths = Directory.GetFiles(pdfPath);
			foreach (var file in filePaths) {
				var fi = new FileInfo(file);
				if (fi.LastAccessTime < DateTime.Today) fi.Delete();
			}

			var doc = new Doc(no.ToString());
			doc.Create("PackingList", pdfFilePath, agency);

			var pdfStream = new MemoryStream();
			using (var input = System.IO.File.OpenRead(pdfFilePath)) {
				input.CopyTo(pdfStream);
			}
			return Json(pdfFile, JsonRequestBehavior.AllowGet);
		}

		public JsonResult JsonGenerateQuote(int agency, int no, string where) {
			var filePath = $@"\\websrv01\ws1\{where}\reports\";
			var pdfFile = $@"Quote-{no}-{agency}-{DateTime.Now:yyyyMMdd-HHmmss}.pdf";
			var pdfPath = $@"{filePath}Temp\";
			var pdfFilePath = $@"{pdfPath}{pdfFile}";

			var filePaths = Directory.GetFiles(pdfPath);
			foreach (var file in filePaths) {
				var fi = new FileInfo(file);
				if (fi.LastAccessTime < DateTime.Today) fi.Delete();
			}

			var doc = new Doc(no.ToString());
			doc.Create("Quote", pdfFilePath, agency);

			var pdfStream = new MemoryStream();
			using (var input = System.IO.File.OpenRead(pdfFilePath)) {
				input.CopyTo(pdfStream);
			}
			return Json(pdfFile, JsonRequestBehavior.AllowGet);
		}

		public JsonResult CreateNewAccount(int agency, string email, string name, string title) {
			var mail = new MailMessage { IsBodyHtml = true, From = new MailAddress("repnet@hew.com") };
			mail.To.Add("repnet@hew.com");
			mail.Subject = "repNET Account Request";
			mail.Body = $"New account requested for<br /><br />Name: {name}<br />Email: {email}<br />Title: {title}<br />Agency: {agency}";
			var smtp = new SmtpClient(MagicString.EmailServer);
			smtp.Port = 25;
			smtp.EnableSsl = true;
			smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
			smtp.Credentials = new NetworkCredential(MagicString.EmailUsername, MagicString.EmailPW, MagicString.EmailDomain);
			smtp.UseDefaultCredentials = false;


			smtp.Send(mail);
			return Json(true, JsonRequestBehavior.AllowGet);
		}

		public JsonResult JsonGetAgencies() {
			var reps = context.GetAgenciesNoName();
			var agencies = reps.Select(x => new AgentNoName { Name = x.name, No = x.salesno.ToString() }).ToList();
			return Json(agencies, JsonRequestBehavior.AllowGet);
		}

		public JsonResult JsonGetCsrs() {
			var cstsrvs = context.GetActiveCstSrvs().OrderBy(x => x.custserv).ToList();
			var custservs = cstsrvs.Select(x => new CustServ { Name = x.name, Init = x.custserv, Login = x.login }).ToList();
			return Json(custservs, JsonRequestBehavior.AllowGet);
		}

		public JsonResult JsonGetStates() {
			var repo = new Repository();
			var states = repo.GetEntities<DataModel.GeoJsonState>().OrderBy(x => x.StateName).Select(x => new { x.No, x.StateCode, x.StateName });
			return Json(states, JsonRequestBehavior.AllowGet);
		}

		public JsonResult JsonGetGeoJsonCounties(string stateCode) {
			var repo = new Repository();
			var state = repo.GetEntities<DataModel.GeoJsonState>().SingleOrDefault(x => x.StateCode == stateCode);
			var items = repo.GetEntities<DataModel.GeoJsonCounty>().Where(x => x.State == state).ToList();
			var result = "{\"type\": \"FeatureCollection\", \"features\": [";
			foreach (var item in items) result = result + item.Json;
			var geo = result + "]}";
			var json = Json(geo.Replace(",]", "]"), JsonRequestBehavior.AllowGet);
			json.MaxJsonLength = int.MaxValue;
			return json;
		}

		public JsonResult JsonGetGeoJsonCountiesByAgencyNo(string agencyNo) {
			var repo = new Repository();
			var items = repo.GetEntities<DataModel.Territory>().Where(x => x.AgencyNo == agencyNo).Select(x => x.County).ToList();
			var result = "{\"type\": \"FeatureCollection\", \"features\": [";
			foreach (var item in items) result = result + item.Json;
			var geo = result + "]}";
			var json = Json(geo.Replace(",]", "]"), JsonRequestBehavior.AllowGet);
			json.MaxJsonLength = int.MaxValue;
			return json;
		}

		public JsonResult JsonGetGeoJsonCountiesByAgencyNoState(string agencyNo, string stateCode) {
			var items = new List<DataModel.GeoJsonCounty>();
			var result = "{\"type\": \"FeatureCollection\", \"features\": [";
			if (!string.IsNullOrEmpty(agencyNo) || !string.IsNullOrEmpty(stateCode)) {
				var repo = new Repository();
				items = repo.GetEntities<DataModel.Territory>().Where(x => (string.IsNullOrEmpty(agencyNo) || x.AgencyNo == agencyNo) && (string.IsNullOrEmpty(stateCode) || x.County.State.StateCode == stateCode)).Select(x => x.County).ToList();
				foreach (var item in items) result = result + item.Json;
			}
			var geo = result + "]}";
			var json = Json(geo.Replace(",]", "]"), JsonRequestBehavior.AllowGet);
			json.MaxJsonLength = int.MaxValue;
			return json;
		}

		public JsonResult JsonGetCountiesByAgencyNoState(string agencyNo, string stateCode) {
			var counties = new List<CountyInfo>();
			if (!string.IsNullOrEmpty(agencyNo) || !string.IsNullOrEmpty(stateCode)) {
				var repo = new Repository();
				var territories = repo.GetEntities<DataModel.Territory>().Where(x => (string.IsNullOrEmpty(agencyNo) || x.AgencyNo == agencyNo) && (string.IsNullOrEmpty(stateCode) || x.County.State.StateCode == stateCode)).ToList();
				counties = territories.Select(x => new CountyInfo { StateCode = x.County.State.StateCode, Name = x.County.CountyName }).OrderBy(x => x.StateCounty).ToList();
			}
			return Json(counties, JsonRequestBehavior.AllowGet);
		}

		public JsonResult JsonGetAgencyInfoByStateCounty(string county, string stateCode) {
			var agentInfo = Oasis.GetAgencyInfoByStateCounty(county, stateCode);
			return Json(agentInfo, JsonRequestBehavior.AllowGet);
		}

		public JsonResult JsonGetCountyFromPlace(string place) {
			var stateCodeCountyName = Oasis.GetCountyFromPlace(place);
			return Json(stateCodeCountyName, JsonRequestBehavior.AllowGet);
		}

		public JsonResult JsonGetMainMenu(bool isInternal) {
			var repo = new WebsiteRepository();
			var items = isInternal ?
				repo.GetEntities<RepnetMenu>().OrderBy(x => x.Position).ToList() :
				repo.GetEntities<RepnetMenu>().Where(x => !x.IsInternal.GetValueOrDefault()).OrderBy(x => x.Position).ToList();
			var menu = Enumerable.Aggregate(items, "[", (current, item) => current + item.Json) + "]";
			return Json(menu.Replace(",]", "]").Replace("/Images", isInternal ? "/csnet/Images" : "/Images").Replace("/config", isInternal ? "/hewconfig/" : "/config"), JsonRequestBehavior.AllowGet);
		}

		public JsonResult JsonGetMessages() {
			var repo = new WebsiteRepository();
			var items = repo.GetEntities<RepnetMessage>().Where(x => DateTime.Today >= x.StartDate && DateTime.Today <= x.StopDate).OrderBy(x => x.StartDate);
			var messages = Enumerable.Aggregate(items, "[", (current, item) => current + item.Json) + "]";
			return Json(messages.Replace(",]", "]"), JsonRequestBehavior.AllowGet);
		}

		public JsonResult JsonGetSlides() {
			var repo = new WebsiteRepository();
			var items = repo.GetEntities<WebMasthead>().Where(x => x.Sort > 1).OrderBy(x => x.Sort);
			var slides = Enumerable.Aggregate(items, "[", (current, item) => current + item.Json) + "]";
			return Json(slides.Replace(",]", "]"), JsonRequestBehavior.AllowGet);
		}

		public JsonResult JsonGetWindowsUser() {
			var userName = User.Identity.Name;
			return Json(userName, JsonRequestBehavior.AllowGet);
		}

		public JsonResult JsonGetUser(string email, string password) {
			var employee = new Employee();
			if (email == "" || password == "") return Json(employee, JsonRequestBehavior.AllowGet);
			var repemp = context.GetAgencyEmployeeByEmailPassword(email, password);
			var manager = context.GetAgencyEmployeeManager(repemp.salesno);
			var man = manager != null ? manager.email : "repnet.hew.com";
			if (repemp != null) {
				employee = new Employee {
					Id = repemp.empid,
					Name = repemp.name,
					Email = repemp.email,
					Email2 = repemp.email2,
					Ext = repemp.ext,
					HomePhone = repemp.phone,
					HomeFax = repemp.fax,
					CellPhone = repemp.cell,
					Password = repemp.password,
					Manager = man
				};
			}
			return Json(employee, JsonRequestBehavior.AllowGet);
		}

		public JsonResult JsonUpdateUser(int id, string name, string email, string email2, string ext, string homePhone, string homeFax, string cellPhone, string password) {
			if (id == 0 || email == "" || password == "") return Json(false, JsonRequestBehavior.AllowGet);
			var repemp = context.GetAgencyEmployeeById(id);
			if (repemp == null) return Json(false, JsonRequestBehavior.AllowGet);
			repemp.name = name;
			repemp.email = email;
			repemp.email2 = email2;
			repemp.ext = ext;
			repemp.phone = homePhone;
			repemp.fax = homeFax;
			repemp.cell = cellPhone;
			repemp.password = password;
			var updated = context.Update(repemp);
			return Json(updated, JsonRequestBehavior.AllowGet);
		}

		public JsonResult AttemptLogin(string username, string password) {
			Employee employee = null;
			if (username == "" || password == "") return Json(employee, JsonRequestBehavior.AllowGet);
			var repemp = context.GetAgencyEmployeeByEmailPassword(username.ToLower(), password);
			if (repemp != null) {
				var rep = context.GetAgency(repemp.salesno);
				var cs = context.GetCustSrv(rep.custserv);
				var csb = context.GetCustSrv(rep.custservi);
				employee = new Employee {
					Name = repemp.name,
					AgencyNo = repemp.salesno,
					AgencyName = rep.name,
					CsmName = cs?.name,
					CsmEmail = $"mailto://{cs?.Email}",
					CsmNameBackup = csb?.name,
					CsmEmailBackup = $"mailto://{csb?.Email}"
				};
				ControllerContext.HttpContext.Response.Cookies.Add(new HttpCookie("username") { Value = username, Expires = DateTime.Now.AddDays(365) });
				ControllerContext.HttpContext.Response.Cookies.Add(new HttpCookie("password") { Value = password, Expires = DateTime.Now.AddDays(365) });
			}
			return Json(employee, JsonRequestBehavior.AllowGet);
		}

		public JsonResult JsonGetCookie() {
			var username = "";
			var password = "";
			if (ControllerContext.HttpContext.Request.Cookies.AllKeys.Contains("username")) {
				username = ControllerContext.HttpContext.Request.Cookies["username"].Value;
			}
			if (ControllerContext.HttpContext.Request.Cookies.AllKeys.Contains("password")) {
				password = ControllerContext.HttpContext.Request.Cookies["password"].Value;
			}
			var user = new Credentials { Username = username, Password = password };
			return Json(user, JsonRequestBehavior.AllowGet);
		}

		public JsonResult JsonRemoveCookie() {
			if (ControllerContext.HttpContext.Request.Cookies.AllKeys.Contains("username")) {
				var cookie = ControllerContext.HttpContext.Request.Cookies["username"];
				if (cookie != null) {
					cookie.Expires = DateTime.Now.AddDays(-1);
					ControllerContext.HttpContext.Response.Cookies.Add(cookie);
				}
			}
			if (ControllerContext.HttpContext.Request.Cookies.AllKeys.Contains("password")) {
				var cookie = ControllerContext.HttpContext.Request.Cookies["password"];
				if (cookie != null) {
					cookie.Expires = DateTime.Now.AddDays(-1);
					ControllerContext.HttpContext.Response.Cookies.Add(cookie);
				}
			}
			return Json(true, JsonRequestBehavior.AllowGet);
		}

		public JsonResult SendPassword(string username) {
			if (username == "") return Json(false, JsonRequestBehavior.AllowGet);
			var repemp = context.GetAgencyEmployeeByEmail(username);
			if (repemp == null) return Json(false, JsonRequestBehavior.AllowGet);
			var mail = new MailMessage { IsBodyHtml = true, From = new MailAddress("repnet@hew.com") };
			mail.To.Add(repemp.email);
			mail.Subject = "repNET password";
			mail.Body = $"Your repNET password is<br/><br/>{repemp.password}";
			var smtp = new SmtpClient(MagicString.EmailServer);
			smtp.Port = 25;
			smtp.EnableSsl = true;
			smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
			smtp.Credentials = new NetworkCredential(MagicString.EmailUsername, MagicString.EmailPW, MagicString.EmailDomain);
			smtp.UseDefaultCredentials = false;
			smtp.Send(mail);
			return Json(true, JsonRequestBehavior.AllowGet);
		}

		public JsonResult JsonGetOrdersForAgency(int agency, string startDate, string endDate, string searchText, string csr) {
			var agency2 = agency;
			if (agency == 915) agency2 = 916;
			if (agency == 916) {
				agency = 915;
				agency2 = 916;
			}
			var ords = context.GetParentAgencyOpenInHouseSearchOrdersDuring(agency, Convert.ToDateTime(startDate), Convert.ToDateTime(endDate), searchText);
			var hewis = new HewisEntityRepository();
			var hcusts = hewis.GetEntities<Hcust>().ToList();
			var hreps = context.GetAllAgencies(false);
			foreach (var entity in ords) {
				var hcust = hcusts.SingleOrDefault(x => x.CustNo == entity.custno);
				if (hcust != null) {
					entity.SoldName = hcust.CustName;
					var hrep = hreps.FirstOrDefault(x => x.salesno == hcust.AgencyNo.GetValueOrDefault());
					if (hrep != null) {
						entity.CsO = hrep.custserv;
						entity.CsOb = hrep.custservi;
						entity.CsQ = hrep.csq;
						entity.CsQb = hrep.csqb;
					}
				}
			}
			var orders = ords.Select(hord => new OrderListReturn(agency == 0 || hord.sale1.GetValueOrDefault() / 10 == agency || hord.sale1.GetValueOrDefault() / 10 == agency2 || (hord.sale1.GetValueOrDefault() / 10 == 850 && hord.sale2.GetValueOrDefault() == 0) ? hord.sale1.GetValueOrDefault() : hord.sale2.GetValueOrDefault(), hord.CsO, hord.date, hord.ship_date, hord.rel_date, hord.schday, hord.orderno, hord.mark, hord.SoldName, hord.ordstyle, hord.pono, hord.status.ToString(), hord.subtotal.GetValueOrDefault(), hord.ordtype.ToString()));
			if (!string.IsNullOrEmpty(csr)) {
				orders = orders.Where(x => x.CSR == csr);
			}
			return Json(orders, JsonRequestBehavior.AllowGet);
		}

		public JsonResult JsonGetOrder(int agency, int no) {
			var agency2 = agency;
			if (agency == 915) agency2 = 916;
			if (agency == 916) {
				agency = 915;
				agency2 = 916;
			}
			var hord = context.GetOrder(agency, no);
			var order = new OrderSingleReturn();
			if (hord != null) {
				order = new OrderSingleReturn(hord.sale1.GetValueOrDefault() / 10 == agency || hord.sale1.GetValueOrDefault() / 10 == agency2 ? hord.sale1.GetValueOrDefault() : hord.sale2.GetValueOrDefault(), hord.date, hord.ship_date, hord.rel_date, hord.orderno, hord.mark, hord.sname, hord.ordstyle, hord.pono, hord.status, hord.subtotal.GetValueOrDefault(), hord.ordtype) {
					Ack = hord.ack,
					Spec = hord.spec,
					Bott = hord.bott,
					BoFrom = hord.bofrom,
					BoTo = hord.boto,
					ActShipDate = hord.ashp_date.ToDateString(),
					PoDate = hord.po_date.ToDateString(),
					Route = hord.route,
					CustNo = hord.custno.ToString(),
					ShipName = hord.sname,
					ShipAddr1 = hord.saddress,
					ShipAddr2 = hord.saddress2,
					ShipAddr3 = $"{hord.scity}, {hord.sstate}  {hord.szip}",
					Credit = hord.credit,
					CreditClear = hord.credclear,
					PrePay = hord.prepay,
					PickUp = hord.pickup,
					LotPrice = hord.lotprice,
					Taxable = hord.taxable,
					CallPhone = hord.call_phone,
					Call = hord.call,
					HoursBefore = hord.hrs_before,
					SubTotal = hord.subtotal.GetValueOrDefault(),
					SalesTax = hord.salestax.GetValueOrDefault(),
					Freight = hord.freight.GetValueOrDefault(),
					Cost = hord.cost.GetValueOrDefault(),
					Comm = hord.commission.GetValueOrDefault(),
					VarComm = hord.vcamount.GetValueOrDefault(),
					CommAdjust = hord.commadjust.GetValueOrDefault(),
					InvNo = hord.invno,
					InvDate = hord.invdate.ToDateString(),
					RecDate = hord.rec_date.ToDateString(),
					FVendor = hord.fvendor,
					CommPer = hord.comper.GetValueOrDefault(),
					AgencyNo = hord.sale1.GetValueOrDefault(),
					Agency1Per = hord.sale1per.GetValueOrDefault(),
					AgencyNo2 = hord.sale2.GetValueOrDefault(),
					Agency2Per = hord.sale2per.GetValueOrDefault(),
					AgencyNo3 = hord.sale3.GetValueOrDefault(),
					Agency3Per = hord.sale3per.GetValueOrDefault(),
					PaidDate = hord.paid_date.ToDateString(),
					PaidDateComm = hord.pcom_date.ToDateString(),
					PaidDateCommV = hord.vcpaiddate.ToDateString(),
					ApComm = hord.apcom.GetValueOrDefault(),
					ApCommV = hord.apvcom.GetValueOrDefault(),
					EsdNewDate = hord.esd_newdt.ToDateString(),
				};

				var sale1 = hord.sale1.GetValueOrDefault();
				var sale1per = hord.sale1per.GetValueOrDefault();
				var sale2 = hord.sale2.GetValueOrDefault();
				var sale2per = hord.sale2per.GetValueOrDefault();
				var sale3 = hord.sale3.GetValueOrDefault();
				var sale3per = hord.sale3per.GetValueOrDefault();
				var isPrimaryAgency = false;
				var agent = 0;
				var agentPer = 0;
				if (agency != 0) {
					if (sale3 / 10 == agency || sale3 / 10 == agency2) {
						agent = sale3;
						agentPer = sale3per;
					}
					if (sale2 / 10 == agency || sale2 / 10 == agency2) {
						agent = sale2;
						agentPer = sale2per;
					}
					if (sale1 / 10 == agency || sale1 / 10 == agency2) {
						agent = sale1;
						agentPer = sale1per;
					}

					//if ((hord.sale1.GetValueOrDefault() / 10 == agency || hord.sale1.GetValueOrDefault() / 10 == agency2) && hord.sale1per.GetValueOrDefault() != 0) isPrimaryAgency = true;
					//if ((hord.sale2.GetValueOrDefault() / 10 == agency || hord.sale2.GetValueOrDefault() / 10 == agency2) && hord.sale2per.GetValueOrDefault() != 0) isPrimaryAgency = true;
					//if ((hord.sale3.GetValueOrDefault() / 10 == agency || hord.sale3.GetValueOrDefault() / 10 == agency2) && hord.sale3per.GetValueOrDefault() != 0) isPrimaryAgency = true;
					if (sale1per != 0) {
						if (sale1 == agent) isPrimaryAgency = true;
					}
					else if (sale2per != 0) {
						if (sale2 == agent) isPrimaryAgency = true;
					}
					else if (sale3per != 0) {
						if (sale3 == agent) isPrimaryAgency = true;
					}

					//if (hord.sale1.GetValueOrDefault() / 10 == order.AgencyNo && hord.sale1per.GetValueOrDefault() != 0) isPrimaryAgency = true;
					//else if (hord.sale2.GetValueOrDefault() / 10 == order.AgencyNo && hord.sale2per.GetValueOrDefault() != 0) isPrimaryAgency = true;
					//else if (hord.sale3.GetValueOrDefault() / 10 == order.AgencyNo && hord.sale3per.GetValueOrDefault() != 0) isPrimaryAgency = true;
				}
				else isPrimaryAgency = true;

				//if (hord.sale1per == 0) isPrimaryAgency = agency == 0 || hord.sale2 / 10 == agency;

				//if (agency == 915 && agency2 == 916) isPrimaryAgency = true;

				var rep = context.GetAgency(order.AgencyNo, new List<string> { "salesno", "name", "custserv", "region" });
				if (rep != null) {
					order.AgencyNoName = $"{rep.salesno} - {rep.name}";
					var cs = context.GetCustSrv(rep.custserv);
					if (cs != null) {
						order.CustServEmail = $"mailto://{cs.login}@hew.com";
						order.CustServName = cs.name;
					}
				}
				var cust = context.GetCustomer(hord.custno, new List<string> { "name", "address", "address2", "city", "state", "zip" });
				if (cust != null) {
					order.CustName = cust.name;
					order.CustAddr1 = cust.address;
					order.CustAddr2 = cust.address2;
					order.CustAddr3 = $"{cust.city}, {cust.state}  {cust.zip}";
				}
				if (order.ApComm != 0) {
					var ap = context.GetAp(order.ApComm);
					if (ap != null) {
						order.CheckDateComm = ap.check_date.ToDateString();
						if (isPrimaryAgency) order.CheckNoComm = ap.checkno.ToString();
					}
				}
				if (order.ApCommV != 0) {
					var ap = context.GetAp(order.ApCommV);
					if (ap != null) {
						order.CheckDateCommV = ap.check_date.ToDateString();
						order.CheckNoCommV = ap.checkno.ToString();
					}
				}
				var pronums = context.GetOrderPronums(no);
				foreach (var pronum in pronums) {
					order.ProNums.Add(pronum.pronum);
				}
				var iRegCommTot = 0m;
				var iVarCommTot = 0m;
				var isOverage = false;
				var isProd = false;
				var isShip = false;
				var hdets = context.GetOrderDetails(order.OrderNo);
				foreach (var hdet in hdets) {
					var desc = hdet.desc;
					var fields = new List<string> { "gdesc", "cuft" };
					var hfinv = context.GetFinishedInventory(hdet.itemno, hdet.pack, true, fields);
					if (!hdet.itemno.StartsWith("MISC") && hfinv != null) desc = hfinv.gdesc;
					var add = new OrderDetailReturn {
						LineNo = hdet.lineno,
						Quantity = hdet.qty.GetValueOrDefault(),
						Type = hdet.type,
						ProdQty = hdet.prod_qty.GetValueOrDefault() + hdet.prod_qty2.GetValueOrDefault(),
						ProdDate = hdet.prod_date.ToDateString(),
						ShipQty = hdet.ShipQty,
						WtCarton = hdet.WtCarton,
						NoCarton = hdet.NoCarton,
						Description = desc,
						ItemPack = $"{hdet.itemno}{hdet.pack}",
						Comment = hdet.comment ?? "",
						CommissionCode = hdet.code,
						PriceBase = hdet.cprice.GetValueOrDefault(),
						Price = hdet.price.GetValueOrDefault(),
						Cost = hdet.cost.GetValueOrDefault(),
						Brand = hdet.brand,
					};
					order.Details.Add(add);
					if (add.PriceBase != add.Price) order.ShowBase = true;
					var iCommPer = GetCommCodePer(hdet.code);
					var cPrice = (hdet.cprice > 0) ? hdet.cprice.GetValueOrDefault() : hdet.price.GetValueOrDefault();
					var price = hdet.price.GetValueOrDefault();
					var iCommQty = (order.Status == "C" || string.IsNullOrEmpty(order.Status)) ? 0 : Convert.ToInt32(order.Status) > 7 ? hdet.ShipQty : hdet.qty.GetValueOrDefault();
					//iRegCommTot += (Math.Round(iCommQty * cPrice, 2) * iCommPer);
					iRegCommTot += (Math.Round(iCommQty * cPrice * iCommPer, 2));
					if (price - cPrice > 0) {
						isOverage = true;
						var iVarPct = order.CommPer / 100m;
						iRegCommTot = iRegCommTot + (iVarPct * (iCommQty * (price - cPrice)));
						if (isPrimaryAgency) iVarCommTot = iVarCommTot + (iVarPct * (iCommQty * (price - cPrice)));
					}
					if (hdet.ProdQty > 0) isProd = true;
					if (hdet.ShipQty > 0) isShip = true;

					order.Cartons += hdet.no_carton.GetValueOrDefault();
					order.Weight += Convert.ToDecimal(hdet.no_carton * hdet.wt_carton.GetValueOrDefault());
					if (hfinv != null) order.CubicFeet += (hfinv.cuft.GetValueOrDefault() * hdet.ShipQty);
					order.Cost += add.ExtCost;
				}

				iRegCommTot = (order.Status == "C" || string.IsNullOrEmpty(order.Status)) ? 0 : (Convert.ToInt32(order.Status) > 7) ? order.Comm - order.VarComm : Math.Round(iRegCommTot, 2) - Math.Round(iVarCommTot, 2);
				iVarCommTot = (order.Status == "C" || string.IsNullOrEmpty(order.Status)) ? 0 : (Convert.ToInt32(order.Status) > 7) ? order.VarComm : Math.Round(iVarCommTot, 2);

				//var iCommTot = (order.Status == "C") ? 0 : (Convert.ToInt32(order.Status) > 7) ? order.Comm + order.CommAdjust : Math.Round(iRegCommTot, 2) - order.CommAdjust;
				//order.Comm = order.Status == "C" ? 0 : (order.Comm != 0 ? (order.Comm - order.CommAdjust) : (iRegCommTot - order.CommAdjust)) * agencyPer;

				var agencyPer = agentPer / 100m;

				//order.Comm = agency == 0 ? (iRegCommTot - order.CommAdjust) : (iRegCommTot - order.CommAdjust) * agencyPer;
				order.Comm = agency == 0 ? (iRegCommTot + order.CommAdjust) : ((iRegCommTot * agencyPer) + order.CommAdjust);

				//order.VarComm = agency == 0 ? iVarCommTot : iVarCommTot * agencyPer;
				order.VarComm = isPrimaryAgency ? iVarCommTot : 0;
				order.TotalComm = order.Comm + order.VarComm;
				order.Total = order.SubTotal + order.SalesTax + order.Freight;
				order.FloorSpace = Math.Round(order.CubicFeet / 66, 2);
			}
			return Json(order, JsonRequestBehavior.AllowGet);
		}

		public JsonResult JsonGetQuotesForAgency(int agency, string startDate, string endDate, string searchText) {
			var agency2 = agency;
			if (agency == 915) agency2 = 916;
			if (agency == 916) agency2 = 915;
			var repository = new Repository();
			IList<QuoteListReturn> quotes;
			Expression<System.Func<DataModel.Quote, bool>> findExpression;
			if (string.IsNullOrEmpty(searchText)) {
				if (agency == 0)
					findExpression = x => x.Status != QuoteStatus.Blank && x.Date >= Convert.ToDateTime(startDate) && x.Date <= Convert.ToDateTime(endDate);
				else
					findExpression = x => (x.Status != QuoteStatus.Blank && x.Date >= Convert.ToDateTime(startDate) && x.Date <= Convert.ToDateTime(endDate) && x.Status != QuoteStatus.Oasis && x.Status != QuoteStatus.Cahill) && (x.AgencyNo.Substring(0, x.AgencyNo.Length - 1) == agency.ToString() || x.AgencyNo.Substring(0, x.AgencyNo.Length - 1) == agency2.ToString());
			}
			else {
				int searchNum;
				var isNumeric = int.TryParse(searchText, out searchNum);
				if (isNumeric) {
					if (agency == 0)
						findExpression = x => x.No == searchNum.ToString();
					else
						findExpression = x => (x.No == searchNum.ToString() && x.Status != QuoteStatus.Blank && x.Status != QuoteStatus.Oasis && x.Status != QuoteStatus.Cahill) && (x.AgencyNo.Substring(0, x.AgencyNo.Length - 1) == agency.ToString() || x.AgencyNo.Substring(0, x.AgencyNo.Length - 1) == agency2.ToString());
				}
				else {
					var search = searchText.ToUpper();
					if (agency == 0)
						findExpression = x => x.Date >= Convert.ToDateTime(startDate) && x.Date <= Convert.ToDateTime(endDate) && (x.JobName.Contains(search) || x.Location.Contains(search));
					else
						findExpression = x => (x.Date >= Convert.ToDateTime(startDate) && x.Date <= Convert.ToDateTime(endDate) && (x.JobName.Contains(search) || x.Location.Contains(search)) && x.Status != QuoteStatus.Blank && x.Status != QuoteStatus.Oasis && x.Status != QuoteStatus.Cahill) && (x.AgencyNo.Substring(0, x.AgencyNo.Length - 1) == agency.ToString() || x.AgencyNo.Substring(0, x.AgencyNo.Length - 1) == agency2.ToString());
				}
			}
			quotes = repository.GetEntities<DataModel.Quote>().Where(findExpression).Select(x => new QuoteListReturn(x.AgencyNo, x.Date, x.No, x.JobName, x.Location, x.ConfirmTo, x.TakenBy, x.Status, x.Id)).ToList();
			foreach (var entity in quotes) {
				var details = repository.GetEntities<QuoteDetail>().Where(x => x.Quote.Id == entity.QuoteId);
				foreach (var detail in details) {
					entity.QuoteTotal += Math.Round((detail.Quantity * detail.Price).GetValueOrDefault(), 2);
				}
			}
			return Json(quotes, JsonRequestBehavior.AllowGet);
		}

		public JsonResult JsonGetQuote(int agency, int no) {
			var agency2 = agency;
			if (agency == 915) agency2 = 916;
			if (agency == 916) agency2 = 915;
			var repository = new Repository();
			var entity = agency == 0 ?
				repository.GetEntities<DataModel.Quote>().SingleOrDefault(x => x.No == no.ToString()) :
				repository.GetEntities<DataModel.Quote>().SingleOrDefault(x => (x.No == no.ToString() && x.Status != QuoteStatus.Blank && x.Status != QuoteStatus.Oasis && x.Status != QuoteStatus.Cahill) && (x.AgencyNo.Substring(0, x.AgencyNo.Length - 1) == agency.ToString() || x.AgencyNo.Substring(0, x.AgencyNo.Length - 1) == agency2.ToString()));
			var quote = new QuoteSingleReturn();
			if (entity == null) return Json(quote, JsonRequestBehavior.AllowGet);
			quote.No = entity.No;
			quote.AgencyNo = entity.AgencyNo;
			quote.AgencyName = entity.AgencyName;
			quote.OrderNo = entity.OrderNo;
			quote.Date = entity.Date;
			quote.SDate = entity.Date.ToDateString();
			quote.Status = entity.Status;
			quote.CreatedFrom = entity.CreatedFrom;
			quote.Reason = entity.Reason;
			quote.LotPrice = entity.LotPrice;
			quote.JobName = entity.JobName;
			quote.Location = entity.Location;
			quote.Contractor = entity.Contractor;
			quote.Architect = entity.Architect;
			quote.Engineer = entity.Engineer;
			quote.ConfirmTo = entity.ConfirmTo;
			quote.TakenBy = entity.TakenBy;
			quote.TermsNormal = entity.TermsNormal;
			quote.TermsExtended = entity.TermsExtended;
			foreach (var detail in entity.Details) {
				var add = new QuoteDetailReturn {
					Position = detail.Position.GetValueOrDefault(),
					LineNo = detail.LineNo.GetValueOrDefault(),
					Quantity = detail.Quantity.GetValueOrDefault(),
					Type = detail.Type,
					Description = detail.Description,
					OrigDescription = detail.OrigDescription,
					ItemPack = detail.ItemPack,
					Comment = detail.Comment ?? "",
					TargetPrice = detail.TargetPrice.GetValueOrDefault(),
					CommissionCode = detail.CommissionCode,
					PriceBase = detail.PriceBase.GetValueOrDefault(),
					Price = detail.Price.GetValueOrDefault(),
					Cost = detail.Cost.GetValueOrDefault(),
					Overage = detail.Overage,
					RecType = detail.RecType,
					Location = detail.Location,
					FinClass = detail.FinClass,
					Brand = detail.Brand,
					Config = detail.Config,
					PriceLock = detail.PriceLock
				};
				add.ExtPrice = Math.Round(add.Quantity * add.Price, 2);
				add.ExtCost = Math.Round(add.Quantity * add.Cost, 2);
				quote.Details.Add(add);
				quote.Total += add.ExtPrice;
				quote.Cost += add.ExtCost;
				quote.TotalComm += add.Commission;
				//quote.Total += add.ExtPrice;
				//quote.Cost += add.ExtCost;
				//quote.Margin => Total == 0 ? 0 : 1 - ((Cost + Comm) / Total);
			}
			quote.AvgComm = (quote.Total == 0) ? 0 : quote.TotalComm / quote.Total;
			AssignQuoteAgency(quote, agency);
			return Json(quote, JsonRequestBehavior.AllowGet);
		}

		private void AssignQuoteAgency(QuoteSingleReturn quote, int agency) {
			var no = agency * 10;
			var rep = context.GetAgency(no);
			if (rep == null) return;
			quote.AgencyAddressLine1 = rep.address;
			quote.AgencyAddressLine2 = rep.address2;
			quote.AgencyAddressLine3 = $"{rep.city}, {rep.state}  {rep.zip}";
		}

		public JsonResult JsonGetAlertOrdersCount(int agency) {
			var count = context.GetAlertOrdersCount(agency);
			return Json(count, JsonRequestBehavior.AllowGet);
		}

		public JsonResult JsonGetAlertOrders(int parentNo) {
			var notords = context.GetAlertOrders(parentNo);
			var orders = new List<OrderListReturn>();
			foreach (var notord in notords) {
				var order = new OrderListReturn(notord.sale1.GetValueOrDefault(), "", notord.date, notord.ship_date, notord.rel_date, notord.schday, notord.orderno, notord.mark, notord.sname, notord.ordstyle, notord.pono, notord.status, notord.subtotal.GetValueOrDefault(), notord.ordtype);
				order.Alert = notord.Alert;
				orders.Add(order);
			}
			return Json(orders, JsonRequestBehavior.AllowGet);
		}

		public JsonResult JsonGetYtd(int no) {
			var ytd = context.GetAgencyYtd(no);
			return Json(ytd, JsonRequestBehavior.AllowGet);
		}

		public JsonResult JsonGetYtdParent(int parentNo) {
			var ytd = context.GetAgencyYtdParent(parentNo);
			return Json(ytd, JsonRequestBehavior.AllowGet);
		}

		public decimal GetCommCodePer(string code) {
			decimal commPer;
			switch (code) {
				case "D":
					commPer = .01m;
					break;
				case "E":
					commPer = .02m;
					break;
				case "F":
					commPer = .03m;
					break;
				case "G":
					commPer = .04m;
					break;
				case "H":
					commPer = .05m;
					break;
				case "I":
					commPer = .06m;
					break;
				case "J":
					commPer = .07m;
					break;
				case "K":
					commPer = .08m;
					break;
				case "L":
					commPer = .09m;
					break;
				case "M":
					commPer = .1m;
					break;
				default:
					commPer = 0m;
					break;
			}
			return commPer;
		}

	}

	public class Employee {
		public int AgencyNo { get; set; }
		public string AgencyName { get; set; }
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Email2 { get; set; }
		public string Ext { get; set; }
		public string HomePhone { get; set; }
		public string HomeFax { get; set; }
		public string CellPhone { get; set; }
		public string Password { get; set; }
		public string Manager { get; set; }
		public string CsmName { get; set; }
		public string CsmEmail { get; set; }
		public string CsmNameBackup { get; set; }
		public string CsmEmailBackup { get; set; }
	}

	public class OrderListReturn {

		public OrderListReturn() {
		}

		public OrderListReturn(int agencyNo, string csr, DateTime? date, DateTime? shipDate, DateTime? relDate, DateTime? schDate, int orderNo, string mark, string soldName, string ordStyle, string poNo, string status, decimal subTotal, string ordType) {
			AgencyNo = agencyNo;
			CSR = csr;
			Date = date.ToDateString();
			ShipDate = shipDate.ToDateString();
			RelDate = relDate.ToDateString();
			SchDate = schDate.ToDateString();
			OrderNo = orderNo;
			Mark = mark;
			SoldName = soldName;
			OrdStyle = "";
			if (ordStyle.Contains("I") || ordStyle.Contains("W")) OrdStyle += "I";
			if (ordStyle.Contains("O")) OrdStyle += "O";
			PONo = poNo;
			Status = status;
			SubTotal = subTotal;
			OrdType = ordType;
		}

		public int AgencyNo { get; set; }
		public string CSR { get; set; }
		public string Date { get; set; }
		public int OrderNo { get; set; }
		public string OrdStyle { get; set; }
		public string Mark { get; set; }
		public string ShipDate { get; set; }
		public string RelDate { get; set; }
		public string SchDate { get; set; }
		public string PONo { get; set; }
		public string SoldName { get; set; }
		public decimal SubTotal { get; set; }
		public string Status { get; set; }
		public string Alert { get; set; }
		public string OrdType { get; set; }

		public string StatusWord {
			get {
				switch (Status) {
					case "1":
					case "2":
						return "Unsched";
					case "3":
					case "4":
					case "5":
					case "6":
						return "Sched";
					case "7":
					case "8":
					case "9":
						return "Shipped";
					case "C":
						return "Cancelled";
					default:
						return "On Hold";
				}
			}
		}

		public string StatusColor {
			get {
				switch (StatusWord) {
					case "On Hold":
						return "Red";
					case "Unsched":
						return "Orange";
					case "Sched":
						return "Blue";
					case "Shipped":
						return "Green";
					default:
						return "Black";
				}
			}
		}

	}

	public class OrderSingleReturn : OrderListReturn {

		public OrderSingleReturn(int agencyNo, DateTime? date, DateTime? shipDate, DateTime? relDate, int orderNo, string mark, string soldName, string ordStyle, string poNo, string status, decimal subTotal, string ordType) {
			Details = new List<OrderDetailReturn>();
			ProNums = new List<string>();
			AgencyNo = agencyNo;
			Date = date.ToDateString();
			ShipDate = shipDate.ToDateString();
			RelDate = relDate.ToDateString();
			OrderNo = orderNo;
			Mark = mark;
			SoldName = soldName;
			OrdStyle = ordStyle;
			PONo = poNo;
			Status = status;
			SubTotal = subTotal;
			OrdType = ordType;
		}

		public OrderSingleReturn() {
			Details = new List<OrderDetailReturn>();
			ProNums = new List<string>();
		}

		public string RecDate { get; set; }
		public string ActShipDate { get; set; }
		public string PoDate { get; set; }
		public string Route { get; set; }
		public string CustServEmail { get; set; }
		public string CustServName { get; set; }
		public string AgencyNoName { get; set; }
		public string CustNo { get; set; }
		public string CustName { get; set; }
		public string CustAddr1 { get; set; }
		public string CustAddr2 { get; set; }
		public string CustAddr3 { get; set; }
		public string ShipName { get; set; }
		public string ShipAddr1 { get; set; }
		public string ShipAddr2 { get; set; }
		public string ShipAddr3 { get; set; }
		public int? BoFrom { get; set; }
		public int? BoTo { get; set; }
		public int Agency1Per { get; set; }
		public int AgencyNo2 { get; set; }
		public int Agency2Per { get; set; }
		public int AgencyNo3 { get; set; }
		public int Agency3Per { get; set; }
		public int? InvNo { get; set; }
		public string InvDate { get; set; }
		public string Credit { get; set; }
		public string CreditClear { get; set; }
		public string PrePay { get; set; }
		public string PickUp { get; set; }
		public string LotPrice { get; set; }
		public string Taxable { get; set; }
		public string CallPhone { get; set; }
		public string Call { get; set; }
		public string HoursBefore { get; set; }
		public int Cartons { get; set; }
		public decimal Weight { get; set; }
		public decimal CubicFeet { get; set; }
		public decimal FloorSpace { get; set; }
		public string Ack { get; set; }
		public string Spec { get; set; }
		public string Bott { get; set; }
		public string FVendor { get; set; }
		public decimal SalesTax { get; set; }
		public decimal Freight { get; set; }
		public decimal Total { get; set; }
		public decimal Cost { get; set; }
		public decimal Comm { get; set; }
		public decimal VarComm { get; set; }
		public decimal CommAdjust { get; set; }
		public decimal TotalComm { get; set; }
		public decimal CommPer { get; set; }
		public string PaidDate { get; set; }
		public string PaidDateComm { get; set; }
		public string PaidDateCommV { get; set; }
		public int ApComm { get; set; }
		public int ApCommV { get; set; }
		public string CheckNoComm { get; set; }
		public string CheckNoCommV { get; set; }
		public string CheckDateComm { get; set; }
		public string CheckDateCommV { get; set; }
		public bool ShowBase { get; set; }
		public string EsdNewDate { get; set; }

		public string CreditClearEmail => $"mailto:{CreditClear}@hew.com";

		public string CreditDesc {
			get {
				switch (Credit) {
					case "1":
						return "1 - Current";
					case "2":
						return "2 - Watch";
					case "3":
						return "3 - Over Limit";
					case "4":
						return "4 - Past Due";
					case "5":
						return "5 - UnAuth Deduction Taken";
					case "6":
						return "6 - UnEarned Discount Taken";
					case "9":
						return "9 - CIA";
					default:
						return "";
				}
			}
		}

		public string PrepayDesc {
			get {
				switch (PrePay) {
					case "P":
						return "Prepaid";
					case "A":
						return "Prepay & Add";
					case "C":
						return "Collect Frt on Del";
					case "T":
						return "Third Party Billing";
					case "B":
						return "PPP Coast Collect Beyond";
					case "D":
						return "Dead Head";
					case "O":
						return "Collect on Delivery";
					default:
						return "";
				}
			}
		}

		public IList<OrderDetailReturn> Details { get; set; }

		public IList<string> ProNums { get; set; }

	}

	public class OrderDetailReturn {

		public OrderDetailReturn() {
		}

		public int Position { get; set; }
		public int LineNo { get; set; }
		public int Quantity { get; set; }
		public string Type { get; set; }
		public string Description { get; set; } = string.Empty;
		public string OrigDescription { get; set; } = string.Empty;
		public string ItemPack { get; set; }
		public string Comment { get; set; }
		public decimal TargetPrice { get; set; }
		public string CommissionCode { get; set; }
		public decimal PriceBase { get; set; }
		public decimal Price { get; set; }
		public decimal Cost { get; set; }
		public bool Overage { get; set; }
		public string RecType { get; set; }
		public string Location { get; set; }
		public string FinClass { get; set; }
		public string Brand { get; set; }
		public bool Config { get; set; }
		public bool? PriceLock { get; set; }
		public int ProdQty { get; set; }
		public string ProdDate { get; set; }
		public int ShipQty { get; set; }
		public int NoCarton { get; set; }
		public decimal WtCarton { get; set; }

		public decimal ExtPrice => Math.Round((Quantity * Price), 2);
		public decimal ExtPriceBase => Math.Round((Quantity * PriceBase), 2);
		public decimal ExtCost => Math.Round((Quantity * Cost), 2);

		public decimal Margin {
			get {
				if (CommissionCode == null) return 0M;
				var pct = GetCommissionPercentFromCode(CommissionCode.ToUpper());
				var mar = Quantity == 0 ? 0 : Price == 0 ? 0 : ((1 - (((decimal)pct / 100 * Price) + Cost) / Price) * 100);
				return Math.Round(mar, 2);
			}
		}

		public decimal Commission {
			get {
				if (CommissionCode == null) return 0m;
				var pct = GetCommissionPercentFromCode(CommissionCode.ToUpper());
				var com = Price == 0 ? 0 : ((decimal)pct / 100 * Price) * Quantity;
				return Math.Round(com, 2);
			}
		}

		public decimal CommissionRate => CommissionCode != null ? GetCommissionPercentFromCode(CommissionCode.ToUpper()) : 0;

		public string CommPercentString => GetCommissionPercentStringFromCode(CommissionCode);


		public static int GetCommissionPercentFromCode(string code) {
			if (code == null) return 0;
			return
				code.Equals("D") ? 1 :
				code.Equals("E") ? 2 :
				code.Equals("F") ? 3 :
				code.Equals("G") ? 4 :
				code.Equals("H") ? 5 :
				code.Equals("I") ? 6 :
				code.Equals("J") ? 7 :
				code.Equals("K") ? 8 :
				code.Equals("L") ? 9 :
				code.Equals("M") ? 10 : 0;
		}

		public static string GetCommissionPercentStringFromCode(string code) {
			if (code == null) return "";
			return
				code.Equals("D") ? "D (1%)" :
				code.Equals("E") ? "E (2%)" :
				code.Equals("F") ? "F (3%)" :
				code.Equals("G") ? "G (4%)" :
				code.Equals("H") ? "H (5%)" :
				code.Equals("I") ? "I (6%)" :
				code.Equals("J") ? "J (7%)" :
				code.Equals("K") ? "K (8%)" :
				code.Equals("L") ? "L (9%)" :
				code.Equals("M") ? "M (10%)" : code;
		}

	}

	public class Credentials {
		public string Username { get; set; }
		public string Password { get; set; }
	}

	public class CustServ {
		public string Init { get; set; }
		public string Login { get; set; }
		public string Name { get; set; }
	}

}
