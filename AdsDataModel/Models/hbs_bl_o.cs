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

	public class hbs_bl_o : FoxProEntity {

		private int _bluqty_o;
		private int _bludol_o;
		private int _blupqty_o;
		private int _blupdol_o;
		private int _blumin_o;
		private int _bluvcdol_o;
		private int _blpqty_o;
		private int _blpdol_o;
		private int _blppqty_o;
		private int _blppdol_o;
		private int _blpmin_o;
		private int _blpvcdol_o;
		private int _blcqty_o;
		private int _blcdol_o;
		private int _blcpqty_o;
		private int _blcpdol_o;
		private int _blcmin_o;
		private int _blcvcdol_o;
		private int _bl1qty_o;
		private int _bl1dol_o;
		private int _bl1pqty_o;
		private int _bl1pdol_o;
		private int _bl1min_o;
		private int _bl1vcdol_o;
		private int _bl2qty_o;
		private int _bl2dol_o;
		private int _bl2pqty_o;
		private int _bl2pdol_o;
		private int _bl2min_o;
		private int _bl2vcdol_o;
		private int _bl3qty_o;
		private int _bl3dol_o;
		private int _bl3pqty_o;
		private int _bl3pdol_o;
		private int _bl3min_o;
		private int _bl3vcdol_o;
		private int _blfqty_o;
		private int _blfdol_o;
		private int _blfpqty_o;
		private int _blfpdol_o;
		private int _blfmin_o;
		private int _blfvcdol_o;
		private int _blcstfl_o;
		private int _bltot_o;
		private int _bldol_o;
		private int _blcst_o;
		private int _blvcdol_o;

		public int bluqty_o { get => _bluqty_o; set => SetProperty(ref _bluqty_o, value); }

		public int bludol_o { get => _bludol_o; set => SetProperty(ref _bludol_o, value); }

		public int blupqty_o { get => _blupqty_o; set => SetProperty(ref _blupqty_o, value); }

		public int blupdol_o { get => _blupdol_o; set => SetProperty(ref _blupdol_o, value); }

		public int blumin_o { get => _blumin_o; set => SetProperty(ref _blumin_o, value); }

		public int bluvcdol_o { get => _bluvcdol_o; set => SetProperty(ref _bluvcdol_o, value); }

		public int blpqty_o { get => _blpqty_o; set => SetProperty(ref _blpqty_o, value); }

		public int blpdol_o { get => _blpdol_o; set => SetProperty(ref _blpdol_o, value); }

		public int blppqty_o { get => _blppqty_o; set => SetProperty(ref _blppqty_o, value); }

		public int blppdol_o { get => _blppdol_o; set => SetProperty(ref _blppdol_o, value); }

		public int blpmin_o { get => _blpmin_o; set => SetProperty(ref _blpmin_o, value); }

		public int blpvcdol_o { get => _blpvcdol_o; set => SetProperty(ref _blpvcdol_o, value); }

		public int blcqty_o { get => _blcqty_o; set => SetProperty(ref _blcqty_o, value); }

		public int blcdol_o { get => _blcdol_o; set => SetProperty(ref _blcdol_o, value); }

		public int blcpqty_o { get => _blcpqty_o; set => SetProperty(ref _blcpqty_o, value); }

		public int blcpdol_o { get => _blcpdol_o; set => SetProperty(ref _blcpdol_o, value); }

		public int blcmin_o { get => _blcmin_o; set => SetProperty(ref _blcmin_o, value); }

		public int blcvcdol_o { get => _blcvcdol_o; set => SetProperty(ref _blcvcdol_o, value); }

		public int bl1qty_o { get => _bl1qty_o; set => SetProperty(ref _bl1qty_o, value); }

		public int bl1dol_o { get => _bl1dol_o; set => SetProperty(ref _bl1dol_o, value); }

		public int bl1pqty_o { get => _bl1pqty_o; set => SetProperty(ref _bl1pqty_o, value); }

		public int bl1pdol_o { get => _bl1pdol_o; set => SetProperty(ref _bl1pdol_o, value); }

		public int bl1min_o { get => _bl1min_o; set => SetProperty(ref _bl1min_o, value); }

		public int bl1vcdol_o { get => _bl1vcdol_o; set => SetProperty(ref _bl1vcdol_o, value); }

		public int bl2qty_o { get => _bl2qty_o; set => SetProperty(ref _bl2qty_o, value); }

		public int bl2dol_o { get => _bl2dol_o; set => SetProperty(ref _bl2dol_o, value); }

		public int bl2pqty_o { get => _bl2pqty_o; set => SetProperty(ref _bl2pqty_o, value); }

		public int bl2pdol_o { get => _bl2pdol_o; set => SetProperty(ref _bl2pdol_o, value); }

		public int bl2min_o { get => _bl2min_o; set => SetProperty(ref _bl2min_o, value); }

		public int bl2vcdol_o { get => _bl2vcdol_o; set => SetProperty(ref _bl2vcdol_o, value); }

		public int bl3qty_o { get => _bl3qty_o; set => SetProperty(ref _bl3qty_o, value); }

		public int bl3dol_o { get => _bl3dol_o; set => SetProperty(ref _bl3dol_o, value); }

		public int bl3pqty_o { get => _bl3pqty_o; set => SetProperty(ref _bl3pqty_o, value); }

		public int bl3pdol_o { get => _bl3pdol_o; set => SetProperty(ref _bl3pdol_o, value); }

		public int bl3min_o { get => _bl3min_o; set => SetProperty(ref _bl3min_o, value); }

		public int bl3vcdol_o { get => _bl3vcdol_o; set => SetProperty(ref _bl3vcdol_o, value); }

		public int blfqty_o { get => _blfqty_o; set => SetProperty(ref _blfqty_o, value); }

		public int blfdol_o { get => _blfdol_o; set => SetProperty(ref _blfdol_o, value); }

		public int blfpqty_o { get => _blfpqty_o; set => SetProperty(ref _blfpqty_o, value); }

		public int blfpdol_o { get => _blfpdol_o; set => SetProperty(ref _blfpdol_o, value); }

		public int blfmin_o { get => _blfmin_o; set => SetProperty(ref _blfmin_o, value); }

		public int blfvcdol_o { get => _blfvcdol_o; set => SetProperty(ref _blfvcdol_o, value); }

		public int blcstfl_o { get => _blcstfl_o; set => SetProperty(ref _blcstfl_o, value); }

		public int bltot_o { get => _bltot_o; set => SetProperty(ref _bltot_o, value); }

		public int bldol_o { get => _bldol_o; set => SetProperty(ref _bldol_o, value); }

		public int blcst_o { get => _blcst_o; set => SetProperty(ref _blcst_o, value); }

		public int blvcdol_o { get => _blvcdol_o; set => SetProperty(ref _blvcdol_o, value); }

		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { };

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("bluqty_o")) bluqty_o = reader.ReadInt("bluqty_o");
			if (InFieldList("bludol_o")) bludol_o = reader.ReadInt("bludol_o");
			if (InFieldList("blupqty_o")) blupqty_o = reader.ReadInt("blupqty_o");
			if (InFieldList("blupdol_o")) blupdol_o = reader.ReadInt("blupdol_o");
			if (InFieldList("blumin_o")) blumin_o = reader.ReadInt("blumin_o");
			if (InFieldList("bluvcdol_o")) bluvcdol_o = reader.ReadInt("bluvcdol_o");
			if (InFieldList("blpqty_o")) blpqty_o = reader.ReadInt("blpqty_o");
			if (InFieldList("blpdol_o")) blpdol_o = reader.ReadInt("blpdol_o");
			if (InFieldList("blppqty_o")) blppqty_o = reader.ReadInt("blppqty_o");
			if (InFieldList("blppdol_o")) blppdol_o = reader.ReadInt("blppdol_o");
			if (InFieldList("blpmin_o")) blpmin_o = reader.ReadInt("blpmin_o");
			if (InFieldList("blpvcdol_o")) blpvcdol_o = reader.ReadInt("blpvcdol_o");
			if (InFieldList("blcqty_o")) blcqty_o = reader.ReadInt("blcqty_o");
			if (InFieldList("blcdol_o")) blcdol_o = reader.ReadInt("blcdol_o");
			if (InFieldList("blcpqty_o")) blcpqty_o = reader.ReadInt("blcpqty_o");
			if (InFieldList("blcpdol_o")) blcpdol_o = reader.ReadInt("blcpdol_o");
			if (InFieldList("blcmin_o")) blcmin_o = reader.ReadInt("blcmin_o");
			if (InFieldList("blcvcdol_o")) blcvcdol_o = reader.ReadInt("blcvcdol_o");
			if (InFieldList("bl1qty_o")) bl1qty_o = reader.ReadInt("bl1qty_o");
			if (InFieldList("bl1dol_o")) bl1dol_o = reader.ReadInt("bl1dol_o");
			if (InFieldList("bl1pqty_o")) bl1pqty_o = reader.ReadInt("bl1pqty_o");
			if (InFieldList("bl1pdol_o")) bl1pdol_o = reader.ReadInt("bl1pdol_o");
			if (InFieldList("bl1min_o")) bl1min_o = reader.ReadInt("bl1min_o");
			if (InFieldList("bl1vcdol_o")) bl1vcdol_o = reader.ReadInt("bl1vcdol_o");
			if (InFieldList("bl2qty_o")) bl2qty_o = reader.ReadInt("bl2qty_o");
			if (InFieldList("bl2dol_o")) bl2dol_o = reader.ReadInt("bl2dol_o");
			if (InFieldList("bl2pqty_o")) bl2pqty_o = reader.ReadInt("bl2pqty_o");
			if (InFieldList("bl2pdol_o")) bl2pdol_o = reader.ReadInt("bl2pdol_o");
			if (InFieldList("bl2min_o")) bl2min_o = reader.ReadInt("bl2min_o");
			if (InFieldList("bl2vcdol_o")) bl2vcdol_o = reader.ReadInt("bl2vcdol_o");
			if (InFieldList("bl3qty_o")) bl3qty_o = reader.ReadInt("bl3qty_o");
			if (InFieldList("bl3dol_o")) bl3dol_o = reader.ReadInt("bl3dol_o");
			if (InFieldList("bl3pqty_o")) bl3pqty_o = reader.ReadInt("bl3pqty_o");
			if (InFieldList("bl3pdol_o")) bl3pdol_o = reader.ReadInt("bl3pdol_o");
			if (InFieldList("bl3min_o")) bl3min_o = reader.ReadInt("bl3min_o");
			if (InFieldList("bl3vcdol_o")) bl3vcdol_o = reader.ReadInt("bl3vcdol_o");
			if (InFieldList("blfqty_o")) blfqty_o = reader.ReadInt("blfqty_o");
			if (InFieldList("blfdol_o")) blfdol_o = reader.ReadInt("blfdol_o");
			if (InFieldList("blfpqty_o")) blfpqty_o = reader.ReadInt("blfpqty_o");
			if (InFieldList("blfpdol_o")) blfpdol_o = reader.ReadInt("blfpdol_o");
			if (InFieldList("blfmin_o")) blfmin_o = reader.ReadInt("blfmin_o");
			if (InFieldList("blfvcdol_o")) blfvcdol_o = reader.ReadInt("blfvcdol_o");
			if (InFieldList("blcstfl_o")) blcstfl_o = reader.ReadInt("blcstfl_o");
			if (InFieldList("bltot_o")) bltot_o = reader.ReadInt("bltot_o");
			if (InFieldList("bldol_o")) bldol_o = reader.ReadInt("bldol_o");
			if (InFieldList("blcst_o")) blcst_o = reader.ReadInt("blcst_o");
			if (InFieldList("blvcdol_o")) blvcdol_o = reader.ReadInt("blvcdol_o");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public IList<hbs_bl_o> GetBs_Bl_O(string itemNo) {
			var qTime = DateTime.Now;
			Conn.Open();
			var entities = new List<hbs_bl_o>();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hbs_bl_o";
			var reader = cmd.ExecuteExtendedReader();
			reader.ActiveIndex = "itemno";
			var found = reader.Seek(new object[] { itemNo }, AdsExtendedReader.SeekType.HardSeek);
			if (found) {
				var valid = true;
				while (valid) {
					var item = reader.ReadString("itemno");
					if (item != itemNo) break;
					var entity = new hbs_bl_o();
					entity.FillFromReader(reader);
					entities.Add(entity);
					valid = reader.Read();
				}
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetBs_Bl_O");
			return entities;
		}

	}

}
