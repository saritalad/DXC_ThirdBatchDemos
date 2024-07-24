import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, catchError, throwError } from 'rxjs';
import { Feedback } from '../Models/Feedback';

@Injectable({
  providedIn: 'root'
})
export class FeedbackService {
apiUrl:string='https://localhost:44353/api/feedback'
httpOptions = { headers: new HttpHeaders({ 'Content-type': 'application/json' }) };
  constructor(private http:HttpClient) { }
getAllfeedbacks():Observable<Feedback[]>
{
  return this.http.get<Feedback[]>(this.apiUrl,this.httpOptions).pipe(catchError(this.handleError));
}
CreateFeedback(feedback:Feedback):Observable<Feedback>
{
  return this.http.post<Feedback>(this.apiUrl,feedback,this.httpOptions).pipe(catchError(this.handleError));
}

handleError(error:HttpErrorResponse){
  let errorMessage="";
  errorMessage=error.status +'\n'+error.statusText+'\n'+error.error;
  alert(errorMessage);
  return throwError(errorMessage);
}
}




