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

  find(uri: string, filter: any): Observable<T[]> {
    return this.http.get(`${endpoint}/${uri}`, httpOptions).pipe(map(r => r as T[]));
  }

  findOne(uri: string, id: number): Observable<T> {
    return this.http.get(`${endpoint}/${uri}/${id}`, httpOptions) as Observable<T>;
  }

  create(uri: string, entity: T): Observable<any> {
    return this.http.post(`${endpoint}/${uri}`, entity, httpOptions);
  }

  edit(uri: string, id: number, entity: T): Observable<any> {
    return this.http.put(`${endpoint}/${uri}/${id}`, entity, httpOptions);
  }

  delete(uri: string, id: number): Observable<any> {
    return this.http.delete(`${endpoint}/${uri}/${id}`);
  }
}
