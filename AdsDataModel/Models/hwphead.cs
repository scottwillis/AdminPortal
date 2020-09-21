using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Advantage.Data.Provider;
using Common;

namespace AdsDataModel {

	public class hwphead : FoxProEntity {

		public hwphead() {
			Key = "partno";
		}

		private string _partno;
		private string _desc;
		private string _blank;
		private decimal? _sqft;
		private decimal? _lbs;
		private string _material;
		private string _gauge;
		private decimal? _thick;
		private string _rawpart;
		private string _obsolete;
		private int? _leaddays;
		private decimal? _minthick;
		private string _dwgtype;
		private string _dwgname;
		private string _dwgsize;
		private string _dwgprg;
		private string _dwgflat;
		private string _enghold;
		private string _wipstat;
		private string _oldkey;

		public string partno { get => _partno; set => SetProperty(ref _partno, value); }

		public string desc { get => _desc; set => SetProperty(ref _desc, value); }

		public string blank { get => _blank; set => SetProperty(ref _blank, value); }

		public decimal? sqft { get => _sqft; set => SetProperty(ref _sqft, value); }

		public decimal? lbs { get => _lbs; set => SetProperty(ref _lbs, value); }

		public string material { get => _material; set => SetProperty(ref _material, value); }

		public string gauge { get => _gauge; set => SetProperty(ref _gauge, value); }

		public decimal? thick { get => _thick; set => SetProperty(ref _thick, value); }

		public string rawpart { get => _rawpart; set => SetProperty(ref _rawpart, value); }

		public string obsolete { get => _obsolete; set => SetProperty(ref _obsolete, value); }

		public int? leaddays { get => _leaddays; set => SetProperty(ref _leaddays, value); }

		public decimal? minthick { get => _minthick; set => SetProperty(ref _minthick, value); }

		public string dwgtype { get => _dwgtype; set => SetProperty(ref _dwgtype, value); }

		public string dwgname { get => _dwgname; set => SetProperty(ref _dwgname, value); }

		public string dwgsize { get => _dwgsize; set => SetProperty(ref _dwgsize, value); }

		public string dwgprg { get => _dwgprg; set => SetProperty(ref _dwgprg, value); }

		public string dwgflat { get => _dwgflat; set => SetProperty(ref _dwgflat, value); }

		public string enghold { get => _enghold; set => SetProperty(ref _enghold, value); }

		public string wipstat { get => _wipstat; set => SetProperty(ref _wipstat, value); }

		public string oldkey { get => _oldkey; set => SetProperty(ref _oldkey, value); }

		public sealed override string Key { get; set; }

		public sealed override object[] KeyValue => new object[] { partno };

		public override void FillFromReader(AdsDataReader reader) {
			partno = reader.ReadString(reader.GetOrdinal("partno"));
			desc = reader.ReadString(reader.GetOrdinal("desc"));
			blank = reader.ReadString(reader.GetOrdinal("blank"));
			sqft = reader.ReadDecimal(reader.GetOrdinal("sqft"));
			lbs = reader.ReadDecimal(reader.GetOrdinal("lbs"));
			material = reader.ReadString(reader.GetOrdinal("material"));
			gauge = reader.ReadString(reader.GetOrdinal("gauge"));
			thick = reader.ReadDecimal(reader.GetOrdinal("thick"));
			rawpart = reader.ReadString(reader.GetOrdinal("rawpart"));
			obsolete = reader.ReadString(reader.GetOrdinal("obsolete"));
			leaddays = reader.ReadInt(reader.GetOrdinal("leaddays"));
			minthick = reader.ReadDecimal(reader.GetOrdinal("minthick"));
			dwgtype = reader.ReadString(reader.GetOrdinal("dwgtype"));
			dwgname = reader.ReadString(reader.GetOrdinal("dwgname"));
			dwgsize = reader.ReadString(reader.GetOrdinal("dwgsize"));
			dwgprg = reader.ReadString(reader.GetOrdinal("dwgprg"));
			dwgflat = reader.ReadString(reader.GetOrdinal("dwgflat"));
			enghold = reader.ReadString(reader.GetOrdinal("enghold"));
			wipstat = reader.ReadString(reader.GetOrdinal("wipstat"));
			oldkey = reader.ReadString(reader.GetOrdinal("oldkey"));
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public hwphead GetWipHead(string partno) {
			var sql = $"select * from hwphead where partno='{partno}'";
			var entity = GetEntitySql<hwphead>(sql);
			return entity;
		}

	}

}
