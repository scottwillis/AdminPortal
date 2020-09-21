using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using Advantage.Data.Provider;
using Common;
using System.Runtime.Serialization;

namespace AdsDataModel {

	public abstract class FoxProEntity : IFoxProEntity {

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public List<string> DirtyList { get; set; } = new List<string>();

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public List<string> DupDirtyList { get; set; } = new List<string>();

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public List<string> FieldList { get; set; } = new List<string>();

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public abstract string Key { get; set; }

		[Display(AutoGenerateField = false)]
		[MyCustom(AdsIgnore = true)]
		public abstract object[] KeyValue { get; }

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
			if (propertyName != null && propertyName.Equals("DupDirtyList")) return;
			if (DirtyList == null) DirtyList = new List<string>();
			if (DirtyList.SingleOrDefault(x => x == propertyName) == null) DirtyList.Add(propertyName);
		}

		protected virtual bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null) {
			if (object.Equals(storage, value)) return false;
			storage = value;
			OnPropertyChanged(propertyName);
			return true;
		}

		public void MakeClean() {
			DirtyList.Clear();
			DupDirtyList.Clear();
		}

		public void PrepareSave() {
			DupDirtyList = DirtyList;
		}

		public bool InFieldList(string field) {
			if (field.Equals("desc")) field = "[desc]";
			return !FieldList.Any() || FieldList.Contains(field) || FieldList.Contains("*");
		}

		public virtual void Refresh() {

		}

		public virtual int Insert() {
			return 0;
		}

		public virtual bool Update() {
			return false;
		}

		public virtual bool Delete() {
			return false;
		}

		public abstract void FillFromReader(AdsDataReader reader);

		public virtual void FillFromReaderList(AdsDataReader reader, List<string> fields) {
			FieldList = fields;
			FillFromReader(reader);
		}

	}

	public interface IFoxProEntity : INotifyPropertyChanged {
		string Key { get; set; }
		object[] KeyValue { get; }
		List<string> DirtyList { get; set; }
		List<string> DupDirtyList { get; set; }
		List<string> FieldList { get; set; }
		void Refresh();
		int Insert();
		bool Update();
		bool Delete();
		void PrepareSave();
		bool InFieldList(string field);
		void MakeClean();
		void FillFromReader(AdsDataReader reader);
		void FillFromReaderList(AdsDataReader reader, List<string> fields);
	}

}
