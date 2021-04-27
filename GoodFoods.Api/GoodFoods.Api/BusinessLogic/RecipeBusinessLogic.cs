using GoodFoods.Api.DataAccess;
using GoodFoods.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodFoods.Api.BusinessLogic
{
    public class RecipeBusinessLogic
    {
        public void SaveRecipe(RecipeModel recipeModel)
        {
            //Validate info

            var dataAccess = new RecipeDataAccess();
            dataAccess.SaveRecipeToDatabase(recipeModel);
        }
    }
}
