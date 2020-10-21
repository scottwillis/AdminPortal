import { Component, Input, TemplateRef, ViewChild, ElementRef, forwardRef } from '@angular/core';
import { ToolBarToolComponent } from '@progress/kendo-angular-toolbar';

export function outerWidth(element: any): number {
  let width = element.offsetWidth;
  const style = getComputedStyle(element);
  width += (parseFloat(style.marginLeft) || 0 + parseFloat(style.marginRight) || 0);
  return width;
}

@Component({
  providers: [{ provide: ToolBarToolComponent, useExisting: forwardRef(() => SearchInputComponent) }],
  selector: 'search-input',
  templateUrl: './searchinput.component.html',
  styleUrls: ['./searchinput.component.css']
})

export class SearchInputComponent extends ToolBarToolComponent {
  @Input() text: string;
  @Input() what: string;
  @Input() searchValue: string;

  @ViewChild('toolbarTemplate', { static: true }) toolbarTemplate: TemplateRef<any>;
  @ViewChild('toolbarElement', { static: true }) toolbarElement: ElementRef;

  get outerWidth(): number {
    if (this.toolbarElement) {
      return 400; //outerWidth(this.toolbarElement.nativeElement);
    }
    return 400;
  }

}
