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

	public class hbs_mis : FoxProEntity {

		private DateTime? _calcdate;
		private string _calctime;
		private string _calcend;
		private DateTime? _me_cur;
		private DateTime? _me_las;
		private DateTime? _me_pre;
		private DateTime? _me_start;
		private DateTime? _pre_sun;
		private DateTime? _pre_mon;
		private DateTime? _pre_tue;
		private DateTime? _pre_wed;
		private DateTime? _pre_thu;
		private DateTime? _pre_fri;
		private DateTime? _pre_sat;
		private DateTime? _cur_sun;
		private DateTime? _cur_mon;
		private DateTime? _cur_tue;
		private DateTime? _cur_wed;
		private DateTime? _cur_thu;
		private DateTime? _cur_fri;
		private DateTime? _cur_sat;
		private int _ho_l60_cnt;
		private int _ho_l60_fix;
		private int _ho_l60_dol;
		private int _ho_g60_cnt;
		private int _ho_g60_fix;
		private int _ho_g60_dol;
		private int _inv_r_dol;
		private int _inv_r_cnt;
		private int _inv_w_dol;
		private int _inv_w_cnt;
		private int _inv_f_dol;
		private int _inv_f_cnt;
		private int _inv_q_dol;
		private int _inv_q_cnt;
		private int _invs_r_dol;
		private int _invs_r_cnt;
		private int _invs_w_dol;
		private int _invs_w_cnt;
		private int _invs_f_dol;
		private int _invs_f_cnt;
		private int _invs_q_dol;
		private int _invs_q_cnt;
		private int _ar_fut;
		private int _ar_cur;
		private int _ar_30;
		private int _ar_bey;
		private int _ar_fut_cnt;
		private int _ar_cur_cnt;
		private int _ar_30_cnt;
		private int _ar_bey_cnt;
		private int _q_cur_cnt;
		private int _q_cur_fix;
		private int _q_cur_dol;
		private int _q_las_cnt;
		private int _q_las_fix;
		private int _q_las_dol;
		private int _q_pre_cnt;
		private int _q_pre_fix;
		private int _q_pre_dol;
		private int _o_cur_cnt;
		private int _o_cur_fix;
		private int _o_cur_dol;
		private int _o_las_cnt;
		private int _o_las_fix;
		private int _o_las_dol;
		private int _o_pre_cnt;
		private int _o_pre_fix;
		private int _o_pre_dol;
		private int _q_pen_cnt;
		private int _q_pen_fix;
		private int _q_pen_dol;
		private int _q_ukn_cnt;
		private int _q_ukn_fix;
		private int _q_ukn_dol;
		private int _unres_cnt;
		private int _unres_dol;
		private int _rga_cnt;
		private int _rga_dol;
		private int _stat6dol_w;
		private int _stat6dol_i;
		private int _stat6dol_o;
		private int _cur_boq;
		private int _pre_boq;
		private int _tfrtcost;

		public DateTime? calcdate { get => _calcdate; set => SetProperty(ref _calcdate, value); }

		public string calctime { get => _calctime; set => SetProperty(ref _calctime, value); }

		public string calcend { get => _calcend; set => SetProperty(ref _calcend, value); }
		
		public DateTime? me_cur { get => _me_cur; set => SetProperty(ref _me_cur, value); }

		public DateTime? me_las { get => _me_las; set => SetProperty(ref _me_las, value); }

		public DateTime? me_pre { get => _me_pre; set => SetProperty(ref _me_pre, value); }

		public DateTime? me_start { get => _me_start; set => SetProperty(ref _me_start, value); }

		public DateTime? pre_sun { get => _pre_sun; set => SetProperty(ref _pre_sun, value); }

		public DateTime? pre_mon { get => _pre_mon; set => SetProperty(ref _pre_mon, value); }

		public DateTime? pre_tue { get => _pre_tue; set => SetProperty(ref _pre_tue, value); }

		public DateTime? pre_wed { get => _pre_wed; set => SetProperty(ref _pre_wed, value); }

		public DateTime? pre_thu { get => _pre_thu; set => SetProperty(ref _pre_thu, value); }

		public DateTime? pre_fri { get => _pre_fri; set => SetProperty(ref _pre_fri, value); }

		public DateTime? pre_sat { get => _pre_sat; set => SetProperty(ref _pre_sat, value); }

		public DateTime? cur_sun { get => _cur_sun; set => SetProperty(ref _cur_sun, value); }

		public DateTime? cur_mon { get => _cur_mon; set => SetProperty(ref _cur_mon, value); }

		public DateTime? cur_tue { get => _cur_tue; set => SetProperty(ref _cur_tue, value); }

		public DateTime? cur_wed { get => _cur_wed; set => SetProperty(ref _cur_wed, value); }

		public DateTime? cur_thu { get => _cur_thu; set => SetProperty(ref _cur_thu, value); }

		public DateTime? cur_fri { get => _cur_fri; set => SetProperty(ref _cur_fri, value); }

		public DateTime? cur_sat { get => _cur_sat; set => SetProperty(ref _cur_sat, value); }

		public int ho_l60_cnt { get => _ho_l60_cnt; set => SetProperty(ref _ho_l60_cnt, value); }

		public int ho_l60_fix { get => _ho_l60_fix; set => SetProperty(ref _ho_l60_fix, value); }

		public int ho_l60_dol { get => _ho_l60_dol; set => SetProperty(ref _ho_l60_dol, value); }

		public int ho_g60_cnt { get => _ho_g60_cnt; set => SetProperty(ref _ho_g60_cnt, value); }

		public int ho_g60_fix { get => _ho_g60_fix; set => SetProperty(ref _ho_g60_fix, value); }

		public int ho_g60_dol { get => _ho_g60_dol; set => SetProperty(ref _ho_g60_dol, value); }

		public int inv_r_dol { get => _inv_r_dol; set => SetProperty(ref _inv_r_dol, value); }

		public int inv_r_cnt { get => _inv_r_cnt; set => SetProperty(ref _inv_r_cnt, value); }

		public int inv_w_dol { get => _inv_w_dol; set => SetProperty(ref _inv_w_dol, value); }

		public int inv_w_cnt { get => _inv_w_cnt; set => SetProperty(ref _inv_w_cnt, value); }

		public int inv_f_dol { get => _inv_f_dol; set => SetProperty(ref _inv_f_dol, value); }

		public int inv_f_cnt { get => _inv_f_cnt; set => SetProperty(ref _inv_f_cnt, value); }

		public int inv_q_dol { get => _inv_q_dol; set => SetProperty(ref _inv_q_dol, value); }

		public int inv_q_cnt { get => _inv_q_cnt; set => SetProperty(ref _inv_q_cnt, value); }

		public int invs_r_dol { get => _invs_r_dol; set => SetProperty(ref _invs_r_dol, value); }

		public int invs_r_cnt { get => _invs_r_cnt; set => SetProperty(ref _invs_r_cnt, value); }

		public int invs_w_dol { get => _invs_w_dol; set => SetProperty(ref _invs_w_dol, value); }

		public int invs_w_cnt { get => _invs_w_cnt; set => SetProperty(ref _invs_w_cnt, value); }

		public int invs_f_dol { get => _invs_f_dol; set => SetProperty(ref _invs_f_dol, value); }

		public int invs_f_cnt { get => _invs_f_cnt; set => SetProperty(ref _invs_f_cnt, value); }

		public int invs_q_dol { get => _invs_q_dol; set => SetProperty(ref _invs_q_dol, value); }

		public int invs_q_cnt { get => _invs_q_cnt; set => SetProperty(ref _invs_q_cnt, value); }

		public int ar_fut { get => _ar_fut; set => SetProperty(ref _ar_fut, value); }

		public int ar_cur { get => _ar_cur; set => SetProperty(ref _ar_cur, value); }

		public int ar_30 { get => _ar_30; set => SetProperty(ref _ar_30, value); }

		public int ar_bey { get => _ar_bey; set => SetProperty(ref _ar_bey, value); }

		public int ar_fut_cnt { get => _ar_fut_cnt; set => SetProperty(ref _ar_fut_cnt, value); }

		public int ar_cur_cnt { get => _ar_cur_cnt; set => SetProperty(ref _ar_cur_cnt, value); }

		public int ar_30_cnt { get => _ar_30_cnt; set => SetProperty(ref _ar_30_cnt, value); }

		public int ar_bey_cnt { get => _ar_bey_cnt; set => SetProperty(ref _ar_bey_cnt, value); }

		public int q_cur_cnt { get => _q_cur_cnt; set => SetProperty(ref _q_cur_cnt, value); }

		public int q_cur_fix { get => _q_cur_fix; set => SetProperty(ref _q_cur_fix, value); }

		public int q_cur_dol { get => _q_cur_dol; set => SetProperty(ref _q_cur_dol, value); }

		public int q_las_cnt { get => _q_las_cnt; set => SetProperty(ref _q_las_cnt, value); }

		public int q_las_fix { get => _q_las_fix; set => SetProperty(ref _q_las_fix, value); }

		public int q_las_dol { get => _q_las_dol; set => SetProperty(ref _q_las_dol, value); }

		public int q_pre_cnt { get => _q_pre_cnt; set => SetProperty(ref _q_pre_cnt, value); }

		public int q_pre_fix { get => _q_pre_fix; set => SetProperty(ref _q_pre_fix, value); }

		public int q_pre_dol { get => _q_pre_dol; set => SetProperty(ref _q_pre_dol, value); }

		public int o_cur_cnt { get => _o_cur_cnt; set => SetProperty(ref _o_cur_cnt, value); }

		public int o_cur_fix { get => _o_cur_fix; set => SetProperty(ref _o_cur_fix, value); }

		public int o_cur_dol { get => _o_cur_dol; set => SetProperty(ref _o_cur_dol, value); }

		public int o_las_cnt { get => _o_las_cnt; set => SetProperty(ref _o_las_cnt, value); }

		public int o_las_fix { get => _o_las_fix; set => SetProperty(ref _o_las_fix, value); }

		public int o_las_dol { get => _o_las_dol; set => SetProperty(ref _o_las_dol, value); }

		public int o_pre_cnt { get => _o_pre_cnt; set => SetProperty(ref _o_pre_cnt, value); }

		public int o_pre_fix { get => _o_pre_fix; set => SetProperty(ref _o_pre_fix, value); }

		public int o_pre_dol { get => _o_pre_dol; set => SetProperty(ref _o_pre_dol, value); }

		public int q_pen_cnt { get => _q_pen_cnt; set => SetProperty(ref _q_pen_cnt, value); }

		public int q_pen_fix { get => _q_pen_fix; set => SetProperty(ref _q_pen_fix, value); }

		public int q_pen_dol { get => _q_pen_dol; set => SetProperty(ref _q_pen_dol, value); }

		public int q_ukn_cnt { get => _q_ukn_cnt; set => SetProperty(ref _q_ukn_cnt, value); }

		public int q_ukn_fix { get => _q_ukn_fix; set => SetProperty(ref _q_ukn_fix, value); }

		public int q_ukn_dol { get => _q_ukn_dol; set => SetProperty(ref _q_ukn_dol, value); }

		public int unres_cnt { get => _unres_cnt; set => SetProperty(ref _unres_cnt, value); }

		public int unres_dol { get => _unres_dol; set => SetProperty(ref _unres_dol, value); }

		public int rga_cnt { get => _rga_cnt; set => SetProperty(ref _rga_cnt, value); }

		public int rga_dol { get => _rga_dol; set => SetProperty(ref _rga_dol, value); }

		public int stat6dol_w { get => _stat6dol_w; set => SetProperty(ref _stat6dol_w, value); }

		public int stat6dol_i { get => _stat6dol_i; set => SetProperty(ref _stat6dol_i, value); }

		public int stat6dol_o { get => _stat6dol_o; set => SetProperty(ref _stat6dol_o, value); }

		public int cur_boq { get => _cur_boq; set => SetProperty(ref _cur_boq, value); }

		public int pre_boq { get => _pre_boq; set => SetProperty(ref _pre_boq, value); }

		public int tfrtcost { get => _tfrtcost; set => SetProperty(ref _tfrtcost, value); }

		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { };

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("calcdate")) calcdate = reader.ReadDate("calcdate");
			if (InFieldList("calctime")) calctime = reader.ReadString("calctime");
			if (InFieldList("calcend")) calcend = reader.ReadString("calcend");
			if (InFieldList("me_cur")) me_cur = reader.ReadDate("me_cur");
			if (InFieldList("me_las")) me_las = reader.ReadDate("me_las");
			if (InFieldList("me_pre")) me_pre = reader.ReadDate("me_pre");
			if (InFieldList("me_start")) me_start = reader.ReadDate("me_start");
			if (InFieldList("pre_sun")) pre_sun = reader.ReadDate("pre_sun");
			if (InFieldList("pre_mon")) pre_mon = reader.ReadDate("pre_mon");
			if (InFieldList("pre_tue")) pre_tue = reader.ReadDate("pre_tue");
			if (InFieldList("pre_wed")) pre_wed = reader.ReadDate("pre_wed");
			if (InFieldList("pre_thu")) pre_thu = reader.ReadDate("pre_thu");
			if (InFieldList("pre_fri")) pre_fri = reader.ReadDate("pre_fri");
			if (InFieldList("pre_sat")) pre_sat = reader.ReadDate("pre_sat");
			if (InFieldList("cur_sun")) cur_sun = reader.ReadDate("cur_sun");
			if (InFieldList("cur_mon")) cur_mon = reader.ReadDate("cur_mon");
			if (InFieldList("cur_tue")) cur_tue = reader.ReadDate("cur_tue");
			if (InFieldList("cur_wed")) cur_wed = reader.ReadDate("cur_wed");
			if (InFieldList("cur_thu")) cur_thu = reader.ReadDate("cur_thu");
			if (InFieldList("cur_fri")) cur_fri = reader.ReadDate("cur_fri");
			if (InFieldList("cur_sat")) cur_sat = reader.ReadDate("cur_sat");
			if (InFieldList("ho_l60_cnt")) ho_l60_cnt = reader.ReadInt("ho_l60_cnt");
			if (InFieldList("ho_l60_fix")) ho_l60_fix = reader.ReadInt("ho_l60_fix");
			if (InFieldList("ho_l60_dol")) ho_l60_dol = reader.ReadInt("ho_l60_dol");
			if (InFieldList("ho_g60_cnt")) ho_g60_cnt = reader.ReadInt("ho_g60_cnt");
			if (InFieldList("ho_g60_fix")) ho_g60_fix = reader.ReadInt("ho_g60_fix");
			if (InFieldList("ho_g60_dol")) ho_g60_dol = reader.ReadInt("ho_g60_dol");
			if (InFieldList("inv_r_dol")) inv_r_dol = reader.ReadInt("inv_r_dol");
			if (InFieldList("inv_r_cnt")) inv_r_cnt = reader.ReadInt("inv_r_cnt");
			if (InFieldList("inv_w_dol")) inv_w_dol = reader.ReadInt("inv_w_dol");
			if (InFieldList("inv_w_cnt")) inv_w_cnt = reader.ReadInt("inv_w_cnt");
			if (InFieldList("inv_f_dol")) inv_f_dol = reader.ReadInt("inv_f_dol");
			if (InFieldList("inv_f_cnt")) inv_f_cnt = reader.ReadInt("inv_f_cnt");
			if (InFieldList("inv_q_dol")) inv_q_dol = reader.ReadInt("inv_q_dol");
			if (InFieldList("inv_q_cnt")) inv_q_cnt = reader.ReadInt("inv_q_cnt");
			if (InFieldList("invs_r_dol")) invs_r_dol = reader.ReadInt("invs_r_dol");
			if (InFieldList("invs_r_cnt")) invs_r_cnt = reader.ReadInt("invs_r_cnt");
			if (InFieldList("invs_w_dol")) invs_w_dol = reader.ReadInt("invs_w_dol");
			if (InFieldList("invs_w_cnt")) invs_w_cnt = reader.ReadInt("invs_w_cnt");
			if (InFieldList("invs_f_dol")) invs_f_dol = reader.ReadInt("invs_f_dol");
			if (InFieldList("invs_f_cnt")) invs_f_cnt = reader.ReadInt("invs_f_cnt");
			if (InFieldList("invs_q_dol")) invs_q_dol = reader.ReadInt("invs_q_dol");
			if (InFieldList("invs_q_cnt")) invs_q_cnt = reader.ReadInt("invs_q_cnt");
			if (InFieldList("ar_fut")) ar_fut = reader.ReadInt("ar_fut");
			if (InFieldList("ar_cur")) ar_cur = reader.ReadInt("ar_cur");
			if (InFieldList("ar_30")) ar_30 = reader.ReadInt("ar_30");
			if (InFieldList("ar_bey")) ar_bey = reader.ReadInt("ar_bey");
			if (InFieldList("ar_fut_cnt")) ar_fut_cnt = reader.ReadInt("ar_fut_cnt");
			if (InFieldList("ar_cur_cnt")) ar_cur_cnt = reader.ReadInt("ar_cur_cnt");
			if (InFieldList("ar_30_cnt")) ar_30_cnt = reader.ReadInt("ar_30_cnt");
			if (InFieldList("ar_bey_cnt")) ar_bey_cnt = reader.ReadInt("ar_bey_cnt");
			if (InFieldList("q_cur_cnt")) q_cur_cnt = reader.ReadInt("q_cur_cnt");
			if (InFieldList("q_cur_fix")) q_cur_fix = reader.ReadInt("q_cur_fix");
			if (InFieldList("q_cur_dol")) q_cur_dol = reader.ReadInt("q_cur_dol");
			if (InFieldList("q_las_cnt")) q_las_cnt = reader.ReadInt("q_las_cnt");
			if (InFieldList("q_las_fix")) q_las_fix = reader.ReadInt("q_las_fix");
			if (InFieldList("q_las_dol")) q_las_dol = reader.ReadInt("q_las_dol");
			if (InFieldList("q_pre_cnt")) q_pre_cnt = reader.ReadInt("q_pre_cnt");
			if (InFieldList("q_pre_fix")) q_pre_fix = reader.ReadInt("q_pre_fix");
			if (InFieldList("q_pre_dol")) q_pre_dol = reader.ReadInt("q_pre_dol");
			if (InFieldList("o_cur_cnt")) o_cur_cnt = reader.ReadInt("o_cur_cnt");
			if (InFieldList("o_cur_fix")) o_cur_fix = reader.ReadInt("o_cur_fix");
			if (InFieldList("o_cur_dol")) o_cur_dol = reader.ReadInt("o_cur_dol");
			if (InFieldList("o_las_cnt")) o_las_cnt = reader.ReadInt("o_las_cnt");
			if (InFieldList("o_las_fix")) o_las_fix = reader.ReadInt("o_las_fix");
			if (InFieldList("o_las_dol")) o_las_dol = reader.ReadInt("o_las_dol");
			if (InFieldList("o_pre_cnt")) o_pre_cnt = reader.ReadInt("o_pre_cnt");
			if (InFieldList("o_pre_fix")) o_pre_fix = reader.ReadInt("o_pre_fix");
			if (InFieldList("o_pre_dol")) o_pre_dol = reader.ReadInt("o_pre_dol");
			if (InFieldList("q_pen_cnt")) q_pen_cnt = reader.ReadInt("q_pen_cnt");
			if (InFieldList("q_pen_fix")) q_pen_fix = reader.ReadInt("q_pen_fix");
			if (InFieldList("q_pen_dol")) q_pen_dol = reader.ReadInt("q_pen_dol");
			if (InFieldList("q_ukn_cnt")) q_ukn_cnt = reader.ReadInt("q_ukn_cnt");
			if (InFieldList("q_ukn_fix")) q_ukn_fix = reader.ReadInt("q_ukn_fix");
			if (InFieldList("q_ukn_dol")) q_ukn_dol = reader.ReadInt("q_ukn_dol");
			if (InFieldList("unres_cnt")) unres_cnt = reader.ReadInt("unres_cnt");
			if (InFieldList("unres_dol")) unres_dol = reader.ReadInt("unres_dol");
			if (InFieldList("rga_cnt")) rga_cnt = reader.ReadInt("rga_cnt");
			if (InFieldList("rga_dol")) rga_dol = reader.ReadInt("rga_dol");
			if (InFieldList("stat6dol_w")) stat6dol_w = reader.ReadInt("stat6dol_w");
			if (InFieldList("stat6dol_i")) stat6dol_i = reader.ReadInt("stat6dol_i");
			if (InFieldList("stat6dol_o")) stat6dol_o = reader.ReadInt("stat6dol_o");
			if (InFieldList("cur_boq")) cur_boq = reader.ReadInt("cur_boq");
			if (InFieldList("pre_boq")) pre_boq = reader.ReadInt("pre_boq");
			if (InFieldList("tfrtcost  ")) tfrtcost = reader.ReadInt("tfrtcost");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public hbs_mis GetBs_Mis() {
			var qTime = DateTime.Now;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hbs_mis";
			var reader = cmd.ExecuteExtendedReader();
			reader.Read();
			var entity = new hbs_mis();
			entity.FillFromReader(reader);
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetBs_Mis");
			return entity;
		}

	}

}
