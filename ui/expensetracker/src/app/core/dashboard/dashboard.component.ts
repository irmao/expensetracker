import { Component, OnInit } from '@angular/core';
import { IncomeService } from 'src/app/shared/service/income.service';
import { Observable } from 'rxjs';
import { DashboardFilter } from 'src/app/shared/dto/dashboard.filter';
import * as moment from 'moment';

@Component({
    selector: 'app-dashboard',
    templateUrl: './dashboard.component.html',
    styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {

    startDate: Date;
    endDate: Date;
    totalIncomeObservable: Observable<number>;
    filter: DashboardFilter;

    constructor(private incomeService: IncomeService) {
    }

    ngOnInit() {
        this.filter = new DashboardFilter();
        this.startDate = moment().toDate();
        this.endDate = moment().add(30, 'days').toDate();

        this.search();
    }

    search() {
        this.filter.startDate = this.startDate.toISOString();
        this.filter.endDate = this.endDate.toISOString();
        this.totalIncomeObservable = this.incomeService.findSum(this.filter);
    }
}
