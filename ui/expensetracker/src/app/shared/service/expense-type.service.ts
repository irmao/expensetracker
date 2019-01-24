import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { RestService } from './rest.service';
import { ExpenseType } from '../model/expense-type.model';


@Injectable({
  providedIn: 'root'
})
export class ExpenseTypeService extends RestService<ExpenseType> {

  constructor(http: HttpClient) {
      super(http);
  }

  getUri(): string {
      return 'expensetypes';
  }
}
