
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home.component';
import { MasterComponent } from './master.component';
import { MainRoutes } from '../routing/routing.main';

import { LoginComponent } from 'src/app/login/login.component';
import { RegisterComponent } from 'src/app/register/register.component';
import { AuthService } from 'src/app/auth.service';

@NgModule({
  declarations: [
    HomeComponent,
    MasterComponent,
    LoginComponent,
    RegisterComponent
    
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(MainRoutes),
    
  ],
  providers: [AuthService],
  bootstrap: [MasterComponent]
})

export class MasterModule { }





