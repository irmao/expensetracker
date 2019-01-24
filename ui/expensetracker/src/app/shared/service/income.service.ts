import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { RestService } from './rest.service';
import { Income } from '../model/income.model';


@Injectable({
  providedIn: 'root'
})
export class IncomeService extends RestService<Income> {

  constructor(http: HttpClient) {
      super(http);
  }

  getUri(): string {
      return 'incomes';
  }
}
