import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Bs_Mis } from '../models/bs-mis.model';
import { Bs_Do } from '../models/bs-do.model';
import { Bs_Bl } from '../models/bs-bl.model';

@Component({
	selector: 'app-stats-component',
	templateUrl: './stats.component.html',
	styleUrls: ['./stats.component.css']
})

export class StatsComponent {

	private _isDo = true;
	private _isBl = false;

	private _isCurrent = true;
	private _isPrevious = false;

	private _isWilliams = true;
	private _isInfinity = false;
	private _isOutdoor = false;
	private _isCombined = false;

	mis: Bs_Mis;
	dos: Bs_Do[];
	do: Bs_Do;
	bls: Bs_Bl[];
	bl: Bs_Bl;
	toggleable = true;

	date1 = new Date();
	date2 = new Date();
	date3 = new Date();
	date4 = new Date();
	date5 = new Date();
	date6 = new Date();
	date7 = new Date();

	constructor(public http: HttpClient, @Inject('BASE_URL') public baseUrl: string) {
		this.date1 = this.getNextDayOfWeek(new Date(), 6);
		this.date2 = new Date(this.date2.setDate(this.date1.getDate() + 7));
		this.date3 = new Date(this.date3.setDate(this.date2.getDate() + 7));
		this.date4 = new Date(this.date4.setDate(this.date3.getDate() + 7));
		this.date5 = new Date(this.date5.setDate(this.date4.getDate() + 7));
		this.date6 = new Date(this.date6.setDate(this.date5.getDate() + 7));
		this.date7 = new Date(this.date7.setDate(this.date6.getDate() + 7));
		this.loadData();
	}

	loadData() {
		this.do = null;
		this.bl = null;
		this.http.get<Bs_Mis>(this.baseUrl + 'data/GetMis').subscribe(result => {
			this.mis = result;
		}, error => console.error(error));
		this.http.get<Bs_Do[]>(this.baseUrl + 'data/GetDo').subscribe(result => {
			this.dos = result;
			this.do = this.dos[0];
		}, error => console.error(error));
		this.http.get<Bs_Bl[]>(this.baseUrl + 'data/GetBl').subscribe(result => {
			this.bls = result;
			this.bl = this.bls[0];
		}, error => console.error(error));
	}

	get isDo() {
		return this._isDo;
	}
	set isDo(value) {
		this._isDo = value;
		if (value) this._isBl = false;
	}

	get isBl() {
		return this._isBl;
	}
	set isBl(value) {
		this._isBl = value;
		if (value) this._isDo = false;
	}

	get isCurrent() {
		return this._isCurrent;
	}
	set isCurrent(value) {
		this._isCurrent = value;
		if (value) this._isPrevious = false;
	}

	get isPrevious() {
		return this._isPrevious;
	}
	set isPrevious(value) {
		this._isPrevious = value;
		if (value) this._isCurrent = false;
	}

	get isWilliams() {
		return this._isWilliams;
	}
	set isWilliams(value) {
		this._isWilliams = value;
		if (value) {
			this._isInfinity = false;
			this._isOutdoor = false;
			this._isCombined = false;
		}
	}

	get isInfinity() {
		return this._isInfinity;
	}
	set isInfinity(value) {
		this._isInfinity = value;
		if (value) {
			this._isWilliams = false;
			this._isOutdoor = false;
			this._isCombined = false;
		}
	}

	get isOutdoor() {
		return this._isOutdoor;
	}
	set isOutdoor(value) {
		this._isOutdoor = value;
		if (value) {
			this._isWilliams = false;
			this._isInfinity = false;
			this._isCombined = false;
		}
	}

	get isCombined() {
		return this._isCombined;
	}
	set isCombined(value) {
		this._isCombined = value;
		if (value) {
			this._isWilliams = false;
			this._isInfinity = false;
			this._isOutdoor = false;
		}
	}

	switchToDo() {
		this.isDo = true;
	}

	switchToBl() {
		this.isBl = true;
	}

	switchToCurrent() {
		this.isCurrent = true;
	}

	switchToPrevious() {
		this.isPrevious = true;
	}

	switchToWilliams() {
		this.isWilliams = true;
		if (this.isDo) {
			this.do = this.dos[0];
		} else {
			this.bl = this.bls[0];
		}
	}

	switchToInfinity() {
		this.isInfinity = true;
		if (this.isDo) {
			this.do = this.dos[1];
		} else {
			this.bl = this.bls[1];
		}
	}

	switchToOutdoor() {
		this.isOutdoor = true;
		if (this.isDo) {
			this.do = this.dos[2];
		} else {
			this.bl = this.bls[2];
		}
	}

	switchToCombined() {
		this.isCombined = true;
		if (this.isDo) {
			this.do = this.dos[3];
		} else {
			this.bl = this.bls[3];
		}
	}

	getNextDayOfWeek(date: Date, dayOfWeek: number): Date {
		let resultDate = new Date(date.getTime());
		resultDate.setDate(date.getDate() + (7 + dayOfWeek - date.getDay()) % 7);
		return resultDate;
	}

}
