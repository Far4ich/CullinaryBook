import { Component, Input } from "@angular/core";
import { SearchTag } from "../../Shared/recipe-search-tag";

@Component({
    selector: 'recipe-search-tag',
    templateUrl: 'recipe-search-tag.component.html',
    styleUrls: ['../../../../../assets/styles/recipe-search-tag.css']
})

export class RecipeSearchTagComponent { 
    @Input() public tag!: SearchTag;
}