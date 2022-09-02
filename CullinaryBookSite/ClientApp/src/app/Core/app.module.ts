import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './Components/page/app.component';

import { HeaderComponent } from './Components/header/header.component';
import { FooterComponent } from './Components/footer/footer.component';

import { MainPageModule } from '../Modules/MainPage/main-page.module';
import { CreateRecipePageModule } from '../Modules/CreateRecipePage/create-recipe-page.module';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent
  ],
  imports: [
    BrowserModule,
    MainPageModule,
    CreateRecipePageModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
