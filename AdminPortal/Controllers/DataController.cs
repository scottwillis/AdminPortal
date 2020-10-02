using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mail;
using AdsDataModel;
using Common;

namespace AdminPortal.Controllers {

	[ApiController]
	[Route("[controller]")]
	public class DataController : ControllerBase {

		private readonly FoxProDataContext context = new FoxProDataContext();

		//private static readonly string[] Summaries = new[] {
		//	"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		//};

		private readonly ILogger<DataController> _logger;

		public DataController(ILogger<DataController> logger) {
			_logger = logger;
		}

		//[HttpGet]
		//public IEnumerable<WeatherForecast> Get() {
		//	var rng = new Random();
		//	return Enumerable.Range(1, 5).Select(index => new WeatherForecast {
		//		Date = DateTime.Now.AddDays(index),
		//		TemperatureC = rng.Next(-20, 55),
		//		Summary = Summaries[rng.Next(Summaries.Length)]
		//	})
		//		.ToArray();
		//}

		//public string GetWindowsUser() {
		//	var userName = User.Identity.Name;
		//	return userName;
		//}

		//[HttpGet]
		//public hbs_mis GetBsMis() {
		//	var items = context.GetBs_Mis();
		//	return items;
		//}

		[HttpGet]
		public hbs_do_w Get() {
			var items = context.GetBs_Do_W();
			return items;
		}

	}

}
