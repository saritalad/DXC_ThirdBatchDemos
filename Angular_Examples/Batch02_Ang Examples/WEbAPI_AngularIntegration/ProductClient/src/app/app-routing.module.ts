import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';
import { ProdlistComponent } from './prodlist/prodlist.component';
import { ProdAddComponent } from './prod-add/prod-add.component';
import { ProdEditComponent } from './prod-edit/prod-edit.component';
import { CatComponent } from './cat/cat.component';
import { CatAddComponent } from './cat-add/cat-add.component';
import { CatEditComponent } from './cat-edit/cat-edit.component';
import { EmpListComponent } from './emp-list/emp-list.component';

const routes: Routes = [
  {path:"prodlist",component:ProdlistComponent},
  {path:"addproduct",component:ProdAddComponent},
  {path:"prodedit/:id",component:ProdEditComponent},
  {path:"catlist",component:CatComponent},
  {path:"addcat",component:CatAddComponent},
  {path:"editcat/:id",component:CatEditComponent},
  {path:"emplist",component:EmpListComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
