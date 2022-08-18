﻿namespace Domain.RecipeEntity
{
    public class Tag
    {
        public Tag(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }

        public List<RecipeTag> RecipeTag { get; set; } = new();
        public List<Recipe> Recipe { get; set; } = new();
    }
}
