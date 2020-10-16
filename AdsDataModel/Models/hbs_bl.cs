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

	public class hbs_bl : FoxProEntity {

		private int _bluqty;
		private int _bludol;
		private int _blupqty;
		private int _blupdol;
		private int _blumin;
		private int _bluvcdol;

		private int _blpqty;
		private int _blpdol;
		private int _blppqty;
		private int _blppdol;
		private int _blpmin;
		private int _blpvcdol;

		private int _blcqty;
		private int _blcdol;
		private int _blcpqty;
		private int _blcpdol;
		private int _blcmin;
		private int _blcvcdol;

		private int _bl1qty;
		private int _bl1dol;
		private int _bl1pqty;
		private int _bl1pdol;
		private int _bl1min;
		private int _bl1vcdol;

		private int _bl2qty;
		private int _bl2dol;
		private int _bl2pqty;
		private int _bl2pdol;
		private int _bl2min;
		private int _bl2vcdol;

		private int _bl3qty;
		private int _bl3dol;
		private int _bl3pqty;
		private int _bl3pdol;
		private int _bl3min;
		private int _bl3vcdol;

		private int _bl4qty;
		private int _bl4dol;
		private int _bl4pqty;
		private int _bl4pdol;
		private int _bl4min;
		private int _bl4vcdol;

		private int _bl5qty;
		private int _bl5dol;
		private int _bl5pqty;
		private int _bl5pdol;
		private int _bl5min;
		private int _bl5vcdol;

		private int _bl6qty;
		private int _bl6dol;
		private int _bl6pqty;
		private int _bl6pdol;
		private int _bl6min;
		private int _bl6vcdol;

		private int _blfqty;
		private int _blfdol;
		private int _blfpqty;
		private int _blfpdol;
		private int _blfmin;
		private int _blfvcdol;

		private int _blcstfl;
		private int _bltot;
		private int _bldol;
		private int _blcst;
		private int _blvcdol;

		public int bluqty { get => _bluqty; set => SetProperty(ref _bluqty, value); }

		public int bludol { get => _bludol; set => SetProperty(ref _bludol, value); }

		public int blupqty { get => _blupqty; set => SetProperty(ref _blupqty, value); }

		public int blupdol { get => _blupdol; set => SetProperty(ref _blupdol, value); }

		public int blumin { get => _blumin; set => SetProperty(ref _blumin, value); }

		public int bluvcdol { get => _bluvcdol; set => SetProperty(ref _bluvcdol, value); }

		public int blpqty { get => _blpqty; set => SetProperty(ref _blpqty, value); }

		public int blpdol { get => _blpdol; set => SetProperty(ref _blpdol, value); }

		public int blppqty { get => _blppqty; set => SetProperty(ref _blppqty, value); }

		public int blppdol { get => _blppdol; set => SetProperty(ref _blppdol, value); }

		public int blpmin { get => _blpmin; set => SetProperty(ref _blpmin, value); }

		public int blpvcdol { get => _blpvcdol; set => SetProperty(ref _blpvcdol, value); }

		public int blcqty { get => _blcqty; set => SetProperty(ref _blcqty, value); }

		public int blcdol { get => _blcdol; set => SetProperty(ref _blcdol, value); }

		public int blcpqty { get => _blcpqty; set => SetProperty(ref _blcpqty, value); }

		public int blcpdol { get => _blcpdol; set => SetProperty(ref _blcpdol, value); }

		public int blcmin { get => _blcmin; set => SetProperty(ref _blcmin, value); }

		public int blcvcdol { get => _blcvcdol; set => SetProperty(ref _blcvcdol, value); }

		public int bl1qty { get => _bl1qty; set => SetProperty(ref _bl1qty, value); }

		public int bl1dol { get => _bl1dol; set => SetProperty(ref _bl1dol, value); }

		public int bl1pqty { get => _bl1pqty; set => SetProperty(ref _bl1pqty, value); }

		public int bl1pdol { get => _bl1pdol; set => SetProperty(ref _bl1pdol, value); }

		public int bl1min { get => _bl1min; set => SetProperty(ref _bl1min, value); }

		public int bl1vcdol { get => _bl1vcdol; set => SetProperty(ref _bl1vcdol, value); }

		public int bl2qty { get => _bl2qty; set => SetProperty(ref _bl2qty, value); }

		public int bl2dol { get => _bl2dol; set => SetProperty(ref _bl2dol, value); }

		public int bl2pqty { get => _bl2pqty; set => SetProperty(ref _bl2pqty, value); }

		public int bl2pdol { get => _bl2pdol; set => SetProperty(ref _bl2pdol, value); }

		public int bl2min { get => _bl2min; set => SetProperty(ref _bl2min, value); }

		public int bl2vcdol { get => _bl2vcdol; set => SetProperty(ref _bl2vcdol, value); }

		public int bl3qty { get => _bl3qty; set => SetProperty(ref _bl3qty, value); }

		public int bl3dol { get => _bl3dol; set => SetProperty(ref _bl3dol, value); }
		
		public int bl3pqty { get => _bl3pqty; set => SetProperty(ref _bl3pqty, value); }
		
		public int bl3pdol { get => _bl3pdol; set => SetProperty(ref _bl3pdol, value); }
		
		public int bl3min { get => _bl3min; set => SetProperty(ref _bl3min, value); }
		
		public int bl3vcdol { get => _bl3vcdol; set => SetProperty(ref _bl3vcdol, value); }

		public int bl4qty { get => _bl4qty; set => SetProperty(ref _bl4qty, value); }
		
		public int bl4dol { get => _bl4dol; set => SetProperty(ref _bl4dol, value); }
		
		public int bl4pqty { get => _bl4pqty; set => SetProperty(ref _bl4pqty, value); }
		
		public int bl4pdol { get => _bl4pdol; set => SetProperty(ref _bl4pdol, value); }
		
		public int bl4min { get => _bl4min; set => SetProperty(ref _bl4min, value); }
		
		public int bl4vcdol { get => _bl4vcdol; set => SetProperty(ref _bl4vcdol, value); }

		public int bl5qty { get => _bl5qty; set => SetProperty(ref _bl5qty, value); }
		
		public int bl5dol { get => _bl5dol; set => SetProperty(ref _bl5dol, value); }
		
		public int bl5pqty { get => _bl5pqty; set => SetProperty(ref _bl5pqty, value); }
		
		public int bl5pdol { get => _bl5pdol; set => SetProperty(ref _bl5pdol, value); }
		
		public int bl5min { get => _bl5min; set => SetProperty(ref _bl5min, value); }
		
		public int bl5vcdol { get => _bl5vcdol; set => SetProperty(ref _bl5vcdol, value); }

		public int bl6qty { get => _bl6qty; set => SetProperty(ref _bl6qty, value); }
		
		public int bl6dol { get => _bl6dol; set => SetProperty(ref _bl6dol, value); }
		
		public int bl6pqty { get => _bl6pqty; set => SetProperty(ref _bl6pqty, value); }
		
		public int bl6pdol { get => _bl6pdol; set => SetProperty(ref _bl6pdol, value); }
		
		public int bl6min { get => _bl6min; set => SetProperty(ref _bl6min, value); }
		
		public int bl6vcdol { get => _bl6vcdol; set => SetProperty(ref _bl6vcdol, value); }
		
		public int blfqty { get => _blfqty; set => SetProperty(ref _blfqty, value); }

		public int blfdol { get => _blfdol; set => SetProperty(ref _blfdol, value); }

		public int blfpqty { get => _blfpqty; set => SetProperty(ref _blfpqty, value); }

		public int blfpdol { get => _blfpdol; set => SetProperty(ref _blfpdol, value); }

		public int blfmin { get => _blfmin; set => SetProperty(ref _blfmin, value); }

		public int blfvcdol { get => _blfvcdol; set => SetProperty(ref _blfvcdol, value); }

		public int blcstfl { get => _blcstfl; set => SetProperty(ref _blcstfl, value); }

		public int bltot { get => _bltot; set => SetProperty(ref _bltot, value); }

		public int bldol { get => _bldol; set => SetProperty(ref _bldol, value); }

		public int blcst { get => _blcst; set => SetProperty(ref _blcst, value); }

		public int blvcdol { get => _blvcdol; set => SetProperty(ref _blvcdol, value); }

		public int bltqty => bluqty + blpqty + blcqty + bl1qty + bl2qty + bl3qty + bl4qty + bl5qty + bl6qty + blfqty;

		public int bltdol => bludol + blpdol + blcdol + bl1dol + bl2dol + bl3dol + bl4dol + bl5dol + bl6dol + blfdol;

		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { };

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("bluqty_w")) bluqty = reader.ReadInt("bluqty_w");
			if (InFieldList("bludol_w")) bludol = reader.ReadInt("bludol_w");
			if (InFieldList("blupqty_w")) blupqty = reader.ReadInt("blupqty_w");
			if (InFieldList("blupdol_w")) blupdol = reader.ReadInt("blupdol_w");
			if (InFieldList("blumin_w")) blumin = reader.ReadInt("blumin_w");
			if (InFieldList("bluvcdol_w")) bluvcdol = reader.ReadInt("bluvcdol_w");
			if (InFieldList("blpqty_w")) blpqty = reader.ReadInt("blpqty_w");
			if (InFieldList("blpdol_w")) blpdol = reader.ReadInt("blpdol_w");
			if (InFieldList("blppqty_w")) blppqty = reader.ReadInt("blppqty_w");
			if (InFieldList("blppdol_w")) blppdol = reader.ReadInt("blppdol_w");
			if (InFieldList("blpmin_w")) blpmin = reader.ReadInt("blpmin_w");
			if (InFieldList("blpvcdol_w")) blpvcdol = reader.ReadInt("blpvcdol_w");
			if (InFieldList("blcqty_w")) blcqty = reader.ReadInt("blcqty_w");
			if (InFieldList("blcdol_w")) blcdol = reader.ReadInt("blcdol_w");
			if (InFieldList("blcpqty_w")) blcpqty = reader.ReadInt("blcpqty_w");
			if (InFieldList("blcpdol_w")) blcpdol = reader.ReadInt("blcpdol_w");
			if (InFieldList("blcmin_w")) blcmin = reader.ReadInt("blcmin_w");
			if (InFieldList("blcvcdol_w")) blcvcdol = reader.ReadInt("blcvcdol_w");
			if (InFieldList("bl1qty_w")) bl1qty = reader.ReadInt("bl1qty_w");
			if (InFieldList("bl1dol_w")) bl1dol = reader.ReadInt("bl1dol_w");
			if (InFieldList("bl1pqty_w")) bl1pqty = reader.ReadInt("bl1pqty_w");
			if (InFieldList("bl1pdol_w")) bl1pdol = reader.ReadInt("bl1pdol_w");
			if (InFieldList("bl1min_w")) bl1min = reader.ReadInt("bl1min_w");
			if (InFieldList("bl1vcdol_w")) bl1vcdol = reader.ReadInt("bl1vcdol_w");
			if (InFieldList("bl2qty_w")) bl2qty = reader.ReadInt("bl2qty_w");
			if (InFieldList("bl2dol_w")) bl2dol = reader.ReadInt("bl2dol_w");
			if (InFieldList("bl2pqty_w")) bl2pqty = reader.ReadInt("bl2pqty_w");
			if (InFieldList("bl2pdol_w")) bl2pdol = reader.ReadInt("bl2pdol_w");
			if (InFieldList("bl2min_w")) bl2min = reader.ReadInt("bl2min_w");
			if (InFieldList("bl2vcdol_w")) bl2vcdol = reader.ReadInt("bl2vcdol_w");
			if (InFieldList("bl3qty_w")) bl3qty = reader.ReadInt("bl3qty_w");
			if (InFieldList("bl3dol_w")) bl3dol = reader.ReadInt("bl3dol_w");
			if (InFieldList("bl3pqty_w")) bl3pqty = reader.ReadInt("bl3pqty_w");
			if (InFieldList("bl3pdol_w")) bl3pdol = reader.ReadInt("bl3pdol_w");
			if (InFieldList("bl3min_w")) bl3min = reader.ReadInt("bl3min_w");
			if (InFieldList("bl3vcdol_w")) bl3vcdol = reader.ReadInt("bl3vcdol_w");
			if (InFieldList("bl4qty_w")) bl4qty = reader.ReadInt("bl4qty_w");
			if (InFieldList("bl4dol_w")) bl4dol = reader.ReadInt("bl4dol_w");
			if (InFieldList("bl4pqty_w")) bl4pqty = reader.ReadInt("bl4pqty_w");
			if (InFieldList("bl4pdol_w")) bl4pdol = reader.ReadInt("bl4pdol_w");
			if (InFieldList("bl4min_w")) bl4min = reader.ReadInt("bl4min_w");
			if (InFieldList("bl4vcdol_w")) bl4vcdol = reader.ReadInt("bl4vcdol_w");
			if (InFieldList("bl5qty_w")) bl5qty = reader.ReadInt("bl5qty_w");
			if (InFieldList("bl5dol_w")) bl5dol = reader.ReadInt("bl5dol_w");
			if (InFieldList("bl5pqty_w")) bl5pqty = reader.ReadInt("bl5pqty_w");
			if (InFieldList("bl5pdol_w")) bl5pdol = reader.ReadInt("bl5pdol_w");
			if (InFieldList("bl5min_w")) bl5min = reader.ReadInt("bl5min_w");
			if (InFieldList("bl5vcdol_w")) bl5vcdol = reader.ReadInt("bl5vcdol_w");
			if (InFieldList("bl6qty_w")) bl6qty = reader.ReadInt("bl6qty_w");
			if (InFieldList("bl6dol_w")) bl6dol = reader.ReadInt("bl6dol_w");
			if (InFieldList("bl6pqty_w")) bl6pqty = reader.ReadInt("bl6pqty_w");
			if (InFieldList("bl6pdol_w")) bl6pdol = reader.ReadInt("bl6pdol_w");
			if (InFieldList("bl6min_w")) bl6min = reader.ReadInt("bl6min_w");
			if (InFieldList("bl6vcdol_w")) bl6vcdol = reader.ReadInt("bl6vcdol_w");
			if (InFieldList("blfqty_w")) blfqty = reader.ReadInt("blfqty_w");
			if (InFieldList("blfdol_w")) blfdol = reader.ReadInt("blfdol_w");
			if (InFieldList("blfpqty_w")) blfpqty = reader.ReadInt("blfpqty_w");
			if (InFieldList("blfpdol_w")) blfpdol = reader.ReadInt("blfpdol_w");
			if (InFieldList("blfmin_w")) blfmin = reader.ReadInt("blfmin_w");
			if (InFieldList("blfvcdol_w")) blfvcdol = reader.ReadInt("blfvcdol_w");
			if (InFieldList("blcstfl_w")) blcstfl = reader.ReadInt("blcstfl_w");
			if (InFieldList("bltot_w")) bltot = reader.ReadInt("bltot_w");
			if (InFieldList("bldol_w")) bldol = reader.ReadInt("bldol_w");
			if (InFieldList("blcst_w")) blcst = reader.ReadInt("blcst_w");
			if (InFieldList("blvcdol_w")) blvcdol = reader.ReadInt("blvcdol_w");
			MakeClean();
		}

	}

	public class hbs_bl_w : hbs_bl {

	}

	public class hbs_bl_i : hbs_bl {

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("bluqty_i")) bluqty = reader.ReadInt("bluqty_i");
			if (InFieldList("bludol_i")) bludol = reader.ReadInt("bludol_i");
			if (InFieldList("blupqty_i")) blupqty = reader.ReadInt("blupqty_i");
			if (InFieldList("blupdol_i")) blupdol = reader.ReadInt("blupdol_i");
			if (InFieldList("blumin_i")) blumin = reader.ReadInt("blumin_i");
			if (InFieldList("bluvcdol_i")) bluvcdol = reader.ReadInt("bluvcdol_i");
			if (InFieldList("blpqty_i")) blpqty = reader.ReadInt("blpqty_i");
			if (InFieldList("blpdol_i")) blpdol = reader.ReadInt("blpdol_i");
			if (InFieldList("blppqty_i")) blppqty = reader.ReadInt("blppqty_i");
			if (InFieldList("blppdol_i")) blppdol = reader.ReadInt("blppdol_i");
			if (InFieldList("blpmin_i")) blpmin = reader.ReadInt("blpmin_i");
			if (InFieldList("blpvcdol_i")) blpvcdol = reader.ReadInt("blpvcdol_i");
			if (InFieldList("blcqty_i")) blcqty = reader.ReadInt("blcqty_i");
			if (InFieldList("blcdol_i")) blcdol = reader.ReadInt("blcdol_i");
			if (InFieldList("blcpqty_i")) blcpqty = reader.ReadInt("blcpqty_i");
			if (InFieldList("blcpdol_i")) blcpdol = reader.ReadInt("blcpdol_i");
			if (InFieldList("blcmin_i")) blcmin = reader.ReadInt("blcmin_i");
			if (InFieldList("blcvcdol_i")) blcvcdol = reader.ReadInt("blcvcdol_i");
			if (InFieldList("bl1qty_i")) bl1qty = reader.ReadInt("bl1qty_i");
			if (InFieldList("bl1dol_i")) bl1dol = reader.ReadInt("bl1dol_i");
			if (InFieldList("bl1pqty_i")) bl1pqty = reader.ReadInt("bl1pqty_i");
			if (InFieldList("bl1pdol_i")) bl1pdol = reader.ReadInt("bl1pdol_i");
			if (InFieldList("bl1min_i")) bl1min = reader.ReadInt("bl1min_i");
			if (InFieldList("bl1vcdol_i")) bl1vcdol = reader.ReadInt("bl1vcdol_i");
			if (InFieldList("bl2qty_i")) bl2qty = reader.ReadInt("bl2qty_i");
			if (InFieldList("bl2dol_i")) bl2dol = reader.ReadInt("bl2dol_i");
			if (InFieldList("bl2pqty_i")) bl2pqty = reader.ReadInt("bl2pqty_i");
			if (InFieldList("bl2pdol_i")) bl2pdol = reader.ReadInt("bl2pdol_i");
			if (InFieldList("bl2min_i")) bl2min = reader.ReadInt("bl2min_i");
			if (InFieldList("bl2vcdol_i")) bl2vcdol = reader.ReadInt("bl2vcdol_i");
			if (InFieldList("bl3qty_i")) bl3qty = reader.ReadInt("bl3qty_i");
			if (InFieldList("bl3dol_i")) bl3dol = reader.ReadInt("bl3dol_i");
			if (InFieldList("bl3pqty_i")) bl3pqty = reader.ReadInt("bl3pqty_i");
			if (InFieldList("bl3pdol_i")) bl3pdol = reader.ReadInt("bl3pdol_i");
			if (InFieldList("bl3min_i")) bl3min = reader.ReadInt("bl3min_i");
			if (InFieldList("bl3vcdol_i")) bl3vcdol = reader.ReadInt("bl3vcdol_i");
			if (InFieldList("bl4qty_i")) bl4qty = reader.ReadInt("bl4qty_i");
			if (InFieldList("bl4dol_i")) bl4dol = reader.ReadInt("bl4dol_i");
			if (InFieldList("bl4pqty_i")) bl4pqty = reader.ReadInt("bl4pqty_i");
			if (InFieldList("bl4pdol_i")) bl4pdol = reader.ReadInt("bl4pdol_i");
			if (InFieldList("bl4min_i")) bl4min = reader.ReadInt("bl4min_i");
			if (InFieldList("bl4vcdol_i")) bl4vcdol = reader.ReadInt("bl4vcdol_i");
			if (InFieldList("bl5qty_i")) bl5qty = reader.ReadInt("bl5qty_i");
			if (InFieldList("bl5dol_i")) bl5dol = reader.ReadInt("bl5dol_i");
			if (InFieldList("bl5pqty_i")) bl5pqty = reader.ReadInt("bl5pqty_i");
			if (InFieldList("bl5pdol_i")) bl5pdol = reader.ReadInt("bl5pdol_i");
			if (InFieldList("bl5min_i")) bl5min = reader.ReadInt("bl5min_i");
			if (InFieldList("bl5vcdol_i")) bl5vcdol = reader.ReadInt("bl5vcdol_i");
			if (InFieldList("bl6qty_i")) bl6qty = reader.ReadInt("bl6qty_i");
			if (InFieldList("bl6dol_i")) bl6dol = reader.ReadInt("bl6dol_i");
			if (InFieldList("bl6pqty_i")) bl6pqty = reader.ReadInt("bl6pqty_i");
			if (InFieldList("bl6pdol_i")) bl6pdol = reader.ReadInt("bl6pdol_i");
			if (InFieldList("bl6min_i")) bl6min = reader.ReadInt("bl6min_i");
			if (InFieldList("bl6vcdol_i")) bl6vcdol = reader.ReadInt("bl6vcdol_i");
			if (InFieldList("blfqty_i")) blfqty = reader.ReadInt("blfqty_i");
			if (InFieldList("blfdol_i")) blfdol = reader.ReadInt("blfdol_i");
			if (InFieldList("blfpqty_i")) blfpqty = reader.ReadInt("blfpqty_i");
			if (InFieldList("blfpdol_i")) blfpdol = reader.ReadInt("blfpdol_i");
			if (InFieldList("blfmin_i")) blfmin = reader.ReadInt("blfmin_i");
			if (InFieldList("blfvcdol_i")) blfvcdol = reader.ReadInt("blfvcdol_i");
			if (InFieldList("blcstfl_i")) blcstfl = reader.ReadInt("blcstfl_i");
			if (InFieldList("bltot_i")) bltot = reader.ReadInt("bltot_i");
			if (InFieldList("bldol_i")) bldol = reader.ReadInt("bldol_i");
			if (InFieldList("blcst_i")) blcst = reader.ReadInt("blcst_i");
			if (InFieldList("blvcdol_i")) blvcdol = reader.ReadInt("blvcdol_i");
			MakeClean();
		}

	}

	public class hbs_bl_o : hbs_bl {

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("bluqty_o")) bluqty = reader.ReadInt("bluqty_o");
			if (InFieldList("bludol_o")) bludol = reader.ReadInt("bludol_o");
			if (InFieldList("blupqty_o")) blupqty = reader.ReadInt("blupqty_o");
			if (InFieldList("blupdol_o")) blupdol = reader.ReadInt("blupdol_o");
			if (InFieldList("blumin_o")) blumin = reader.ReadInt("blumin_o");
			if (InFieldList("bluvcdol_o")) bluvcdol = reader.ReadInt("bluvcdol_o");
			if (InFieldList("blpqty_o")) blpqty = reader.ReadInt("blpqty_o");
			if (InFieldList("blpdol_o")) blpdol = reader.ReadInt("blpdol_o");
			if (InFieldList("blppqty_o")) blppqty = reader.ReadInt("blppqty_o");
			if (InFieldList("blppdol_o")) blppdol = reader.ReadInt("blppdol_o");
			if (InFieldList("blpmin_o")) blpmin = reader.ReadInt("blpmin_o");
			if (InFieldList("blpvcdol_o")) blpvcdol = reader.ReadInt("blpvcdol_o");
			if (InFieldList("blcqty_o")) blcqty = reader.ReadInt("blcqty_o");
			if (InFieldList("blcdol_o")) blcdol = reader.ReadInt("blcdol_o");
			if (InFieldList("blcpqty_o")) blcpqty = reader.ReadInt("blcpqty_o");
			if (InFieldList("blcpdol_o")) blcpdol = reader.ReadInt("blcpdol_o");
			if (InFieldList("blcmin_o")) blcmin = reader.ReadInt("blcmin_o");
			if (InFieldList("blcvcdol_o")) blcvcdol = reader.ReadInt("blcvcdol_o");
			if (InFieldList("bl1qty_o")) bl1qty = reader.ReadInt("bl1qty_o");
			if (InFieldList("bl1dol_o")) bl1dol = reader.ReadInt("bl1dol_o");
			if (InFieldList("bl1pqty_o")) bl1pqty = reader.ReadInt("bl1pqty_o");
			if (InFieldList("bl1pdol_o")) bl1pdol = reader.ReadInt("bl1pdol_o");
			if (InFieldList("bl1min_o")) bl1min = reader.ReadInt("bl1min_o");
			if (InFieldList("bl1vcdol_o")) bl1vcdol = reader.ReadInt("bl1vcdol_o");
			if (InFieldList("bl2qty_o")) bl2qty = reader.ReadInt("bl2qty_o");
			if (InFieldList("bl2dol_o")) bl2dol = reader.ReadInt("bl2dol_o");
			if (InFieldList("bl2pqty_o")) bl2pqty = reader.ReadInt("bl2pqty_o");
			if (InFieldList("bl2pdol_o")) bl2pdol = reader.ReadInt("bl2pdol_o");
			if (InFieldList("bl2min_o")) bl2min = reader.ReadInt("bl2min_o");
			if (InFieldList("bl2vcdol_o")) bl2vcdol = reader.ReadInt("bl2vcdol_o");
			if (InFieldList("bl3qty_o")) bl3qty = reader.ReadInt("bl3qty_o");
			if (InFieldList("bl3dol_o")) bl3dol = reader.ReadInt("bl3dol_o");
			if (InFieldList("bl3pqty_o")) bl3pqty = reader.ReadInt("bl3pqty_o");
			if (InFieldList("bl3pdol_o")) bl3pdol = reader.ReadInt("bl3pdol_o");
			if (InFieldList("bl3min_o")) bl3min = reader.ReadInt("bl3min_o");
			if (InFieldList("bl3vcdol_o")) bl3vcdol = reader.ReadInt("bl3vcdol_o");
			if (InFieldList("bl4qty_o")) bl4qty = reader.ReadInt("bl4qty_o");
			if (InFieldList("bl4dol_o")) bl4dol = reader.ReadInt("bl4dol_o");
			if (InFieldList("bl4pqty_o")) bl4pqty = reader.ReadInt("bl4pqty_o");
			if (InFieldList("bl4pdol_o")) bl4pdol = reader.ReadInt("bl4pdol_o");
			if (InFieldList("bl4min_o")) bl4min = reader.ReadInt("bl4min_o");
			if (InFieldList("bl4vcdol_o")) bl4vcdol = reader.ReadInt("bl4vcdol_o");
			if (InFieldList("bl5qty_o")) bl5qty = reader.ReadInt("bl5qty_o");
			if (InFieldList("bl5dol_o")) bl5dol = reader.ReadInt("bl5dol_o");
			if (InFieldList("bl5pqty_o")) bl5pqty = reader.ReadInt("bl5pqty_o");
			if (InFieldList("bl5pdol_o")) bl5pdol = reader.ReadInt("bl5pdol_o");
			if (InFieldList("bl5min_o")) bl5min = reader.ReadInt("bl5min_o");
			if (InFieldList("bl5vcdol_o")) bl5vcdol = reader.ReadInt("bl5vcdol_o");
			if (InFieldList("bl6qty_o")) bl6qty = reader.ReadInt("bl6qty_o");
			if (InFieldList("bl6dol_o")) bl6dol = reader.ReadInt("bl6dol_o");
			if (InFieldList("bl6pqty_o")) bl6pqty = reader.ReadInt("bl6pqty_o");
			if (InFieldList("bl6pdol_o")) bl6pdol = reader.ReadInt("bl6pdol_o");
			if (InFieldList("bl6min_o")) bl6min = reader.ReadInt("bl6min_o");
			if (InFieldList("bl6vcdol_o")) bl6vcdol = reader.ReadInt("bl6vcdol_o");
			if (InFieldList("blfqty_o")) blfqty = reader.ReadInt("blfqty_o");
			if (InFieldList("blfdol_o")) blfdol = reader.ReadInt("blfdol_o");
			if (InFieldList("blfpqty_o")) blfpqty = reader.ReadInt("blfpqty_o");
			if (InFieldList("blfpdol_o")) blfpdol = reader.ReadInt("blfpdol_o");
			if (InFieldList("blfmin_o")) blfmin = reader.ReadInt("blfmin_o");
			if (InFieldList("blfvcdol_o")) blfvcdol = reader.ReadInt("blfvcdol_o");
			if (InFieldList("blcstfl_o")) blcstfl = reader.ReadInt("blcstfl_o");
			if (InFieldList("bltot_o")) bltot = reader.ReadInt("bltot_o");
			if (InFieldList("bldol_o")) bldol = reader.ReadInt("bldol_o");
			if (InFieldList("blcst_o")) blcst = reader.ReadInt("blcst_o");
			if (InFieldList("blvcdol_o")) blvcdol = reader.ReadInt("blvcdol_o");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public hbs_bl_w GetBs_Bl_W() {
			var qTime = DateTime.Now;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hbs_bl_w";
			var reader = cmd.ExecuteExtendedReader();
			reader.Read();
			var entity = new hbs_bl_w();
			entity.FillFromReader(reader);
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetBs_BL_W");
			return entity;
		}

		public hbs_bl_i GetBs_Bl_I() {
			var qTime = DateTime.Now;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hbs_bl_i";
			var reader = cmd.ExecuteExtendedReader();
			reader.Read();
			var entity = new hbs_bl_i();
			entity.FillFromReader(reader);
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetBs_BL_I");
			return entity;
		}

		public hbs_bl_o GetBs_Bl_O() {
			var qTime = DateTime.Now;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hbs_bl_o";
			var reader = cmd.ExecuteExtendedReader();
			reader.Read();
			var entity = new hbs_bl_o();
			entity.FillFromReader(reader);
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetBs_BL_O");
			return entity;
		}

	}

}
