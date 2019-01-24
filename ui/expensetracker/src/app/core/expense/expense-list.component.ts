import { Component, OnInit } from '@angular/core';
import { CrudBaseComponent } from 'src/app/shared/component/crud-base.component';
import { HttpClient } from '@angular/common/http';
import { MatSnackBar, MatDialog } from '@angular/material';
import { ExpenseDialogComponent } from './expense-dialog.component';
import { Expense } from 'src/app/shared/model/expense.model';
import { ExpenseService } from 'src/app/shared/service/expense.service';

@Component({
  selector: 'app-expense-list',
  templateUrl: './expense-list.component.html'
})
export class ExpenseListComponent extends CrudBaseComponent<Expense> implements OnInit {

  readonly displayedColumns: string[] = ['description', 'value', 'frequency', 'expenseType', 'startDate',
    'endDate', 'comment', 'actions'];

  constructor(http: HttpClient, service: ExpenseService, snackBar: MatSnackBar, dialog: MatDialog) {
    super(http, service, snackBar, dialog);
  }

  ngOnInit() {
    this.search();
  }

  dialogComponent() {
    return ExpenseDialogComponent;
  }
}
