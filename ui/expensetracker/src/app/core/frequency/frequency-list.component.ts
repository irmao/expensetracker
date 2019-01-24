import { Component, OnInit } from '@angular/core';
import { Frequency } from 'src/app/shared/model/frequency.model';
import { CrudBaseComponent } from 'src/app/shared/component/crud-base.component';
import { HttpClient } from '@angular/common/http';
import { MatSnackBar, MatDialog } from '@angular/material';
import { FrequencyDialogComponent } from './frequency-dialog.component';
import { FrequencyService } from 'src/app/shared/service/frequency.service';

@Component({
  selector: 'app-frequency-list',
  templateUrl: './frequency-list.component.html'
})
export class FrequencyListComponent extends CrudBaseComponent<Frequency> implements OnInit {

  readonly displayedColumns: string[] = ['description', 'averageTimesPerMonth', 'actions'];

  constructor(http: HttpClient, service: FrequencyService, snackBar: MatSnackBar, dialog: MatDialog) {
    super(http, service, snackBar, dialog);
  }

  ngOnInit() {
    this.search();
  }

  dialogComponent() {
    return FrequencyDialogComponent;
  }
}
