import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './Components/page/app.component';

import { HeaderComponent } from './Components/header/header.component';
import { FooterComponent } from './Components/footer/footer.component';

import { CreateRecipePageModule } from '../Modules/CreateRecipePage/create-recipe-page.module';
import { RecipesPageModule } from '../Modules/RecipesPage/recipes-page.module';
import { MainPageModule } from '../Modules/MainPage/main-page.module';


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent
  ],
  imports: [
    BrowserModule,
    CreateRecipePageModule,
    MainPageModule,
    RecipesPageModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule { }
