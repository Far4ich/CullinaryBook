import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MatCardModule } from "@angular/material/card";
import { MatButtonModule } from "@angular/material/button";
import { MatListModule } from "@angular/material/list";
import { MatIconModule } from "@angular/material/icon";
import { MatFormFieldModule } from "@angular/material/form-field";
import { MatInputModule } from "@angular/material/input";

import { DayRecipeComponent } from './Components/day-recipe/day-recipe.component';
import { MainPageComponent } from './Components/page/main-page.component';
import { RecipeSearchComponent } from './Components/recipe-search/recipe-search.component';
import { TagsPreviewCardsItemComponent } from './Components/tags-prewiew-cards/tags-preview-cards-item.component';
import { RecipeSearchTagComponent } from './Components/recipe-search-tag/recipe-search-tag.component';
import { AppRoutingModule } from 'src/app/Core/app-routing.module';

@NgModule({
    imports: [
        CommonModule,
        MatFormFieldModule,
        MatInputModule,
        MatCardModule,
        MatButtonModule,
        MatListModule,
        MatIconModule,
        AppRoutingModule
    ],
    declarations: [
        DayRecipeComponent,
        MainPageComponent,
        RecipeSearchComponent,
        TagsPreviewCardsItemComponent,
        RecipeSearchTagComponent
    ],
    exports: [RecipeSearchComponent]
})
export class MainPageModule {}