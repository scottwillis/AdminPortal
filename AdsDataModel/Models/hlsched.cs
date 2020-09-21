using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Advantage.Data.Provider;
using Common;

namespace AdsDataModel
{

    public class hlsched : FoxProEntity {

        public hlsched() { Key = "orderline"; }

        private DateTime? _ship_date;
        private string _line;
        private string _base;
        private string _day;
        private DateTime? _sortday;
        private string _manual;
        private int? _orderno;
        private int? _lineno;
        private string _itemno;
        private string _pack;
        private int? _qty;
        private int? _ordqty;
        private decimal? _minutes;
        private string _bal_volt;
        private string _picklist;
        private int? _pprqty;
        private int? _runqty;
        private string _checkoff;
        private string _didpick;
        private string _didwork;
        private string _comment;
        private int? _madeqty;
        private string _override;
        private string _percomp;
        private int? _ordprob;
        private string _progress;
        private string _jobstart;
        private string _shift;
        private int? _no_emps;
        private string _trouble;
        private string _troubcomm;
        private string _postdrv;
        private decimal? _jobstime;
        private string _jobnext;
        private string _prodbase;


        [Display(Name = "ShipDate", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public DateTime? shipdate { get => _ship_date; set => SetProperty(ref _ship_date, value); }

        [Display(Name = "Line", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string line { get => _line; set => SetProperty(ref _line, value); }

        [Display(Name = "Base", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string prodbase { get => _prodbase; set => SetProperty(ref _prodbase, value); }

        [Display(Name = "Day", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string day { get => _day; set => SetProperty(ref _day, value); }

        [Display(Name = "SortDay", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public DateTime? sortday { get => _sortday; set => SetProperty(ref _sortday, value); }

        [Display(Name = "Manual", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string manual { get => _manual; set => SetProperty(ref _manual, value); }

        [Display(Name = "OrderNo", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public int? orderno { get => _orderno; set => SetProperty(ref _orderno, value); }

        [Display(Name = "LineNo", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public int? lineno { get => _lineno; set => SetProperty(ref _lineno, value); }

        [Display(Name = "ItemNo", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string itemno { get => _itemno; set => SetProperty(ref _itemno, value); }

        [Display(Name = "Pack", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string pack { get => _pack; set => SetProperty(ref _pack, value); }

        [Display(Name = "Qty", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public int? qty { get => _qty; set => SetProperty(ref _qty, value); }

        [Display(Name = "OrdQty", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public int? ordqty { get => _ordqty; set => SetProperty(ref _ordqty, value); }

        [Display(Name = "Minutes", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? minutes { get => _minutes; set => SetProperty(ref _minutes, value); }

        [Display(Name = "BalVolt", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string bal_volt { get => _bal_volt; set => SetProperty(ref _bal_volt, value); }

        [Display(Name = "PickList", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string picklist { get => _picklist; set => SetProperty(ref _picklist, value); }

        [Display(Name = "PprQty", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public int? pprqty { get => _pprqty; set => SetProperty(ref _pprqty, value); }

        [Display(Name = "RunQty", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public int? runqty { get => _runqty; set => SetProperty(ref _runqty, value); }

        [Display(Name = "Checkoff", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string checkoff { get => _checkoff; set => SetProperty(ref _checkoff, value); }

        [Display(Name = "DidPick", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string didpick { get => _didpick; set => SetProperty(ref _didpick, value); }

        [Display(Name = "DidWork", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string didwork { get => _didwork; set => SetProperty(ref _didwork, value); }

        [Display(Name = "Comment", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string comment { get => _comment; set => SetProperty(ref _comment, value); }

        [Display(Name = "MadeQty", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public int? madeqty { get => _madeqty; set => SetProperty(ref _madeqty, value); }

        [Display(Name = "Override", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string over_ride { get => _override; set => SetProperty(ref _override, value); }

        [Display(Name = "PerComp", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string percomp { get => _percomp; set => SetProperty(ref _percomp, value); }

        [Display(Name = "OrderProb", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public int? ordprob { get => _ordprob; set => SetProperty(ref _ordprob, value); }

        [Display(Name = "Progress", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string progress { get => _progress; set => SetProperty(ref _progress, value); }

        [Display(Name = "JobStart", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string jobstart { get => _jobstart; set => SetProperty(ref _jobstart, value); }

        [Display(Name = "Shift", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string shift { get => _shift; set => SetProperty(ref _shift, value); }

        [Display(Name = "NoEmps", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public int? no_emps { get => _no_emps; set => SetProperty(ref _no_emps, value); }

        [Display(Name = "Trouble", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string trouble { get => _trouble; set => SetProperty(ref _trouble, value); }

        [Display(Name = "TroubComm", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string troubcomm { get => _troubcomm; set => SetProperty(ref _troubcomm, value); }

        [Display(Name = "PostDrv", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string postdrv { get => _postdrv; set => SetProperty(ref _postdrv, value); }

        [Display(Name = "JobsTime", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? jobstime { get => _jobstime; set => SetProperty(ref _jobstime, value); }

        [Display(Name = "JobNext", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string jobnext { get => _jobnext; set => SetProperty(ref _jobnext, value); }




        public sealed override string Key { get; set; }

        public sealed override object[] KeyValue => new object[] {itemno};

        public override void FillFromReader(AdsDataReader reader) {
            if (InFieldList("ship_date")) shipdate = reader.ReadDate("ship_date");
            if (InFieldList("line")) line = reader.ReadString("line");
            if (InFieldList("base")) prodbase = reader.ReadString("base");
            if (InFieldList("day")) day = reader.ReadString("day");
            if (InFieldList("sortday")) sortday = reader.ReadDate("sortday");
            if (InFieldList("manual")) manual = reader.ReadString("manual");
            if (InFieldList("orderno")) orderno = reader.ReadInt("orderno");
            if (InFieldList("lineno")) lineno = reader.ReadInt("lineno");
            if (InFieldList("itemno")) itemno = reader.ReadString("itemno");
            if (InFieldList("pack")) pack = reader.ReadString("pack");
            if (InFieldList("qty")) qty = reader.ReadInt("qty");
            if (InFieldList("ordqty")) ordqty = reader.ReadInt("ordqty");
            if (InFieldList("minutes")) minutes = reader.ReadDecimal("minutes");
            if (InFieldList("bal_volt")) bal_volt = reader.ReadString("bal_volt");
            if (InFieldList("picklist")) picklist = reader.ReadString("picklist");
            if (InFieldList("pprqty")) pprqty = reader.ReadInt("pprqty");
            if (InFieldList("runqty")) runqty = reader.ReadInt("runqty");
            if (InFieldList("checkoff")) checkoff = reader.ReadString("checkoff");
            if (InFieldList("didpick")) didpick = reader.ReadString("didpick");
            if (InFieldList("didwork")) didwork = reader.ReadString("didwork");
            if (InFieldList("comment")) comment = reader.ReadString("comment");
            if (InFieldList("madeqty")) madeqty = reader.ReadInt("madeqty");
            if (InFieldList("override")) over_ride = reader.ReadString("override");
            if (InFieldList("percomp")) percomp = reader.ReadString("percomp");
            if (InFieldList("ordprob")) ordprob = reader.ReadInt("ordprob");
            if (InFieldList("progress")) progress = reader.ReadString("progress");
            if (InFieldList("jobstart")) jobstart = reader.ReadString("jobstart");
            if (InFieldList("shift")) shift = reader.ReadString("shift");
            if (InFieldList("no_emps")) no_emps = reader.ReadInt("no_emps");
            if (InFieldList("trouble")) trouble = reader.ReadString("trouble");
            if (InFieldList("troubcomm")) troubcomm = reader.ReadString("troubcomm");
            if (InFieldList("postdrv")) postdrv = reader.ReadString("postdrv");
            if (InFieldList("jobstime")) jobstime = reader.ReadDecimal("jobstime");
            if (InFieldList("jobnext")) jobnext = reader.ReadString("jobnext");

            MakeClean();
        }

    }

    public partial class FoxProDataContext
    {

        public hlsched GetActiveSchedItem(int assyLine)
        {
            var sql = $"select * from hlsched where progress = 'S' and jobstart = '1'";
            return GetEntitySql<hlsched>(sql, new List<string>() { "*" });
        }

        public IList<hlsched> GetAsbyLineViewItems(string asbyLine)
        {
            var sql = $"select * from hlsched where line = '{asbyLine}' and runqty > 0 order by sortday";
            return GetEntitiesSql<hlsched>(sql, new List<string>() { "*" });
        }

        public IList<hlsched> GetAsbyLineNo(DateTime weekEnd, bool isPastDue)
        {
            if (isPastDue) {
                var sql = $"select * from hlsched where ship_date <= ctod('{weekEnd}')";
                return GetEntitiesSql<hlsched>(sql, new List<string>() { "*" });
            }
            else {
                var sql = $"select * from hlsched where ship_date = ctod('{weekEnd}')";
                return GetEntitiesSql<hlsched>(sql, new List<string>() { "*" });
            }

        }

        public IList<hlsched> GetOneDaySched(DateTime endDay)
        {
            var sql = $"select * from hlsched where sortday = ctod('{endDay}')";
            return GetEntitiesSql<hlsched>(sql, new List<string>() { "*" });

        }

        public IList<hlsched> GetWallPackOrders()
        {
            var sql = $"select * from hlsched where base like 'VW%'";
            return GetEntitiesSql<hlsched>(sql, new List<string>() { "*" });

        }
    }

}