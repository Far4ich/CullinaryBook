import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateRecipePageComponent } from '../Modules/CreateRecipePage/Components/page/create-recipe-page.component';
import { MainPageComponent } from '../Modules/MainPage/Components/page/main-page.component';
import { RecipesPageComponent } from '../Modules/RecipesPage/Components/page/recipes-page.component';

const routes: Routes = [
  {
    path: "recipes",
    component: RecipesPageComponent
  },
  {
    path: "recipes/create",
    component: CreateRecipePageComponent
  },
  {
    path: "",
    component: MainPageComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
