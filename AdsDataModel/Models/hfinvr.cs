using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Advantage.Data.Provider;
using Common;

namespace AdsDataModel {

	public class hfinvr : FoxProEntity {

		public hfinvr() {
			Key = "";
		}

		private string _itemno;
		private string _version;
		private DateTime? _datemade;
		private string _madeby;
		private string _comment;
		private string _schno;
		private string _schnoalt;
		private string _schgeniot;
		private string _schosriot;

		public string itemno { get => _itemno; set => SetProperty(ref _itemno, value); }

		public string version { get => _version; set => SetProperty(ref _version, value); }

		public DateTime? datemade { get => _datemade; set => SetProperty(ref _datemade, value); }

		public string madeby { get => _madeby; set => SetProperty(ref _madeby, value); }

		public string comment { get => _comment; set => SetProperty(ref _comment, value); }

		public string schno { get => _schno; set => SetProperty(ref _schno, value); }

		public string schnoalt { get => _schnoalt; set => SetProperty(ref _schnoalt, value); }

		public string schgeniot { get => _schgeniot; set => SetProperty(ref _schgeniot, value); }

		public string schosriot { get => _schosriot; set => SetProperty(ref _schosriot, value); }

		public sealed override string Key { get; set; }

		public sealed override object[] KeyValue => new object[] { itemno};

		public override void FillFromReader(AdsDataReader reader) {
			itemno = reader.ReadString(reader.GetOrdinal("itemno"));
			version = reader.ReadString(reader.GetOrdinal("version"));
			datemade = reader.ReadDate(reader.GetOrdinal("datemade"));
			madeby = reader.ReadString(reader.GetOrdinal("madeby"));
			comment = reader.ReadString(reader.GetOrdinal("comment"));
			schno = reader.ReadString(reader.GetOrdinal("schno"));
			schnoalt = reader.ReadString(reader.GetOrdinal("schnoalt"));
			schgeniot = reader.ReadString(reader.GetOrdinal("schgeniot"));
			schosriot = reader.ReadString(reader.GetOrdinal("schosriot"));
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public IList<hfinvr> GetFinishedInventoryRevisions(string itemno) {
			var sql = $"select * from hfinvr where itemno='{itemno}'";
			var entities = GetEntities<hfinvr>(sql);
			return entities;
		}

		public hfinvr GetFinishedInventoryRevision(string itemno, string version){
			var sql = $"select * from hfinvr where itemno='{itemno}' and version = '{version}'";
			return GetEntitySql<hfinvr>(sql);	
		}

	}

}
