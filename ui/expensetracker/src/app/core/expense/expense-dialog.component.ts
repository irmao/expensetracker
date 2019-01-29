import { Component, OnInit } from '@angular/core';
import { DialogBaseComponent } from 'src/app/shared/component/dialog-base.component';
import { Expense } from 'src/app/shared/model/expense.model';
import { Frequency } from 'src/app/shared/model/frequency.model';
import { Observable } from 'rxjs';
import { FrequencyService } from 'src/app/shared/service/frequency.service';
import { ExpenseTypeService } from 'src/app/shared/service/expense-type.service';
import { ExpenseType } from 'src/app/shared/model/expense-type.model';

@Component({
    selector: 'app-expense-dialog',
    templateUrl: './expense-dialog.component.html'
})
export class ExpenseDialogComponent implements DialogBaseComponent, OnInit {
    item = new Expense();
    frequencyObservable: Observable<Frequency[]>;
    expenseTypeObservable: Observable<ExpenseType[]>;

    constructor(private frequencyService: FrequencyService, private expenseTypeService: ExpenseTypeService) {
    }

    ngOnInit() {
        this.frequencyObservable = this.frequencyService.find(undefined, undefined);
        this.expenseTypeObservable = this.expenseTypeService.find(undefined, undefined);
    }
}
