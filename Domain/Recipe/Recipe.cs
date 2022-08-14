﻿namespace Domain.Recipe
{
    public class Recipe
    {
        public Recipe(int id, string title, string description, int cookingMinutes, int numberOfServings, string image, int authorId, User.User author)
        {
            Id = id;
            Title = title;
            Description = description;
            CookingMinutes = cookingMinutes;
            NumberOfServings = numberOfServings;
            AuthorId = authorId;
            Author = author;
            Image = image;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int CookingMinutes { get; private set; }
        public int NumberOfServings { get; private set; }
        public string Image { get; private set; }

        public int AuthorId { get; private set; }
        public User.User Author { get; private set; }
    }
}
