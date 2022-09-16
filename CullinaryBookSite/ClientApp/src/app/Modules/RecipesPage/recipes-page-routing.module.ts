import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RecipesPageComponent } from './Components/page/recipes-page.component';

const routes: Routes = [
  {
    path: "recipes",
    component: RecipesPageComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class RecipesPageRoutingModule { }