import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../Models/User';
import { LoginModel } from '../Models/Login';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private apiUrl = 'https://localhost:44353/api/Auth';
  constructor(private http:HttpClient) { }
Login(user:LoginModel):any
{
  return this.http.post<any>(this.apiUrl+"/Login",user,{observe:'response'});
}


}
