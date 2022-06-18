import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AdminComponent } from './Component/admin/admin.component';
import { ProductComponent } from './Component/product/product.component';
import { UserComponent } from './Component/user/user.component';

@NgModule({
  declarations: [
    AppComponent,
    AdminComponent,
    ProductComponent,
    UserComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
