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

	public class hbs_bl_i : FoxProEntity {

		private int _bluqty_i;
		private int _bludol_i;
		private int _blupqty_i;
		private int _blupdol_i;
		private int _blumin_i;
		private int _bluvcdol_i;
		private int _blpqty_i;
		private int _blpdol_i;
		private int _blppqty_i;
		private int _blppdol_i;
		private int _blpmin_i;
		private int _blpvcdol_i;
		private int _blcqty_i;
		private int _blcdol_i;
		private int _blcpqty_i;
		private int _blcpdol_i;
		private int _blcmin_i;
		private int _blcvcdol_i;
		private int _bl1qty_i;
		private int _bl1dol_i;
		private int _bl1pqty_i;
		private int _bl1pdol_i;
		private int _bl1min_i;
		private int _bl1vcdol_i;
		private int _bl2qty_i;
		private int _bl2dol_i;
		private int _bl2pqty_i;
		private int _bl2pdol_i;
		private int _bl2min_i;
		private int _bl2vcdol_i;
		private int _bl3qty_i;
		private int _bl3dol_i;
		private int _bl3pqty_i;
		private int _bl3pdol_i;
		private int _bl3min_i;
		private int _bl3vcdol_i;
		private int _blfqty_i;
		private int _blfdol_i;
		private int _blfpqty_i;
		private int _blfpdol_i;
		private int _blfmin_i;
		private int _blfvcdol_i;
		private int _blcstfl_i;
		private int _bltot_i;
		private int _bldol_i;
		private int _blcst_i;
		private int _blvcdol_i;

		public int bluqty_i { get => _bluqty_i; set => SetProperty(ref _bluqty_i, value); }

		public int bludol_i { get => _bludol_i; set => SetProperty(ref _bludol_i, value); }

		public int blupqty_i { get => _blupqty_i; set => SetProperty(ref _blupqty_i, value); }

		public int blupdol_i { get => _blupdol_i; set => SetProperty(ref _blupdol_i, value); }

		public int blumin_i { get => _blumin_i; set => SetProperty(ref _blumin_i, value); }

		public int bluvcdol_i { get => _bluvcdol_i; set => SetProperty(ref _bluvcdol_i, value); }

		public int blpqty_i { get => _blpqty_i; set => SetProperty(ref _blpqty_i, value); }

		public int blpdol_i { get => _blpdol_i; set => SetProperty(ref _blpdol_i, value); }

		public int blppqty_i { get => _blppqty_i; set => SetProperty(ref _blppqty_i, value); }

		public int blppdol_i { get => _blppdol_i; set => SetProperty(ref _blppdol_i, value); }

		public int blpmin_i { get => _blpmin_i; set => SetProperty(ref _blpmin_i, value); }

		public int blpvcdol_i { get => _blpvcdol_i; set => SetProperty(ref _blpvcdol_i, value); }

		public int blcqty_i { get => _blcqty_i; set => SetProperty(ref _blcqty_i, value); }

		public int blcdol_i { get => _blcdol_i; set => SetProperty(ref _blcdol_i, value); }

		public int blcpqty_i { get => _blcpqty_i; set => SetProperty(ref _blcpqty_i, value); }

		public int blcpdol_i { get => _blcpdol_i; set => SetProperty(ref _blcpdol_i, value); }

		public int blcmin_i { get => _blcmin_i; set => SetProperty(ref _blcmin_i, value); }

		public int blcvcdol_i { get => _blcvcdol_i; set => SetProperty(ref _blcvcdol_i, value); }

		public int bl1qty_i { get => _bl1qty_i; set => SetProperty(ref _bl1qty_i, value); }

		public int bl1dol_i { get => _bl1dol_i; set => SetProperty(ref _bl1dol_i, value); }

		public int bl1pqty_i { get => _bl1pqty_i; set => SetProperty(ref _bl1pqty_i, value); }

		public int bl1pdol_i { get => _bl1pdol_i; set => SetProperty(ref _bl1pdol_i, value); }

		public int bl1min_i { get => _bl1min_i; set => SetProperty(ref _bl1min_i, value); }

		public int bl1vcdol_i { get => _bl1vcdol_i; set => SetProperty(ref _bl1vcdol_i, value); }

		public int bl2qty_i { get => _bl2qty_i; set => SetProperty(ref _bl2qty_i, value); }

		public int bl2dol_i { get => _bl2dol_i; set => SetProperty(ref _bl2dol_i, value); }

		public int bl2pqty_i { get => _bl2pqty_i; set => SetProperty(ref _bl2pqty_i, value); }

		public int bl2pdol_i { get => _bl2pdol_i; set => SetProperty(ref _bl2pdol_i, value); }

		public int bl2min_i { get => _bl2min_i; set => SetProperty(ref _bl2min_i, value); }

		public int bl2vcdol_i { get => _bl2vcdol_i; set => SetProperty(ref _bl2vcdol_i, value); }

		public int bl3qty_i { get => _bl3qty_i; set => SetProperty(ref _bl3qty_i, value); }

		public int bl3dol_i { get => _bl3dol_i; set => SetProperty(ref _bl3dol_i, value); }

		public int bl3pqty_i { get => _bl3pqty_i; set => SetProperty(ref _bl3pqty_i, value); }

		public int bl3pdol_i { get => _bl3pdol_i; set => SetProperty(ref _bl3pdol_i, value); }

		public int bl3min_i { get => _bl3min_i; set => SetProperty(ref _bl3min_i, value); }

		public int bl3vcdol_i { get => _bl3vcdol_i; set => SetProperty(ref _bl3vcdol_i, value); }

		public int blfqty_i { get => _blfqty_i; set => SetProperty(ref _blfqty_i, value); }

		public int blfdol_i { get => _blfdol_i; set => SetProperty(ref _blfdol_i, value); }

		public int blfpqty_i { get => _blfpqty_i; set => SetProperty(ref _blfpqty_i, value); }

		public int blfpdol_i { get => _blfpdol_i; set => SetProperty(ref _blfpdol_i, value); }

		public int blfmin_i { get => _blfmin_i; set => SetProperty(ref _blfmin_i, value); }

		public int blfvcdol_i { get => _blfvcdol_i; set => SetProperty(ref _blfvcdol_i, value); }

		public int blcstfl_i { get => _blcstfl_i; set => SetProperty(ref _blcstfl_i, value); }

		public int bltot_i { get => _bltot_i; set => SetProperty(ref _bltot_i, value); }

		public int bldol_i { get => _bldol_i; set => SetProperty(ref _bldol_i, value); }

		public int blcst_i { get => _blcst_i; set => SetProperty(ref _blcst_i, value); }

		public int blvcdol_i { get => _blvcdol_i; set => SetProperty(ref _blvcdol_i, value); }

		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { };

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("bluqty_i")) bluqty_i = reader.ReadInt("bluqty_i");
			if (InFieldList("bludol_i")) bludol_i = reader.ReadInt("bludol_i");
			if (InFieldList("blupqty_i")) blupqty_i = reader.ReadInt("blupqty_i");
			if (InFieldList("blupdol_i")) blupdol_i = reader.ReadInt("blupdol_i");
			if (InFieldList("blumin_i")) blumin_i = reader.ReadInt("blumin_i");
			if (InFieldList("bluvcdol_i")) bluvcdol_i = reader.ReadInt("bluvcdol_i");
			if (InFieldList("blpqty_i")) blpqty_i = reader.ReadInt("blpqty_i");
			if (InFieldList("blpdol_i")) blpdol_i = reader.ReadInt("blpdol_i");
			if (InFieldList("blppqty_i")) blppqty_i = reader.ReadInt("blppqty_i");
			if (InFieldList("blppdol_i")) blppdol_i = reader.ReadInt("blppdol_i");
			if (InFieldList("blpmin_i")) blpmin_i = reader.ReadInt("blpmin_i");
			if (InFieldList("blpvcdol_i")) blpvcdol_i = reader.ReadInt("blpvcdol_i");
			if (InFieldList("blcqty_i")) blcqty_i = reader.ReadInt("blcqty_i");
			if (InFieldList("blcdol_i")) blcdol_i = reader.ReadInt("blcdol_i");
			if (InFieldList("blcpqty_i")) blcpqty_i = reader.ReadInt("blcpqty_i");
			if (InFieldList("blcpdol_i")) blcpdol_i = reader.ReadInt("blcpdol_i");
			if (InFieldList("blcmin_i")) blcmin_i = reader.ReadInt("blcmin_i");
			if (InFieldList("blcvcdol_i")) blcvcdol_i = reader.ReadInt("blcvcdol_i");
			if (InFieldList("bl1qty_i")) bl1qty_i = reader.ReadInt("bl1qty_i");
			if (InFieldList("bl1dol_i")) bl1dol_i = reader.ReadInt("bl1dol_i");
			if (InFieldList("bl1pqty_i")) bl1pqty_i = reader.ReadInt("bl1pqty_i");
			if (InFieldList("bl1pdol_i")) bl1pdol_i = reader.ReadInt("bl1pdol_i");
			if (InFieldList("bl1min_i")) bl1min_i = reader.ReadInt("bl1min_i");
			if (InFieldList("bl1vcdol_i")) bl1vcdol_i = reader.ReadInt("bl1vcdol_i");
			if (InFieldList("bl2qty_i")) bl2qty_i = reader.ReadInt("bl2qty_i");
			if (InFieldList("bl2dol_i")) bl2dol_i = reader.ReadInt("bl2dol_i");
			if (InFieldList("bl2pqty_i")) bl2pqty_i = reader.ReadInt("bl2pqty_i");
			if (InFieldList("bl2pdol_i")) bl2pdol_i = reader.ReadInt("bl2pdol_i");
			if (InFieldList("bl2min_i")) bl2min_i = reader.ReadInt("bl2min_i");
			if (InFieldList("bl2vcdol_i")) bl2vcdol_i = reader.ReadInt("bl2vcdol_i");
			if (InFieldList("bl3qty_i")) bl3qty_i = reader.ReadInt("bl3qty_i");
			if (InFieldList("bl3dol_i")) bl3dol_i = reader.ReadInt("bl3dol_i");
			if (InFieldList("bl3pqty_i")) bl3pqty_i = reader.ReadInt("bl3pqty_i");
			if (InFieldList("bl3pdol_i")) bl3pdol_i = reader.ReadInt("bl3pdol_i");
			if (InFieldList("bl3min_i")) bl3min_i = reader.ReadInt("bl3min_i");
			if (InFieldList("bl3vcdol_i")) bl3vcdol_i = reader.ReadInt("bl3vcdol_i");
			if (InFieldList("blfqty_i")) blfqty_i = reader.ReadInt("blfqty_i");
			if (InFieldList("blfdol_i")) blfdol_i = reader.ReadInt("blfdol_i");
			if (InFieldList("blfpqty_i")) blfpqty_i = reader.ReadInt("blfpqty_i");
			if (InFieldList("blfpdol_i")) blfpdol_i = reader.ReadInt("blfpdol_i");
			if (InFieldList("blfmin_i")) blfmin_i = reader.ReadInt("blfmin_i");
			if (InFieldList("blfvcdol_i")) blfvcdol_i = reader.ReadInt("blfvcdol_i");
			if (InFieldList("blcstfl_i")) blcstfl_i = reader.ReadInt("blcstfl_i");
			if (InFieldList("bltot_i")) bltot_i = reader.ReadInt("bltot_i");
			if (InFieldList("bldol_i")) bldol_i = reader.ReadInt("bldol_i");
			if (InFieldList("blcst_i")) blcst_i = reader.ReadInt("blcst_i");
			if (InFieldList("blvcdol_i")) blvcdol_i = reader.ReadInt("blvcdol_i");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public IList<hbs_bl_i> GetBs_Bl_I(string itemNo) {
			var qTime = DateTime.Now;
			Conn.Open();
			var entities = new List<hbs_bl_i>();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hbs_bl_i";
			var reader = cmd.ExecuteExtendedReader();
			reader.ActiveIndex = "itemno";
			var found = reader.Seek(new object[] { itemNo }, AdsExtendedReader.SeekType.HardSeek);
			if (found) {
				var valid = true;
				while (valid) {
					var item = reader.ReadString("itemno");
					if (item != itemNo) break;
					var entity = new hbs_bl_i();
					entity.FillFromReader(reader);
					entities.Add(entity);
					valid = reader.Read();
				}
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetBs_Bl_I");
			return entities;
		}

	}

}
