import { Component, OnInit } from "@angular/core";
import { Location } from '@angular/common';
import { RecipeEditDto } from "src/app/Dtos/recipeEditDto";
import { MatChipInputEvent } from '@angular/material/chips'
import { COMMA, ENTER } from '@angular/cdk/keycodes';
import { TagDto } from "src/app/Dtos/tagDto";
import { OptionNumber } from "../../Shared/option-number";
import { IngredientDto } from "src/app/Dtos/ingredientDto";
import { StepDto } from "src/app/Dtos/stepDto";
import { RecipeService } from "src/app/Services/recipe.service";

@Component({
    templateUrl:'./create-recipe-page.component.html',
    styleUrls: ['../../../../../assets/styles/create-recipe-page.css'],
    providers: [RecipeService]
})

export class CreateRecipePageComponent implements OnInit{
    readonly separatorKeysCodes = [ENTER, COMMA] as const;

    constructor(private _location: Location) {}

        
    ngOnInit(): void {}

    backClicked() {
        this._location.back();
    }

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

    recipe: RecipeEditDto = {
        title: "",
        description: "",
        cookingMinutes: 0,
        numberOfServings: 0,
        image: "",
        authorId: 5,
        tags: [],
        ingredients: [
            {
                title: "",
                orderNumber: 1,
                products: ""
            }
        ],
        steps: [
            {
                orderNumber: 1,
                description: ""
            }
        ]
    };

    addTag(event: MatChipInputEvent): void {
        const value = (event.value || '').trim();

        if (value) {
          this.recipe.tags.push({title: value});
        }

        event.chipInput!.clear();
      }
    
    removeTag(tag: TagDto): void {
        const index = this.recipe.tags.indexOf(tag);

        if (index >= 0) {
            this.recipe.tags.splice(index, 1);
        }
    }

    addIngredient(): void
    {
        this.recipe.ingredients.push(
            {
                title: "",
                orderNumber: this.recipe.ingredients[this.recipe.ingredients.length - 1].orderNumber + 1,
                products: ""
            }
        )
    }

    removeIngredient(ingredient: IngredientDto): void
    {
        const ingredientsLength = this.recipe.ingredients.length;
        if (ingredientsLength > 1)
        {
            const index = this.recipe.ingredients.indexOf(ingredient);
            this.recipe.ingredients.splice(index, 1);
            var i:number; 
            for(i = index;i <= ingredientsLength - 2;i++)
            {
                this.recipe.ingredients[i].orderNumber--;
            }
        }
    }

    addStep(): void
    {
        this.recipe.steps.push(
            {
                orderNumber: this.recipe.steps[this.recipe.steps.length - 1].orderNumber + 1,
                description: ""
            }
        )
    }

    removeStep(step: StepDto): void
    {
        const stepsLength = this.recipe.steps.length;
        if (stepsLength > 1)
        {
            const index = this.recipe.steps.indexOf(step);
            this.recipe.steps.splice(index, 1);
            var i:number; 
            for(i = index;i <= stepsLength - 2;i++)
            {
                this.recipe.steps[i].orderNumber--;
            }
        }
    }
}