import { TagDto } from "./tagDto";

export interface RecipeDto{
    id: number;
    title: string;
    description: string;
    cookingMinutes: number;
    numberOfServings: number;
    image: string;
    authorId: number;
    tags: TagDto[];
    countOfLikes: number;
    countOfFavorites: number;
}