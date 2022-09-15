import { Component, Input, OnInit, Output, EventEmitter } from "@angular/core";
import { IngredientDto } from "src/app/Dto/ingredientDto";
import { RecipeService } from "src/app/Services/recipe.service";

@Component({
    selector: 'app-ingredient-item',
    templateUrl:'./create-recipe-ingredient-item.component.html',
    styleUrls: ['../../../../../assets/styles/create-recipe-ingredient-item.css'],
    providers: [RecipeService]
})

export class CreateRecipeIngredientItemComponent implements OnInit {
    @Input() ingredient!: IngredientDto;
    @Output() delete = new EventEmitter<IngredientDto>();  

    ngOnInit(): void {}

    deleteClicked(): void 
    {
        this.delete.emit(this.ingredient);
    }
}