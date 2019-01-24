import { Component } from '@angular/core';
import { ExpenseType } from 'src/app/shared/model/expense-type.model';
import { DialogBaseComponent } from 'src/app/shared/component/dialog-base.component';

@Component({
    selector: 'app-expense-type-dialog',
    templateUrl: './expense-type-dialog.component.html'
})
export class ExpenseTypeDialogComponent implements DialogBaseComponent {
    item = new ExpenseType();
}
