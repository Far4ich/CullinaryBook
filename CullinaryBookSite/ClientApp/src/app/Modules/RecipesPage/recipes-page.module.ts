import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MatCardModule } from "@angular/material/card";
import { MatButtonModule } from "@angular/material/button";
import { MatListModule } from "@angular/material/list";
import { MatIconModule } from "@angular/material/icon";
import { MatFormFieldModule } from "@angular/material/form-field";
import { MatInputModule } from "@angular/material/input";

import { RecipesPageRoutingModule } from './recipes-page-routing.module';
import { RecipesPageComponent } from './Components/page/recipes-page.component';
import { TagCardsComponent } from './Components/tag-cards/tag-cards.component';
import { RecipeSearchComponent } from './Components/recipe-search/recipe-search.component';
import { RecipeItemComponent } from './Components/recipe-item/recipe-item.component';
import { UserService } from 'src/app/Services/user.service';

@NgModule({
    imports: [
        CommonModule,
        RecipesPageRoutingModule,
        MatFormFieldModule,
        MatInputModule,
        MatCardModule,
        MatButtonModule,
        MatListModule,
        MatIconModule,
    ],
    declarations: [
        RecipesPageComponent,
        TagCardsComponent,
        RecipeSearchComponent,
        RecipeItemComponent
    ],
    providers: [
        UserService
    ]
})
export class RecipesPageModule {}