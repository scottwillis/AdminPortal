using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Advantage.Data.Provider;
using Common;

namespace AdsDataModel {

	public class hwpbmat : FoxProEntity {

		public hwpbmat() {
			Key = "itemno";
		}

		private string _itemno;
		private string _partno;
		private decimal? _qty;
		private string _code;

		public string itemno { get => _itemno; set => SetProperty(ref _itemno, value); }

		public string partno { get => _partno; set => SetProperty(ref _partno, value); }

		public decimal? qty { get => _qty; set => SetProperty(ref _qty, value); }

		public string code { get => _code; set => SetProperty(ref _code, value); }

		public sealed override string Key { get; set; }

		public sealed override object[] KeyValue => new object[] { itemno};

		public override void FillFromReader(AdsDataReader reader) {
			itemno = reader.ReadString(reader.GetOrdinal("itemno"));
			partno = reader.ReadString(reader.GetOrdinal("partno"));
			qty = reader.ReadDecimal(reader.GetOrdinal("qty"));
			code = reader.ReadString(reader.GetOrdinal("code"));
			MakeClean();
		}



	}

	public partial class FoxProDataContext
	{
		public IList<hwpbmat> GetWipBomComponents(string itemno) {
			var qTime = DateTime.Now;
			Conn.Open();
			var entities = new List<hwpbmat>();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hwpbmat";
			var reader = cmd.ExecuteExtendedReader();
			reader.ActiveIndex = "itemno";

			var found = reader.Seek(new object[] { itemno }, AdsExtendedReader.SeekType.HardSeek);
			if (found) {
				var valid = true;
				while (valid) {
					var entity = new hwpbmat();
					entity.FillFromReader(reader);
					if (entity.itemno != null) {
						if (entity.itemno != itemno) break;
						entities.Add(entity);
					}
					valid = reader.Read();
				}
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, "GetWipBomComponents");
			return entities;
		}
	}

}
