﻿namespace Domain.Ingredient
{
    public interface IIngredientRepository
    {
        Ingredient Get(int id);
        void Create(Ingredient ingredient);
        void Update(Ingredient ingredient);
        void Delete(Ingredient ingredient);
    }
}