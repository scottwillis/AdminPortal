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

	public class hbmnote : FoxProEntity {

		public hbmnote() {
			Key = "itemno";
		}


		private string _itemno;
		private string _note;

		[Display(Name = "ItemNo", Order = 10)]
		[MyCustom(Width = "*", IsVisible = true)]
		public string itemno { get => _itemno; set => SetProperty(ref _itemno, value); }

		[Display(Name = "Note", Order = 10)]
		[MyCustom(Width = "*", IsVisible = true)]
		public string note { get => _note; set => SetProperty(ref _note, value); }

		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { itemno};

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("itemno")) itemno = reader.ReadString("itemno");
			if (InFieldList("note")) note = reader.ReadString("note");
			MakeClean();
		}
	}

	public partial class FoxProDataContext {

		public IList<hbmnote> GetFinishedInventoryNotes(string itemNo) {
			var qTime = DateTime.Now;
			Conn.Open();
			var entities = new List<hbmnote>();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hbmnote";
			var reader = cmd.ExecuteExtendedReader();
			reader.ActiveIndex = "itemno";
			var found = reader.Seek(new object[] { itemNo }, AdsExtendedReader.SeekType.HardSeek);
			if (found) {
				var valid = true;
				while (valid) {
					var item = reader.ReadString("itemno");
					if (item != itemNo) break;
					var entity = new hbmnote();
					entity.FillFromReader(reader);
					entities.Add(entity);
					valid = reader.Read();
				}
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetFinishedInventoryNotes");
			return entities;
		}





	}

}
