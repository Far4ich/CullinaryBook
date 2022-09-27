import { IngredientDto } from "./ingredientDto";
import { StepDto } from "./stepDto";
import { TagDto } from "./tagDto";

export interface RecipeEditDto{
    id?: number;
    title: string;
    description: string;
    cookingMinutes: number;
    numberOfServings: number;
    image: Blob | null;
    authorId: number;
    tags: TagDto[];
    ingredients: IngredientDto[];
    steps: StepDto[];
}