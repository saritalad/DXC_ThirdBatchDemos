import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, catchError, throwError } from 'rxjs';
import { User } from '../Models/User';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private apiUrl = 'https://localhost:44353/api/User';
  httpOptions = { headers: new HttpHeaders({ 'Content-type': 'application/json' }) };
  constructor(private http: HttpClient) { }

  // Get all users
  getAllStudents(): Observable<User[]> {
    return this.http.get<User[]>(this.apiUrl);
  }

  // Get user by ID
  getUser(userId: number): Observable<User> {
    const url = `${this.apiUrl}/${userId}`;
    return this.http.get<User>(url);
  }

  // Create user
  createUser(user: User): Observable<User> {
    return this.http.post<User>(this.apiUrl, user,this.httpOptions).pipe(catchError(this.handleError));
  }

  // Update user
  updateUser(userId: number, user: User): Observable<User> {
    const url = `${this.apiUrl}/${userId}`;
    return this.http.put<User>(url, user);
  }

  // Delete user
  deleteUser(userId: number): Observable<any> {
    const url = `${this.apiUrl}/${userId}`;
    return this.http.delete(url);
  }
  handleError(error:HttpErrorResponse){
    let errorMessage="";
    errorMessage=error.status +'\n'+error.statusText+'\n'+error.error;
    alert(errorMessage);
    return throwError(errorMessage);
  }



}
