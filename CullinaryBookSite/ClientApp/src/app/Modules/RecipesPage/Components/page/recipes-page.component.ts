import { Component } from "@angular/core";
import { RecipeDto } from "src/app/Dto/recipeDto";
import { Tag } from "../../Shared/tag";

@Component({
    templateUrl:'./recipes-page.component.html',
    styleUrls: ['../../../../../assets/styles/recipes-page.css']
})

export class RecipesPageComponent{
    public tags: Tag[] = [
        {
            title: "Простые блюда",
            picture: "../../../../assets/images/ic-menu.svg"
        },
        {
            title: "Детское",
            picture: "../../../../assets/images/ic-cook.svg"
        },
        {
            title: "От шеф-поваров",
            picture: "../../../../assets/images/ic-chef.svg"
        },
        {
            title: "На праздник",
            picture: "../../../../assets/images/holiday.svg"
        }
    ];

    public recipes: RecipeDto[] = 
    [
        {
            title: "Клубничная панна-котта",
            description: "Десерт, который невероятно легко и быстро готовится. Советую подавать его порционно в красивых бокалах, украсив взбитыми сливками, свежими ягодами и мятой.",
            cookingMinutes: 35,
            numberOfServings: 5,
            image: "../../../../../assets/images/test-recipe-img.png",
            authorId: 1,
            tags: [
                {
                    title: "десерты"
                },
                {
                    title: "клубника"
                },
                {
                    title: "сливки"
                }
            ],
            countOfLikes: 8,
            countOfFavorites: 10
        }
    ];
}