import { Component, Inject, Input, Output, EventEmitter, ViewChild } from '@angular/core';
//import { Http, Response, Headers, RequestOptions, URLSearchParams } from '@angular/http';
import { HttpClient } from '@angular/common/http';

//import { fadeInOut } from '../../services/animations';

//import { GridDataResult, SelectionEvent } from '@progress/kendo-angular-grid';
//import { SortDescriptor, GroupDescriptor, State, process, orderBy, groupBy } from '@progress/kendo-data-query';

import { hord } from '../models/hord.model';

//import { GridBaseComponent } from '../base/grid/grid-base.component';

@Component({
	selector: 'orders',
	templateUrl: './orders.component.html',
	styleUrls: ['./orders.component.scss'],
	//animations: [fadeInOut]
})

export class OrdersComponent {

	//@Output() openTab: EventEmitter<hord> = new EventEmitter();

	entities: hord[];
	currentEntity: hord;

	endDate = new Date();
	startDate = new Date(new Date().getTime() - (3 * 1000 * 60 * 60 * 24));

	constructor(public http: HttpClient, @Inject('BASE_URL') public baseUrl: string) {
		this.loadData();
	}

	loadData() {
		this.http.get<hord[]>(this.baseUrl + 'data/GetAgencyOrders').subscribe(result => {
			this.entities = result;
		}, error => console.error(error));
	}

}
