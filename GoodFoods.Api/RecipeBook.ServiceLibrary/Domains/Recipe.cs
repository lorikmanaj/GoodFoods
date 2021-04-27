﻿using RecipeBook.ServiceLibrary.Entities;
using RecipeBook.ServiceLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeBook.ServiceLibrary.Domains
{
    public class Recipe
    {
        public void SaveRecipe(RecipeEntity recipeEntity)
        {
            //Validate info

            var repository = new RecipeRepository();
            repository.SaveRecipeToDatabase(recipeEntity);
        }
    }
}
