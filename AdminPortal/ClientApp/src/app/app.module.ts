import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { ButtonsModule } from '@progress/kendo-angular-buttons';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ChartsModule } from '@progress/kendo-angular-charts';
import { ChatModule } from '@progress/kendo-angular-conversational-ui';
import { DateInputsModule } from '@progress/kendo-angular-dateinputs';
import { DialogsModule } from '@progress/kendo-angular-dialog';
import { DropDownsModule } from '@progress/kendo-angular-dropdowns';
import { EditorModule } from '@progress/kendo-angular-editor';
import { ExcelExportModule } from '@progress/kendo-angular-excel-export';
import { GaugesModule } from '@progress/kendo-angular-gauges';
import { GridModule } from '@progress/kendo-angular-grid';
import { IconsModule } from '@progress/kendo-angular-icons';
import { IndicatorsModule } from '@progress/kendo-angular-indicators';
import { InputsModule } from '@progress/kendo-angular-inputs';
import { LabelModule } from '@progress/kendo-angular-label';
import { LayoutModule } from '@progress/kendo-angular-layout';
import { ListViewModule } from '@progress/kendo-angular-listview';
import { MenuModule } from '@progress/kendo-angular-menu';
import { NavigationModule } from '@progress/kendo-angular-navigation';
import { NotificationModule } from '@progress/kendo-angular-notification';
import { PDFExportModule } from '@progress/kendo-angular-pdf-export';
import { PagerModule } from '@progress/kendo-angular-pager';
import { PopupModule } from '@progress/kendo-angular-popup';
import { ProgressBarModule } from '@progress/kendo-angular-progressbar';
import { RippleModule } from '@progress/kendo-angular-ripple';
import { SchedulerModule } from '@progress/kendo-angular-scheduler';
import { ScrollViewModule } from '@progress/kendo-angular-scrollview';
import { SortableModule } from '@progress/kendo-angular-sortable';
import { ToolBarModule } from '@progress/kendo-angular-toolbar';
import { TooltipModule } from '@progress/kendo-angular-tooltip';
import { TreeListModule } from '@progress/kendo-angular-treelist';
import { TreeViewModule } from '@progress/kendo-angular-treeview';
import { UploadModule } from '@progress/kendo-angular-upload';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { StatsComponent } from './stats/stats.component';
import { OrdersComponent } from './orders/orders.component';

import 'hammerjs';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    StatsComponent,
    OrdersComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'orders', component: OrdersComponent },
      { path: 'stats', component: StatsComponent },
    ]),
    ButtonsModule,
    BrowserAnimationsModule,
    ChartsModule,
    ChatModule,
    DateInputsModule,
    DialogsModule,
    DropDownsModule,
    EditorModule,
    ExcelExportModule,
    GaugesModule,
    GridModule,
    IconsModule,
    IndicatorsModule,
    InputsModule,
    LabelModule,
    LayoutModule,
    ListViewModule,
    MenuModule,
    NavigationModule,
    NotificationModule,
    PDFExportModule,
    PagerModule,
    PopupModule,
    ProgressBarModule,
    RippleModule,
    SchedulerModule,
    ScrollViewModule,
    SortableModule,
    ToolBarModule,
    TooltipModule,
    TreeListModule,
    TreeViewModule,
    UploadModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
