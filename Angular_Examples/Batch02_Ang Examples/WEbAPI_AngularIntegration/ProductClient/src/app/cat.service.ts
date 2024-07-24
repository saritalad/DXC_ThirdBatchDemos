import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, ObservableLike, catchError, retry, throwError } from 'rxjs';
import { category } from 'src/Models/Category';

@Injectable({
  providedIn: 'root'
})
export class CatService {
url:string="http://localhost:3700/api/category"
httpOptions={headers:new HttpHeaders({'content-type':"application/json"})};
  constructor(private service:HttpClient) { }
getAllCategories():Observable<any>
{
  return this.service.get<any>(this.url);
}



getCatById(Id:number):Observable<any>
{
  return this.service.get(this.url+"/"+Id)
}
AddCategory(newcat:category)
{
  return this.service.post(this.url,newcat,this.httpOptions).pipe(retry(1), catchError(this.handleError));
}

Update(id:number,cat:category):Observable<any>
{
  return this.service.put(this.url+"/"+id,cat,this.httpOptions).pipe(catchError(this.handleError));
}

handleError(error:any) {
  let errorMessage = '';
  if (error.error instanceof ErrorEvent) {
    // client-side error
    errorMessage = `Error: ${error.error.message}`;
  } else {
    // server-side error
    errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
  }
  console.log(errorMessage);
  return throwError(() => {
      return errorMessage;
  });
}
}
