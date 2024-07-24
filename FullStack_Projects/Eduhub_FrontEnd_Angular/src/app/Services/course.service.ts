import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Course } from '../Models/Course';
import { Observable, catchError, throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CourseService {
  private apiUrl = 'https://localhost:44353/api/Course';
  private apiUrl1='https://localhost:44353/api/Course/GetCoursesByUserId';
  httpOptions = { headers: new HttpHeaders({ 'Content-type': 'application/json' }) };
  constructor(private http: HttpClient) { }

  // Get all courses
  getCourses(): Observable<any> {
    return this.http.get<any>(this.apiUrl);
  }
  
getCoursesByUserId(userId:number):Observable<any>
{
  return this.http.get<any>(this.apiUrl1+"/"+userId)
}
getCourse(Id:number):Observable<any>
{
  return this.http.get<any>(this.apiUrl+"/"+Id)
}


  createCourse(course: Course): Observable<Course> {
    return this.http.post<Course>(this.apiUrl, course,this.httpOptions).pipe(catchError(this.handleError));
  }

  // Update course
  updateCourse(course: Course): Observable<Course> {
      return this.http.put<Course>(this.apiUrl+"/"+course.courseId,course,this.httpOptions).pipe(catchError(this.handleError));
  }

  // Delete course
  deleteCourse(courseId: number): Observable<any> {
   // const url = `${this.apiUrl}/${courseId}`;
    return this.http.delete(`${this.apiUrl}/${courseId}`);
  }
  handleError(error:HttpErrorResponse){
    let errorMessage="";
    errorMessage=error.status +'\n'+error.statusText+'\n'+error.error;
    alert(errorMessage);
    return throwError(errorMessage);
  }
}
