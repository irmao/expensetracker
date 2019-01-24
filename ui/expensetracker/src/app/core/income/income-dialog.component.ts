import { Component, OnInit } from '@angular/core';
import { DialogBaseComponent } from 'src/app/shared/component/dialog-base.component';
import { Income } from 'src/app/shared/model/income.model';
import { Observable } from 'rxjs';
import { Frequency } from 'src/app/shared/model/frequency.model';
import { FrequencyService } from 'src/app/shared/service/frequency.service';

@Component({
    selector: 'app-income-dialog',
    templateUrl: './income-dialog.component.html'
})
export class IncomeDialogComponent implements DialogBaseComponent, OnInit {
    item = new Income();
    frequencyObservable: Observable<Frequency[]>;

    constructor(private frequencyService: FrequencyService) {
    }

    ngOnInit() {
        this.frequencyObservable = this.frequencyService.find(undefined);
    }
}
