import { Component, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'delete-dialog',
  templateUrl: './deletedialog.component.html',
  styleUrls: [ './deletedialog.component.scss' ]
})

export class DeleteDialogComponent {
  @Input() deleteType = '';
  @Output() dialogResponse = new EventEmitter<boolean>();

  deleteDialogOpened = false;
  deleteTypeName = '';

  closeDeleteDialog(status) {
    this.deleteDialogOpened = false;
    this.dialogResponse.emit(status === 'yes');
  }

}
