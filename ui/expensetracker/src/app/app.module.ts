import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { FlexLayoutModule } from '@angular/flex-layout';

import {
  MatFormFieldModule, MatInputModule, MatButtonModule, MatSnackBarModule,
  MatTableModule, MatToolbarModule, MatIconModule, MatDialogModule
} from '@angular/material';

import { AppComponent } from './app.component';
import { FrequencyListComponent } from './core/frequency/frequency-list.component';
import { HttpClientModule } from '@angular/common/http';
import { FrequencyDialogComponent } from './core/frequency/frequency-dialog.component';
import { ConfirmDialogComponent } from './shared/component/confirm-dialog/confirm-dialog.component';

@NgModule({
  declarations: [
    AppComponent,
    FrequencyListComponent,
    FrequencyDialogComponent,
    ConfirmDialogComponent
  ],
  entryComponents: [
    FrequencyDialogComponent,
    ConfirmDialogComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    FlexLayoutModule,
    MatSnackBarModule,
    MatTableModule,
    MatToolbarModule,
    MatIconModule,
    FormsModule,
    MatDialogModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
