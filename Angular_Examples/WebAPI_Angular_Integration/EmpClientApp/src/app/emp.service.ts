import { Injectable } from '@angular/core';
import {HttpClient, HttpErrorResponse, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { throwError } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class EmpService {
url:string="http://localhost:3700/api/Employee/"
  
constructor(private service:HttpClient) { }
httpOptions = { headers: new HttpHeaders({ 'Content-type': 'application/json' }) };
  getEmployees():Observable<any>
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
