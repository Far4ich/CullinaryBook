﻿namespace Domain.RecipeEntity
{
    public class Step
    {
        public Step(int id, int order, string description, int recipeId, Recipe recipe)
        {
            Id = id;
            Order = order;
            Description = description;
            RecipeId = recipeId;
            Recipe = recipe;
        }

        public int Id { get; private set; }
        public int Order { get; private set; }
        public string Description { get; private set; }

        public int RecipeId { get; private set; }
        public Recipe Recipe { get; private set; }
    }
}
