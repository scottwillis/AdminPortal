import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
	selector: 'app-stats-component',
	templateUrl: './stats.component.html',
	styleUrls: ['./stats.component.css']
})

export class StatsComponent {

	mis: Bs_Mis;
	dos: Bs_Do[];
	do: Bs_Do;
	bls: Bs_Bl[];
	bl: Bs_Bl;
	toggleable = true;

	isDo = true;
	isBl = false;

	isCurrent = true;
	isPrevious = false;

	isWilliams = true;
	isInfinity = false;
	isOutdoor = false;
	isCombined = false;

	date1 = new Date();
	date2 = new Date();
	date3 = new Date();
	date4 = new Date();
	date5 = new Date();
	date6 = new Date();
	date7 = new Date();

	constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
		this.date1 = this.getNextDayOfWeek(new Date(), 6);
		this.date2 = new Date(this.date2.setDate(this.date1.getDate() + 7));
		this.date3 = new Date(this.date3.setDate(this.date2.getDate() + 7));
		this.date4 = new Date(this.date4.setDate(this.date3.getDate() + 7));
		this.date5 = new Date(this.date5.setDate(this.date4.getDate() + 7));
		this.date6 = new Date(this.date6.setDate(this.date5.getDate() + 7));
		this.date7 = new Date(this.date7.setDate(this.date6.getDate() + 7));
		http.get<Bs_Mis>(baseUrl + 'data/GetMis').subscribe(result => {
			this.mis = result;
		}, error => console.error(error));
		http.get<Bs_Do[]>(baseUrl + 'data/GetDo').subscribe(result => {
			this.dos = result;
			this.do = this.dos[0];
		}, error => console.error(error));
		http.get<Bs_Bl[]>(baseUrl + 'data/GetBl').subscribe(result => {
			this.bls = result;
			this.bl = this.bls[0];
		}, error => console.error(error));
	}

	SwitchToCurrent() {
		this.isCurrent = true;
		this.isPrevious = false;
	}

	SwitchToPrevious() {
		this.isCurrent = false;
		this.isPrevious = true;
	}

	SwitchToWilliams() {
		this.isWilliams = true;
		this.isInfinity = false;
		this.isOutdoor = false;
		this.isCombined = false;
		if (this.isDo) {
			this.do = this.dos[0];
		} else {
			this.bl = this.bls[0];
		}
	}

	SwitchToInfinity() {
		this.isWilliams = false;
		this.isInfinity = true;
		this.isOutdoor = false;
		this.isCombined = false;
		if (this.isDo) {
			this.do = this.dos[1];
		} else {
			this.bl = this.bls[1];
		}
	}

	SwitchToOutdoor() {
		this.isWilliams = false;
		this.isInfinity = false;
		this.isOutdoor = true;
		this.isCombined = false;
		if (this.isDo) {
			this.do = this.dos[2];
		} else {
			this.bl = this.bls[2];
		}
	}

	SwitchToCombined() {
		this.isWilliams = false;
		this.isInfinity = false;
		this.isOutdoor = false;
		this.isCombined = true;
		if (this.isDo) {
			this.do = this.dos[3];
		} else {
			this.bl = this.bls[3];
		}
	}

	SwitchToDo() {
		this.isDo = true;
		this.isBl = false;
	}

	SwitchToBl() {
		this.isDo = false;
		this.isBl = true;
	}

	getNextDayOfWeek(date: Date, dayOfWeek: number): Date {
		let resultDate = new Date(date.getTime());
		resultDate.setDate(date.getDate() + (7 + dayOfWeek - date.getDay()) % 7);
		return resultDate;
	}

}

interface Bs_Do {
	preqfix: number;
	curqfix: number;
	preofix: number;
	curofix: number;
	prepfix: number;
	curpfix: number;
	presfix: number;
	cursfix: number;

	presunqd: number;
	premonqd: number;
	pretueqd: number;
	prewedqd: number;
	prethuqd: number;
	prefriqd: number;
	presatqd: number;
	pretotqd: number;
	cursunqd: number;
	curmonqd: number;
	curtueqd: number;
	curwedqd: number;
	curthuqd: number;
	curfriqd: number;
	cursatqd: number;
	curtotqd: number;

	presunod: number;
	premonod: number;
	pretueod: number;
	prewedod: number;
	prethuod: number;
	prefriod: number;
	presatod: number;
	pretotod: number;
	cursunod: number;
	curmonod: number;
	curtueod: number;
	curwedod: number;
	curthuod: number;
	curfriod: number;
	cursatod: number;
	curtotod: number;

	presunpd: number;
	premonpd: number;
	pretuepd: number;
	prewedpd: number;
	prethupd: number;
	prefripd: number;
	presatpd: number;
	pretotpd: number;
	cursunpd: number;
	curmonpd: number;
	curtuepd: number;
	curwedpd: number;
	curthupd: number;
	curfripd: number;
	cursatpd: number;
	curtotpd: number;

	presunpq: number;
	premonpq: number;
	pretuepq: number;
	prewedpq: number;
	prethupq: number;
	prefripq: number;
	presatpq: number;
	pretotpq: number;
	cursunpq: number;
	curmonpq: number;
	curtuepq: number;
	curwedpq: number;
	curthupq: number;
	curfripq: number;
	cursatpq: number;
	curtotpq: number;

	presunpm: number;
	premonpm: number;
	pretuepm: number;
	prewedpm: number;
	prethupm: number;
	prefripm: number;
	presatpm: number;
	pretotpm: number;
	cursunpm: number;
	curmonpm: number;
	curtuepm: number;
	curwedpm: number;
	curthupm: number;
	curfripm: number;
	cursatpm: number;
	curtotpm: number;

	presunsd: number;
	premonsd: number;
	pretuesd: number;
	prewedsd: number;
	prethusd: number;
	prefrisd: number;
	presatsd: number;
	pretotsd: number;
	cursunsd: number;
	curmonsd: number;
	curtuesd: number;
	curwedsd: number;
	curthusd: number;
	curfrisd: number;
	cursatsd: number;
	curtotsd: number;

	presunsq: number;
	premonsq: number;
	pretuesq: number;
	prewedsq: number;
	prethusq: number;
	prefrisq: number;
	presatsq: number;
	pretotsq: number;
	cursunsq: number;
	curmonsq: number;
	curtuesq: number;
	curwedsq: number;
	curthusq: number;
	curfrisq: number;
	cursatsq: number;
	curtotsq: number;

	preinfpd: number;
	curinfpd: number;
	preinfpq: number;
	curinfpq: number;
	preinfpm: number;
	curinfpm: number;

	presd: number;
	cursd: number;
	presc: number;
	cursc: number;
	preosd: number;
	curosd: number;

	pre_rts: number;
	cur_rts: number;
	pre_rtsq: number;
	cur_rtsq: number;
	pre_rtsr: number;
	cur_rtsr: number;
	pre_rtsrq: number;
	cur_rtsrq: number;
}

interface Bs_Bl {
	bluqty: number;
	bludol: number;
	blupqty: number;
	blupdol: number;
	blumin: number;
	bluvcdol: number;

	blpqty: number;
	blpdol: number;
	blppqty: number;
	blppdol: number;
	blpmin: number;
	blpvcdol: number;

	blcqty: number;
	blcdol: number;
	blcpqty: number;
	blcpdol: number;
	blcmin: number;
	blcvcdol: number;

	bl1qty: number;
	bl1dol: number;
	bl1pqty: number;
	bl1pdol: number;
	bl1min: number;
	bl1vcdol: number;

	bl2qty: number;
	bl2dol: number;
	bl2pqty: number;
	bl2pdol: number;
	bl2min: number;
	bl2vcdol: number;

	bl3qty: number;
	bl3dol: number;
	bl3pqty: number;
	bl3pdol: number;
	bl3min: number;
	bl3vcdol: number;

	bl4qty: number;
	bl4dol: number;
	bl4pqty: number;
	bl4pdol: number;
	bl4min: number;
	bl4vcdol: number;

	bl5qty: number;
	bl5dol: number;
	bl5pqty: number;
	bl5pdol: number;
	bl5min: number;
	bl5vcdol: number;

	bl6qty: number;
	bl6dol: number;
	bl6pqty: number;
	bl6pdol: number;
	bl6min: number;
	bl6vcdol: number;

	blfqty: number;
	blfdol: number;
	blfpqty: number;
	blfpdol: number;
	blfmin: number;
	blfvcdol: number;

	blcstfl: number;
	bltot: number;
	bldol: number;
	blcst: number;
	blvcdol: number;

	bltqty: number;
	bltdol: number;
	//bltpqty: number;
	//bltpdol: number;
	//bltmin: number;
	//bltvcdol: number;

}

interface Bs_Mis {
	calcdate?: Date;
	calctime: string;
	calcend: string;
	me_cur?: Date;
	me_las?: Date;
	me_pre?: Date;
	me_start?: Date;
	pre_sun?: Date;
	pre_mon?: Date;
	pre_tue?: Date;
	pre_wed?: Date;
	pre_thu?: Date;
	pre_fri?: Date;
	pre_sat?: Date;
	cur_sun?: Date;
	cur_mon?: Date;
	cur_tue?: Date;
	cur_wed?: Date;
	cur_thu?: Date;
	cur_fri?: Date;
	cur_sat?: Date;
	ho_l60_cnt: number;
	ho_l60_fix: number;
	ho_l60_dol: number;
	ho_g60_cnt: number;
	ho_g60_fix: number;
	ho_g60_dol: number;
	inv_r_dol: number;
	inv_r_cnt: number;
	inv_w_dol: number;
	inv_w_cnt: number;
	inv_f_dol: number;
	inv_f_cnt: number;
	inv_q_dol: number;
	inv_q_cnt: number;
	invs_r_dol: number;
	invs_r_cnt: number;
	invs_w_dol: number;
	invs_w_cnt: number;
	invs_f_dol: number;
	invs_f_cnt: number;
	invs_q_dol: number;
	invs_q_cnt: number;
	ar_fut: number;
	ar_cur: number;
	ar_30: number;
	ar_bey: number;
	ar_fut_cnt: number;
	ar_cur_cnt: number;
	ar_30_cnt: number;
	ar_bey_cnt: number;
	q_cur_cnt: number;
	q_cur_fix: number;
	q_cur_dol: number;
	q_las_cnt: number;
	q_las_fix: number;
	q_las_dol: number;
	q_pre_cnt: number;
	q_pre_fix: number;
	q_pre_dol: number;
	o_cur_cnt: number;
	o_cur_fix: number;
	o_cur_dol: number;
	o_las_cnt: number;
	o_las_fix: number;
	o_las_dol: number;
	o_pre_cnt: number;
	o_pre_fix: number;
	o_pre_dol: number;
	q_pen_cnt: number;
	q_pen_fix: number;
	q_pen_dol: number;
	q_ukn_cnt: number;
	q_ukn_fix: number;
	q_ukn_dol: number;
	unres_cnt: number;
	unres_dol: number;
	rga_cnt: number;
	rga_dol: number;
	stat6dol_w: number;
	stat6dol_i: number;
	stat6dol_o: number;
	cur_boq: number;
	pre_boq: number;
	tfrtcost: number;
}
