using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Advantage.Data.Provider;
using Common;

namespace AdsDataModel {

	public class hoption : FoxProEntity {

		public hoption() {
			Key = "option_cod";
		}

		private string _option_cod;
		private decimal? _book;
		private string _series;
		private int? _qty;
		private string _qtyper;
		private int? _width;
		private int? _length;
		private int? _number;
		private string _opt_acc;
		private string _partno;
		private string _pack;
		private string _option_min;
		private string _addmin;
		private decimal? _minutes;
		private int? _emmin1;
		private int? _emmin2;
		private decimal? _oldbook;
		private decimal? _newbook;
		private string _option_old;
		private string _ul_dry;
		private string _ul_wet;
		private string _ul_nocan;
		private string _empartno;
		private string _empack;
		private string _obsolete;

		public string option_cod { get => _option_cod; set => SetProperty(ref _option_cod, value); }
		public decimal? book { get => _book; set => SetProperty(ref _book, value); }
		public string series { get => _series; set => SetProperty(ref _series, value); }
		public int? qty { get => _qty; set => SetProperty(ref _qty, value); }
		public string qtyper { get => _qtyper; set => SetProperty(ref _qtyper, value); }
		public int? width { get => _width; set => SetProperty(ref _width, value); }
		public int? length { get => _length; set => SetProperty(ref _length, value); }
		public int? number { get => _number; set => SetProperty(ref _number, value); }
		public string opt_acc { get => _opt_acc; set => SetProperty(ref _opt_acc, value); }
		public string partno { get => _partno; set => SetProperty(ref _partno, value); }
		public string pack { get => _pack; set => SetProperty(ref _pack, value); }
		public string option_min { get => _option_min; set => SetProperty(ref _option_min, value); }
		public string addmin { get => _addmin; set => SetProperty(ref _addmin, value); }
		public decimal? minutes { get => _minutes; set => SetProperty(ref _minutes, value); }
		public int? emmin1 { get => _emmin1; set => SetProperty(ref _emmin1, value); }
		public int? emmin2 { get => _emmin2; set => SetProperty(ref _emmin2, value); }
		public decimal? oldbook { get => _oldbook; set => SetProperty(ref _oldbook, value); }
		public decimal? newbook { get => _newbook; set => SetProperty(ref _newbook, value); }
		public string option_old { get => _option_old; set => SetProperty(ref _option_old, value); }
		public string ul_dry { get => _ul_dry; set => SetProperty(ref _ul_dry, value); }
		public string ul_wet { get => _ul_wet; set => SetProperty(ref _ul_wet, value); }
		public string ul_nocan { get => _ul_nocan; set => SetProperty(ref _ul_nocan, value); }
		public string empartno { get => _empartno; set => SetProperty(ref _empartno, value); }
		public string empack { get => _empack; set => SetProperty(ref _empack, value); }
		public string obsolete { get => _obsolete; set => SetProperty(ref _obsolete, value); }


		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[MyCustom(AdsIgnore = true)]
		public override object[] KeyValue => new object[] { option_cod };

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("option_cod")) option_cod = reader.ReadString("option_cod");
			if (InFieldList("book")) book = reader.ReadDecimal("book");
			if (InFieldList("series")) series = reader.ReadString("series");
			if (InFieldList("qty")) qty = reader.ReadInt("qty");
			if (InFieldList("qtyper")) qtyper = reader.ReadString("qtyper");
			if (InFieldList("width")) width = reader.ReadInt("width");
			if (InFieldList("length")) length = reader.ReadInt("length");
			if (InFieldList("number")) number = reader.ReadInt("number");
			if (InFieldList("opt_acc")) opt_acc = reader.ReadString("opt_acc");
			if (InFieldList("partno")) partno = reader.ReadString("partno");
			if (InFieldList("pack")) pack = reader.ReadString("pack");
			if (InFieldList("option_min")) option_min = reader.ReadString("option_min");
			if (InFieldList("addmin")) addmin = reader.ReadString("addmin");
			if (InFieldList("minutes")) minutes = reader.ReadDecimal("minutes");
			if (InFieldList("emmin1")) emmin1 = reader.ReadInt("emmin1");
			if (InFieldList("emmin2")) emmin2 = reader.ReadInt("emmin2");
			if (InFieldList("oldbook")) oldbook = reader.ReadDecimal("oldbook");
			if (InFieldList("newbook")) newbook = reader.ReadDecimal("newbook");
			if (InFieldList("option_old")) option_old = reader.ReadString("option_old");
			if (InFieldList("ul_dry")) ul_dry = reader.ReadString("ul_dry");
			if (InFieldList("ul_wet")) ul_wet = reader.ReadString("ul_wet");
			if (InFieldList("ul_nocan")) ul_nocan = reader.ReadString("ul_nocan");
			if (InFieldList("empartno")) empartno = reader.ReadString("empartno");
			if (InFieldList("empack")) empack = reader.ReadString("empack");
			if (InFieldList("obsolete")) obsolete = reader.ReadString("obsolete");

			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public IList<hoption> GetOptions(string optCode) {
			var qTime = DateTime.Now;
			var sql = $"select * from hoption where option_cod='{optCode}'";
			var entities = GetEntities<hoption>(sql);					
			QueryDebugEnd(qTime, $"GetOptions - {sql}");
			return entities;
		}

		public bool UpdateOptionMinutes(string optCode, decimal minutes) {
			var qTime = DateTime.Now;
			var did = false;
			var table = "hoption";
			Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = table;
			var rdr = cmd.ExecuteExtendedReader();
			rdr.ActiveIndex = "option_cod";
			var found = rdr.Seek(new object[] { optCode }, AdsExtendedReader.SeekType.HardSeek);
			if (found) {
				var valid = true;
				while (valid) {
					var adsOptCode = rdr.ReadString("option_cod");
					if (adsOptCode != optCode) break;
					if (rdr.FoxRecordLock(table)) {
						var ordinal = rdr.GetOrdinal("Minutes");
						rdr.SetDecimal(ordinal, minutes);
						rdr.WriteRecord();
						rdr.UnlockRecord();
					}
					else {
						// Record could not be locked, data was not written
						// write failure message somewhere
						if (rdr.IsRecordLocked()) {
							rdr.UnlockRecord();
						}
						Debug.WriteLine($"ADS Update Error: lock failed!");
					}
					valid = rdr.Read();
				}
			}
			else {
				// write didn't find keyvalue record message
			}
			rdr.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"Update - {table}");
			return did;
		}

	}

}
