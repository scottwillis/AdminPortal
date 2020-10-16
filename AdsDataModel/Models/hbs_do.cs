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

	public class hbs_do : FoxProEntity {

		private int _preqfix;
		private int _curqfix;
		private int _preofix;
		private int _curofix;
		private int _prepfix;
		private int _curpfix;
		private int _presfix;
		private int _cursfix;

		private int _presunqd;
		private int _premonqd;
		private int _pretueqd;
		private int _prewedqd;
		private int _prethuqd;
		private int _prefriqd;
		private int _presatqd;
		private int _cursunqd;
		private int _curmonqd;
		private int _curtueqd;
		private int _curwedqd;
		private int _curthuqd;
		private int _curfriqd;
		private int _cursatqd;
		
		private int _presunod;
		private int _premonod;
		private int _pretueod;
		private int _prewedod;
		private int _prethuod;
		private int _prefriod;
		private int _presatod;
		private int _cursunod;
		private int _curmonod;
		private int _curtueod;
		private int _curwedod;
		private int _curthuod;
		private int _curfriod;
		private int _cursatod;
		
		private int _presunpd;
		private int _premonpd;
		private int _pretuepd;
		private int _prewedpd;
		private int _prethupd;
		private int _prefripd;
		private int _presatpd;
		private int _cursunpd;
		private int _curmonpd;
		private int _curtuepd;
		private int _curwedpd;
		private int _curthupd;
		private int _curfripd;
		private int _cursatpd;
		
		private int _presunpq;
		private int _premonpq;
		private int _pretuepq;
		private int _prewedpq;
		private int _prethupq;
		private int _prefripq;
		private int _presatpq;
		private int _cursunpq;
		private int _curmonpq;
		private int _curtuepq;
		private int _curwedpq;
		private int _curthupq;
		private int _curfripq;
		private int _cursatpq;
		
		private int _presunpm;
		private int _premonpm;
		private int _pretuepm;
		private int _prewedpm;
		private int _prethupm;
		private int _prefripm;
		private int _presatpm;
		private int _cursunpm;
		private int _curmonpm;
		private int _curtuepm;
		private int _curwedpm;
		private int _curthupm;
		private int _curfripm;
		private int _cursatpm;
		
		private int _presunsd;
		private int _premonsd;
		private int _pretuesd;
		private int _prewedsd;
		private int _prethusd;
		private int _prefrisd;
		private int _presatsd;
		private int _cursunsd;
		private int _curmonsd;
		private int _curtuesd;
		private int _curwedsd;
		private int _curthusd;
		private int _curfrisd;
		private int _cursatsd;

		private int _presunsq;
		private int _premonsq;
		private int _pretuesq;
		private int _prewedsq;
		private int _prethusq;
		private int _prefrisq;
		private int _presatsq;
		private int _cursunsq;
		private int _curmonsq;
		private int _curtuesq;
		private int _curwedsq;
		private int _curthusq;
		private int _curfrisq;
		private int _cursatsq;

		private int _preinfpd;
		private int _curinfpd;
		private int _preinfpq;
		private int _curinfpq;
		private int _preinfpm;
		private int _curinfpm;

		private int _presd;
		private int _cursd;
		private int _presc;
		private int _cursc;
		private int _preosd;
		private int _curosd;

		private int _pre_rts;
		private int _cur_rts;
		private int _pre_rtsq;
		private int _cur_rtsq;
		private int _pre_rtsr;
		private int _cur_rtsr;
		private int _pre_rtsrq;
		private int _cur_rtsrq;
		
		public int preqfix { get => _preqfix; set => SetProperty(ref _preqfix, value); }

		public int curqfix { get => _curqfix; set => SetProperty(ref _curqfix, value); }

		public int preofix { get => _preofix; set => SetProperty(ref _preofix, value); }

		public int curofix { get => _curofix; set => SetProperty(ref _curofix, value); }

		public int prepfix { get => _prepfix; set => SetProperty(ref _prepfix, value); }

		public int curpfix { get => _curpfix; set => SetProperty(ref _curpfix, value); }

		public int presfix { get => _presfix; set => SetProperty(ref _presfix, value); }

		public int cursfix { get => _cursfix; set => SetProperty(ref _cursfix, value); }


		public int presunqd { get => _presunqd; set => SetProperty(ref _presunqd, value); }

		public int premonqd { get => _premonqd; set => SetProperty(ref _premonqd, value); }

		public int pretueqd { get => _pretueqd; set => SetProperty(ref _pretueqd, value); }

		public int prewedqd { get => _prewedqd; set => SetProperty(ref _prewedqd, value); }

		public int prethuqd { get => _prethuqd; set => SetProperty(ref _prethuqd, value); }

		public int prefriqd { get => _prefriqd; set => SetProperty(ref _prefriqd, value); }

		public int presatqd { get => _presatqd; set => SetProperty(ref _presatqd, value); }

		public int pretotqd => presunqd + premonqd + pretueqd + prewedqd + prethuqd + prefriqd + presatqd;


		public int cursunqd { get => _cursunqd; set => SetProperty(ref _cursunqd, value); }

		public int curmonqd { get => _curmonqd; set => SetProperty(ref _curmonqd, value); }

		public int curtueqd { get => _curtueqd; set => SetProperty(ref _curtueqd, value); }

		public int curwedqd { get => _curwedqd; set => SetProperty(ref _curwedqd, value); }

		public int curthuqd { get => _curthuqd; set => SetProperty(ref _curthuqd, value); }

		public int curfriqd { get => _curfriqd; set => SetProperty(ref _curfriqd, value); }

		public int cursatqd { get => _cursatqd; set => SetProperty(ref _cursatqd, value); }

		public int curtotqd => cursunqd + curmonqd + curtueqd + curwedqd + curthuqd + curfriqd + cursatqd;

	
		public int presunod { get => _presunod; set => SetProperty(ref _presunod, value); }

		public int premonod { get => _premonod; set => SetProperty(ref _premonod, value); }

		public int pretueod { get => _pretueod; set => SetProperty(ref _pretueod, value); }

		public int prewedod { get => _prewedod; set => SetProperty(ref _prewedod, value); }

		public int prethuod { get => _prethuod; set => SetProperty(ref _prethuod, value); }

		public int prefriod { get => _prefriod; set => SetProperty(ref _prefriod, value); }

		public int presatod { get => _presatod; set => SetProperty(ref _presatod, value); }

		public int pretotod => presunod + premonod + pretueod + prewedod + prethuod + prefriod + presatod;

		
		public int cursunod { get => _cursunod; set => SetProperty(ref _cursunod, value); }

		public int curmonod { get => _curmonod; set => SetProperty(ref _curmonod, value); }

		public int curtueod { get => _curtueod; set => SetProperty(ref _curtueod, value); }

		public int curwedod { get => _curwedod; set => SetProperty(ref _curwedod, value); }

		public int curthuod { get => _curthuod; set => SetProperty(ref _curthuod, value); }

		public int curfriod { get => _curfriod; set => SetProperty(ref _curfriod, value); }

		public int cursatod { get => _cursatod; set => SetProperty(ref _cursatod, value); }

		public int curtotod => cursunod + curmonod + curtueod + curwedod + curthuod + curfriod + cursatod;

		
		public int presunpd { get => _presunpd; set => SetProperty(ref _presunpd, value); }

		public int premonpd { get => _premonpd; set => SetProperty(ref _premonpd, value); }

		public int pretuepd { get => _pretuepd; set => SetProperty(ref _pretuepd, value); }

		public int prewedpd { get => _prewedpd; set => SetProperty(ref _prewedpd, value); }

		public int prethupd { get => _prethupd; set => SetProperty(ref _prethupd, value); }

		public int prefripd { get => _prefripd; set => SetProperty(ref _prefripd, value); }

		public int presatpd { get => _presatpd; set => SetProperty(ref _presatpd, value); }

		public int pretotpd => presunpd + premonpd + pretuepd + prewedpd + prethupd + prefripd + presatpd;


		public int cursunpd { get => _cursunpd; set => SetProperty(ref _cursunpd, value); }

		public int curmonpd { get => _curmonpd; set => SetProperty(ref _curmonpd, value); }

		public int curtuepd { get => _curtuepd; set => SetProperty(ref _curtuepd, value); }

		public int curwedpd { get => _curwedpd; set => SetProperty(ref _curwedpd, value); }

		public int curthupd { get => _curthupd; set => SetProperty(ref _curthupd, value); }

		public int curfripd { get => _curfripd; set => SetProperty(ref _curfripd, value); }

		public int cursatpd { get => _cursatpd; set => SetProperty(ref _cursatpd, value); }

		public int curtotpd => cursunpd + curmonpd + curtuepd + curwedpd + curthupd + curfripd + cursatpd;


		public int presunpq { get => _presunpq; set => SetProperty(ref _presunpq, value); }

		public int premonpq { get => _premonpq; set => SetProperty(ref _premonpq, value); }

		public int pretuepq { get => _pretuepq; set => SetProperty(ref _pretuepq, value); }

		public int prewedpq { get => _prewedpq; set => SetProperty(ref _prewedpq, value); }

		public int prethupq { get => _prethupq; set => SetProperty(ref _prethupq, value); }

		public int prefripq { get => _prefripq; set => SetProperty(ref _prefripq, value); }

		public int presatpq { get => _presatpq; set => SetProperty(ref _presatpq, value); }

		public int pretotpq => presunpq + premonpq + pretuepq + prewedpq + prethupq + prefripq + presatpq;


		public int cursunpq { get => _cursunpq; set => SetProperty(ref _cursunpq, value); }

		public int curmonpq { get => _curmonpq; set => SetProperty(ref _curmonpq, value); }

		public int curtuepq { get => _curtuepq; set => SetProperty(ref _curtuepq, value); }

		public int curwedpq { get => _curwedpq; set => SetProperty(ref _curwedpq, value); }

		public int curthupq { get => _curthupq; set => SetProperty(ref _curthupq, value); }

		public int curfripq { get => _curfripq; set => SetProperty(ref _curfripq, value); }

		public int cursatpq { get => _cursatpq; set => SetProperty(ref _cursatpq, value); }

		public int curtotpq => cursunpq + curmonpq + curtuepq + curwedpq + curthupq + curfripq + cursatpq;


		public int presunpm { get => _presunpm; set => SetProperty(ref _presunpm, value); }

		public int premonpm { get => _premonpm; set => SetProperty(ref _premonpm, value); }

		public int pretuepm { get => _pretuepm; set => SetProperty(ref _pretuepm, value); }

		public int prewedpm { get => _prewedpm; set => SetProperty(ref _prewedpm, value); }

		public int prethupm { get => _prethupm; set => SetProperty(ref _prethupm, value); }

		public int prefripm { get => _prefripm; set => SetProperty(ref _prefripm, value); }

		public int presatpm { get => _presatpm; set => SetProperty(ref _presatpm, value); }

		public int pretotpm => presunpm + premonpm + pretuepm + prewedpm + prethupm + prefripm + presatpm;


		public int cursunpm { get => _cursunpm; set => SetProperty(ref _cursunpm, value); }

		public int curmonpm { get => _curmonpm; set => SetProperty(ref _curmonpm, value); }

		public int curtuepm { get => _curtuepm; set => SetProperty(ref _curtuepm, value); }

		public int curwedpm { get => _curwedpm; set => SetProperty(ref _curwedpm, value); }

		public int curthupm { get => _curthupm; set => SetProperty(ref _curthupm, value); }

		public int curfripm { get => _curfripm; set => SetProperty(ref _curfripm, value); }

		public int cursatpm { get => _cursatpm; set => SetProperty(ref _cursatpm, value); }

		public int curtotpm => cursunpm + curmonpm + curtuepm + curwedpm + curthupm + curfripm + cursatpm;


		public int presunsd { get => _presunsd; set => SetProperty(ref _presunsd, value); }

		public int premonsd { get => _premonsd; set => SetProperty(ref _premonsd, value); }

		public int pretuesd { get => _pretuesd; set => SetProperty(ref _pretuesd, value); }

		public int prewedsd { get => _prewedsd; set => SetProperty(ref _prewedsd, value); }

		public int prethusd { get => _prethusd; set => SetProperty(ref _prethusd, value); }

		public int prefrisd { get => _prefrisd; set => SetProperty(ref _prefrisd, value); }

		public int presatsd { get => _presatsd; set => SetProperty(ref _presatsd, value); }

		public int pretotsd => presunsd + premonsd + pretuesd + prewedsd + prethusd + prefrisd + presatsd;


		public int cursunsd { get => _cursunsd; set => SetProperty(ref _cursunsd, value); }

		public int curmonsd { get => _curmonsd; set => SetProperty(ref _curmonsd, value); }

		public int curtuesd { get => _curtuesd; set => SetProperty(ref _curtuesd, value); }

		public int curwedsd { get => _curwedsd; set => SetProperty(ref _curwedsd, value); }

		public int curthusd { get => _curthusd; set => SetProperty(ref _curthusd, value); }

		public int curfrisd { get => _curfrisd; set => SetProperty(ref _curfrisd, value); }

		public int cursatsd { get => _cursatsd; set => SetProperty(ref _cursatsd, value); }

		public int curtotsd => cursunsd + curmonsd + curtuesd + curwedsd + curthusd + curfrisd + cursatsd;


		public int presunsq { get => _presunsq; set => SetProperty(ref _presunsq, value); }

		public int premonsq { get => _premonsq; set => SetProperty(ref _premonsq, value); }

		public int pretuesq { get => _pretuesq; set => SetProperty(ref _pretuesq, value); }

		public int prewedsq { get => _prewedsq; set => SetProperty(ref _prewedsq, value); }

		public int prethusq { get => _prethusq; set => SetProperty(ref _prethusq, value); }

		public int prefrisq { get => _prefrisq; set => SetProperty(ref _prefrisq, value); }

		public int presatsq { get => _presatsq; set => SetProperty(ref _presatsq, value); }

		public int pretotsq => presunsq + premonsq + pretuesq + prewedsq + prethusq + prefrisq + presatsq;


		public int cursunsq { get => _cursunsq; set => SetProperty(ref _cursunsq, value); }

		public int curmonsq { get => _curmonsq; set => SetProperty(ref _curmonsq, value); }

		public int curtuesq { get => _curtuesq; set => SetProperty(ref _curtuesq, value); }

		public int curwedsq { get => _curwedsq; set => SetProperty(ref _curwedsq, value); }

		public int curthusq { get => _curthusq; set => SetProperty(ref _curthusq, value); }

		public int curfrisq { get => _curfrisq; set => SetProperty(ref _curfrisq, value); }

		public int cursatsq { get => _cursatsq; set => SetProperty(ref _cursatsq, value); }

		public int curtotsq => cursunsq + curmonsq + curtuesq + curwedsq + curthusq + curfrisq + cursatsq;


		public int preinfpd { get => _preinfpd; set => SetProperty(ref _preinfpd, value); }

		public int preinfpq { get => _preinfpq; set => SetProperty(ref _preinfpq, value); }

		public int preinfpm { get => _preinfpm; set => SetProperty(ref _preinfpm, value); }

		public int curinfpd { get => _curinfpd; set => SetProperty(ref _curinfpd, value); }

		public int curinfpq { get => _curinfpq; set => SetProperty(ref _curinfpq, value); }

		public int curinfpm { get => _curinfpm; set => SetProperty(ref _curinfpm, value); }


		public int presd { get => _presd; set => SetProperty(ref _presd, value); }

		public int cursd { get => _cursd; set => SetProperty(ref _cursd, value); }

		public int presc { get => _presc; set => SetProperty(ref _presc, value); }

		public int cursc { get => _cursc; set => SetProperty(ref _cursc, value); }

		public int preosd { get => _preosd; set => SetProperty(ref _preosd, value); }

		public int curosd { get => _curosd; set => SetProperty(ref _curosd, value); }


		public int pre_rts { get => _pre_rts; set => SetProperty(ref _pre_rts, value); }

		public int cur_rts { get => _cur_rts; set => SetProperty(ref _cur_rts, value); }

		public int pre_rtsq { get => _pre_rtsq; set => SetProperty(ref _pre_rtsq, value); }

		public int cur_rtsq { get => _cur_rtsq; set => SetProperty(ref _cur_rtsq, value); }

		public int pre_rtsr { get => _pre_rtsr; set => SetProperty(ref _pre_rtsr, value); }

		public int cur_rtsr { get => _cur_rtsr; set => SetProperty(ref _cur_rtsr, value); }

		public int pre_rtsrq { get => _pre_rtsrq; set => SetProperty(ref _pre_rtsrq, value); }

		public int cur_rtsrq { get => _cur_rtsrq; set => SetProperty(ref _cur_rtsrq, value); }


		[MyCustom(AdsIgnore = true)]
		public sealed override string Key { get; set; }

		[MyCustom(AdsIgnore = true)]
		public sealed override object[] KeyValue => new object[] { };

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("preqfix_w")) preqfix = reader.ReadInt("preqfix_w");
			if (InFieldList("curqfix_w")) curqfix = reader.ReadInt("curqfix_w");
			if (InFieldList("preofix_w")) preofix = reader.ReadInt("preofix_w");
			if (InFieldList("curofix_w")) curofix = reader.ReadInt("curofix_w");
			if (InFieldList("prepfix_w")) prepfix = reader.ReadInt("prepfix_w");
			if (InFieldList("curpfix_w")) curpfix = reader.ReadInt("curpfix_w");
			if (InFieldList("presfix_w")) presfix = reader.ReadInt("presfix_w");
			if (InFieldList("cursfix_w")) cursfix = reader.ReadInt("cursfix_w");
			if (InFieldList("presunqd_w")) presunqd = reader.ReadInt("presunqd_w");
			if (InFieldList("premonqd_w")) premonqd = reader.ReadInt("premonqd_w");
			if (InFieldList("pretueqd_w")) pretueqd = reader.ReadInt("pretueqd_w");
			if (InFieldList("prewedqd_w")) prewedqd = reader.ReadInt("prewedqd_w");
			if (InFieldList("prethuqd_w")) prethuqd = reader.ReadInt("prethuqd_w");
			if (InFieldList("prefriqd_w")) prefriqd = reader.ReadInt("prefriqd_w");
			if (InFieldList("presatqd_w")) presatqd = reader.ReadInt("presatqd_w");
			if (InFieldList("cursunqd_w")) cursunqd = reader.ReadInt("cursunqd_w");
			if (InFieldList("curmonqd_w")) curmonqd = reader.ReadInt("curmonqd_w");
			if (InFieldList("curtueqd_w")) curtueqd = reader.ReadInt("curtueqd_w");
			if (InFieldList("curwedqd_w")) curwedqd = reader.ReadInt("curwedqd_w");
			if (InFieldList("curthuqd_w")) curthuqd = reader.ReadInt("curthuqd_w");
			if (InFieldList("curfriqd_w")) curfriqd = reader.ReadInt("curfriqd_w");
			if (InFieldList("cursatqd_w")) cursatqd = reader.ReadInt("cursatqd_w");
			if (InFieldList("presunod_w")) presunod = reader.ReadInt("presunod_w");
			if (InFieldList("premonod_w")) premonod = reader.ReadInt("premonod_w");
			if (InFieldList("pretueod_w")) pretueod = reader.ReadInt("pretueod_w");
			if (InFieldList("prewedod_w")) prewedod = reader.ReadInt("prewedod_w");
			if (InFieldList("prethuod_w")) prethuod = reader.ReadInt("prethuod_w");
			if (InFieldList("prefriod_w")) prefriod = reader.ReadInt("prefriod_w");
			if (InFieldList("presatod_w")) presatod = reader.ReadInt("presatod_w");
			if (InFieldList("cursunod_w")) cursunod = reader.ReadInt("cursunod_w");
			if (InFieldList("curmonod_w")) curmonod = reader.ReadInt("curmonod_w");
			if (InFieldList("curtueod_w")) curtueod = reader.ReadInt("curtueod_w");
			if (InFieldList("curwedod_w")) curwedod = reader.ReadInt("curwedod_w");
			if (InFieldList("curthuod_w")) curthuod = reader.ReadInt("curthuod_w");
			if (InFieldList("curfriod_w")) curfriod = reader.ReadInt("curfriod_w");
			if (InFieldList("cursatod_w")) cursatod = reader.ReadInt("cursatod_w");
			if (InFieldList("presunpd_w")) presunpd = reader.ReadInt("presunpd_w");
			if (InFieldList("premonpd_w")) premonpd = reader.ReadInt("premonpd_w");
			if (InFieldList("pretuepd_w")) pretuepd = reader.ReadInt("pretuepd_w");
			if (InFieldList("prewedpd_w")) prewedpd = reader.ReadInt("prewedpd_w");
			if (InFieldList("prethupd_w")) prethupd = reader.ReadInt("prethupd_w");
			if (InFieldList("prefripd_w")) prefripd = reader.ReadInt("prefripd_w");
			if (InFieldList("presatpd_w")) presatpd = reader.ReadInt("presatpd_w");
			if (InFieldList("cursunpd_w")) cursunpd = reader.ReadInt("cursunpd_w");
			if (InFieldList("curmonpd_w")) curmonpd = reader.ReadInt("curmonpd_w");
			if (InFieldList("curtuepd_w")) curtuepd = reader.ReadInt("curtuepd_w");
			if (InFieldList("curwedpd_w")) curwedpd = reader.ReadInt("curwedpd_w");
			if (InFieldList("curthupd_w")) curthupd = reader.ReadInt("curthupd_w");
			if (InFieldList("curfripd_w")) curfripd = reader.ReadInt("curfripd_w");
			if (InFieldList("cursatpd_w")) cursatpd = reader.ReadInt("cursatpd_w");
			if (InFieldList("presunpq_w")) presunpq = reader.ReadInt("presunpq_w");
			if (InFieldList("premonpq_w")) premonpq = reader.ReadInt("premonpq_w");
			if (InFieldList("pretuepq_w")) pretuepq = reader.ReadInt("pretuepq_w");
			if (InFieldList("prewedpq_w")) prewedpq = reader.ReadInt("prewedpq_w");
			if (InFieldList("prethupq_w")) prethupq = reader.ReadInt("prethupq_w");
			if (InFieldList("prefripq_w")) prefripq = reader.ReadInt("prefripq_w");
			if (InFieldList("presatpq_w")) presatpq = reader.ReadInt("presatpq_w");
			if (InFieldList("cursunpq_w")) cursunpq = reader.ReadInt("cursunpq_w");
			if (InFieldList("curmonpq_w")) curmonpq = reader.ReadInt("curmonpq_w");
			if (InFieldList("curtuepq_w")) curtuepq = reader.ReadInt("curtuepq_w");
			if (InFieldList("curwedpq_w")) curwedpq = reader.ReadInt("curwedpq_w");
			if (InFieldList("curthupq_w")) curthupq = reader.ReadInt("curthupq_w");
			if (InFieldList("curfripq_w")) curfripq = reader.ReadInt("curfripq_w");
			if (InFieldList("cursatpq_w")) cursatpq = reader.ReadInt("cursatpq_w");
			if (InFieldList("presunpm_w")) presunpm = reader.ReadInt("presunpm_w");
			if (InFieldList("premonpm_w")) premonpm = reader.ReadInt("premonpm_w");
			if (InFieldList("pretuepm_w")) pretuepm = reader.ReadInt("pretuepm_w");
			if (InFieldList("prewedpm_w")) prewedpm = reader.ReadInt("prewedpm_w");
			if (InFieldList("prethupm_w")) prethupm = reader.ReadInt("prethupm_w");
			if (InFieldList("prefripm_w")) prefripm = reader.ReadInt("prefripm_w");
			if (InFieldList("presatpm_w")) presatpm = reader.ReadInt("presatpm_w");
			if (InFieldList("cursunpm_w")) cursunpm = reader.ReadInt("cursunpm_w");
			if (InFieldList("curmonpm_w")) curmonpm = reader.ReadInt("curmonpm_w");
			if (InFieldList("curtuepm_w")) curtuepm = reader.ReadInt("curtuepm_w");
			if (InFieldList("curwedpm_w")) curwedpm = reader.ReadInt("curwedpm_w");
			if (InFieldList("curthupm_w")) curthupm = reader.ReadInt("curthupm_w");
			if (InFieldList("curfripm_w")) curfripm = reader.ReadInt("curfripm_w");
			if (InFieldList("cursatpm_w")) cursatpm = reader.ReadInt("cursatpm_w");
			if (InFieldList("preinfpd_w")) preinfpd = reader.ReadInt("preinfpd_w");
			if (InFieldList("preinfpq_w")) preinfpq = reader.ReadInt("preinfpq_w");
			if (InFieldList("preinfpm_w")) preinfpm = reader.ReadInt("preinfpm_w");
			if (InFieldList("curinfpd_w")) curinfpd = reader.ReadInt("curinfpd_w");
			if (InFieldList("curinfpq_w")) curinfpq = reader.ReadInt("curinfpq_w");
			if (InFieldList("curinfpm_w")) curinfpm = reader.ReadInt("curinfpm_w");
			if (InFieldList("presunsd_w")) presunsd = reader.ReadInt("presunsd_w");
			if (InFieldList("premonsd_w")) premonsd = reader.ReadInt("premonsd_w");
			if (InFieldList("pretuesd_w")) pretuesd = reader.ReadInt("pretuesd_w");
			if (InFieldList("prewedsd_w")) prewedsd = reader.ReadInt("prewedsd_w");
			if (InFieldList("prethusd_w")) prethusd = reader.ReadInt("prethusd_w");
			if (InFieldList("prefrisd_w")) prefrisd = reader.ReadInt("prefrisd_w");
			if (InFieldList("presatsd_w")) presatsd = reader.ReadInt("presatsd_w");
			if (InFieldList("cursunsd_w")) cursunsd = reader.ReadInt("cursunsd_w");
			if (InFieldList("curmonsd_w")) curmonsd = reader.ReadInt("curmonsd_w");
			if (InFieldList("curtuesd_w")) curtuesd = reader.ReadInt("curtuesd_w");
			if (InFieldList("curwedsd_w")) curwedsd = reader.ReadInt("curwedsd_w");
			if (InFieldList("curthusd_w")) curthusd = reader.ReadInt("curthusd_w");
			if (InFieldList("curfrisd_w")) curfrisd = reader.ReadInt("curfrisd_w");
			if (InFieldList("cursatsd_w")) cursatsd = reader.ReadInt("cursatsd_w");
			if (InFieldList("presunsq_w")) presunsq = reader.ReadInt("presunsq_w");
			if (InFieldList("premonsq_w")) premonsq = reader.ReadInt("premonsq_w");
			if (InFieldList("pretuesq_w")) pretuesq = reader.ReadInt("pretuesq_w");
			if (InFieldList("prewedsq_w")) prewedsq = reader.ReadInt("prewedsq_w");
			if (InFieldList("prethusq_w")) prethusq = reader.ReadInt("prethusq_w");
			if (InFieldList("prefrisq_w")) prefrisq = reader.ReadInt("prefrisq_w");
			if (InFieldList("presatsq_w")) presatsq = reader.ReadInt("presatsq_w");
			if (InFieldList("cursunsq_w")) cursunsq = reader.ReadInt("cursunsq_w");
			if (InFieldList("curmonsq_w")) curmonsq = reader.ReadInt("curmonsq_w");
			if (InFieldList("curtuesq_w")) curtuesq = reader.ReadInt("curtuesq_w");
			if (InFieldList("curwedsq_w")) curwedsq = reader.ReadInt("curwedsq_w");
			if (InFieldList("curthusq_w")) curthusq = reader.ReadInt("curthusq_w");
			if (InFieldList("curfrisq_w")) curfrisq = reader.ReadInt("curfrisq_w");
			if (InFieldList("cursatsq_w")) cursatsq = reader.ReadInt("cursatsq_w");
			if (InFieldList("presd_w")) presd = reader.ReadInt("presd_w");
			if (InFieldList("cursd_w")) cursd = reader.ReadInt("cursd_w");
			if (InFieldList("presc_w")) presc = reader.ReadInt("presc_w");
			if (InFieldList("cursc_w")) cursc = reader.ReadInt("cursc_w");
			if (InFieldList("preosd_w")) preosd = reader.ReadInt("preosd_w");
			if (InFieldList("curosd_w")) curosd = reader.ReadInt("curosd_w");
			if (InFieldList("pre_rts")) pre_rts = reader.ReadInt("pre_rts");
			if (InFieldList("cur_rts")) cur_rts = reader.ReadInt("cur_rts");
			if (InFieldList("pre_rtsq")) pre_rtsq = reader.ReadInt("pre_rtsq");
			if (InFieldList("cur_rtsq")) cur_rtsq = reader.ReadInt("cur_rtsq");
			if (InFieldList("pre_rtsr")) pre_rtsr = reader.ReadInt("pre_rtsr");
			if (InFieldList("pre_rtsrq")) pre_rtsrq = reader.ReadInt("pre_rtsrq");
			if (InFieldList("cur_rtsr")) cur_rtsr = reader.ReadInt("cur_rtsr");
			if (InFieldList("cur_rtsrq")) cur_rtsrq = reader.ReadInt("cur_rtsrq");
			MakeClean();
		}

	}

	public class hbs_do_w : hbs_do {

	}

	public class hbs_do_o : hbs_do {

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("preqfix_o")) preqfix = reader.ReadInt("preqfix_o");
			if (InFieldList("curqfix_o")) curqfix = reader.ReadInt("curqfix_o");
			if (InFieldList("preofix_o")) preofix = reader.ReadInt("preofix_o");
			if (InFieldList("curofix_o")) curofix = reader.ReadInt("curofix_o");
			if (InFieldList("prepfix_o")) prepfix = reader.ReadInt("prepfix_o");
			if (InFieldList("curpfix_o")) curpfix = reader.ReadInt("curpfix_o");
			if (InFieldList("presfix_o")) presfix = reader.ReadInt("presfix_o");
			if (InFieldList("cursfix_o")) cursfix = reader.ReadInt("cursfix_o");
			if (InFieldList("presunod_o")) presunod = reader.ReadInt("presunod_o");
			if (InFieldList("premonod_o")) premonod = reader.ReadInt("premonod_o");
			if (InFieldList("pretueod_o")) pretueod = reader.ReadInt("pretueod_o");
			if (InFieldList("prewedod_o")) prewedod = reader.ReadInt("prewedod_o");
			if (InFieldList("prethuod_o")) prethuod = reader.ReadInt("prethuod_o");
			if (InFieldList("prefriod_o")) prefriod = reader.ReadInt("prefriod_o");
			if (InFieldList("presatod_o")) presatod = reader.ReadInt("presatod_o");
			if (InFieldList("cursunod_o")) cursunod = reader.ReadInt("cursunod_o");
			if (InFieldList("curmonod_o")) curmonod = reader.ReadInt("curmonod_o");
			if (InFieldList("curtueod_o")) curtueod = reader.ReadInt("curtueod_o");
			if (InFieldList("curwedod_o")) curwedod = reader.ReadInt("curwedod_o");
			if (InFieldList("curthuod_o")) curthuod = reader.ReadInt("curthuod_o");
			if (InFieldList("curfriod_o")) curfriod = reader.ReadInt("curfriod_o");
			if (InFieldList("cursatod_o")) cursatod = reader.ReadInt("cursatod_o");
			if (InFieldList("presunpd_o")) presunpd = reader.ReadInt("presunpd_o");
			if (InFieldList("premonpd_o")) premonpd = reader.ReadInt("premonpd_o");
			if (InFieldList("pretuepd_o")) pretuepd = reader.ReadInt("pretuepd_o");
			if (InFieldList("prewedpd_o")) prewedpd = reader.ReadInt("prewedpd_o");
			if (InFieldList("prethupd_o")) prethupd = reader.ReadInt("prethupd_o");
			if (InFieldList("prefripd_o")) prefripd = reader.ReadInt("prefripd_o");
			if (InFieldList("presatpd_o")) presatpd = reader.ReadInt("presatpd_o");
			if (InFieldList("cursunpd_o")) cursunpd = reader.ReadInt("cursunpd_o");
			if (InFieldList("curmonpd_o")) curmonpd = reader.ReadInt("curmonpd_o");
			if (InFieldList("curtuepd_o")) curtuepd = reader.ReadInt("curtuepd_o");
			if (InFieldList("curwedpd_o")) curwedpd = reader.ReadInt("curwedpd_o");
			if (InFieldList("curthupd_o")) curthupd = reader.ReadInt("curthupd_o");
			if (InFieldList("curfripd_o")) curfripd = reader.ReadInt("curfripd_o");
			if (InFieldList("cursatpd_o")) cursatpd = reader.ReadInt("cursatpd_o");
			if (InFieldList("presunpq_o")) presunpq = reader.ReadInt("presunpq_o");
			if (InFieldList("premonpq_o")) premonpq = reader.ReadInt("premonpq_o");
			if (InFieldList("pretuepq_o")) pretuepq = reader.ReadInt("pretuepq_o");
			if (InFieldList("prewedpq_o")) prewedpq = reader.ReadInt("prewedpq_o");
			if (InFieldList("prethupq_o")) prethupq = reader.ReadInt("prethupq_o");
			if (InFieldList("prefripq_o")) prefripq = reader.ReadInt("prefripq_o");
			if (InFieldList("presatpq_o")) presatpq = reader.ReadInt("presatpq_o");
			if (InFieldList("cursunpq_o")) cursunpq = reader.ReadInt("cursunpq_o");
			if (InFieldList("curmonpq_o")) curmonpq = reader.ReadInt("curmonpq_o");
			if (InFieldList("curtuepq_o")) curtuepq = reader.ReadInt("curtuepq_o");
			if (InFieldList("curwedpq_o")) curwedpq = reader.ReadInt("curwedpq_o");
			if (InFieldList("curthupq_o")) curthupq = reader.ReadInt("curthupq_o");
			if (InFieldList("curfripq_o")) curfripq = reader.ReadInt("curfripq_o");
			if (InFieldList("cursatpq_o")) cursatpq = reader.ReadInt("cursatpq_o");
			if (InFieldList("presunpm_o")) presunpm = reader.ReadInt("presunpm_o");
			if (InFieldList("premonpm_o")) premonpm = reader.ReadInt("premonpm_o");
			if (InFieldList("pretuepm_o")) pretuepm = reader.ReadInt("pretuepm_o");
			if (InFieldList("prewedpm_o")) prewedpm = reader.ReadInt("prewedpm_o");
			if (InFieldList("prethupm_o")) prethupm = reader.ReadInt("prethupm_o");
			if (InFieldList("prefripm_o")) prefripm = reader.ReadInt("prefripm_o");
			if (InFieldList("presatpm_o")) presatpm = reader.ReadInt("presatpm_o");
			if (InFieldList("cursunpm_o")) cursunpm = reader.ReadInt("cursunpm_o");
			if (InFieldList("curmonpm_o")) curmonpm = reader.ReadInt("curmonpm_o");
			if (InFieldList("curtuepm_o")) curtuepm = reader.ReadInt("curtuepm_o");
			if (InFieldList("curwedpm_o")) curwedpm = reader.ReadInt("curwedpm_o");
			if (InFieldList("curthupm_o")) curthupm = reader.ReadInt("curthupm_o");
			if (InFieldList("curfripm_o")) curfripm = reader.ReadInt("curfripm_o");
			if (InFieldList("cursatpm_o")) cursatpm = reader.ReadInt("cursatpm_o");
			if (InFieldList("preinfpd_o")) preinfpd = reader.ReadInt("preinfpd_o");
			if (InFieldList("preinfpq_o")) preinfpq = reader.ReadInt("preinfpq_o");
			if (InFieldList("preinfpm_o")) preinfpm = reader.ReadInt("preinfpm_o");
			if (InFieldList("curinfpd_o")) curinfpd = reader.ReadInt("curinfpd_o");
			if (InFieldList("curinfpq_o")) curinfpq = reader.ReadInt("curinfpq_o");
			if (InFieldList("curinfpm_o")) curinfpm = reader.ReadInt("curinfpm_o");
			if (InFieldList("presunsd_o")) presunsd = reader.ReadInt("presunsd_o");
			if (InFieldList("premonsd_o")) premonsd = reader.ReadInt("premonsd_o");
			if (InFieldList("pretuesd_o")) pretuesd = reader.ReadInt("pretuesd_o");
			if (InFieldList("prewedsd_o")) prewedsd = reader.ReadInt("prewedsd_o");
			if (InFieldList("prethusd_o")) prethusd = reader.ReadInt("prethusd_o");
			if (InFieldList("prefrisd_o")) prefrisd = reader.ReadInt("prefrisd_o");
			if (InFieldList("presatsd_o")) presatsd = reader.ReadInt("presatsd_o");
			if (InFieldList("cursunsd_o")) cursunsd = reader.ReadInt("cursunsd_o");
			if (InFieldList("curmonsd_o")) curmonsd = reader.ReadInt("curmonsd_o");
			if (InFieldList("curtuesd_o")) curtuesd = reader.ReadInt("curtuesd_o");
			if (InFieldList("curwedsd_o")) curwedsd = reader.ReadInt("curwedsd_o");
			if (InFieldList("curthusd_o")) curthusd = reader.ReadInt("curthusd_o");
			if (InFieldList("curfrisd_o")) curfrisd = reader.ReadInt("curfrisd_o");
			if (InFieldList("cursatsd_o")) cursatsd = reader.ReadInt("cursatsd_o");
			if (InFieldList("presunsq_o")) presunsq = reader.ReadInt("presunsq_o");
			if (InFieldList("premonsq_o")) premonsq = reader.ReadInt("premonsq_o");
			if (InFieldList("pretuesq_o")) pretuesq = reader.ReadInt("pretuesq_o");
			if (InFieldList("prewedsq_o")) prewedsq = reader.ReadInt("prewedsq_o");
			if (InFieldList("prethusq_o")) prethusq = reader.ReadInt("prethusq_o");
			if (InFieldList("prefrisq_o")) prefrisq = reader.ReadInt("prefrisq_o");
			if (InFieldList("presatsq_o")) presatsq = reader.ReadInt("presatsq_o");
			if (InFieldList("cursunsq_o")) cursunsq = reader.ReadInt("cursunsq_o");
			if (InFieldList("curmonsq_o")) curmonsq = reader.ReadInt("curmonsq_o");
			if (InFieldList("curtuesq_o")) curtuesq = reader.ReadInt("curtuesq_o");
			if (InFieldList("curwedsq_o")) curwedsq = reader.ReadInt("curwedsq_o");
			if (InFieldList("curthusq_o")) curthusq = reader.ReadInt("curthusq_o");
			if (InFieldList("curfrisq_o")) curfrisq = reader.ReadInt("curfrisq_o");
			if (InFieldList("cursatsq_o")) cursatsq = reader.ReadInt("cursatsq_o");
			if (InFieldList("presd_o")) presd = reader.ReadInt("presd_o");
			if (InFieldList("cursd_o")) cursd = reader.ReadInt("cursd_o");
			if (InFieldList("presc_o")) presc = reader.ReadInt("presc_o");
			if (InFieldList("cursc_o")) cursc = reader.ReadInt("cursc_o");
			if (InFieldList("preosd_o")) preosd = reader.ReadInt("preosd_o");
			if (InFieldList("curosd_o")) curosd = reader.ReadInt("curosd_o");
			if (InFieldList("pre_rts")) pre_rts = reader.ReadInt("pre_rts");
			if (InFieldList("cur_rts")) cur_rts = reader.ReadInt("cur_rts");
			if (InFieldList("pre_rtsq")) pre_rtsq = reader.ReadInt("pre_rtsq");
			if (InFieldList("cur_rtsq")) cur_rtsq = reader.ReadInt("cur_rtsq");
			if (InFieldList("pre_rtsr")) pre_rtsr = reader.ReadInt("pre_rtsr");
			if (InFieldList("pre_rtsrq")) pre_rtsrq = reader.ReadInt("pre_rtsrq");
			if (InFieldList("cur_rtsr")) cur_rtsr = reader.ReadInt("cur_rtsr");
			if (InFieldList("cur_rtsrq")) cur_rtsrq = reader.ReadInt("cur_rtsrq");
			MakeClean();
		}

	}

	public class hbs_do_i : hbs_do {

		public override void FillFromReader(AdsDataReader reader) {
			if (InFieldList("preqfix_i")) preqfix = reader.ReadInt("preqfix_i");
			if (InFieldList("curqfix_i")) curqfix = reader.ReadInt("curqfix_i");
			if (InFieldList("preofix_i")) preofix = reader.ReadInt("preofix_i");
			if (InFieldList("curofix_i")) curofix = reader.ReadInt("curofix_i");
			if (InFieldList("prepfix_i")) prepfix = reader.ReadInt("prepfix_i");
			if (InFieldList("curpfix_i")) curpfix = reader.ReadInt("curpfix_i");
			if (InFieldList("presfix_i")) presfix = reader.ReadInt("presfix_i");
			if (InFieldList("cursfix_i")) cursfix = reader.ReadInt("cursfix_i");
			if (InFieldList("presunqd_i")) presunqd = reader.ReadInt("presunqd_i");
			if (InFieldList("premonqd_i")) premonqd = reader.ReadInt("premonqd_i");
			if (InFieldList("pretueqd_i")) pretueqd = reader.ReadInt("pretueqd_i");
			if (InFieldList("prewedqd_i")) prewedqd = reader.ReadInt("prewedqd_i");
			if (InFieldList("prethuqd_i")) prethuqd = reader.ReadInt("prethuqd_i");
			if (InFieldList("prefriqd_i")) prefriqd = reader.ReadInt("prefriqd_i");
			if (InFieldList("presatqd_i")) presatqd = reader.ReadInt("presatqd_i");
			if (InFieldList("cursunqd_i")) cursunqd = reader.ReadInt("cursunqd_i");
			if (InFieldList("curmonqd_i")) curmonqd = reader.ReadInt("curmonqd_i");
			if (InFieldList("curtueqd_i")) curtueqd = reader.ReadInt("curtueqd_i");
			if (InFieldList("curwedqd_i")) curwedqd = reader.ReadInt("curwedqd_i");
			if (InFieldList("curthuqd_i")) curthuqd = reader.ReadInt("curthuqd_i");
			if (InFieldList("curfriqd_i")) curfriqd = reader.ReadInt("curfriqd_i");
			if (InFieldList("cursatqd_i")) cursatqd = reader.ReadInt("cursatqd_i");
			if (InFieldList("presunod_i")) presunod = reader.ReadInt("presunod_i");
			if (InFieldList("premonod_i")) premonod = reader.ReadInt("premonod_i");
			if (InFieldList("pretueod_i")) pretueod = reader.ReadInt("pretueod_i");
			if (InFieldList("prewedod_i")) prewedod = reader.ReadInt("prewedod_i");
			if (InFieldList("prethuod_i")) prethuod = reader.ReadInt("prethuod_i");
			if (InFieldList("prefriod_i")) prefriod = reader.ReadInt("prefriod_i");
			if (InFieldList("presatod_i")) presatod = reader.ReadInt("presatod_i");
			if (InFieldList("cursunod_i")) cursunod = reader.ReadInt("cursunod_i");
			if (InFieldList("curmonod_i")) curmonod = reader.ReadInt("curmonod_i");
			if (InFieldList("curtueod_i")) curtueod = reader.ReadInt("curtueod_i");
			if (InFieldList("curwedod_i")) curwedod = reader.ReadInt("curwedod_i");
			if (InFieldList("curthuod_i")) curthuod = reader.ReadInt("curthuod_i");
			if (InFieldList("curfriod_i")) curfriod = reader.ReadInt("curfriod_i");
			if (InFieldList("cursatod_i")) cursatod = reader.ReadInt("cursatod_i");
			if (InFieldList("presunpd_i")) presunpd = reader.ReadInt("presunpd_i");
			if (InFieldList("premonpd_i")) premonpd = reader.ReadInt("premonpd_i");
			if (InFieldList("pretuepd_i")) pretuepd = reader.ReadInt("pretuepd_i");
			if (InFieldList("prewedpd_i")) prewedpd = reader.ReadInt("prewedpd_i");
			if (InFieldList("prethupd_i")) prethupd = reader.ReadInt("prethupd_i");
			if (InFieldList("prefripd_i")) prefripd = reader.ReadInt("prefripd_i");
			if (InFieldList("presatpd_i")) presatpd = reader.ReadInt("presatpd_i");
			if (InFieldList("cursunpd_i")) cursunpd = reader.ReadInt("cursunpd_i");
			if (InFieldList("curmonpd_i")) curmonpd = reader.ReadInt("curmonpd_i");
			if (InFieldList("curtuepd_i")) curtuepd = reader.ReadInt("curtuepd_i");
			if (InFieldList("curwedpd_i")) curwedpd = reader.ReadInt("curwedpd_i");
			if (InFieldList("curthupd_i")) curthupd = reader.ReadInt("curthupd_i");
			if (InFieldList("curfripd_i")) curfripd = reader.ReadInt("curfripd_i");
			if (InFieldList("cursatpd_i")) cursatpd = reader.ReadInt("cursatpd_i");
			if (InFieldList("presunpq_i")) presunpq = reader.ReadInt("presunpq_i");
			if (InFieldList("premonpq_i")) premonpq = reader.ReadInt("premonpq_i");
			if (InFieldList("pretuepq_i")) pretuepq = reader.ReadInt("pretuepq_i");
			if (InFieldList("prewedpq_i")) prewedpq = reader.ReadInt("prewedpq_i");
			if (InFieldList("prethupq_i")) prethupq = reader.ReadInt("prethupq_i");
			if (InFieldList("prefripq_i")) prefripq = reader.ReadInt("prefripq_i");
			if (InFieldList("presatpq_i")) presatpq = reader.ReadInt("presatpq_i");
			if (InFieldList("cursunpq_i")) cursunpq = reader.ReadInt("cursunpq_i");
			if (InFieldList("curmonpq_i")) curmonpq = reader.ReadInt("curmonpq_i");
			if (InFieldList("curtuepq_i")) curtuepq = reader.ReadInt("curtuepq_i");
			if (InFieldList("curwedpq_i")) curwedpq = reader.ReadInt("curwedpq_i");
			if (InFieldList("curthupq_i")) curthupq = reader.ReadInt("curthupq_i");
			if (InFieldList("curfripq_i")) curfripq = reader.ReadInt("curfripq_i");
			if (InFieldList("cursatpq_i")) cursatpq = reader.ReadInt("cursatpq_i");
			if (InFieldList("presunpm_i")) presunpm = reader.ReadInt("presunpm_i");
			if (InFieldList("premonpm_i")) premonpm = reader.ReadInt("premonpm_i");
			if (InFieldList("pretuepm_i")) pretuepm = reader.ReadInt("pretuepm_i");
			if (InFieldList("prewedpm_i")) prewedpm = reader.ReadInt("prewedpm_i");
			if (InFieldList("prethupm_i")) prethupm = reader.ReadInt("prethupm_i");
			if (InFieldList("prefripm_i")) prefripm = reader.ReadInt("prefripm_i");
			if (InFieldList("presatpm_i")) presatpm = reader.ReadInt("presatpm_i");
			if (InFieldList("cursunpm_i")) cursunpm = reader.ReadInt("cursunpm_i");
			if (InFieldList("curmonpm_i")) curmonpm = reader.ReadInt("curmonpm_i");
			if (InFieldList("curtuepm_i")) curtuepm = reader.ReadInt("curtuepm_i");
			if (InFieldList("curwedpm_i")) curwedpm = reader.ReadInt("curwedpm_i");
			if (InFieldList("curthupm_i")) curthupm = reader.ReadInt("curthupm_i");
			if (InFieldList("curfripm_i")) curfripm = reader.ReadInt("curfripm_i");
			if (InFieldList("cursatpm_i")) cursatpm = reader.ReadInt("cursatpm_i");
			if (InFieldList("preinfpd_i")) preinfpd = reader.ReadInt("preinfpd_i");
			if (InFieldList("preinfpq_i")) preinfpq = reader.ReadInt("preinfpq_i");
			if (InFieldList("preinfpm_i")) preinfpm = reader.ReadInt("preinfpm_i");
			if (InFieldList("curinfpd_i")) curinfpd = reader.ReadInt("curinfpd_i");
			if (InFieldList("curinfpq_i")) curinfpq = reader.ReadInt("curinfpq_i");
			if (InFieldList("curinfpm_i")) curinfpm = reader.ReadInt("curinfpm_i");
			if (InFieldList("presunsd_i")) presunsd = reader.ReadInt("presunsd_i");
			if (InFieldList("premonsd_i")) premonsd = reader.ReadInt("premonsd_i");
			if (InFieldList("pretuesd_i")) pretuesd = reader.ReadInt("pretuesd_i");
			if (InFieldList("prewedsd_i")) prewedsd = reader.ReadInt("prewedsd_i");
			if (InFieldList("prethusd_i")) prethusd = reader.ReadInt("prethusd_i");
			if (InFieldList("prefrisd_i")) prefrisd = reader.ReadInt("prefrisd_i");
			if (InFieldList("presatsd_i")) presatsd = reader.ReadInt("presatsd_i");
			if (InFieldList("cursunsd_i")) cursunsd = reader.ReadInt("cursunsd_i");
			if (InFieldList("curmonsd_i")) curmonsd = reader.ReadInt("curmonsd_i");
			if (InFieldList("curtuesd_i")) curtuesd = reader.ReadInt("curtuesd_i");
			if (InFieldList("curwedsd_i")) curwedsd = reader.ReadInt("curwedsd_i");
			if (InFieldList("curthusd_i")) curthusd = reader.ReadInt("curthusd_i");
			if (InFieldList("curfrisd_i")) curfrisd = reader.ReadInt("curfrisd_i");
			if (InFieldList("cursatsd_i")) cursatsd = reader.ReadInt("cursatsd_i");
			if (InFieldList("presunsq_i")) presunsq = reader.ReadInt("presunsq_i");
			if (InFieldList("premonsq_i")) premonsq = reader.ReadInt("premonsq_i");
			if (InFieldList("pretuesq_i")) pretuesq = reader.ReadInt("pretuesq_i");
			if (InFieldList("prewedsq_i")) prewedsq = reader.ReadInt("prewedsq_i");
			if (InFieldList("prethusq_i")) prethusq = reader.ReadInt("prethusq_i");
			if (InFieldList("prefrisq_i")) prefrisq = reader.ReadInt("prefrisq_i");
			if (InFieldList("presatsq_i")) presatsq = reader.ReadInt("presatsq_i");
			if (InFieldList("cursunsq_i")) cursunsq = reader.ReadInt("cursunsq_i");
			if (InFieldList("curmonsq_i")) curmonsq = reader.ReadInt("curmonsq_i");
			if (InFieldList("curtuesq_i")) curtuesq = reader.ReadInt("curtuesq_i");
			if (InFieldList("curwedsq_i")) curwedsq = reader.ReadInt("curwedsq_i");
			if (InFieldList("curthusq_i")) curthusq = reader.ReadInt("curthusq_i");
			if (InFieldList("curfrisq_i")) curfrisq = reader.ReadInt("curfrisq_i");
			if (InFieldList("cursatsq_i")) cursatsq = reader.ReadInt("cursatsq_i");
			if (InFieldList("presd_i")) presd = reader.ReadInt("presd_i");
			if (InFieldList("cursd_i")) cursd = reader.ReadInt("cursd_i");
			if (InFieldList("presc_i")) presc = reader.ReadInt("presc_i");
			if (InFieldList("cursc_i")) cursc = reader.ReadInt("cursc_i");
			if (InFieldList("preosd_i")) preosd = reader.ReadInt("preosd_i");
			if (InFieldList("curosd_i")) curosd = reader.ReadInt("curosd_i");
			if (InFieldList("pre_rts")) pre_rts = reader.ReadInt("pre_rts");
			if (InFieldList("cur_rts")) cur_rts = reader.ReadInt("cur_rts");
			if (InFieldList("pre_rtsq")) pre_rtsq = reader.ReadInt("pre_rtsq");
			if (InFieldList("cur_rtsq")) cur_rtsq = reader.ReadInt("cur_rtsq");
			if (InFieldList("pre_rtsr")) pre_rtsr = reader.ReadInt("pre_rtsr");
			if (InFieldList("pre_rtsrq")) pre_rtsrq = reader.ReadInt("pre_rtsrq");
			if (InFieldList("cur_rtsr")) cur_rtsr = reader.ReadInt("cur_rtsr");
			if (InFieldList("cur_rtsrq")) cur_rtsrq = reader.ReadInt("cur_rtsrq");
			MakeClean();
		}

	}

	public partial class FoxProDataContext {

		public hbs_do_w GetBs_Do_W() {
			var qTime = DateTime.Now;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hbs_do_w";
			var reader = cmd.ExecuteExtendedReader();
			reader.Read();
			var entity = new hbs_do_w();
			entity.FillFromReader(reader);
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetBs_Do_W");
			return entity;
		}

		public hbs_do_o GetBs_Do_O() {
			var qTime = DateTime.Now;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hbs_do_o";
			var reader = cmd.ExecuteExtendedReader();
			reader.Read();
			var entity = new hbs_do_o();
			entity.FillFromReader(reader);
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetBs_Do_O");
			return entity;
		}

		public hbs_do_i GetBs_Do_I() {
			var qTime = DateTime.Now;
			Conn.Open();
			var cmd = Conn.CreateCommand();
			cmd.CommandType = CommandType.TableDirect;
			cmd.CommandText = "hbs_do_i";
			var reader = cmd.ExecuteExtendedReader();
			reader.Read();
			var entity = new hbs_do_i();
			entity.FillFromReader(reader);
			reader.Close();
			Conn.Close();
			QueryDebugEnd(qTime, $"GetBs_Do_I");
			return entity;
		}

	}

}
