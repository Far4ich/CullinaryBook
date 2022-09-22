import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MatCardModule } from "@angular/material/card";
import { MatButtonModule } from "@angular/material/button";
import { MatListModule } from "@angular/material/list";
import { MatIconModule } from "@angular/material/icon";
import { MatFormFieldModule } from "@angular/material/form-field";
import { MatInputModule } from "@angular/material/input";

import { RecipesPageComponent } from './Components/page/recipes-page.component';
import { TagCardsComponent } from './Components/tag-cards/tag-cards.component';
import { RecipeItemComponent } from './Components/recipe-item/recipe-item.component';
import { UserService } from 'src/app/Services/user.service';
import { AppRoutingModule } from 'src/app/Core/app-routing.module';
import { MainPageModule } from '../MainPage/main-page.module';

@NgModule({
    imports: [
        CommonModule,
        MatFormFieldModule,
        MatInputModule,
        MatCardModule,
        MatButtonModule,
        MatListModule,
        MatIconModule,
        AppRoutingModule,
        MainPageModule
    ],
    declarations: [
        RecipesPageComponent,
        TagCardsComponent,
        RecipeItemComponent
    ],
    providers: [
        UserService
    ]
})
export class RecipesPageModule {}