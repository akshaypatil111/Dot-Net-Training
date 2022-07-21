import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';


@Injectable()
export class AuthService {
  private _registerUrl = "https://eshopping.azurewebsites.net/api/Login/register";
  private _loginUrl = "https://eshopping.azurewebsites.net/api/Login/login";
  private _userUrl="https://eshopping.azurewebsites.net/api/Login";

  constructor(private http: HttpClient,private _router:Router) { }

  registerUser(user: any) {
    return this.http.post<any>(this._registerUrl, user);
  }
  loginUser(user: any) {
    return this.http.post<any>(this._loginUrl, user);
  }
  loggedIn()
  {
    return !!localStorage.getItem('token')
  }
  logoutUser(){
    localStorage.removeItem('token');
    this._router.navigate(['/home']);
  }
  getUsers(){
    return this.http.get<any>(this._userUrl);
  }
}