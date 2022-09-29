import { Component, Input } from "@angular/core";
import { SearchTag } from "../../Shared/recipe-search-tag";

@Component({
    selector: 'app-recipe-search',
    templateUrl:'./recipe-search.component.html',
    styleUrls: ['../../../../../assets/styles/recipe-search.css']
})

export class RecipeSearchComponent{
    @Input() public prewiewTags: SearchTag[]=[];
}