import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EmpService {
url:string="http://localhost:3700/api/employee"
  constructor(private service:HttpClient) { }
  httpOptions={headers:new HttpHeaders({'content-type':"application/json"})};


  getAllEmployees():Observable<any>
  {
    return this.service.get<any>(this.url);
  }




  
  handleError(error:HttpErrorResponse){
    let errorMessage="";
    errorMessage=error.status +'\n'+error.statusText+'\n'+error.error;
    alert(errorMessage);
    return throwError(errorMessage);
  }



}
