import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule }   from '@angular/forms';

import { MatCardModule } from "@angular/material/card";
import { MatChipsModule } from '@angular/material/chips';
import { MatButtonModule } from "@angular/material/button";
import { MatListModule } from "@angular/material/list";
import { MatIconModule } from "@angular/material/icon";
import { MatFormFieldModule } from "@angular/material/form-field";
import { MatInputModule } from "@angular/material/input";

import { CreateRecipePageComponent } from './Components/page/create-recipe-page.component';
import { CreateRecipePageRoutingModule } from './create-recipe-page-routing.module';
import { CreateRecipeIngredientItemComponent } from './Components/ingredient-item/create-recipe-ingredient-item.component';
import { CreateRecipeStepItemComponent } from './Components/step-item/create-recipe-step-item.component';

@NgModule({
    imports: [
        CommonModule,
        CreateRecipePageRoutingModule,
        MatChipsModule,
        FormsModule,
        MatFormFieldModule,
        MatInputModule,
        MatCardModule,
        MatButtonModule,
        MatListModule,
        MatIconModule
    ],
    declarations: [
        CreateRecipePageComponent,
        CreateRecipeIngredientItemComponent,
        CreateRecipeStepItemComponent
    ]
})
export class CreateRecipePageModule {}