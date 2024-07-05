import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  constructor(private http: HttpClient) {}
  private apiUrl = 'https://reqres.in/api/users?page=2';
  getUsers(): Observable<any> {
   return this.http.get<any>(this.apiUrl);
  }
}
