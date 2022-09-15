import { Injectable } from "@angular/core";
import { RecipeEditDto } from "../Dto/recipeEditDto";
import { Observable } from "rxjs";
import { HttpClient } from "@angular/common/http";
import { RecipeDto } from "../Dto/recipeDto";
import { RecipeBestDto } from "../Dto/recipeBestDto";

@Injectable()
export class RecipeService {
    private readonly apiUrl: string = 'http://localhost:4200/api/recipe';

    constructor(private httpClient: HttpClient) {
    }

    public getRecipe(recipeId: number) : Observable<RecipeEditDto>
    {
        return this.httpClient.get<RecipeEditDto>(`${this.apiUrl}/${recipeId}`);
    }

    public addRecipe(recipeEditDto: RecipeEditDto): Observable<null> {
        return this.httpClient.post<null>(`${this.apiUrl}/create`, recipeEditDto);
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

    public getBestRecipe(): Observable<RecipeBestDto> {
        return this.httpClient.get<RecipeBestDto>(`${this.apiUrl}/best-recipe`);
    }
}