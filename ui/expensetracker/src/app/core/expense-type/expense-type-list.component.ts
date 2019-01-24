import { Component, OnInit } from '@angular/core';
import { CrudBaseComponent } from 'src/app/shared/component/crud-base.component';
import { HttpClient } from '@angular/common/http';
import { MatSnackBar, MatDialog } from '@angular/material';
import { ExpenseTypeDialogComponent } from './expense-type-dialog.component';
import { ExpenseType } from 'src/app/shared/model/expense-type.model';
import { ExpenseTypeService } from 'src/app/shared/service/expense-type.service';

@Component({
  selector: 'app-expense-type-list',
  templateUrl: './expense-type-list.component.html'
})
export class ExpenseTypeListComponent extends CrudBaseComponent<ExpenseType> implements OnInit {

  readonly displayedColumns: string[] = ['description', 'actions'];

  constructor(http: HttpClient, service: ExpenseTypeService, snackBar: MatSnackBar, dialog: MatDialog) {
    super(http, service, snackBar, dialog);
  }

  ngOnInit() {
    this.search();
  }

  dialogComponent() {
    return ExpenseTypeDialogComponent;
  }
}
