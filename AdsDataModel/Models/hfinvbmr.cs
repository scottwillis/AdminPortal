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

	public class hfinvbmr : FoxProEntity {

		public hfinvbmr() {
			Key = "";
		}


		private string _itemno;
		private string _version;
		private string _partno;
		private decimal? _qty;
		private string _code;

		[Display(Name = "ItemNo", Order = 10)]
		[MyCustom(Width = "*", IsVisible = true)]
		public string itemno { get => _itemno; set => SetProperty(ref _itemno, value); }

		[Display(Name = "Version", Order = 10)]
		[MyCustom(Width = "*", IsVisible = true)]
		public string version { get => _version; set => SetProperty(ref _version, value); }

		[Display(Name = "PartNo", Order = 10)]
		[MyCustom(Width = "*", IsVisible = true)]
		public string partno { get => _partno; set => SetProperty(ref _partno, value); }

		public decimal? qty { get => _qty; set => SetProperty(ref _qty, value); }

		public string code { get => _code; set => SetProperty(ref _code, value); }



		public sealed override string Key { get; set; }

		public sealed override object[] KeyValue => new object[] { itemno};



		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("itemno")) itemno = reader.ReadString("itemno");
			if (InFieldList("version")) version = reader.ReadString("version");
			if (InFieldList("partno")) partno = reader.ReadString("partno");
			if (InFieldList("qty")) qty = reader.ReadDecimal("qty");
			if (InFieldList("code")) code = reader.ReadString("code");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {
		public IList<hfinvbmr> GetFinishedInventoryPastBomItems(string _itemno, string _version) {
			var qTime = DateTime.Now;
			Conn.Open();
			var entities = new List<hfinvbmr>();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hfinvbmr";
			var reader = cmd.ExecuteExtendedReader();
			reader.ActiveIndex = "itemver";
			var found = reader.Seek(new object[] { _itemno, _version }, AdsExtendedReader.SeekType.HardSeek);
			if (found) {
				var valid = true;
				while (valid) {
					var itemno = reader.ReadString("itemno");
					var version = reader.ReadString("version");
					if (itemno != _itemno || version != _version) break;
					var entity = new hfinvbmr();
					entity.FillFromReader(reader);
					entities.Add(entity);
					valid = reader.Read();
				}
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetFinishedInventoryPastBomItems");
			return entities;
		}
	}

}
