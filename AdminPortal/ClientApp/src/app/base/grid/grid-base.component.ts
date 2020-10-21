import { Component, ViewChild, HostListener, OnInit, Inject, Input, Output, EventEmitter  } from '@angular/core';
//import { Http, Response, Headers, RequestOptions, URLSearchParams } from '@angular/http';
import { HttpClient } from '@angular/common/http';
import { FormGroup, FormControl, Validators } from '@angular/forms';

//import { Observable } from 'rxjs';
//import { Subscription } from 'rxjs';

import { GridComponent } from '@progress/kendo-angular-grid';
import { GroupDescriptor, SortDescriptor, State, process, orderBy, filterBy, groupBy, aggregateBy } from '@progress/kendo-data-query';
import { GridDataResult, SelectionEvent, AddEvent, EditEvent, SaveEvent, CancelEvent, RemoveEvent, PageChangeEvent, DataStateChangeEvent } from '@progress/kendo-angular-grid';

import { DeleteDialogComponent } from '../../usercontrols/deletedialog/deletedialog.component';

@Component({
  selector: 'grid-base',
  templateUrl: 'grid-base.component.html',
  styleUrls: ['grid-base.component.scss'],
})

export class GridBaseComponent {
  @ViewChild('grid', { static: false }) grid: GridComponent;
  @ViewChild('deleteDialog', { static: false }) deleteDialog: DeleteDialogComponent;

  http: HttpClient;
  headers: Headers;
  //options: RequestOptions;

  gridDataResult: GridDataResult;
  formGroup: FormGroup;

  screenHeight: any;
  screenWidth: any;

  loading = false;
  navigable = false;
  selectable = true;
  sortable = '{ mode: "multiple" }';
  sort: SortDescriptor[] = [{ dir: 'asc', field: 'id' }];
  groupable = false;
  group: GroupDescriptor[];
  filterable = false;
  scrollable = 'virtual';
  pageSize = 100;
  skip = 0;
  rowHeight = 35;
  minheight = 600;
  height = 600;

  entities: any[];
  currentEntity: any;
  editedRowIndex: number;
  inEdit = false;
  placeholder = '';
  deleteType = '';
  searchValue = '';
  recordCount = 0;

  constructor(http: HttpClient) {
    this.getScreenSize();
    this.http = http;
    this.headers = new Headers({ 'Content-Type': 'application/json', 'Accept': 'q=0.8;application/json;q=0.9' });
    this.init();
    //this.loadData();
  }

  @HostListener('window:resize', ['$event'])
  getScreenSize(event?) {
    this.screenHeight = window.innerHeight;
    this.screenWidth = window.innerWidth;
    this.height = this.screenHeight - 162;
  }

  @HostListener('window:keydown', ['$event'])
  keyboardInput(event: any) {
    let isHandled = false;
    if (this.inEdit) {
      if (event.code === 'Escape') {
        isHandled = true;
        this.cancel({ dataItem: this.currentEntity, formGroup: this.formGroup, sender: this.grid, rowIndex: this.editedRowIndex, isNew: false });
      }
      if (event.code === 'Enter' || event.code === 'NumpadEnter') {
        isHandled = true;
        this.save({ dataItem: this.currentEntity, formGroup: this.formGroup, sender: this.grid, rowIndex: this.editedRowIndex, isNew: false });
      }
    } else {
      if (event.code === 'Escape') {
        isHandled = true;
        this.reset();
      }
      if (event.code === 'Enter' || event.code === 'NumpadEnter') {
        isHandled = true;
        this.loadData();
      }
      //if (event.code === 'Insert' || event.code === 'PageUp') {
      //  isHandled = true;
      //  this.add({ dataItem: this.currentEntity, sender: this.grid, rowIndex: this.editedRowIndex, isNew: false });
      //}
      //if (event.code === 'Delete') {
      //  isHandled = true;
      //  this.verifyDelete();
      //}
      //if (event.code === 'F2') {
      //  isHandled = true;
      //  this.edit({ dataItem: this.currentEntity, sender: this.grid, rowIndex: this.editedRowIndex, isNew: false });
      //}
    }
    if (isHandled) {
      event.preventDefault();
      event.stopPropagation();
    }
  }

  init(): void {
  }

  loadData(): void {
  }

  reset(): void {
  }

  loadDataResult() {
    this.gridDataResult = {
      data: orderBy(
        this.entities.slice(this.skip, this.skip + this.pageSize),
        this.sort),
      total: this.entities.length
    };
    this.recordCount = this.entities.length;
    this.loading = false;
    this.minheight = 100;
    if (this.recordCount <= 0) this.height = 600;
  }

  onFilter() {
    this.filterable = !this.filterable;
  }

  onGroup() {
    this.groupable = !this.groupable;
  }

  onFilterableChange(e) {
    this.filterable = e;
  }

  onGroupableChange(e) {
    this.groupable = e;
  }

  selectionChange(event: SelectionEvent) {
    const ctrlKey = event.ctrlKey;
    const shiftKey = event.shiftKey;
    const deselectedRows = event.deselectedRows;
    const selectedRows = event.selectedRows;
    const index = event.selectedRows[0].index;
    //const selected = event.selected;
    if (index === this.editedRowIndex) {
      //event.selectedRows = event.deselectedRows;
      this.edit({ sender: this.grid, rowIndex: index, dataItem: this.currentEntity, isNew: false });
    } else {
      this.closeEditor(this.grid, this.editedRowIndex);
    }
    this.editedRowIndex = index;
    this.currentEntity = this.gridDataResult.data[index];
  }

  sortChange(sort: SortDescriptor[]): void {
    this.sort = sort;
    this.loadData();
  }

  groupChange(group: GroupDescriptor[]): void {
    this.group = group;
    this.loadData();
  }

  pageChange(event: PageChangeEvent): void {
    const skip = event.skip;
    const take = event.take;
    this.skip = skip;
    this.loadData();
  }

  dataStateChange(event: DataStateChangeEvent) {
    const filter = event.filter;
    const group = event.group;
    const skip = event.skip;
    const sort = event.sort;
    const take = event.take;
  }

  onAdd() {
  }

  add(event: AddEvent) {
    const dataItem = event.dataItem;
    const isNew = event.isNew;
    const rowIndex = event.rowIndex;
    const sender = event.sender;
    this.closeEditor(sender);
    this.editedRowIndex = -1;
    this.inEdit = true;
    this.createNewFormGroup();
    sender.addRow(this.formGroup);
  }

  createNewFormGroup() {
  }

  edit(event: EditEvent) {
    const dataItem = event.dataItem;
    const isNew = event.isNew;
    const rowIndex = event.rowIndex;
    const sender = event.sender;
    this.closeEditor(sender);
    if (dataItem !== undefined) {
      this.inEdit = true;
      this.createEditFormGroup(dataItem);
      this.editedRowIndex = rowIndex;
      sender.editRow(rowIndex, this.formGroup);
    }
  }

  createEditFormGroup(entity) {
  }

  cancel(event: CancelEvent) {
    const dataItem = event.dataItem;
    const formGroup = event.formGroup;
    const isNew = event.isNew;
    const rowIndex = event.rowIndex;
    const sender = event.sender;
    this.currentEntity = undefined;
    this.editedRowIndex = undefined;
    this.closeEditor(sender, rowIndex);
  }

  closeEditor(grid, rowIndex = this.editedRowIndex) {
    grid.closeRow(rowIndex);
    this.inEdit = false;
  }

  save(event: SaveEvent) {
    const dataItem = event.dataItem;
    const formGroup = event.formGroup;
    const isNew = event.isNew;
    const rowIndex = event.rowIndex;
    const sender = event.sender;
    if (!formGroup.invalid) {
      sender.closeRow(rowIndex);
      const entity = formGroup.value;
      if (entity.id === null) entity.id = 0;
      this.saveEntity(entity);
      this.inEdit = false;
    }
  }

  saveEntity(entity) {
  }

  remove(event: RemoveEvent) {
    const dataItem = event.dataItem;
    const isNew = event.isNew;
    const rowIndex = event.rowIndex;
    const sender = event.sender;
    if (dataItem !== undefined) {
      //this.repository.positionDelete(entity);
    }
  }

  verifyDelete() {
    if (!this.deleteDialog.deleteDialogOpened && this.editedRowIndex >= 0) {
      this.defineDeleteTypeName();
      this.deleteDialog.deleteDialogOpened = true;
    }
  }

  defineDeleteTypeName() {
    this.deleteDialog.deleteTypeName = this.currentEntity.Name;
  }

  dialogResponse(doit) {
    if (doit) {
      this.deleteEntity(this.currentEntity);
    }
  }

  deleteEntity(entity) {
  }

}
