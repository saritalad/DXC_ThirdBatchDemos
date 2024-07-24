import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { OnewaybindingComponent } from './onewaybinding/onewaybinding.component';
import { TwowaybindingComponent } from './twowaybinding/twowaybinding.component';
import { StructaldirectiveComponent } from './structaldirective/structaldirective.component';
import { AttibdirectiveComponent } from './attibdirective/attibdirective.component';
import { PipesComponent } from './pipes/pipes.component';
import { PagenotfoundComponent } from './pagenotfound/pagenotfound.component';

const routes: Routes = [
{path:'',redirectTo:"home",pathMatch:"full"},
{path:"home",component:HomeComponent},
{path:"oneway",component:OnewaybindingComponent},
{path:"twoway",component:TwowaybindingComponent},
{path:"struct",component:StructaldirectiveComponent},
{path:"attrib",component:AttibdirectiveComponent},
{path:"mypipes",component:PipesComponent},
{path:"**",component:PagenotfoundComponent}




];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
