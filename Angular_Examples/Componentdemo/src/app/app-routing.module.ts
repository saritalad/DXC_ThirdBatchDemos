import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ProductComponent } from './product/product.component';
import { DetailsComponent } from './details/details.component';

const routes: Routes = [
{path:"",redirectTo:"home",pathMatch:"full"},
{path:"home",component:HomeComponent},
{path:"prodlist",component:ProductComponent,
children:[
  {path:"details/:id",component:DetailsComponent}
]
}



];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
