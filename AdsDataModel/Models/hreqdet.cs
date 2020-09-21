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

    public class hreqdet : FoxProEntity {

        public hreqdet() { Key = "partno"; }

        private string _partno;
        private decimal? _qty;
        private int _orderno;
        private int _lineno;
        private string _week;
        private string _gen;
        

        [Display(Name = "PartNo", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string partno { get => _partno; set => SetProperty(ref _partno, value); }

        [Display(Name = "Qty", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? qty { get => _qty; set => SetProperty(ref _qty, value); }

        [Display(Name = "Orderno", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public int orderno { get => _orderno; set => SetProperty(ref _orderno, value); }

        [Display(Name = "Lineno", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public int lineno { get => _lineno; set => SetProperty(ref _lineno, value); }

        [Display(Name = "Week", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string week { get => _week; set => SetProperty(ref _week, value); }

        [Display(Name = "Gen", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string gen { get => _gen; set => SetProperty(ref _gen, value); }


        public sealed override string Key { get; set; }

        public sealed override object[] KeyValue => new object[] { partno };

        public override void FillFromReader(AdsDataReader reader) {
            if (InFieldList("partno")) partno = reader.ReadString("partno");
            if (InFieldList("qty")) qty = reader.ReadDecimal("qty");
            if (InFieldList("orderno")) orderno = reader.ReadInt("orderno");
            if (InFieldList("lineno")) lineno = reader.ReadInt("lineno");
            if (InFieldList("week")) week = reader.ReadString("week");
            if (InFieldList("gen")) gen = reader.ReadString("gen");


            MakeClean();
        }

    }

	public partial class FoxProDataContext {

        public IList<hreqdet> GetDriverRequirements()
        {
            //var sql = $"select * from hreqdet where (partno like '1011%' or partno like '1014%' or partno like '1018%' or partno like '1025%' or partno like '1054%') and partno not like '10180035'";
            var sql = $"select * from hreqdet where (partno like '1011%' or partno like '1014%' or partno like '1018%' or partno like '1025%' or partno like '1054%')";
            return GetEntitiesSql<hreqdet>(sql, new List<string>() { "*" });

        }

    }


}