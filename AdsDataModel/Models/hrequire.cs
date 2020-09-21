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

    public class hrequire : FoxProEntity {

        public hrequire() { Key = "code"; }

        private string _partno;
        private decimal? _price;
        private decimal? _qty;
        private string _code;
        private decimal? _qty1;
        private decimal? _qty2;
        private decimal? _qty3;
        private decimal? _qty4;
        private decimal? _qty5;
        private decimal? _qty6;
        private decimal? _qty7;
        private decimal? _qty8;
        private decimal? _specqty;
        private decimal? _specqty1;
        private decimal? _specqty2;
        private decimal? _specqty3;
        private decimal? _specqty4;
        private decimal? _specqty5;
        private decimal? _specqty6;
        private decimal? _specqty7;
        private decimal? _specqty8;
        private decimal? _csun;
        private decimal? _cmon;
        private decimal? _ctue;
        private decimal? _cwed;
        private decimal? _cthu;
        private decimal? _cfri;
        private decimal? _csat;
        private decimal? _nsun;
        private decimal? _nmon;
        private decimal? _ntue;
        private decimal? _nwed;
        private decimal? _nthu;
        private decimal? _nfri;
        private decimal? _nsat;
        private int? _partseq;



        [Display(Name = "PartNo", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string partno { get => _partno; set => SetProperty(ref _partno, value); }

        [Display(Name = "Price", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? price { get => _price; set => SetProperty(ref _price, value); }

        [Display(Name = "Qty", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? qty { get => _qty; set => SetProperty(ref _qty, value); }

        [Display(Name = "Code", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public string code { get => _code; set => SetProperty(ref _code, value); }

        [Display(Name = "Qty1", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? qty1 { get => _qty1; set => SetProperty(ref _qty1, value); }

        [Display(Name = "Qty2", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? qty2 { get => _qty2; set => SetProperty(ref _qty2, value); }

        [Display(Name = "Qty3", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? qty3 { get => _qty3; set => SetProperty(ref _qty3, value); }

        [Display(Name = "Qty4", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? qty4 { get => _qty4; set => SetProperty(ref _qty4, value); }

        [Display(Name = "Qty5", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? qty5 { get => _qty5; set => SetProperty(ref _qty5, value); }

        [Display(Name = "Qty6", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? qty6 { get => _qty6; set => SetProperty(ref _qty6, value); }

        [Display(Name = "Qty7", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? qty7 { get => _qty7; set => SetProperty(ref _qty7, value); }

        [Display(Name = "Qty8", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? qty8 { get => _qty8; set => SetProperty(ref _qty8, value); }

        [Display(Name = "SpecQty", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? specqty { get => _specqty; set => SetProperty(ref _specqty, value); }

        [Display(Name = "SpecQty1", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? specqty1 { get => _specqty1; set => SetProperty(ref _specqty1, value); }

        [Display(Name = "SpecQty2", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? specqty2 { get => _specqty2; set => SetProperty(ref _specqty2, value); }

        [Display(Name = "SpecQty3", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? specqty3 { get => _specqty3; set => SetProperty(ref _specqty3, value); }

        [Display(Name = "SpecQty4", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? specqty4 { get => _specqty4; set => SetProperty(ref _specqty4, value); }

        [Display(Name = "SpecQty5", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? specqty5 { get => _specqty5; set => SetProperty(ref _specqty5, value); }

        [Display(Name = "SpecQty6", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? specqty6 { get => _specqty6; set => SetProperty(ref _specqty6, value); }

        [Display(Name = "SpecQty7", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? specqty7 { get => _specqty7; set => SetProperty(ref _specqty7, value); }

        [Display(Name = "SpecQty8", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? specqty8 { get => _specqty8; set => SetProperty(ref _specqty8, value); }

        [Display(Name = "CSun", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? csun { get => _csun; set => SetProperty(ref _csun, value); }

        [Display(Name = "CMon", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? cmon { get => _cmon; set => SetProperty(ref _cmon, value); }

        [Display(Name = "CTue", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? ctue { get => _ctue; set => SetProperty(ref _ctue, value); }

        [Display(Name = "CWed", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? cwed { get => _cwed; set => SetProperty(ref _cwed, value); }

        [Display(Name = "CThu", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? cthu { get => _cthu; set => SetProperty(ref _cthu, value); }

        [Display(Name = "CFri", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? cfri { get => _cfri; set => SetProperty(ref _cfri, value); }

        [Display(Name = "CSat", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? csat { get => _csat; set => SetProperty(ref _csat, value); }

        [Display(Name = "NSun", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? nsun { get => _nsun; set => SetProperty(ref _nsun, value); }

        [Display(Name = "NMon", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? nmon { get => _nmon; set => SetProperty(ref _nmon, value); }

        [Display(Name = "NTue", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? ntue { get => _ntue; set => SetProperty(ref _ntue, value); }

        [Display(Name = "NWed", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? nwed { get => _nwed; set => SetProperty(ref _nwed, value); }

        [Display(Name = "NThu", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? nthu { get => _nthu; set => SetProperty(ref _nthu, value); }

        [Display(Name = "NFri", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? nfri { get => _nfri; set => SetProperty(ref _nfri, value); }

        [Display(Name = "NSat", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public decimal? nsat { get => _nsat; set => SetProperty(ref _nsat, value); }

        [Display(Name = "PartSeq", Order = 10)]
        [MyCustom(Width = "*", IsVisible = true)]
        public int? partseq { get => _partseq; set => SetProperty(ref _partseq, value); }




        public sealed override string Key { get; set; }

        public sealed override object[] KeyValue => new object[] { code };

        public override void FillFromReader(AdsDataReader reader) {
            if (InFieldList("partno")) partno = reader.ReadString("partno");
            if (InFieldList("price")) price = reader.ReadDecimal("price");
            if (InFieldList("qty")) qty = reader.ReadDecimal("qty");
            if (InFieldList("code")) code = reader.ReadString("code");
            if (InFieldList("qty1")) qty1 = reader.ReadDecimal("qty1");
            if (InFieldList("qty2")) qty2 = reader.ReadDecimal("qty2");
            if (InFieldList("qty3")) qty3 = reader.ReadDecimal("qty3");
            if (InFieldList("qty4")) qty4 = reader.ReadDecimal("qty4");
            if (InFieldList("qty5")) qty5 = reader.ReadDecimal("qty5");
            if (InFieldList("qty6")) qty6 = reader.ReadDecimal("qty6");
            if (InFieldList("qty7")) qty7 = reader.ReadDecimal("qty7");
            if (InFieldList("qty8")) qty8 = reader.ReadDecimal("qty8");
            if (InFieldList("specqty")) specqty = reader.ReadDecimal("specqty");
            if (InFieldList("specqty1")) specqty1 = reader.ReadDecimal("specqty1");
            if (InFieldList("specqty2")) specqty2 = reader.ReadDecimal("specqty2");
            if (InFieldList("specqty3")) specqty3 = reader.ReadDecimal("specqty3");
            if (InFieldList("specqty4")) specqty4 = reader.ReadDecimal("specqty4");
            if (InFieldList("specqty5")) specqty5 = reader.ReadDecimal("specqty5");
            if (InFieldList("specqty6")) specqty6 = reader.ReadDecimal("specqty6");
            if (InFieldList("specqty7")) specqty7 = reader.ReadDecimal("specqty7");
            if (InFieldList("specqty8")) specqty8 = reader.ReadDecimal("specqty8");
            if (InFieldList("csun")) csun = reader.ReadDecimal("csun");
            if (InFieldList("cmon")) cmon = reader.ReadDecimal("cmon");
            if (InFieldList("ctue")) ctue = reader.ReadDecimal("ctue");
            if (InFieldList("cwed")) cwed = reader.ReadDecimal("cwed");
            if (InFieldList("cthu")) cthu = reader.ReadDecimal("cthu");
            if (InFieldList("cfri")) cfri = reader.ReadDecimal("cfri");
            if (InFieldList("csat")) csat = reader.ReadDecimal("csat");
            if (InFieldList("nsun")) nsun = reader.ReadDecimal("nsun");
            if (InFieldList("nmon")) nmon = reader.ReadDecimal("nmon");
            if (InFieldList("ntue")) ntue = reader.ReadDecimal("ntue");
            if (InFieldList("nwed")) nwed = reader.ReadDecimal("nwed");
            if (InFieldList("nthu")) nthu = reader.ReadDecimal("nthu");
            if (InFieldList("nfri")) nfri = reader.ReadDecimal("nfri");
            if (InFieldList("nsat")) nsat = reader.ReadDecimal("nsat");
            if (InFieldList("partseq")) partseq = reader.ReadInt("partseq");
          

            MakeClean();
        }

    }

	public partial class FoxProDataContext {

        public IList<hrequire> GetCartonRequirements()
        {
            var sql = $"select * from hrequire where partno like '15%'";
            return GetEntitiesSql<hrequire>(sql, new List<string>() { "*" });

        }

    }


}