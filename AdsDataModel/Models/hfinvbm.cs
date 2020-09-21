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

	public class hfinvbm : FoxProEntity {

		public hfinvbm() {
			Key = "itemno";
		}

		private int _sqlid;
		private int _foxid;
		private string _itemno;
		private string _partno;
		private decimal? _qty;
		private string _code;
		private string _desc;
		private decimal? _cost;

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public int sqlid { get => _sqlid; set => SetProperty(ref _sqlid, value); }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public int foxid { get => _foxid; set => SetProperty(ref _foxid, value); }

		[Display(Name = "ItemNo")]
		[MyCustom(IsVisible = false)]
		public string itemno { get => _itemno; set => SetProperty(ref _itemno, value); }

		[Display(Name = "PartNo")]
		[MyCustom(IsVisible = true)]
		public string partno { get => _partno; set => SetProperty(ref _partno, value); }

		[Display(Name = "Qty")]
		[MyCustom(IsVisible = true)]
		public decimal? qty { get => _qty; set => SetProperty(ref _qty, value); }

		[Display(Name = "Code")]
		[MyCustom(IsVisible = true)]
		public string code { get => _code; set => SetProperty(ref _code, value); }

		[Display(Name = "Cost")]
		[MyCustom(IsVisible = true, AdsIgnore =true)]
		public decimal? Cost { get => _cost; set => SetProperty(ref _cost, value); }

		[Display(Name = "Desc")]
		[MyCustom(IsVisible = true, AdsIgnore = true)]
		public string Desc {
			get {
				if (string.IsNullOrEmpty(_desc)) {
					var context = new FoxProDataContext();
					var cost = 0m;
					_desc = code == "R" ? context.GetRawInventoryDesc(partno, ref cost) : context.GetWipDetailInventoryDesc(partno, ref cost);
					Cost = cost;
				}
				return _desc;
			}
			set => SetProperty(ref _desc, value);
		}

		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { itemno};

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("itemno")) itemno = reader.ReadString("itemno");
			if (InFieldList("partno")) partno = reader.ReadString("partno");
			if (InFieldList("qty")) qty = reader.ReadDecimal("qty");
			if (InFieldList("code")) code = reader.ReadString("code");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public IList<hfinvbm> GetFinishedInventoryBomItems(string _itemno){
			var qTime = DateTime.Now;
			Conn.Open();
			var entities = new List<hfinvbm>();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hfinvbm";
			var reader = cmd.ExecuteExtendedReader();
			reader.ActiveIndex = "itemno";
			var found = reader.Seek(new object[] { _itemno }, AdsExtendedReader.SeekType.HardSeek);
			if (found) {
				var valid = true;
				while (valid) {
					var itemno = reader.ReadString("itemno");
					if (itemno != _itemno) break;
					var entity = new hfinvbm();
					entity.FillFromReader(reader);
					entities.Add(entity);
					valid = reader.Read();
				}
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetFinishedInventoryBomItems");
			return entities;
		}

	}

}
