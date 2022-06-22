import { Component, OnInit } from '@angular/core';
import { UserData } from '../component/models/UserData';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  registerUserData: UserData = new UserData();
  constructor(private _auth: AuthService) { }

  ngOnInit(): void {
  }

  registerUser() {
    this._auth.registerUser(this.registerUserData).subscribe(res => {
      //we will write code here
    },
      err => console.log(err));
  }

}