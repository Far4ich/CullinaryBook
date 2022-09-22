import { Component, OnInit } from "@angular/core";
import { FavoriteDto } from "src/app/Dto/favoriteDto";
import { LikeDto } from "src/app/Dto/likeDto";
import { RecipeDto } from "src/app/Dto/recipeDto";
import { SearchTag } from "src/app/Modules/MainPage/Shared/recipe-search-tag";
import { RecipeService } from "src/app/Services/recipe.service";
import { UserService } from "src/app/Services/user.service";
import { Tag } from "../../Shared/tag";

@Component({
    templateUrl:'./recipes-page.component.html',
    styleUrls: ['../../../../../assets/styles/recipes-page.css']
})

export class RecipesPageComponent implements OnInit{
    public RecipesDownloadCount = 2;
    public userId: number = 1;

    public recipes: RecipeDto[] = [];
    public visibleRecipes: RecipeDto[] = [];
    public likes: LikeDto[] = [];
    public favorites: FavoriteDto[] = [];
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
    public searchTags: SearchTag[] = [
        {
            title: "Мясо"
        },
        {
            title: "Деликатесы"
        },
        {
            title: "Пироги"
        },
        {
            title: "Рыба"
        },
        {
            title: "пост"
        },
        {
            title: "пасха2021"
        }
    ]

    constructor(private recipeService: RecipeService,
        private userService: UserService)
    {}
    
    ngOnInit(): void {
        this.refreshRecipes();
        this.refreshLikes();
        this.refreshFavorites();
    }

    public refreshRecipes(): void
    {
        this.recipeService.getRecipes().subscribe(recipes => {
            this.recipes = recipes;
            this.AddVisibleRecipes();
        })
        
    }

    public AddVisibleRecipes(): void
    {
        this.recipes.splice(0, this.RecipesDownloadCount).forEach(r => this.visibleRecipes.push(r));
    }

    public refreshLikes(): void
    {
        this.userService.getLikes(this.userId).subscribe(likes => {
            this.likes = likes;
        })
    }

    public refreshFavorites(): void
    {
        this.userService.getFavorites(this.userId).subscribe(favorites => {
            this.favorites = favorites;
        })
    }
    
    public likeClicked(recipe: RecipeDto): void
    {
        let like: LikeDto | undefined;
        like = this.likes.find(x => x.recipeId == recipe.id)
        if (like != undefined)
        {
            this.recipes[this.recipes.indexOf(recipe)].countOfLikes--;
            this.likes.splice(this.likes.indexOf(like), 1);
            this.recipeService.removeLike(like).subscribe();
        }
        else
        {
            like = {recipeId: recipe.id, userId: this.userId}
            this.recipes[this.recipes.indexOf(recipe)].countOfLikes++;
            this.likes.push(like);
            this.recipeService.addLike(like).subscribe();
        }
    }

    public favoriteClicked(recipe: RecipeDto): void
    {
        let favorite: FavoriteDto | undefined;
        favorite = this.favorites.find(x => x.recipeId == recipe.id)
        if (favorite != undefined)
        {
            this.recipes[this.recipes.indexOf(recipe)].countOfFavorites--;
            this.favorites.splice(this.favorites.indexOf(favorite), 1);
            this.recipeService.removeFavorite(favorite).subscribe();
        }
        else
        {
            favorite = {recipeId: recipe.id, userId: this.userId}
            this.recipes[this.recipes.indexOf(recipe)].countOfFavorites++;
            this.favorites.push(favorite);
            this.recipeService.addFavorite(favorite).subscribe();
        }
    }

    public isLiked(recipeId: number | undefined): boolean
    {
        if (recipeId != undefined)
        {
            if (this.likes.find(x => x.recipeId == recipeId) != undefined)
            {
                return true;
            }
        }
        return false;
    }

    public isFavorited(recipeId: number | undefined): boolean
    {
        if (recipeId != undefined)
        {
            if (this.favorites.find(x => x.recipeId == recipeId) != undefined)
            {
                return true;
            }
        }
        return false;
    }
}