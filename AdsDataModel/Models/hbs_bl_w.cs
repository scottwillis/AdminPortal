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

	public class hbs_bl_w : FoxProEntity {

		private int _bluqty_w;
		private int _bludol_w;
		private int _blupqty_w;
		private int _blupdol_w;
		private int _blumin_w;
		private int _bluvcdol_w;
		private int _blpqty_w;
		private int _blpdol_w;
		private int _blppqty_w;
		private int _blppdol_w;
		private int _blpmin_w;
		private int _blpvcdol_w;
		private int _blcqty_w;
		private int _blcdol_w;
		private int _blcpqty_w;
		private int _blcpdol_w;
		private int _blcmin_w;
		private int _blcvcdol_w;
		private int _bl1qty_w;
		private int _bl1dol_w;
		private int _bl1pqty_w;
		private int _bl1pdol_w;
		private int _bl1min_w;
		private int _bl1vcdol_w;
		private int _bl2qty_w;
		private int _bl2dol_w;
		private int _bl2pqty_w;
		private int _bl2pdol_w;
		private int _bl2min_w;
		private int _bl2vcdol_w;
		private int _bl3qty_w;
		private int _bl3dol_w;
		private int _bl3pqty_w;
		private int _bl3pdol_w;
		private int _bl3min_w;
		private int _bl3vcdol_w;
		private int _blfqty_w;
		private int _blfdol_w;
		private int _blfpqty_w;
		private int _blfpdol_w;
		private int _blfmin_w;
		private int _blfvcdol_w;
		private int _blcstfl_w;
		private int _bltot_w;
		private int _bldol_w;
		private int _blcst_w;
		private int _blvcdol_w;

		public int bluqty_w { get => _bluqty_w; set => SetProperty(ref _bluqty_w, value); }

		public int bludol_w { get => _bludol_w; set => SetProperty(ref _bludol_w, value); }

		public int blupqty_w { get => _blupqty_w; set => SetProperty(ref _blupqty_w, value); }

		public int blupdol_w { get => _blupdol_w; set => SetProperty(ref _blupdol_w, value); }

		public int blumin_w { get => _blumin_w; set => SetProperty(ref _blumin_w, value); }

		public int bluvcdol_w { get => _bluvcdol_w; set => SetProperty(ref _bluvcdol_w, value); }

		public int blpqty_w { get => _blpqty_w; set => SetProperty(ref _blpqty_w, value); }

		public int blpdol_w { get => _blpdol_w; set => SetProperty(ref _blpdol_w, value); }

		public int blppqty_w { get => _blppqty_w; set => SetProperty(ref _blppqty_w, value); }

		public int blppdol_w { get => _blppdol_w; set => SetProperty(ref _blppdol_w, value); }

		public int blpmin_w { get => _blpmin_w; set => SetProperty(ref _blpmin_w, value); }

		public int blpvcdol_w { get => _blpvcdol_w; set => SetProperty(ref _blpvcdol_w, value); }

		public int blcqty_w { get => _blcqty_w; set => SetProperty(ref _blcqty_w, value); }

		public int blcdol_w { get => _blcdol_w; set => SetProperty(ref _blcdol_w, value); }

		public int blcpqty_w { get => _blcpqty_w; set => SetProperty(ref _blcpqty_w, value); }

		public int blcpdol_w { get => _blcpdol_w; set => SetProperty(ref _blcpdol_w, value); }

		public int blcmin_w { get => _blcmin_w; set => SetProperty(ref _blcmin_w, value); }

		public int blcvcdol_w { get => _blcvcdol_w; set => SetProperty(ref _blcvcdol_w, value); }

		public int bl1qty_w { get => _bl1qty_w; set => SetProperty(ref _bl1qty_w, value); }

		public int bl1dol_w { get => _bl1dol_w; set => SetProperty(ref _bl1dol_w, value); }

		public int bl1pqty_w { get => _bl1pqty_w; set => SetProperty(ref _bl1pqty_w, value); }

		public int bl1pdol_w { get => _bl1pdol_w; set => SetProperty(ref _bl1pdol_w, value); }

		public int bl1min_w { get => _bl1min_w; set => SetProperty(ref _bl1min_w, value); }

		public int bl1vcdol_w { get => _bl1vcdol_w; set => SetProperty(ref _bl1vcdol_w, value); }

		public int bl2qty_w { get => _bl2qty_w; set => SetProperty(ref _bl2qty_w, value); }

		public int bl2dol_w { get => _bl2dol_w; set => SetProperty(ref _bl2dol_w, value); }

		public int bl2pqty_w { get => _bl2pqty_w; set => SetProperty(ref _bl2pqty_w, value); }

		public int bl2pdol_w { get => _bl2pdol_w; set => SetProperty(ref _bl2pdol_w, value); }

		public int bl2min_w { get => _bl2min_w; set => SetProperty(ref _bl2min_w, value); }

		public int bl2vcdol_w { get => _bl2vcdol_w; set => SetProperty(ref _bl2vcdol_w, value); }

		public int bl3qty_w { get => _bl3qty_w; set => SetProperty(ref _bl3qty_w, value); }

		public int bl3dol_w { get => _bl3dol_w; set => SetProperty(ref _bl3dol_w, value); }

		public int bl3pqty_w { get => _bl3pqty_w; set => SetProperty(ref _bl3pqty_w, value); }

		public int bl3pdol_w { get => _bl3pdol_w; set => SetProperty(ref _bl3pdol_w, value); }

		public int bl3min_w { get => _bl3min_w; set => SetProperty(ref _bl3min_w, value); }

		public int bl3vcdol_w { get => _bl3vcdol_w; set => SetProperty(ref _bl3vcdol_w, value); }

		public int blfqty_w { get => _blfqty_w; set => SetProperty(ref _blfqty_w, value); }

		public int blfdol_w { get => _blfdol_w; set => SetProperty(ref _blfdol_w, value); }

		public int blfpqty_w { get => _blfpqty_w; set => SetProperty(ref _blfpqty_w, value); }

		public int blfpdol_w { get => _blfpdol_w; set => SetProperty(ref _blfpdol_w, value); }

		public int blfmin_w { get => _blfmin_w; set => SetProperty(ref _blfmin_w, value); }

		public int blfvcdol_w { get => _blfvcdol_w; set => SetProperty(ref _blfvcdol_w, value); }

		public int blcstfl_w { get => _blcstfl_w; set => SetProperty(ref _blcstfl_w, value); }

		public int bltot_w { get => _bltot_w; set => SetProperty(ref _bltot_w, value); }

		public int bldol_w { get => _bldol_w; set => SetProperty(ref _bldol_w, value); }

		public int blcst_w { get => _blcst_w; set => SetProperty(ref _blcst_w, value); }

		public int blvcdol_w { get => _blvcdol_w; set => SetProperty(ref _blvcdol_w, value); }

		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { };

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("bluqty_w")) bluqty_w = reader.ReadInt("bluqty_w");
			if (InFieldList("bludol_w")) bludol_w = reader.ReadInt("bludol_w");
			if (InFieldList("blupqty_w")) blupqty_w = reader.ReadInt("blupqty_w");
			if (InFieldList("blupdol_w")) blupdol_w = reader.ReadInt("blupdol_w");
			if (InFieldList("blumin_w")) blumin_w = reader.ReadInt("blumin_w");
			if (InFieldList("bluvcdol_w")) bluvcdol_w = reader.ReadInt("bluvcdol_w");
			if (InFieldList("blpqty_w")) blpqty_w = reader.ReadInt("blpqty_w");
			if (InFieldList("blpdol_w")) blpdol_w = reader.ReadInt("blpdol_w");
			if (InFieldList("blppqty_w")) blppqty_w = reader.ReadInt("blppqty_w");
			if (InFieldList("blppdol_w")) blppdol_w = reader.ReadInt("blppdol_w");
			if (InFieldList("blpmin_w")) blpmin_w = reader.ReadInt("blpmin_w");
			if (InFieldList("blpvcdol_w")) blpvcdol_w = reader.ReadInt("blpvcdol_w");
			if (InFieldList("blcqty_w")) blcqty_w = reader.ReadInt("blcqty_w");
			if (InFieldList("blcdol_w")) blcdol_w = reader.ReadInt("blcdol_w");
			if (InFieldList("blcpqty_w")) blcpqty_w = reader.ReadInt("blcpqty_w");
			if (InFieldList("blcpdol_w")) blcpdol_w = reader.ReadInt("blcpdol_w");
			if (InFieldList("blcmin_w")) blcmin_w = reader.ReadInt("blcmin_w");
			if (InFieldList("blcvcdol_w")) blcvcdol_w = reader.ReadInt("blcvcdol_w");
			if (InFieldList("bl1qty_w")) bl1qty_w = reader.ReadInt("bl1qty_w");
			if (InFieldList("bl1dol_w")) bl1dol_w = reader.ReadInt("bl1dol_w");
			if (InFieldList("bl1pqty_w")) bl1pqty_w = reader.ReadInt("bl1pqty_w");
			if (InFieldList("bl1pdol_w")) bl1pdol_w = reader.ReadInt("bl1pdol_w");
			if (InFieldList("bl1min_w")) bl1min_w = reader.ReadInt("bl1min_w");
			if (InFieldList("bl1vcdol_w")) bl1vcdol_w = reader.ReadInt("bl1vcdol_w");
			if (InFieldList("bl2qty_w")) bl2qty_w = reader.ReadInt("bl2qty_w");
			if (InFieldList("bl2dol_w")) bl2dol_w = reader.ReadInt("bl2dol_w");
			if (InFieldList("bl2pqty_w")) bl2pqty_w = reader.ReadInt("bl2pqty_w");
			if (InFieldList("bl2pdol_w")) bl2pdol_w = reader.ReadInt("bl2pdol_w");
			if (InFieldList("bl2min_w")) bl2min_w = reader.ReadInt("bl2min_w");
			if (InFieldList("bl2vcdol_w")) bl2vcdol_w = reader.ReadInt("bl2vcdol_w");
			if (InFieldList("bl3qty_w")) bl3qty_w = reader.ReadInt("bl3qty_w");
			if (InFieldList("bl3dol_w")) bl3dol_w = reader.ReadInt("bl3dol_w");
			if (InFieldList("bl3pqty_w")) bl3pqty_w = reader.ReadInt("bl3pqty_w");
			if (InFieldList("bl3pdol_w")) bl3pdol_w = reader.ReadInt("bl3pdol_w");
			if (InFieldList("bl3min_w")) bl3min_w = reader.ReadInt("bl3min_w");
			if (InFieldList("bl3vcdol_w")) bl3vcdol_w = reader.ReadInt("bl3vcdol_w");
			if (InFieldList("blfqty_w")) blfqty_w = reader.ReadInt("blfqty_w");
			if (InFieldList("blfdol_w")) blfdol_w = reader.ReadInt("blfdol_w");
			if (InFieldList("blfpqty_w")) blfpqty_w = reader.ReadInt("blfpqty_w");
			if (InFieldList("blfpdol_w")) blfpdol_w = reader.ReadInt("blfpdol_w");
			if (InFieldList("blfmin_w")) blfmin_w = reader.ReadInt("blfmin_w");
			if (InFieldList("blfvcdol_w")) blfvcdol_w = reader.ReadInt("blfvcdol_w");
			if (InFieldList("blcstfl_w")) blcstfl_w = reader.ReadInt("blcstfl_w");
			if (InFieldList("bltot_w")) bltot_w = reader.ReadInt("bltot_w");
			if (InFieldList("bldol_w")) bldol_w = reader.ReadInt("bldol_w");
			if (InFieldList("blcst_w")) blcst_w = reader.ReadInt("blcst_w");
			if (InFieldList("blvcdol_w")) blvcdol_w = reader.ReadInt("blvcdol_w");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public IList<hbs_bl_w> GetBs_Bl_W(string itemNo) {
			var qTime = DateTime.Now;
			Conn.Open();
			var entities = new List<hbs_bl_w>();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hbs_bl_w";
			var reader = cmd.ExecuteExtendedReader();
			reader.ActiveIndex = "itemno";
			var found = reader.Seek(new object[] { itemNo }, AdsExtendedReader.SeekType.HardSeek);
			if (found) {
				var valid = true;
				while (valid) {
					var item = reader.ReadString("itemno");
					if (item != itemNo) break;
					var entity = new hbs_bl_w();
					entity.FillFromReader(reader);
					entities.Add(entity);
					valid = reader.Read();
				}
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetBs_Bl_W");
			return entities;
		}

	}

}
