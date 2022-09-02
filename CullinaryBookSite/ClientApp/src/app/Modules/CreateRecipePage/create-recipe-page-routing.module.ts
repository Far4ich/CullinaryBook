import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateRecipePageComponent } from './Components/page/create-recipe-page.component';

const routes: Routes = [
  {
    path:"create-recipe",
    component: CreateRecipePageComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class CreateRecipePageRoutingModule { }