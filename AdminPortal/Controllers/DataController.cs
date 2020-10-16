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
using Microsoft.AspNetCore.Mvc.ViewFeatures;

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

		[HttpGet("GetMis")]
		public hbs_mis GetMis() {
			var item = context.GetBs_Mis();
			return item;
		}

		[HttpGet("GetBl")]
		public IList<hbs_bl> GetBL() {
			var items = new List<hbs_bl> {
				context.GetBs_Bl_W(),
				context.GetBs_Bl_I(),
				context.GetBs_Bl_O()
			};

			items.Add(
				new hbs_bl {
					bluqty = items.Sum(x => x.bluqty),
					bludol = items.Sum(x => x.bludol),

					blpqty = items.Sum(x => x.blpqty),
					blpdol = items.Sum(x => x.blpdol),

					blcqty = items.Sum(x => x.blcqty),
					blcdol = items.Sum(x => x.blcdol),

					bl1qty = items.Sum(x => x.bl1qty),
					bl1dol = items.Sum(x => x.bl1dol),

					bl2qty = items.Sum(x => x.bl2qty),
					bl2dol = items.Sum(x => x.bl2dol),

					bl3qty = items.Sum(x => x.bl3qty),
					bl3dol = items.Sum(x => x.bl3dol),

					bl4qty = items.Sum(x => x.bl4qty),
					bl4dol = items.Sum(x => x.bl4dol),

					bl5qty = items.Sum(x => x.bl5qty),
					bl5dol = items.Sum(x => x.bl5dol),

					bl6qty = items.Sum(x => x.bl6qty),
					bl6dol = items.Sum(x => x.bl6dol),

					blfqty = items.Sum(x => x.blfqty),
					blfdol = items.Sum(x => x.blfdol),

					bltot = items.Sum(x => x.bltot),
					bldol = items.Sum(x => x.bldol),
				}
			);
			return items;
		}

		[HttpGet("GetDo")]
		public IList<hbs_do> GetDo() {
			var items = new List<hbs_do> {
				context.GetBs_Do_W(),
				context.GetBs_Do_I(),
				context.GetBs_Do_O()
			};

			items.Add(
				new hbs_do {
					presunqd = items.Sum(x => x.presunqd),
					premonqd = items.Sum(x => x.premonqd),
					pretueqd = items.Sum(x => x.pretueqd),
					prewedqd = items.Sum(x => x.prewedqd),
					prethuqd = items.Sum(x => x.prethuqd),
					prefriqd = items.Sum(x => x.prefriqd),
					presatqd = items.Sum(x => x.presatqd),
					cursunqd = items.Sum(x => x.cursunqd),
					curmonqd = items.Sum(x => x.curmonqd),
					curtueqd = items.Sum(x => x.curtueqd),
					curwedqd = items.Sum(x => x.curwedqd),
					curthuqd = items.Sum(x => x.curthuqd),
					curfriqd = items.Sum(x => x.curfriqd),
					cursatqd = items.Sum(x => x.cursatqd),

					presunod = items.Sum(x => x.presunod),
					premonod = items.Sum(x => x.premonod),
					pretueod = items.Sum(x => x.pretueod),
					prewedod = items.Sum(x => x.prewedod),
					prethuod = items.Sum(x => x.prethuod),
					prefriod = items.Sum(x => x.prefriod),
					presatod = items.Sum(x => x.presatod),
					cursunod = items.Sum(x => x.cursunod),
					curmonod = items.Sum(x => x.curmonod),
					curtueod = items.Sum(x => x.curtueod),
					curwedod = items.Sum(x => x.curwedod),
					curthuod = items.Sum(x => x.curthuod),
					curfriod = items.Sum(x => x.curfriod),
					cursatod = items.Sum(x => x.cursatod),

					presunpd = items.Sum(x => x.presunpd),
					premonpd = items.Sum(x => x.premonpd),
					pretuepd = items.Sum(x => x.pretuepd),
					prewedpd = items.Sum(x => x.prewedpd),
					prethupd = items.Sum(x => x.prethupd),
					prefripd = items.Sum(x => x.prefripd),
					presatpd = items.Sum(x => x.presatpd),
					cursunpd = items.Sum(x => x.cursunpd),
					curmonpd = items.Sum(x => x.curmonpd),
					curtuepd = items.Sum(x => x.curtuepd),
					curwedpd = items.Sum(x => x.curwedpd),
					curthupd = items.Sum(x => x.curthupd),
					curfripd = items.Sum(x => x.curfripd),
					cursatpd = items.Sum(x => x.cursatpd),

					presunsd = items.Sum(x => x.presunsd),
					premonsd = items.Sum(x => x.premonsd),
					pretuesd = items.Sum(x => x.pretuesd),
					prewedsd = items.Sum(x => x.prewedsd),
					prethusd = items.Sum(x => x.prethusd),
					prefrisd = items.Sum(x => x.prefrisd),
					presatsd = items.Sum(x => x.presatsd),
					cursunsd = items.Sum(x => x.cursunsd),
					curmonsd = items.Sum(x => x.curmonsd),
					curtuesd = items.Sum(x => x.curtuesd),
					curwedsd = items.Sum(x => x.curwedsd),
					curthusd = items.Sum(x => x.curthusd),
					curfrisd = items.Sum(x => x.curfrisd),
					cursatsd = items.Sum(x => x.cursatsd),
				}
			);
			return items;
		}

	}

}
