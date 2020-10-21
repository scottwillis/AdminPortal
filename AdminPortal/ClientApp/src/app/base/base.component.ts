import { Component, Inject, Output, EventEmitter, ViewChild } from '@angular/core';
import { HttpClient } from '@angular/common/http';
//import { Http, Response, Headers, RequestOptions, URLSearchParams } from '@angular/http';

@Component({
    selector: 'base',
    templateUrl: './base.component.html',
    styleUrls: ['./base.component.scss'],
})

export class BaseComponent {
  headers: Headers;
  //options: RequestOptions;

  constructor(protected http: HttpClient) {
    this.headers = new Headers({ 'Content-Type': 'application/json', 'Accept': 'q=0.8;application/json;q=0.9' });
  }

}
