import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminComponent } from './admin/admin.component';
import { CartComponent } from './cart/cart.component';
import { FinalOrderComponent } from './finalorder/finalorder.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { OrdercompleteComponent } from './ordercomplete/ordercomplete.component';
import { ProductComponent } from './product/product.component';
import { RegisterComponent } from './register/register.component';

const routes: Routes = [
  {
    path: 'home',
    component: HomeComponent
  },
  {
    path: '',
    component: HomeComponent
  },
  {
    path: 'login',
    component: LoginComponent
  },
  {
    path: 'register',
    component: RegisterComponent
  },
  {
    path: 'product',
    component: ProductComponent
  },

  {
    path: 'admin',
    component: AdminComponent
  },
  {
    path: 'cart',
    component: CartComponent
  },
 

  {
    path:'finalorder',
    component:FinalOrderComponent
  },
  {
    path:'ordercomplete',
    component:OrdercompleteComponent
  },



  
 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
