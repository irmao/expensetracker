import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';


const endpoint = 'http://localhost:5000/api/v1';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json; charset=utf-8'
  })
};

@Injectable({
  providedIn: 'root'
})
export abstract class RestService<T> {

  constructor(private http: HttpClient) { }

  find(filter: any): Observable<T[]> {
    return this.http.get(`${endpoint}/${this.getUri()}`, httpOptions).pipe(map(r => r as T[]));
  }

  findOne(id: number): Observable<T> {
    return this.http.get(`${endpoint}/${this.getUri()}/${id}`, httpOptions) as Observable<T>;
  }

  create(entity: T): Observable<any> {
    return this.http.post(`${endpoint}/${this.getUri()}`, entity, httpOptions);
  }

  edit(id: number, entity: T): Observable<any> {
    return this.http.put(`${endpoint}/${this.getUri()}/${id}`, entity, httpOptions);
  }

  delete(id: number): Observable<any> {
    return this.http.delete(`${endpoint}/${this.getUri()}/${id}`);
  }

  abstract getUri(): string;
}
