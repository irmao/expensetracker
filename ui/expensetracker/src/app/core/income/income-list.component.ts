import { Component, OnInit } from '@angular/core';
import { CrudBaseComponent } from 'src/app/shared/component/crud-base.component';
import { HttpClient } from '@angular/common/http';
import { IncomeService } from 'src/app/shared/service/income.service';
import { MatSnackBar, MatDialog } from '@angular/material';
import { Income } from 'src/app/shared/model/income.model';
import { IncomeDialogComponent } from './income-dialog.component';

@Component({
  selector: 'app-income-list',
  templateUrl: './income-list.component.html'
})
export class IncomeListComponent extends CrudBaseComponent<Income> implements OnInit {

  readonly displayedColumns: string[] = ['description', 'frequency', 'value', 'startDate', 'endDate', 'actions'];

  constructor(http: HttpClient, service: IncomeService, snackBar: MatSnackBar, dialog: MatDialog) {
    super(http, service, snackBar, dialog);
  }

  ngOnInit() {
    this.search();
  }

  dialogComponent() {
    return IncomeDialogComponent;
  }
}
