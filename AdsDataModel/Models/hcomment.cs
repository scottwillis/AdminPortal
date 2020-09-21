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

	public class hcomment : FoxProEntity {

		public hcomment() {
			Key = "orderno";
		}

		private string _orderno;
		private string _code;
		private string _comment;
		private string _user;
		private DateTime? _date;

		[Display(Name = "OrderNo")]
		[MyCustom(IsVisible = true, IsReadOnly = true)]
		public string orderno { get => _orderno; set => SetProperty(ref _orderno, value); }

		[Display(Name = "Date")]
		[DataType(DataType.Date), DisplayFormat(DataFormatString = MagicString.SmallDateFormat, ApplyFormatInEditMode = true)]
		[MyCustom(IsVisible = true, IsReadOnly = true)]
		public DateTime? date { get => _date; set => SetProperty(ref _date, value); }

		[Display(Name = "User")]
		[MyCustom(IsVisible = true, IsReadOnly = true)]
		public string user { get => _user; set => SetProperty(ref _user, value); }

		[Display(Name = "Code")]
		[MyCustom(IsVisible = true, IsReadOnly = true)]
		public string code { get => _code; set => SetProperty(ref _code, value); }

		[Display(Name = "Comment")]
		[MyCustom(IsVisible = true)]
		public string comment { get => _comment; set => SetProperty(ref _comment, value); }

		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { orderno, code };

		public override int Insert() {
			var context = new FoxProDataContext();
			date = DateTime.Today;
			user = Environment.UserName.ToLower();
			var recno = context.Insert(this);
			return recno;
		}

		public override bool Update() {
			var context = new FoxProDataContext();
			date = DateTime.Today;
			user = Environment.UserName.ToLower();
			var updated = context.Update(this);
			return updated;
		}

		public override bool Delete() {
			var context = new FoxProDataContext();
			var deleted = context.Delete(this);
			if (deleted) {
			}
			return deleted;
		}

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("orderno")) orderno = reader.ReadString("orderno");
			if (InFieldList("code")) code = reader.ReadString("code");
			if (InFieldList("comment")) comment = reader.ReadString("comment");
			if (InFieldList("user")) user = reader.ReadString("user");
			if (InFieldList("date")) date = reader.ReadDate("date");
			MakeClean();
		}
	}

	public partial class FoxProDataContext {

		public IList<hcomment> GetOrderComments(int orderno) {
			var qTime = DateTime.Now;
			var ord = orderno.ToString().PadLeft(8, ' ');
			var sql = $"select * from hcomment where orderno='{ord}' order by code";
			var entities = GetEntities<hcomment>(sql);
			QueryDebugEnd(qTime, $"GetOrderComments - {sql}");
			return entities;
		}

		public int GetNextCommentCode(string orderno) {
			var qTime = DateTime.Now;
			var sql = $"select code from hcomment where orderno='{orderno}' order by code";
			var entities = GetEntities<hcomment>(sql);
			var last = Convert.ToInt32(entities.LastOrDefault()?.code) + 1;
			QueryDebugEnd(qTime, $"GetNextCommentCode - {sql}");
			return last;
		}

		public IList<hcomment> GetOrderComments2(int orderno) {
			var qTime = DateTime.Now;
			Conn.Open();
			var entities = new List<hcomment>();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hcomment";
			var reader = cmd.ExecuteExtendedReader();
			reader.ActiveIndex = "orderno";
			var ord = orderno.ToString().PadLeft(8, ' ');
			var found = reader.Seek(new object[] { ord }, AdsExtendedReader.SeekType.HardSeek);
			if (found) {
				var valid = true;
				while (valid) {
					var no = reader.ReadString("orderno");
					if (no != ord) break;
					var entity = new hcomment();
					entity.FillFromReader(reader);
					entities.Add(entity);
					valid = reader.Read();
				}
			}
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetOrderComments");
			return entities;
		}

	}

}
