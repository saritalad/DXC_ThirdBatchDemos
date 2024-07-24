import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { OnewaybindingComponent } from './onewaybinding/onewaybinding.component';
import { TwowaybindingComponent } from './twowaybinding/twowaybinding.component';
import { StructuraldirectivesComponent } from './structuraldirectives/structuraldirectives.component';
import { AttributedirectivesComponent } from './attributedirectives/attributedirectives.component';
import { PipesComponent } from './pipes/pipes.component';
import { PagenotfoundComponent } from './pagenotfound/pagenotfound.component';

const routes: Routes = [
{path:" ",redirectTo:"home",pathMatch:"full"},
{path:"home",component:HomeComponent},
{path:"oneway",component:OnewaybindingComponent},
{path:"twoway",component:TwowaybindingComponent},
{path:"struct",component:StructuraldirectivesComponent},
{path:"attrib",component:AttributedirectivesComponent},
{path:"mypipes",component:PipesComponent},
{path:"**",component:PagenotfoundComponent}



];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
