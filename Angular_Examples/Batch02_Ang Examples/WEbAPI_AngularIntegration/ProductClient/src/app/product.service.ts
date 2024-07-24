import { Injectable } from '@angular/core';
import {HttpClient, HttpErrorResponse, HttpHeaders} from '@angular/common/http'
import { Observable, catchError, throwError } from 'rxjs';
import { Product } from 'src/Models/Product';
@Injectable({
  providedIn: 'root'
})
export class ProductService {
url:string="http://localhost:3700/api/Product";
  constructor(private service:HttpClient) { }
  httpOptions={headers:new HttpHeaders({'content-type':"application/json"})};
  getAllProducts():Observable<any>
  {
     return this.service.get<any>(this.url);
    
  }

  getProductById(id:number):Observable<any>
  {
    return this.service.get<any>(this.url+"/"+id)
  }


  UpdateProduct(product:Product):Observable<Product>
{
  return this.service.put<Product>(this.url+"/"+product.productId,product,this.httpOptions)
  .pipe(catchError(this.handleError));
}



AddNewProduct(newproduct:Product):Observable<any>
{
  return this.service.post<Product>(this.url,newproduct);
}


deleteProduct(Id:number):Observable<any>
{
  return this.service.delete(this.url+"/"+Id,this.httpOptions).pipe(catchError(this.handleError))
}


handleError(error:HttpErrorResponse){
  let errorMessage="";
  errorMessage=error.status +'\n'+error.statusText+'\n'+error.error;
  alert(errorMessage);
  return throwError(errorMessage);
}
}


