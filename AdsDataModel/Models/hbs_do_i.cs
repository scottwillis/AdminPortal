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

	public class hbs_do_iX : FoxProEntity {

		private int _preqfix_i;
		private int _curqfix_i;
		private int _preofix_i;
		private int _curofix_i;
		private int _presunod_i;
		private int _premonod_i;
		private int _pretueod_i;
		private int _prewedod_i;
		private int _prethuod_i;
		private int _prefriod_i;
		private int _presatod_i;
		private int _cursunod_i;
		private int _curmonod_i;
		private int _curtueod_i;
		private int _curwedod_i;
		private int _curthuod_i;
		private int _curfriod_i;
		private int _cursatod_i;
		private int _prepfix_i;
		private int _curpfix_i;
		private int _presunpd_i;
		private int _premonpd_i;
		private int _pretuepd_i;
		private int _prewedpd_i;
		private int _prethupd_i;
		private int _prefripd_i;
		private int _presatpd_i;
		private int _cursunpd_i;
		private int _curmonpd_i;
		private int _curtuepd_i;
		private int _curwedpd_i;
		private int _curthupd_i;
		private int _curfripd_i;
		private int _cursatpd_i;
		private int _presunpq_i;
		private int _premonpq_i;
		private int _pretuepq_i;
		private int _prewedpq_i;
		private int _prethupq_i;
		private int _prefripq_i;
		private int _presatpq_i;
		private int _cursunpq_i;
		private int _curmonpq_i;
		private int _curtuepq_i;
		private int _curwedpq_i;
		private int _curthupq_i;
		private int _curfripq_i;
		private int _cursatpq_i;
		private int _presunpm_i;
		private int _premonpm_i;
		private int _pretuepm_i;
		private int _prewedpm_i;
		private int _prethupm_i;
		private int _prefripm_i;
		private int _presatpm_i;
		private int _cursunpm_i;
		private int _curmonpm_i;
		private int _curtuepm_i;
		private int _curwedpm_i;
		private int _curthupm_i;
		private int _curfripm_i;
		private int _cursatpm_i;
		private int _preinfpd_i;
		private int _preinfpq_i;
		private int _preinfpm_i;
		private int _curinfpd_i;
		private int _curinfpq_i;
		private int _curinfpm_i;
		private int _presfix_i;
		private int _cursfix_i;
		private int _presunsd_i;
		private int _premonsd_i;
		private int _pretuesd_i;
		private int _prewedsd_i;
		private int _prethusd_i;
		private int _prefrisd_i;
		private int _presatsd_i;
		private int _cursunsd_i;
		private int _curmonsd_i;
		private int _curtuesd_i;
		private int _curwedsd_i;
		private int _curthusd_i;
		private int _curfrisd_i;
		private int _cursatsd_i;
		private int _cursd_i;
		private int _cursc_i;
		private int _presd_i;
		private int _presc_i;
		private int _pre_rts;
		private int _cur_rts;
		private int _pre_rtsq;
		private int _cur_rtsq;
		private int _pre_rtsr;
		private int _pre_rtsrq;
		private int _cur_rtsr;
		private int _cur_rtsrq;
		private int _presunsq_i;
		private int _premonsq_i;
		private int _pretuesq_i;
		private int _prewedsq_i;
		private int _prethusq_i;
		private int _prefrisq_i;
		private int _presatsq_i;
		private int _cursunsq_i;
		private int _curmonsq_i;
		private int _curtuesq_i;
		private int _curwedsq_i;
		private int _curthusq_i;
		private int _curfrisq_i;
		private int _cursatsq_i;
		private int _preosd_i;
		private int _curosd_i;

		public int preqfix_i { get => _preqfix_i; set => SetProperty(ref _preqfix_i, value); }

		public int curqfix_i { get => _curqfix_i; set => SetProperty(ref _curqfix_i, value); }

		public int preofix_i { get => _preofix_i; set => SetProperty(ref _preofix_i, value); }

		public int curofix_i { get => _curofix_i; set => SetProperty(ref _curofix_i, value); }

		public int presunod_i { get => _presunod_i; set => SetProperty(ref _presunod_i, value); }

		public int premonod_i { get => _premonod_i; set => SetProperty(ref _premonod_i, value); }

		public int pretueod_i { get => _pretueod_i; set => SetProperty(ref _pretueod_i, value); }

		public int prewedod_i { get => _prewedod_i; set => SetProperty(ref _prewedod_i, value); }

		public int prethuod_i { get => _prethuod_i; set => SetProperty(ref _prethuod_i, value); }

		public int prefriod_i { get => _prefriod_i; set => SetProperty(ref _prefriod_i, value); }

		public int presatod_i { get => _presatod_i; set => SetProperty(ref _presatod_i, value); }

		public int cursunod_i { get => _cursunod_i; set => SetProperty(ref _cursunod_i, value); }

		public int curmonod_i { get => _curmonod_i; set => SetProperty(ref _curmonod_i, value); }

		public int curtueod_i { get => _curtueod_i; set => SetProperty(ref _curtueod_i, value); }

		public int curwedod_i { get => _curwedod_i; set => SetProperty(ref _curwedod_i, value); }

		public int curthuod_i { get => _curthuod_i; set => SetProperty(ref _curthuod_i, value); }

		public int curfriod_i { get => _curfriod_i; set => SetProperty(ref _curfriod_i, value); }

		public int cursatod_i { get => _cursatod_i; set => SetProperty(ref _cursatod_i, value); }

		public int prepfix_i { get => _prepfix_i; set => SetProperty(ref _prepfix_i, value); }

		public int curpfix_i { get => _curpfix_i; set => SetProperty(ref _curpfix_i, value); }

		public int presunpd_i { get => _presunpd_i; set => SetProperty(ref _presunpd_i, value); }

		public int premonpd_i { get => _premonpd_i; set => SetProperty(ref _premonpd_i, value); }

		public int pretuepd_i { get => _pretuepd_i; set => SetProperty(ref _pretuepd_i, value); }

		public int prewedpd_i { get => _prewedpd_i; set => SetProperty(ref _prewedpd_i, value); }

		public int prethupd_i { get => _prethupd_i; set => SetProperty(ref _prethupd_i, value); }

		public int prefripd_i { get => _prefripd_i; set => SetProperty(ref _prefripd_i, value); }

		public int presatpd_i { get => _presatpd_i; set => SetProperty(ref _presatpd_i, value); }

		public int cursunpd_i { get => _cursunpd_i; set => SetProperty(ref _cursunpd_i, value); }

		public int curmonpd_i { get => _curmonpd_i; set => SetProperty(ref _curmonpd_i, value); }

		public int curtuepd_i { get => _curtuepd_i; set => SetProperty(ref _curtuepd_i, value); }

		public int curwedpd_i { get => _curwedpd_i; set => SetProperty(ref _curwedpd_i, value); }

		public int curthupd_i { get => _curthupd_i; set => SetProperty(ref _curthupd_i, value); }

		public int curfripd_i { get => _curfripd_i; set => SetProperty(ref _curfripd_i, value); }

		public int cursatpd_i { get => _cursatpd_i; set => SetProperty(ref _cursatpd_i, value); }

		public int presunpq_i { get => _presunpq_i; set => SetProperty(ref _presunpq_i, value); }

		public int premonpq_i { get => _premonpq_i; set => SetProperty(ref _premonpq_i, value); }

		public int pretuepq_i { get => _pretuepq_i; set => SetProperty(ref _pretuepq_i, value); }

		public int prewedpq_i { get => _prewedpq_i; set => SetProperty(ref _prewedpq_i, value); }

		public int prethupq_i { get => _prethupq_i; set => SetProperty(ref _prethupq_i, value); }

		public int prefripq_i { get => _prefripq_i; set => SetProperty(ref _prefripq_i, value); }

		public int presatpq_i { get => _presatpq_i; set => SetProperty(ref _presatpq_i, value); }

		public int cursunpq_i { get => _cursunpq_i; set => SetProperty(ref _cursunpq_i, value); }

		public int curmonpq_i { get => _curmonpq_i; set => SetProperty(ref _curmonpq_i, value); }

		public int curtuepq_i { get => _curtuepq_i; set => SetProperty(ref _curtuepq_i, value); }

		public int curwedpq_i { get => _curwedpq_i; set => SetProperty(ref _curwedpq_i, value); }

		public int curthupq_i { get => _curthupq_i; set => SetProperty(ref _curthupq_i, value); }

		public int curfripq_i { get => _curfripq_i; set => SetProperty(ref _curfripq_i, value); }

		public int cursatpq_i { get => _cursatpq_i; set => SetProperty(ref _cursatpq_i, value); }

		public int presunpm_i { get => _presunpm_i; set => SetProperty(ref _presunpm_i, value); }

		public int premonpm_i { get => _premonpm_i; set => SetProperty(ref _premonpm_i, value); }

		public int pretuepm_i { get => _pretuepm_i; set => SetProperty(ref _pretuepm_i, value); }

		public int prewedpm_i { get => _prewedpm_i; set => SetProperty(ref _prewedpm_i, value); }

		public int prethupm_i { get => _prethupm_i; set => SetProperty(ref _prethupm_i, value); }

		public int prefripm_i { get => _prefripm_i; set => SetProperty(ref _prefripm_i, value); }

		public int presatpm_i { get => _presatpm_i; set => SetProperty(ref _presatpm_i, value); }

		public int cursunpm_i { get => _cursunpm_i; set => SetProperty(ref _cursunpm_i, value); }

		public int curmonpm_i { get => _curmonpm_i; set => SetProperty(ref _curmonpm_i, value); }

		public int curtuepm_i { get => _curtuepm_i; set => SetProperty(ref _curtuepm_i, value); }

		public int curwedpm_i { get => _curwedpm_i; set => SetProperty(ref _curwedpm_i, value); }

		public int curthupm_i { get => _curthupm_i; set => SetProperty(ref _curthupm_i, value); }

		public int curfripm_i { get => _curfripm_i; set => SetProperty(ref _curfripm_i, value); }

		public int cursatpm_i { get => _cursatpm_i; set => SetProperty(ref _cursatpm_i, value); }

		public int preinfpd_i { get => _preinfpd_i; set => SetProperty(ref _preinfpd_i, value); }

		public int preinfpq_i { get => _preinfpq_i; set => SetProperty(ref _preinfpq_i, value); }

		public int preinfpm_i { get => _preinfpm_i; set => SetProperty(ref _preinfpm_i, value); }

		public int curinfpd_i { get => _curinfpd_i; set => SetProperty(ref _curinfpd_i, value); }

		public int curinfpq_i { get => _curinfpq_i; set => SetProperty(ref _curinfpq_i, value); }

		public int curinfpm_i { get => _curinfpm_i; set => SetProperty(ref _curinfpm_i, value); }

		public int presfix_i { get => _presfix_i; set => SetProperty(ref _presfix_i, value); }

		public int cursfix_i { get => _cursfix_i; set => SetProperty(ref _cursfix_i, value); }

		public int presunsd_i { get => _presunsd_i; set => SetProperty(ref _presunsd_i, value); }

		public int premonsd_i { get => _premonsd_i; set => SetProperty(ref _premonsd_i, value); }

		public int pretuesd_i { get => _pretuesd_i; set => SetProperty(ref _pretuesd_i, value); }

		public int prewedsd_i { get => _prewedsd_i; set => SetProperty(ref _prewedsd_i, value); }

		public int prethusd_i { get => _prethusd_i; set => SetProperty(ref _prethusd_i, value); }

		public int prefrisd_i { get => _prefrisd_i; set => SetProperty(ref _prefrisd_i, value); }

		public int presatsd_i { get => _presatsd_i; set => SetProperty(ref _presatsd_i, value); }

		public int cursunsd_i { get => _cursunsd_i; set => SetProperty(ref _cursunsd_i, value); }

		public int curmonsd_i { get => _curmonsd_i; set => SetProperty(ref _curmonsd_i, value); }

		public int curtuesd_i { get => _curtuesd_i; set => SetProperty(ref _curtuesd_i, value); }

		public int curwedsd_i { get => _curwedsd_i; set => SetProperty(ref _curwedsd_i, value); }

		public int curthusd_i { get => _curthusd_i; set => SetProperty(ref _curthusd_i, value); }

		public int curfrisd_i { get => _curfrisd_i; set => SetProperty(ref _curfrisd_i, value); }

		public int cursatsd_i { get => _cursatsd_i; set => SetProperty(ref _cursatsd_i, value); }

		public int cursd_i { get => _cursd_i; set => SetProperty(ref _cursd_i, value); }

		public int cursc_i { get => _cursc_i; set => SetProperty(ref _cursc_i, value); }

		public int presd_i { get => _presd_i; set => SetProperty(ref _presd_i, value); }

		public int presc_i { get => _presc_i; set => SetProperty(ref _presc_i, value); }

		public int pre_rts { get => _pre_rts; set => SetProperty(ref _pre_rts, value); }

		public int cur_rts { get => _cur_rts; set => SetProperty(ref _cur_rts, value); }

		public int pre_rtsq { get => _pre_rtsq; set => SetProperty(ref _pre_rtsq, value); }

		public int cur_rtsq { get => _cur_rtsq; set => SetProperty(ref _cur_rtsq, value); }

		public int pre_rtsr { get => _pre_rtsr; set => SetProperty(ref _pre_rtsr, value); }

		public int pre_rtsrq { get => _pre_rtsrq; set => SetProperty(ref _pre_rtsrq, value); }

		public int cur_rtsr { get => _cur_rtsr; set => SetProperty(ref _cur_rtsr, value); }

		public int cur_rtsrq { get => _cur_rtsrq; set => SetProperty(ref _cur_rtsrq, value); }

		public int presunsq_i { get => _presunsq_i; set => SetProperty(ref _presunsq_i, value); }

		public int premonsq_i { get => _premonsq_i; set => SetProperty(ref _premonsq_i, value); }

		public int pretuesq_i { get => _pretuesq_i; set => SetProperty(ref _pretuesq_i, value); }

		public int prewedsq_i { get => _prewedsq_i; set => SetProperty(ref _prewedsq_i, value); }

		public int prethusq_i { get => _prethusq_i; set => SetProperty(ref _prethusq_i, value); }

		public int prefrisq_i { get => _prefrisq_i; set => SetProperty(ref _prefrisq_i, value); }

		public int presatsq_i { get => _presatsq_i; set => SetProperty(ref _presatsq_i, value); }

		public int cursunsq_i { get => _cursunsq_i; set => SetProperty(ref _cursunsq_i, value); }

		public int curmonsq_i { get => _curmonsq_i; set => SetProperty(ref _curmonsq_i, value); }

		public int curtuesq_i { get => _curtuesq_i; set => SetProperty(ref _curtuesq_i, value); }

		public int curwedsq_i { get => _curwedsq_i; set => SetProperty(ref _curwedsq_i, value); }

		public int curthusq_i { get => _curthusq_i; set => SetProperty(ref _curthusq_i, value); }

		public int curfrisq_i { get => _curfrisq_i; set => SetProperty(ref _curfrisq_i, value); }

		public int cursatsq_i { get => _cursatsq_i; set => SetProperty(ref _cursatsq_i, value); }

		public int preosd_i { get => _preosd_i; set => SetProperty(ref _preosd_i, value); }

		public int curosd_i { get => _curosd_i; set => SetProperty(ref _curosd_i, value); }

		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { };

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("preqfix_i")) preqfix_i = reader.ReadInt("preqfix_i");
			if (InFieldList("curqfix_i")) curqfix_i = reader.ReadInt("curqfix_i");
			if (InFieldList("preofix_i")) preofix_i = reader.ReadInt("preofix_i");
			if (InFieldList("curofix_i")) curofix_i = reader.ReadInt("curofix_i");
			if (InFieldList("presunod_i")) presunod_i = reader.ReadInt("presunod_i");
			if (InFieldList("premonod_i")) premonod_i = reader.ReadInt("premonod_i");
			if (InFieldList("pretueod_i")) pretueod_i = reader.ReadInt("pretueod_i");
			if (InFieldList("prewedod_i")) prewedod_i = reader.ReadInt("prewedod_i");
			if (InFieldList("prethuod_i")) prethuod_i = reader.ReadInt("prethuod_i");
			if (InFieldList("prefriod_i")) prefriod_i = reader.ReadInt("prefriod_i");
			if (InFieldList("presatod_i")) presatod_i = reader.ReadInt("presatod_i");
			if (InFieldList("cursunod_i")) cursunod_i = reader.ReadInt("cursunod_i");
			if (InFieldList("curmonod_i")) curmonod_i = reader.ReadInt("curmonod_i");
			if (InFieldList("curtueod_i")) curtueod_i = reader.ReadInt("curtueod_i");
			if (InFieldList("curwedod_i")) curwedod_i = reader.ReadInt("curwedod_i");
			if (InFieldList("curthuod_i")) curthuod_i = reader.ReadInt("curthuod_i");
			if (InFieldList("curfriod_i")) curfriod_i = reader.ReadInt("curfriod_i");
			if (InFieldList("cursatod_i")) cursatod_i = reader.ReadInt("cursatod_i");
			if (InFieldList("prepfix_i")) prepfix_i = reader.ReadInt("prepfix_i");
			if (InFieldList("curpfix_i")) curpfix_i = reader.ReadInt("curpfix_i");
			if (InFieldList("presunpd_i")) presunpd_i = reader.ReadInt("presunpd_i");
			if (InFieldList("premonpd_i")) premonpd_i = reader.ReadInt("premonpd_i");
			if (InFieldList("pretuepd_i")) pretuepd_i = reader.ReadInt("pretuepd_i");
			if (InFieldList("prewedpd_i")) prewedpd_i = reader.ReadInt("prewedpd_i");
			if (InFieldList("prethupd_i")) prethupd_i = reader.ReadInt("prethupd_i");
			if (InFieldList("prefripd_i")) prefripd_i = reader.ReadInt("prefripd_i");
			if (InFieldList("presatpd_i")) presatpd_i = reader.ReadInt("presatpd_i");
			if (InFieldList("cursunpd_i")) cursunpd_i = reader.ReadInt("cursunpd_i");
			if (InFieldList("curmonpd_i")) curmonpd_i = reader.ReadInt("curmonpd_i");
			if (InFieldList("curtuepd_i")) curtuepd_i = reader.ReadInt("curtuepd_i");
			if (InFieldList("curwedpd_i")) curwedpd_i = reader.ReadInt("curwedpd_i");
			if (InFieldList("curthupd_i")) curthupd_i = reader.ReadInt("curthupd_i");
			if (InFieldList("curfripd_i")) curfripd_i = reader.ReadInt("curfripd_i");
			if (InFieldList("cursatpd_i")) cursatpd_i = reader.ReadInt("cursatpd_i");
			if (InFieldList("presunpq_i")) presunpq_i = reader.ReadInt("presunpq_i");
			if (InFieldList("premonpq_i")) premonpq_i = reader.ReadInt("premonpq_i");
			if (InFieldList("pretuepq_i")) pretuepq_i = reader.ReadInt("pretuepq_i");
			if (InFieldList("prewedpq_i")) prewedpq_i = reader.ReadInt("prewedpq_i");
			if (InFieldList("prethupq_i")) prethupq_i = reader.ReadInt("prethupq_i");
			if (InFieldList("prefripq_i")) prefripq_i = reader.ReadInt("prefripq_i");
			if (InFieldList("presatpq_i")) presatpq_i = reader.ReadInt("presatpq_i");
			if (InFieldList("cursunpq_i")) cursunpq_i = reader.ReadInt("cursunpq_i");
			if (InFieldList("curmonpq_i")) curmonpq_i = reader.ReadInt("curmonpq_i");
			if (InFieldList("curtuepq_i")) curtuepq_i = reader.ReadInt("curtuepq_i");
			if (InFieldList("curwedpq_i")) curwedpq_i = reader.ReadInt("curwedpq_i");
			if (InFieldList("curthupq_i")) curthupq_i = reader.ReadInt("curthupq_i");
			if (InFieldList("curfripq_i")) curfripq_i = reader.ReadInt("curfripq_i");
			if (InFieldList("cursatpq_i")) cursatpq_i = reader.ReadInt("cursatpq_i");
			if (InFieldList("presunpm_i")) presunpm_i = reader.ReadInt("presunpm_i");
			if (InFieldList("premonpm_i")) premonpm_i = reader.ReadInt("premonpm_i");
			if (InFieldList("pretuepm_i")) pretuepm_i = reader.ReadInt("pretuepm_i");
			if (InFieldList("prewedpm_i")) prewedpm_i = reader.ReadInt("prewedpm_i");
			if (InFieldList("prethupm_i")) prethupm_i = reader.ReadInt("prethupm_i");
			if (InFieldList("prefripm_i")) prefripm_i = reader.ReadInt("prefripm_i");
			if (InFieldList("presatpm_i")) presatpm_i = reader.ReadInt("presatpm_i");
			if (InFieldList("cursunpm_i")) cursunpm_i = reader.ReadInt("cursunpm_i");
			if (InFieldList("curmonpm_i")) curmonpm_i = reader.ReadInt("curmonpm_i");
			if (InFieldList("curtuepm_i")) curtuepm_i = reader.ReadInt("curtuepm_i");
			if (InFieldList("curwedpm_i")) curwedpm_i = reader.ReadInt("curwedpm_i");
			if (InFieldList("curthupm_i")) curthupm_i = reader.ReadInt("curthupm_i");
			if (InFieldList("curfripm_i")) curfripm_i = reader.ReadInt("curfripm_i");
			if (InFieldList("cursatpm_i")) cursatpm_i = reader.ReadInt("cursatpm_i");
			if (InFieldList("preinfpd_i")) preinfpd_i = reader.ReadInt("preinfpd_i");
			if (InFieldList("preinfpq_i")) preinfpq_i = reader.ReadInt("preinfpq_i");
			if (InFieldList("preinfpm_i")) preinfpm_i = reader.ReadInt("preinfpm_i");
			if (InFieldList("curinfpd_i")) curinfpd_i = reader.ReadInt("curinfpd_i");
			if (InFieldList("curinfpq_i")) curinfpq_i = reader.ReadInt("curinfpq_i");
			if (InFieldList("curinfpm_i")) curinfpm_i = reader.ReadInt("curinfpm_i");
			if (InFieldList("presfix_i")) presfix_i = reader.ReadInt("presfix_i");
			if (InFieldList("cursfix_i")) cursfix_i = reader.ReadInt("cursfix_i");
			if (InFieldList("presunsd_i")) presunsd_i = reader.ReadInt("presunsd_i");
			if (InFieldList("premonsd_i")) premonsd_i = reader.ReadInt("premonsd_i");
			if (InFieldList("pretuesd_i")) pretuesd_i = reader.ReadInt("pretuesd_i");
			if (InFieldList("prewedsd_i")) prewedsd_i = reader.ReadInt("prewedsd_i");
			if (InFieldList("prethusd_i")) prethusd_i = reader.ReadInt("prethusd_i");
			if (InFieldList("prefrisd_i")) prefrisd_i = reader.ReadInt("prefrisd_i");
			if (InFieldList("presatsd_i")) presatsd_i = reader.ReadInt("presatsd_i");
			if (InFieldList("cursunsd_i")) cursunsd_i = reader.ReadInt("cursunsd_i");
			if (InFieldList("curmonsd_i")) curmonsd_i = reader.ReadInt("curmonsd_i");
			if (InFieldList("curtuesd_i")) curtuesd_i = reader.ReadInt("curtuesd_i");
			if (InFieldList("curwedsd_i")) curwedsd_i = reader.ReadInt("curwedsd_i");
			if (InFieldList("curthusd_i")) curthusd_i = reader.ReadInt("curthusd_i");
			if (InFieldList("curfrisd_i")) curfrisd_i = reader.ReadInt("curfrisd_i");
			if (InFieldList("cursatsd_i")) cursatsd_i = reader.ReadInt("cursatsd_i");
			if (InFieldList("cursd_i")) cursd_i = reader.ReadInt("cursd_i");
			if (InFieldList("cursc_i")) cursc_i = reader.ReadInt("cursc_i");
			if (InFieldList("presd_i")) presd_i = reader.ReadInt("presd_i");
			if (InFieldList("presc_i")) presc_i = reader.ReadInt("presc_i");
			if (InFieldList("pre_rts")) pre_rts = reader.ReadInt("pre_rts");
			if (InFieldList("cur_rts")) cur_rts = reader.ReadInt("cur_rts");
			if (InFieldList("pre_rtsq")) pre_rtsq = reader.ReadInt("pre_rtsq");
			if (InFieldList("cur_rtsq")) cur_rtsq = reader.ReadInt("cur_rtsq");
			if (InFieldList("pre_rtsr")) pre_rtsr = reader.ReadInt("pre_rtsr");
			if (InFieldList("pre_rtsrq")) pre_rtsrq = reader.ReadInt("pre_rtsrq");
			if (InFieldList("cur_rtsr")) cur_rtsr = reader.ReadInt("cur_rtsr");
			if (InFieldList("cur_rtsrq")) cur_rtsrq = reader.ReadInt("cur_rtsrq");
			if (InFieldList("presunsq_i")) presunsq_i = reader.ReadInt("presunsq_i");
			if (InFieldList("premonsq_i")) premonsq_i = reader.ReadInt("premonsq_i");
			if (InFieldList("pretuesq_i")) pretuesq_i = reader.ReadInt("pretuesq_i");
			if (InFieldList("prewedsq_i")) prewedsq_i = reader.ReadInt("prewedsq_i");
			if (InFieldList("prethusq_i")) prethusq_i = reader.ReadInt("prethusq_i");
			if (InFieldList("prefrisq_i")) prefrisq_i = reader.ReadInt("prefrisq_i");
			if (InFieldList("presatsq_i")) presatsq_i = reader.ReadInt("presatsq_i");
			if (InFieldList("cursunsq_i")) cursunsq_i = reader.ReadInt("cursunsq_i");
			if (InFieldList("curmonsq_i")) curmonsq_i = reader.ReadInt("curmonsq_i");
			if (InFieldList("curtuesq_i")) curtuesq_i = reader.ReadInt("curtuesq_i");
			if (InFieldList("curwedsq_i")) curwedsq_i = reader.ReadInt("curwedsq_i");
			if (InFieldList("curthusq_i")) curthusq_i = reader.ReadInt("curthusq_i");
			if (InFieldList("curfrisq_i")) curfrisq_i = reader.ReadInt("curfrisq_i");
			if (InFieldList("cursatsq_i")) cursatsq_i = reader.ReadInt("cursatsq_i");
			if (InFieldList("preosd_i")) preosd_i = reader.ReadInt("preosd_i");
			if (InFieldList("curosd_i")) curosd_i = reader.ReadInt("curosd_i");
			MakeClean();
		}

	}

}
