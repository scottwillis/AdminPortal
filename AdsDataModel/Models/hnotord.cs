using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using Advantage.Data.Provider;

namespace AdsDataModel {

	public class hnotord : FoxProEntity {

		public hnotord() {
			Key = "orderno";
		}

		public string partno { get; set; }

		public string desc { get; set; }

		public string note { get; set; }

		public int orderno { get; set; }

		public int lineno { get; set; }

		public DateTime? ship_date { get; set; }

		public int repno { get; set; }

		public string custserv { get; set; }

		public string linedesc { get; set; }

		public sealed override string Key { get; set; }

		public sealed override object[] KeyValue => new object[] { orderno };

		public string PartDesc => $"{partno} {desc} {note}";

		public override void FillFromReader(AdsDataReader reader) {
			partno = reader.ReadString("partno");
			desc = reader.ReadString("desc");
			note = reader.ReadString("note");
			orderno = reader.ReadInt("orderno");
			lineno = reader.ReadInt("lineno");
			ship_date = reader.ReadDate("ship_date");
			repno = reader.ReadInt("repno");
			custserv = reader.ReadString("custserv");
			linedesc = reader.ReadString("linedesc");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public int GetAlertOrdersCount(int agencyNo) {
			var qTime = DateTime.Now;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hnotordc";
			var rdr = cmd.ExecuteExtendedReader();
			var count = 0;
			var orderno = 0;
			try {
				while (rdr.Read()) {
					var repno = rdr.ReadInt("repno");
					var neworderno = rdr.ReadInt("orderno");
					if (agencyNo == 0 || Math.Round(repno / 10m, 0) == agencyNo && orderno != neworderno) {
						orderno = neworderno;
						count++;
					}
				}
			}
			catch (Exception e) {
				Debug.WriteLine(e);
				count = GetAlertOrdersCount2(agencyNo);
			}
			rdr.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetAlertOrdersCount");
			return count;
		}

		public int GetAlertOrdersCount2(int agencyNo) {
			var qTime = DateTime.Now;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hnotord";
			var rdr = cmd.ExecuteExtendedReader();
			var count = 0;
			var orderno = 0;
			try {
				while (rdr.Read()) {
					var repno = rdr.ReadInt("repno");
					var neworderno = rdr.ReadInt("orderno");
					if (Math.Round(repno / 10m, 0) == agencyNo && orderno != neworderno) {
						count++;
						orderno = neworderno;
					}
				}
			}
			catch (Exception e) {
				Debug.WriteLine(e);
			}
			rdr.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetAlertOrdersCount2");
			return count;
		}

		public int GetAlertOrdersCount3(int agencyNo) {
			var qTime = DateTime.Now;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			var sql = $"select * from hnotordc order by orderno";
			cmd.CommandText = sql;
			var rdr = cmd.ExecuteReader();
			var count = 0;
			var orderno = 0;
			while (rdr.Read()) {
				var repno = rdr.ReadInt("repno");
				var neworderno = rdr.ReadInt("orderno");
				if (Math.Round(repno / 10m, 0) == agencyNo && orderno != neworderno) {
					count++;
					orderno = neworderno;
				}
			}
			rdr.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetAlertOrdersCount");
			return count;
		}

	}

}
