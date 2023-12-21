import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { FirstComponent } from './first/first.component';
import { ChlidAComponent } from './chlid-a/chlid-a.component';
import { ChildBComponent } from './child-b/child-b.component';
import { SecondComponent } from './second/second.component';

const routes: Routes = [
  {path:'',redirectTo:'home',pathMatch:'full'},
  {path:'home',component:HomeComponent},
  {path:'first',component:FirstComponent,children:[
                {path:'child-a',component:ChlidAComponent},
                {path:'child-b',component:ChildBComponent}
   ]},
{path:'second',component:SecondComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
