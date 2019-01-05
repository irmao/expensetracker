import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { FlexLayoutModule } from '@angular/flex-layout';

import {
  MatFormFieldModule, MatInputModule, MatButtonModule, MatSnackBarModule,
  MatTableModule, MatToolbarModule, MatIconModule
} from '@angular/material';

import { AppComponent } from './app.component';
import { MaintainFrequencyComponent } from './core/maintain-frequency/maintain-frequency.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    MaintainFrequencyComponent,
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
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
