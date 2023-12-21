import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, catchError, throwError } from 'rxjs';
import { Product } from './Models/Product';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
url:string="http://localhost:56356/api/Products";
httpOptions = { headers: new HttpHeaders({ 'Content-type': 'application/json' }) };
  constructor(private http:HttpClient) { }

  getAllProducts():Observable<any>
  {
    return this.http.get<Product>(this.url); 
    
  }
// call post method in AaaNewProduct()
addNewProduct(newprod:Product):Observable<any>
{

  return this.http.post<Product>(this.url,newprod);
}
Update(product:Product):Observable<any>
{
  return this.http.put<Product>(this.url+"/"+product.id,product,this.httpOptions).pipe(catchError(this.handleError));
}

getProductById(id:number):Observable<any>
{
  return this.http.get(this.url+"/"+id);
}

// write delete service 
deleteProduct(id:number):Observable<any>
{
  return this.http.delete(this.url+"/"+id);
}

handleError(error:HttpErrorResponse){
  let errorMessage="";
  errorMessage=error.status +'\n'+error.statusText+'\n'+error.error;
  alert(errorMessage);
  return throwError(errorMessage);
}

}
