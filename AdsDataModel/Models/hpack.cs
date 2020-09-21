using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Advantage.Data.Provider;
using Common;

namespace AdsDataModel {

	public class hpack : FoxProEntity {

		private string _pack;
		private string _pseries;
		private int? _width;
		private int? _length;

		public string pack { get => _pack; set => SetProperty(ref _pack, value); }

		public string pseries { get => _pseries; set => SetProperty(ref _pseries, value); }

		public int? width { get => _width; set => SetProperty(ref _width, value); }

		public int? length { get => _length; set => SetProperty(ref _length, value); }

		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { };

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("pack")) pack = reader.ReadString("pack");
			if (InFieldList("pseries")) pseries = reader.ReadString("pseries");
			if (InFieldList("width")) width = reader.ReadInt("width");
			if (InFieldList("length")) length = reader.ReadInt("length");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public IList<hpack> GetPack(string pseries, int width, int length) {
			var qTime = DateTime.Now;
			var sql = $"select pack from hpack where pseries='{pseries}' and width={width} and length={length}";
			var entities = GetEntities<hpack>(sql);
			QueryDebugEnd(qTime, $"GetCustomersLookup - {sql}");
			return entities;
		}

	}

}
