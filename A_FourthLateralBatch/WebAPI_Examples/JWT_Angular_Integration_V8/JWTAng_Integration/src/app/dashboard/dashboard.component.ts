import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Product } from '../Models/Product';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent {
products:Product[]=[];
constructor(private http:HttpClient) {
  this.loadUsers()
 }
 loadUsers()
 {
  debugger;
  this.http.get('https://localhost:44377/api/product').subscribe((res:any)=>{
this.products=res;
console.log(res)
  })
 }
}
