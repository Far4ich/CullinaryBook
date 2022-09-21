import { Component, Input, OnInit, Output, EventEmitter } from "@angular/core";
import { RecipeDto } from "src/app/Dto/recipeDto";

@Component({
    selector: 'recipe-item',
    templateUrl: 'recipe-item.component.html',
    styleUrls: ['../../../../../assets/styles/recipe-item.css']
})

export class RecipeItemComponent implements OnInit{
    
    @Input() public recipe!: RecipeDto;
    @Input() public liked!: boolean;
    @Input() public favorited!: boolean;

    @Output() public like = new EventEmitter<RecipeDto>();
    @Output() public favorite = new EventEmitter<RecipeDto>();

    likeClicked(): void
    {
        this.liked = !this.liked;
        this.like.emit(this.recipe);
    }

    favoriteClicked(): void
    {
        this.favorited = !this.favorited;
        this.favorite.emit(this.recipe);
    }

    ngOnInit(): void {} 
}