import { IngredientDto } from "./ingredientDto";
import { StepDto } from "./stepDto";
import { TagDto } from "./tagDto";

export interface RecipeDto{
    id?: number;
    title: string;
    description: string;
    cookingMinutes: number;
    numberOfServings: number;
    image: string;
    authorId: number;
    tagDtos: TagDto[];
    ingredientDtos: IngredientDto[];
    stepDtos: StepDto[];
}