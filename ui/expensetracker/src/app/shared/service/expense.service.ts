import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { RestService } from './rest.service';
import { Expense } from '../model/expense.model';


@Injectable({
  providedIn: 'root'
})
export class ExpenseService extends RestService<Expense> {

  constructor(http: HttpClient) {
      super(http);
  }

  getUri(): string {
      return 'expenses';
  }
}
