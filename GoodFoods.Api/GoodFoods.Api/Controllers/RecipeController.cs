using GoodFoods.Api.BusinessLogic;
using GoodFoods.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodFoods.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        public IActionResult AddNewRecipe(RecipeModel recipeModel)
        {
            var businessLogic = new RecipeBusinessLogic();
            businessLogic.SaveRecipe(recipeModel);

            return Ok();
        }
    }
}
