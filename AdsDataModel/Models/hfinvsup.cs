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

	public class hfinvsup : FoxProEntity {

		public hfinvsup() {
			Key = "itemno";
		}

		private string _itemno;
		private string _finpart;
		private int? _qty;

		[Display(Name = "ItemNo", Order = 10)]
		[MyCustom(Width = "*", IsVisible = true)]
		public string itemno { get => _itemno; set => SetProperty(ref _itemno, value); }

		[Display(Name = "PartNo", Order = 10)]
		[MyCustom(Width = "*", IsVisible = true)]
		public string finpart { get => _finpart; set => SetProperty(ref _finpart, value); }

		[Display(Name = "Qty", Order = 10)]
		[MyCustom(Width = "*", IsVisible = true)]
		public int? qty { get => _qty; set => SetProperty(ref _qty, value); }

		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { itemno };

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("itemno")) itemno = reader.ReadString("itemno");
			if (InFieldList("finpart")) finpart = reader.ReadString("finpart");
			if (InFieldList("qty")) qty = reader.ReadInt("qty");
			MakeClean();
		}
	}

	public partial class FoxProDataContext {

		public IList<hfinvsup> GetFinishedInventorySupplementals(string itemno) {
			var qTime = DateTime.Now;			
			Conn.Open();
			var entities = new List<hfinvsup>();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hfinvsup";
			var reader = cmd.ExecuteExtendedReader();
			reader.ActiveIndex = "itemno";
			var found = reader.Seek(new object[] { itemno.Left(8) }, AdsExtendedReader.SeekType.HardSeek);
			if (found) {
				var valid = true;
				while (valid) {
					var itemno_ = reader.ReadString("itemno");
					if (itemno_ != itemno) break;
					var entity = new hfinvsup();
					entity.FillFromReader(reader);
					entities.Add(entity);
					valid = reader.Read();
					if (reader.EOF) break;
				}
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetFinishedInventorySupplement");
			return entities;
		}


	}

}
