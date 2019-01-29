import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { RestService } from './rest.service';
import { Income } from '../model/income.model';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class IncomeService extends RestService<Income> {

  constructor(http: HttpClient) {
      super(http);
  }

  findSum(filter: any): Observable<number> {
    return this.find('sum', filter);
  }

  getUri(): string {
      return 'incomes';
  }
}
