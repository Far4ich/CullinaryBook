import { Component, OnInit } from "@angular/core";
import { Location } from '@angular/common';
import { RecipeDto } from "src/app/Dtos/recipeDto";
import { MatChipInputEvent } from '@angular/material/chips'
import { COMMA, ENTER } from '@angular/cdk/keycodes';
import { TagDto } from "src/app/Dtos/tagDto";
import { OptionNumber } from "../../Shared/option-number";

@Component({
    templateUrl:'./create-recipe-page.component.html',
    styleUrls: ['../../../../../assets/styles/create-recipe-page.css']
})

export class CreateRecipePageComponent implements OnInit{
    readonly separatorKeysCodes = [ENTER, COMMA] as const;

    numberOfServingsOptions: OptionNumber[] = [
        {value: 1, viewValue: '1'},
        {value: 2, viewValue: '2'},
        {value: 3, viewValue: '3'},
        {value: 4, viewValue: '4'},
        {value: 5, viewValue: '5'},
        {value: 6, viewValue: '6'},
    ]

    cookingMinutesOptions: OptionNumber[] = [
        {value: 10, viewValue: '10'},
        {value: 15, viewValue: '15'},
        {value: 30, viewValue: '30'},
        {value: 60, viewValue: '60'},
        {value: 120, viewValue: '120'},
        {value: 180, viewValue: '180'},
      ];

    recipe: RecipeDto = {
        title: "",
        description: "",
        cookingMinutes: 0,
        numberOfServings: 0,
        image: "",
        authorId: 5,
        tagDtos: [],
        ingredientDtos: [
            {
                title: "",
                orderNumber: 1,
                products: ""
            }
        ],
        stepDtos: [
            {
                orderNumber: 1,
                description: ""
            }
        ]
    };

    addTag(event: MatChipInputEvent): void {
        const value = (event.value || '').trim();

        if (value) {
          this.recipe.tagDtos.push({title: value});
        }

        event.chipInput!.clear();
      }
    
    removeTag(tag: TagDto): void {
        const index = this.recipe.tagDtos.indexOf(tag);

        if (index >= 0) {
            this.recipe.tagDtos.splice(index, 1);
        }
    }

    constructor(private _location: Location) {}

    ngOnInit(): void {}

    backClicked() {
        this._location.back();
    }

    
}