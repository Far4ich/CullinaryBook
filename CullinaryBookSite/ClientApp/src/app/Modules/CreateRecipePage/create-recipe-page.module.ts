import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MatCardModule } from "@angular/material/card";
import { MatButtonModule } from "@angular/material/button";
import { MatListModule } from "@angular/material/list";
import { MatIconModule } from "@angular/material/icon";
import { MatFormFieldModule } from "@angular/material/form-field";
import { MatInputModule } from "@angular/material/input";

import { CreateRecipePageComponent } from './Components/page/create-recipe-page.component';
import { CreateRecipePageRoutingModule } from './create-recipe-page-routing.module';

@NgModule({
    imports: [
        CommonModule,
        CreateRecipePageRoutingModule,
        MatFormFieldModule,
        MatInputModule,
        MatCardModule,
        MatButtonModule,
        MatListModule,
        MatIconModule
    ],
    declarations: [
        CreateRecipePageComponent
    ]
})
export class CreateRecipePageModule {}