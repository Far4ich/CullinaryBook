import { Injectable } from "@angular/core";
import { RecipeEditDto } from "../Dto/recipeEditDto";
import { Observable } from "rxjs";
import { HttpClient } from "@angular/common/http";
import { RecipeDto } from "../Dto/recipeDto";
import { LikeDto } from "../Dto/likeDto";
import { FavoriteDto } from "../Dto/favoriteDto";

@Injectable()
export class RecipeService {
    private readonly apiUrl: string = '/api/recipe';

    constructor(private httpClient: HttpClient) {
    }

    public getRecipe(recipeId: number) : Observable<RecipeEditDto>
    {
        return this.httpClient.get<RecipeEditDto>(`${this.apiUrl}/${recipeId}`);
    }

    public addRecipe(recipeFormData: FormData): Observable<null> {
        return this.httpClient.post<null>(`${this.apiUrl}/create`, recipeFormData);
    }

    public updateRecipe(recipeEditDto: RecipeEditDto): Observable<null> {
        return this.httpClient.put<null>(`${this.apiUrl}/update`, recipeEditDto);
    }

    public deleteRecipe(id: number): Observable<object> {
        return this.httpClient.delete(`${this.apiUrl}/${id}/delete`);
    }

    public getRecipes(): Observable<RecipeDto[]> {
        return this.httpClient.get<RecipeDto[]>(`${this.apiUrl}/list`);
    }

    public addLike(likeDto: LikeDto): Observable<null>{
        return this.httpClient.post<null>(`${this.apiUrl}/add-like`, likeDto);
    }

    public addFavorite(favoriteDto: FavoriteDto): Observable<null>{
        return this.httpClient.post<null>(`${this.apiUrl}/add-favorite`, favoriteDto);
    }

    public removeLike(likeDto: LikeDto): Observable<object> {
        return this.httpClient.delete(`${this.apiUrl}/remove-like`, {body: likeDto});
    }

    public removeFavorite(favoriteDto: FavoriteDto): Observable<object> {
        return this.httpClient.delete(`${this.apiUrl}/remove-favorite`, {body: favoriteDto});
    }
}