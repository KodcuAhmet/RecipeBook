using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeBook.ServiceLibrary.Domains;
using RecipeBook.ServiceLibrary.Entities;

namespace RecipeBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        [HttpGet("{recipeId}")] //api/recipe/{recipeId}
        public async Task<IActionResult> GetOnceAsync(
            [FromRoute]Guid recipeId)
        {
            return Ok(recipeId);
        }

        [HttpGet] // api/recipe?pageSize=10&pageNumber=1
        public async Task<IActionResult> GetListAsync(
            [FromQuery]int pageSize,
            [FromQuery]int pageNumber)
        {
            return Ok(pageSize + " " + pageNumber);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(
            [FromBody] RecipeEntity recipe)
        {
            return Ok(recipe);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync([FromBody] RecipeEntity recipe)
        {
            return Ok(recipe);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(Guid recipeId)
        {
            return Ok(recipeId);
        }
    }
}
