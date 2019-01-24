import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { RestService } from './rest.service';
import { Frequency } from '../model/frequency.model';


@Injectable({
  providedIn: 'root'
})
export class FrequencyService extends RestService<Frequency> {

  constructor(http: HttpClient) {
      super(http);
  }

  getUri(): string {
      return 'frequencies';
  }
}
