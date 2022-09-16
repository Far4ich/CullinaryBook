import { Component, Input } from "@angular/core";
import { RecipeDto } from "src/app/Dto/recipeDto";

@Component({
    selector: 'recipe-item',
    templateUrl: 'recipe-item.component.html',
    styleUrls: ['../../../../../assets/styles/recipe-item.css']
})

export class RecipeItemComponent { 
    @Input() public recipe!: RecipeDto;
    @Input() public liked: boolean = false;
    @Input() public favorited: boolean = false;
}