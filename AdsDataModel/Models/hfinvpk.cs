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

	public class hfinvpk : FoxProEntity {

		public hfinvpk() {
			Key = "itemno";
		}

		private string _itemno;
		private string _pack;
		private string _partno;
		private decimal? _qty;
		private string _code;

		[Display(Name = "ItemNo", Order = 10)]
		[MyCustom(Width = "*", IsVisible = true)]
		public string itemno { get => _itemno; set => SetProperty(ref _itemno, value); }

		[Display(Name = "Pack", Order = 10)]
		[MyCustom(Width = "*", IsVisible = true)]
		public string pack { get => _pack; set => SetProperty(ref _pack, value); }

		[Display(Name = "PartNo", Order = 10)]
		[MyCustom(Width = "*", IsVisible = true)]
		public string partno { get => _partno; set => SetProperty(ref _partno, value); }

		[Display(Name = "Qty", Order = 10)]
		[MyCustom(Width = "*", IsVisible = true)]
		public decimal? qty { get => _qty; set => SetProperty(ref _qty, value); }

		[Display(Name = "Code", Order = 10)]
		[MyCustom(Width = "*", IsVisible = true)]
		public string code { get => _code; set => SetProperty(ref _code, value); }

		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { itemno};

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("itemno")) itemno = reader.ReadString("itemno");
			if (InFieldList("pack")) pack = reader.ReadString("pack");
			if (InFieldList("partno")) partno = reader.ReadString("partno");
			if (InFieldList("qty")) qty = reader.ReadDecimal("qty");
			if (InFieldList("code")) code = reader.ReadString("code");
			MakeClean();
		}
	}

	public partial class FoxProDataContext {

		public IList<hfinvpk> GetFinishedInventoryPack(string itemno, string pack) {
			var qTime = DateTime.Now;			
			Conn.Open();
			var entities = new List<hfinvpk>();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hfinvpk";
			var reader = cmd.ExecuteExtendedReader();
			reader.ActiveIndex = "itempack";
			var found = reader.Seek(new object[] { itemno, pack }, AdsExtendedReader.SeekType.HardSeek);
			if (found) {
				var valid = true;
				while (valid) {
					var itemno_ = reader.ReadString("itemno");
					var pack_ = reader.ReadString("pack");
					if (itemno_ != itemno || pack_ != pack) break;
					var entity = new hfinvpk();
					entity.FillFromReader(reader);
					entities.Add(entity);
					valid = reader.Read();
				}
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetFinishedInventoryPack");
			return entities;
		}


	}

}
