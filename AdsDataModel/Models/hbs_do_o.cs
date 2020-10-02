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

	public class hbs_do_oX : FoxProEntity {

		private int _preqfix_o;
		private int _curqfix_o;
		private int _preofix_o;
		private int _curofix_o;
		private int _presunod_o;
		private int _premonod_o;
		private int _pretueod_o;
		private int _prewedod_o;
		private int _prethuod_o;
		private int _prefriod_o;
		private int _presatod_o;
		private int _cursunod_o;
		private int _curmonod_o;
		private int _curtueod_o;
		private int _curwedod_o;
		private int _curthuod_o;
		private int _curfriod_o;
		private int _cursatod_o;
		private int _prepfix_o;
		private int _curpfix_o;
		private int _presunpd_o;
		private int _premonpd_o;
		private int _pretuepd_o;
		private int _prewedpd_o;
		private int _prethupd_o;
		private int _prefripd_o;
		private int _presatpd_o;
		private int _cursunpd_o;
		private int _curmonpd_o;
		private int _curtuepd_o;
		private int _curwedpd_o;
		private int _curthupd_o;
		private int _curfripd_o;
		private int _cursatpd_o;
		private int _presunpq_o;
		private int _premonpq_o;
		private int _pretuepq_o;
		private int _prewedpq_o;
		private int _prethupq_o;
		private int _prefripq_o;
		private int _presatpq_o;
		private int _cursunpq_o;
		private int _curmonpq_o;
		private int _curtuepq_o;
		private int _curwedpq_o;
		private int _curthupq_o;
		private int _curfripq_o;
		private int _cursatpq_o;
		private int _presunpm_o;
		private int _premonpm_o;
		private int _pretuepm_o;
		private int _prewedpm_o;
		private int _prethupm_o;
		private int _prefripm_o;
		private int _presatpm_o;
		private int _cursunpm_o;
		private int _curmonpm_o;
		private int _curtuepm_o;
		private int _curwedpm_o;
		private int _curthupm_o;
		private int _curfripm_o;
		private int _cursatpm_o;
		private int _preinfpd_o;
		private int _preinfpq_o;
		private int _preinfpm_o;
		private int _curinfpd_o;
		private int _curinfpq_o;
		private int _curinfpm_o;
		private int _presfix_o;
		private int _cursfix_o;
		private int _presunsd_o;
		private int _premonsd_o;
		private int _pretuesd_o;
		private int _prewedsd_o;
		private int _prethusd_o;
		private int _prefrisd_o;
		private int _presatsd_o;
		private int _cursunsd_o;
		private int _curmonsd_o;
		private int _curtuesd_o;
		private int _curwedsd_o;
		private int _curthusd_o;
		private int _curfrisd_o;
		private int _cursatsd_o;
		private int _cursd_o;
		private int _cursc_o;
		private int _presd_o;
		private int _presc_o;
		private int _pre_rts;
		private int _cur_rts;
		private int _pre_rtsq;
		private int _cur_rtsq;
		private int _pre_rtsr;
		private int _pre_rtsrq;
		private int _cur_rtsr;
		private int _cur_rtsrq;
		private int _presunsq_o;
		private int _premonsq_o;
		private int _pretuesq_o;
		private int _prewedsq_o;
		private int _prethusq_o;
		private int _prefrisq_o;
		private int _presatsq_o;
		private int _cursunsq_o;
		private int _curmonsq_o;
		private int _curtuesq_o;
		private int _curwedsq_o;
		private int _curthusq_o;
		private int _curfrisq_o;
		private int _cursatsq_o;
		private int _preosd_o;
		private int _curosd_o;

		public int preqfix_o { get => _preqfix_o; set => SetProperty(ref _preqfix_o, value); }
		public int curqfix_o { get => _curqfix_o; set => SetProperty(ref _curqfix_o, value); }
		public int preofix_o { get => _preofix_o; set => SetProperty(ref _preofix_o, value); }
		public int curofix_o { get => _curofix_o; set => SetProperty(ref _curofix_o, value); }
		public int presunod_o { get => _presunod_o; set => SetProperty(ref _presunod_o, value); }
		public int premonod_o { get => _premonod_o; set => SetProperty(ref _premonod_o, value); }
		public int pretueod_o { get => _pretueod_o; set => SetProperty(ref _pretueod_o, value); }
		public int prewedod_o { get => _prewedod_o; set => SetProperty(ref _prewedod_o, value); }
		public int prethuod_o { get => _prethuod_o; set => SetProperty(ref _prethuod_o, value); }
		public int prefriod_o { get => _prefriod_o; set => SetProperty(ref _prefriod_o, value); }
		public int presatod_o { get => _presatod_o; set => SetProperty(ref _presatod_o, value); }
		public int cursunod_o { get => _cursunod_o; set => SetProperty(ref _cursunod_o, value); }
		public int curmonod_o { get => _curmonod_o; set => SetProperty(ref _curmonod_o, value); }
		public int curtueod_o { get => _curtueod_o; set => SetProperty(ref _curtueod_o, value); }
		public int curwedod_o { get => _curwedod_o; set => SetProperty(ref _curwedod_o, value); }
		public int curthuod_o { get => _curthuod_o; set => SetProperty(ref _curthuod_o, value); }
		public int curfriod_o { get => _curfriod_o; set => SetProperty(ref _curfriod_o, value); }
		public int cursatod_o { get => _cursatod_o; set => SetProperty(ref _cursatod_o, value); }
		public int prepfix_o { get => _prepfix_o; set => SetProperty(ref _prepfix_o, value); }
		public int curpfix_o { get => _curpfix_o; set => SetProperty(ref _curpfix_o, value); }
		public int presunpd_o { get => _presunpd_o; set => SetProperty(ref _presunpd_o, value); }
		public int premonpd_o { get => _premonpd_o; set => SetProperty(ref _premonpd_o, value); }
		public int pretuepd_o { get => _pretuepd_o; set => SetProperty(ref _pretuepd_o, value); }
		public int prewedpd_o { get => _prewedpd_o; set => SetProperty(ref _prewedpd_o, value); }
		public int prethupd_o { get => _prethupd_o; set => SetProperty(ref _prethupd_o, value); }
		public int prefripd_o { get => _prefripd_o; set => SetProperty(ref _prefripd_o, value); }
		public int presatpd_o { get => _presatpd_o; set => SetProperty(ref _presatpd_o, value); }
		public int cursunpd_o { get => _cursunpd_o; set => SetProperty(ref _cursunpd_o, value); }
		public int curmonpd_o { get => _curmonpd_o; set => SetProperty(ref _curmonpd_o, value); }
		public int curtuepd_o { get => _curtuepd_o; set => SetProperty(ref _curtuepd_o, value); }
		public int curwedpd_o { get => _curwedpd_o; set => SetProperty(ref _curwedpd_o, value); }
		public int curthupd_o { get => _curthupd_o; set => SetProperty(ref _curthupd_o, value); }
		public int curfripd_o { get => _curfripd_o; set => SetProperty(ref _curfripd_o, value); }
		public int cursatpd_o { get => _cursatpd_o; set => SetProperty(ref _cursatpd_o, value); }
		public int presunpq_o { get => _presunpq_o; set => SetProperty(ref _presunpq_o, value); }
		public int premonpq_o { get => _premonpq_o; set => SetProperty(ref _premonpq_o, value); }
		public int pretuepq_o { get => _pretuepq_o; set => SetProperty(ref _pretuepq_o, value); }
		public int prewedpq_o { get => _prewedpq_o; set => SetProperty(ref _prewedpq_o, value); }
		public int prethupq_o { get => _prethupq_o; set => SetProperty(ref _prethupq_o, value); }
		public int prefripq_o { get => _prefripq_o; set => SetProperty(ref _prefripq_o, value); }
		public int presatpq_o { get => _presatpq_o; set => SetProperty(ref _presatpq_o, value); }
		public int cursunpq_o { get => _cursunpq_o; set => SetProperty(ref _cursunpq_o, value); }
		public int curmonpq_o { get => _curmonpq_o; set => SetProperty(ref _curmonpq_o, value); }
		public int curtuepq_o { get => _curtuepq_o; set => SetProperty(ref _curtuepq_o, value); }
		public int curwedpq_o { get => _curwedpq_o; set => SetProperty(ref _curwedpq_o, value); }
		public int curthupq_o { get => _curthupq_o; set => SetProperty(ref _curthupq_o, value); }
		public int curfripq_o { get => _curfripq_o; set => SetProperty(ref _curfripq_o, value); }
		public int cursatpq_o { get => _cursatpq_o; set => SetProperty(ref _cursatpq_o, value); }
		public int presunpm_o { get => _presunpm_o; set => SetProperty(ref _presunpm_o, value); }
		public int premonpm_o { get => _premonpm_o; set => SetProperty(ref _premonpm_o, value); }
		public int pretuepm_o { get => _pretuepm_o; set => SetProperty(ref _pretuepm_o, value); }
		public int prewedpm_o { get => _prewedpm_o; set => SetProperty(ref _prewedpm_o, value); }
		public int prethupm_o { get => _prethupm_o; set => SetProperty(ref _prethupm_o, value); }
		public int prefripm_o { get => _prefripm_o; set => SetProperty(ref _prefripm_o, value); }
		public int presatpm_o { get => _presatpm_o; set => SetProperty(ref _presatpm_o, value); }
		public int cursunpm_o { get => _cursunpm_o; set => SetProperty(ref _cursunpm_o, value); }
		public int curmonpm_o { get => _curmonpm_o; set => SetProperty(ref _curmonpm_o, value); }
		public int curtuepm_o { get => _curtuepm_o; set => SetProperty(ref _curtuepm_o, value); }
		public int curwedpm_o { get => _curwedpm_o; set => SetProperty(ref _curwedpm_o, value); }
		public int curthupm_o { get => _curthupm_o; set => SetProperty(ref _curthupm_o, value); }
		public int curfripm_o { get => _curfripm_o; set => SetProperty(ref _curfripm_o, value); }
		public int cursatpm_o { get => _cursatpm_o; set => SetProperty(ref _cursatpm_o, value); }
		public int preinfpd_o { get => _preinfpd_o; set => SetProperty(ref _preinfpd_o, value); }
		public int preinfpq_o { get => _preinfpq_o; set => SetProperty(ref _preinfpq_o, value); }
		public int preinfpm_o { get => _preinfpm_o; set => SetProperty(ref _preinfpm_o, value); }
		public int curinfpd_o { get => _curinfpd_o; set => SetProperty(ref _curinfpd_o, value); }
		public int curinfpq_o { get => _curinfpq_o; set => SetProperty(ref _curinfpq_o, value); }
		public int curinfpm_o { get => _curinfpm_o; set => SetProperty(ref _curinfpm_o, value); }
		public int presfix_o { get => _presfix_o; set => SetProperty(ref _presfix_o, value); }
		public int cursfix_o { get => _cursfix_o; set => SetProperty(ref _cursfix_o, value); }
		public int presunsd_o { get => _presunsd_o; set => SetProperty(ref _presunsd_o, value); }
		public int premonsd_o { get => _premonsd_o; set => SetProperty(ref _premonsd_o, value); }
		public int pretuesd_o { get => _pretuesd_o; set => SetProperty(ref _pretuesd_o, value); }
		public int prewedsd_o { get => _prewedsd_o; set => SetProperty(ref _prewedsd_o, value); }
		public int prethusd_o { get => _prethusd_o; set => SetProperty(ref _prethusd_o, value); }
		public int prefrisd_o { get => _prefrisd_o; set => SetProperty(ref _prefrisd_o, value); }
		public int presatsd_o { get => _presatsd_o; set => SetProperty(ref _presatsd_o, value); }
		public int cursunsd_o { get => _cursunsd_o; set => SetProperty(ref _cursunsd_o, value); }
		public int curmonsd_o { get => _curmonsd_o; set => SetProperty(ref _curmonsd_o, value); }
		public int curtuesd_o { get => _curtuesd_o; set => SetProperty(ref _curtuesd_o, value); }
		public int curwedsd_o { get => _curwedsd_o; set => SetProperty(ref _curwedsd_o, value); }
		public int curthusd_o { get => _curthusd_o; set => SetProperty(ref _curthusd_o, value); }
		public int curfrisd_o { get => _curfrisd_o; set => SetProperty(ref _curfrisd_o, value); }
		public int cursatsd_o { get => _cursatsd_o; set => SetProperty(ref _cursatsd_o, value); }
		public int cursd_o { get => _cursd_o; set => SetProperty(ref _cursd_o, value); }
		public int cursc_o { get => _cursc_o; set => SetProperty(ref _cursc_o, value); }
		public int presd_o { get => _presd_o; set => SetProperty(ref _presd_o, value); }
		public int presc_o { get => _presc_o; set => SetProperty(ref _presc_o, value); }
		public int pre_rts { get => _pre_rts; set => SetProperty(ref _pre_rts, value); }
		public int cur_rts { get => _cur_rts; set => SetProperty(ref _cur_rts, value); }
		public int pre_rtsq { get => _pre_rtsq; set => SetProperty(ref _pre_rtsq, value); }
		public int cur_rtsq { get => _cur_rtsq; set => SetProperty(ref _cur_rtsq, value); }
		public int pre_rtsr { get => _pre_rtsr; set => SetProperty(ref _pre_rtsr, value); }
		public int pre_rtsrq { get => _pre_rtsrq; set => SetProperty(ref _pre_rtsrq, value); }
		public int cur_rtsr { get => _cur_rtsr; set => SetProperty(ref _cur_rtsr, value); }
		public int cur_rtsrq { get => _cur_rtsrq; set => SetProperty(ref _cur_rtsrq, value); }
		public int presunsq_o { get => _presunsq_o; set => SetProperty(ref _presunsq_o, value); }
		public int premonsq_o { get => _premonsq_o; set => SetProperty(ref _premonsq_o, value); }
		public int pretuesq_o { get => _pretuesq_o; set => SetProperty(ref _pretuesq_o, value); }
		public int prewedsq_o { get => _prewedsq_o; set => SetProperty(ref _prewedsq_o, value); }
		public int prethusq_o { get => _prethusq_o; set => SetProperty(ref _prethusq_o, value); }
		public int prefrisq_o { get => _prefrisq_o; set => SetProperty(ref _prefrisq_o, value); }
		public int presatsq_o { get => _presatsq_o; set => SetProperty(ref _presatsq_o, value); }
		public int cursunsq_o { get => _cursunsq_o; set => SetProperty(ref _cursunsq_o, value); }
		public int curmonsq_o { get => _curmonsq_o; set => SetProperty(ref _curmonsq_o, value); }
		public int curtuesq_o { get => _curtuesq_o; set => SetProperty(ref _curtuesq_o, value); }
		public int curwedsq_o { get => _curwedsq_o; set => SetProperty(ref _curwedsq_o, value); }
		public int curthusq_o { get => _curthusq_o; set => SetProperty(ref _curthusq_o, value); }
		public int curfrisq_o { get => _curfrisq_o; set => SetProperty(ref _curfrisq_o, value); }
		public int cursatsq_o { get => _cursatsq_o; set => SetProperty(ref _cursatsq_o, value); }
		public int preosd_o { get => _preosd_o; set => SetProperty(ref _preosd_o, value); }
		public int curosd_o { get => _curosd_o; set => SetProperty(ref _curosd_o, value); }

		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { };

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("preqfix_o")) preqfix_o = reader.ReadInt("preqfix_o");
			if (InFieldList("curqfix_o")) curqfix_o = reader.ReadInt("curqfix_o");
			if (InFieldList("preofix_o")) preofix_o = reader.ReadInt("preofix_o");
			if (InFieldList("curofix_o")) curofix_o = reader.ReadInt("curofix_o");
			if (InFieldList("presunod_o")) presunod_o = reader.ReadInt("presunod_o");
			if (InFieldList("premonod_o")) premonod_o = reader.ReadInt("premonod_o");
			if (InFieldList("pretueod_o")) pretueod_o = reader.ReadInt("pretueod_o");
			if (InFieldList("prewedod_o")) prewedod_o = reader.ReadInt("prewedod_o");
			if (InFieldList("prethuod_o")) prethuod_o = reader.ReadInt("prethuod_o");
			if (InFieldList("prefriod_o")) prefriod_o = reader.ReadInt("prefriod_o");
			if (InFieldList("presatod_o")) presatod_o = reader.ReadInt("presatod_o");
			if (InFieldList("cursunod_o")) cursunod_o = reader.ReadInt("cursunod_o");
			if (InFieldList("curmonod_o")) curmonod_o = reader.ReadInt("curmonod_o");
			if (InFieldList("curtueod_o")) curtueod_o = reader.ReadInt("curtueod_o");
			if (InFieldList("curwedod_o")) curwedod_o = reader.ReadInt("curwedod_o");
			if (InFieldList("curthuod_o")) curthuod_o = reader.ReadInt("curthuod_o");
			if (InFieldList("curfriod_o")) curfriod_o = reader.ReadInt("curfriod_o");
			if (InFieldList("cursatod_o")) cursatod_o = reader.ReadInt("cursatod_o");
			if (InFieldList("prepfix_o")) prepfix_o = reader.ReadInt("prepfix_o");
			if (InFieldList("curpfix_o")) curpfix_o = reader.ReadInt("curpfix_o");
			if (InFieldList("presunpd_o")) presunpd_o = reader.ReadInt("presunpd_o");
			if (InFieldList("premonpd_o")) premonpd_o = reader.ReadInt("premonpd_o");
			if (InFieldList("pretuepd_o")) pretuepd_o = reader.ReadInt("pretuepd_o");
			if (InFieldList("prewedpd_o")) prewedpd_o = reader.ReadInt("prewedpd_o");
			if (InFieldList("prethupd_o")) prethupd_o = reader.ReadInt("prethupd_o");
			if (InFieldList("prefripd_o")) prefripd_o = reader.ReadInt("prefripd_o");
			if (InFieldList("presatpd_o")) presatpd_o = reader.ReadInt("presatpd_o");
			if (InFieldList("cursunpd_o")) cursunpd_o = reader.ReadInt("cursunpd_o");
			if (InFieldList("curmonpd_o")) curmonpd_o = reader.ReadInt("curmonpd_o");
			if (InFieldList("curtuepd_o")) curtuepd_o = reader.ReadInt("curtuepd_o");
			if (InFieldList("curwedpd_o")) curwedpd_o = reader.ReadInt("curwedpd_o");
			if (InFieldList("curthupd_o")) curthupd_o = reader.ReadInt("curthupd_o");
			if (InFieldList("curfripd_o")) curfripd_o = reader.ReadInt("curfripd_o");
			if (InFieldList("cursatpd_o")) cursatpd_o = reader.ReadInt("cursatpd_o");
			if (InFieldList("presunpq_o")) presunpq_o = reader.ReadInt("presunpq_o");
			if (InFieldList("premonpq_o")) premonpq_o = reader.ReadInt("premonpq_o");
			if (InFieldList("pretuepq_o")) pretuepq_o = reader.ReadInt("pretuepq_o");
			if (InFieldList("prewedpq_o")) prewedpq_o = reader.ReadInt("prewedpq_o");
			if (InFieldList("prethupq_o")) prethupq_o = reader.ReadInt("prethupq_o");
			if (InFieldList("prefripq_o")) prefripq_o = reader.ReadInt("prefripq_o");
			if (InFieldList("presatpq_o")) presatpq_o = reader.ReadInt("presatpq_o");
			if (InFieldList("cursunpq_o")) cursunpq_o = reader.ReadInt("cursunpq_o");
			if (InFieldList("curmonpq_o")) curmonpq_o = reader.ReadInt("curmonpq_o");
			if (InFieldList("curtuepq_o")) curtuepq_o = reader.ReadInt("curtuepq_o");
			if (InFieldList("curwedpq_o")) curwedpq_o = reader.ReadInt("curwedpq_o");
			if (InFieldList("curthupq_o")) curthupq_o = reader.ReadInt("curthupq_o");
			if (InFieldList("curfripq_o")) curfripq_o = reader.ReadInt("curfripq_o");
			if (InFieldList("cursatpq_o")) cursatpq_o = reader.ReadInt("cursatpq_o");
			if (InFieldList("presunpm_o")) presunpm_o = reader.ReadInt("presunpm_o");
			if (InFieldList("premonpm_o")) premonpm_o = reader.ReadInt("premonpm_o");
			if (InFieldList("pretuepm_o")) pretuepm_o = reader.ReadInt("pretuepm_o");
			if (InFieldList("prewedpm_o")) prewedpm_o = reader.ReadInt("prewedpm_o");
			if (InFieldList("prethupm_o")) prethupm_o = reader.ReadInt("prethupm_o");
			if (InFieldList("prefripm_o")) prefripm_o = reader.ReadInt("prefripm_o");
			if (InFieldList("presatpm_o")) presatpm_o = reader.ReadInt("presatpm_o");
			if (InFieldList("cursunpm_o")) cursunpm_o = reader.ReadInt("cursunpm_o");
			if (InFieldList("curmonpm_o")) curmonpm_o = reader.ReadInt("curmonpm_o");
			if (InFieldList("curtuepm_o")) curtuepm_o = reader.ReadInt("curtuepm_o");
			if (InFieldList("curwedpm_o")) curwedpm_o = reader.ReadInt("curwedpm_o");
			if (InFieldList("curthupm_o")) curthupm_o = reader.ReadInt("curthupm_o");
			if (InFieldList("curfripm_o")) curfripm_o = reader.ReadInt("curfripm_o");
			if (InFieldList("cursatpm_o")) cursatpm_o = reader.ReadInt("cursatpm_o");
			if (InFieldList("preinfpd_o")) preinfpd_o = reader.ReadInt("preinfpd_o");
			if (InFieldList("preinfpq_o")) preinfpq_o = reader.ReadInt("preinfpq_o");
			if (InFieldList("preinfpm_o")) preinfpm_o = reader.ReadInt("preinfpm_o");
			if (InFieldList("curinfpd_o")) curinfpd_o = reader.ReadInt("curinfpd_o");
			if (InFieldList("curinfpq_o")) curinfpq_o = reader.ReadInt("curinfpq_o");
			if (InFieldList("curinfpm_o")) curinfpm_o = reader.ReadInt("curinfpm_o");
			if (InFieldList("presfix_o")) presfix_o = reader.ReadInt("presfix_o");
			if (InFieldList("cursfix_o")) cursfix_o = reader.ReadInt("cursfix_o");
			if (InFieldList("presunsd_o")) presunsd_o = reader.ReadInt("presunsd_o");
			if (InFieldList("premonsd_o")) premonsd_o = reader.ReadInt("premonsd_o");
			if (InFieldList("pretuesd_o")) pretuesd_o = reader.ReadInt("pretuesd_o");
			if (InFieldList("prewedsd_o")) prewedsd_o = reader.ReadInt("prewedsd_o");
			if (InFieldList("prethusd_o")) prethusd_o = reader.ReadInt("prethusd_o");
			if (InFieldList("prefrisd_o")) prefrisd_o = reader.ReadInt("prefrisd_o");
			if (InFieldList("presatsd_o")) presatsd_o = reader.ReadInt("presatsd_o");
			if (InFieldList("cursunsd_o")) cursunsd_o = reader.ReadInt("cursunsd_o");
			if (InFieldList("curmonsd_o")) curmonsd_o = reader.ReadInt("curmonsd_o");
			if (InFieldList("curtuesd_o")) curtuesd_o = reader.ReadInt("curtuesd_o");
			if (InFieldList("curwedsd_o")) curwedsd_o = reader.ReadInt("curwedsd_o");
			if (InFieldList("curthusd_o")) curthusd_o = reader.ReadInt("curthusd_o");
			if (InFieldList("curfrisd_o")) curfrisd_o = reader.ReadInt("curfrisd_o");
			if (InFieldList("cursatsd_o")) cursatsd_o = reader.ReadInt("cursatsd_o");
			if (InFieldList("cursd_o")) cursd_o = reader.ReadInt("cursd_o");
			if (InFieldList("cursc_o")) cursc_o = reader.ReadInt("cursc_o");
			if (InFieldList("presd_o")) presd_o = reader.ReadInt("presd_o");
			if (InFieldList("presc_o")) presc_o = reader.ReadInt("presc_o");
			if (InFieldList("pre_rts")) pre_rts = reader.ReadInt("pre_rts");
			if (InFieldList("cur_rts")) cur_rts = reader.ReadInt("cur_rts");
			if (InFieldList("pre_rtsq")) pre_rtsq = reader.ReadInt("pre_rtsq");
			if (InFieldList("cur_rtsq")) cur_rtsq = reader.ReadInt("cur_rtsq");
			if (InFieldList("pre_rtsr")) pre_rtsr = reader.ReadInt("pre_rtsr");
			if (InFieldList("pre_rtsrq")) pre_rtsrq = reader.ReadInt("pre_rtsrq");
			if (InFieldList("cur_rtsr")) cur_rtsr = reader.ReadInt("cur_rtsr");
			if (InFieldList("cur_rtsrq")) cur_rtsrq = reader.ReadInt("cur_rtsrq");
			if (InFieldList("presunsq_o")) presunsq_o = reader.ReadInt("presunsq_o");
			if (InFieldList("premonsq_o")) premonsq_o = reader.ReadInt("premonsq_o");
			if (InFieldList("pretuesq_o")) pretuesq_o = reader.ReadInt("pretuesq_o");
			if (InFieldList("prewedsq_o")) prewedsq_o = reader.ReadInt("prewedsq_o");
			if (InFieldList("prethusq_o")) prethusq_o = reader.ReadInt("prethusq_o");
			if (InFieldList("prefrisq_o")) prefrisq_o = reader.ReadInt("prefrisq_o");
			if (InFieldList("presatsq_o")) presatsq_o = reader.ReadInt("presatsq_o");
			if (InFieldList("cursunsq_o")) cursunsq_o = reader.ReadInt("cursunsq_o");
			if (InFieldList("curmonsq_o")) curmonsq_o = reader.ReadInt("curmonsq_o");
			if (InFieldList("curtuesq_o")) curtuesq_o = reader.ReadInt("curtuesq_o");
			if (InFieldList("curwedsq_o")) curwedsq_o = reader.ReadInt("curwedsq_o");
			if (InFieldList("curthusq_o")) curthusq_o = reader.ReadInt("curthusq_o");
			if (InFieldList("curfrisq_o")) curfrisq_o = reader.ReadInt("curfrisq_o");
			if (InFieldList("cursatsq_o")) cursatsq_o = reader.ReadInt("cursatsq_o");
			if (InFieldList("preosd_o")) preosd_o = reader.ReadInt("preosd_o");
			if (InFieldList("curosd_o")) curosd_o = reader.ReadInt("curosd_o");
			MakeClean();
		}

	}

}
