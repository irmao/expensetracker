import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { FlexLayoutModule } from '@angular/flex-layout';
import { HttpClientModule } from '@angular/common/http';

import {
  MatFormFieldModule, MatInputModule, MatButtonModule, MatSnackBarModule,
  MatTableModule, MatToolbarModule, MatIconModule, MatDialogModule, MatSidenavModule, MatListModule, MatDatepickerModule,
  MatNativeDateModule, MatSelectModule, MAT_DATE_FORMATS, DateAdapter, MAT_DATE_LOCALE, MatCardModule
} from '@angular/material';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FrequencyListComponent } from './core/frequency/frequency-list.component';
import { ExpenseTypeListComponent } from './core/expense-type/expense-type-list.component';
import { ExpenseTypeDialogComponent } from './core/expense-type/expense-type-dialog.component';
import { FrequencyDialogComponent } from './core/frequency/frequency-dialog.component';
import { ConfirmDialogComponent } from './shared/component/confirm-dialog/confirm-dialog.component';
import { MenuComponent } from './shared/component/menu/menu.component';
import { IncomeListComponent } from './core/income/income-list.component';
import { IncomeDialogComponent } from './core/income/income-dialog.component';
import { ExpenseListComponent } from './core/expense/expense-list.component';
import { ExpenseDialogComponent } from './core/expense/expense-dialog.component';
import { DashboardComponent } from './core/dashboard/dashboard.component';
import { SingleNumberCardComponent } from './core/dashboard/single-number-card.component';

@NgModule({
  declarations: [
    AppComponent,
    FrequencyListComponent,
    FrequencyDialogComponent,
    ExpenseTypeListComponent,
    ExpenseTypeDialogComponent,
    ExpenseListComponent,
    ExpenseDialogComponent,
    IncomeListComponent,
    IncomeDialogComponent,
    ConfirmDialogComponent,
    MenuComponent,
    DashboardComponent,
    SingleNumberCardComponent
  ],
  entryComponents: [
    FrequencyDialogComponent,
    ExpenseTypeDialogComponent,
    ExpenseDialogComponent,
    IncomeDialogComponent,
    ConfirmDialogComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MatFormFieldModule,
    MatCardModule,
    MatInputModule,
    MatButtonModule,
    FlexLayoutModule,
    MatSnackBarModule,
    MatTableModule,
    MatToolbarModule,
    MatIconModule,
    MatSidenavModule,
    MatListModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatSelectModule,
    FormsModule,
    MatDialogModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
