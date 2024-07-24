import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, catchError, throwError } from 'rxjs';
import { Enrollment } from '../Models/Entrollment';
import { EnrollViewModel } from '../Models/EnrollmentViewModel';

@Injectable({
  providedIn: 'root'
})
export class EnrollmentService {

  private apiUrl = 'https://localhost:44353/api/Enroll';
 private apiUrl1:'https://localhost:44353/api/Enroll/GetAllEnrollments'
 private apiUrlB:'https://localhost:44353/api/Enroll/GetEnrollByUserId'
 httpOptions = { headers: new HttpHeaders({ 'Content-type': 'application/json' }) };
  constructor(private http: HttpClient) { }

  // Get all enrollments
 getEnrollments():Observable<Enrollment[]>
 {
  return this.http.get<Enrollment[]>(this.apiUrl);
 }
getEnrollmentsByStudentId(userId:number):Observable<Enrollment[]>
{//debugger;
  return this.http.get<Enrollment[]>('https://localhost:44353/api/Enroll/GetEnrollByUserId/'+userId);
}
  // Get enrollment by ID
  getEnrollment(enrollmentId: number): Observable<Enrollment> {
    const url = `${this.apiUrl}/${enrollmentId}`;
    return this.http.get<Enrollment>(url);
  }
  getAllEnrollments():Observable<EnrollViewModel[]>
  {
   return this.http.get<EnrollViewModel[]>(this.apiUrl+"/",this.httpOptions).pipe(catchError(this.handleError));
  }

  // Create enrollment
  createEnrollment(enrollment: Enrollment): Observable<Enrollment> {
    return this.http.post<Enrollment>(this.apiUrl, enrollment);
  }

  // Update enrollment
  updateEnrollment(enrollmentId: number, enrollment: Enrollment): Observable<Enrollment> {
    const url = `${this.apiUrl}/${enrollmentId}`;
    return this.http.put<Enrollment>(url, enrollment);
  }

  // Delete enrollment
  deleteEnrollment(enrollmentId: number): Observable<any> {
    const url = `${this.apiUrl}/${enrollmentId}`;
    return this.http.delete(url);
  }
  handleError(error:HttpErrorResponse){
    let errorMessage="";
    errorMessage=error.status +'\n'+error.statusText+'\n'+error.error;
    alert(errorMessage);
    return throwError(errorMessage);
  }
}
