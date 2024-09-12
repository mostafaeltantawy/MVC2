using Microsoft.AspNetCore.Mvc;
using MVC2.Models;

namespace MVC2.Controllers
{
    // In mvc Controller there is only two methods in browser only get & post that allowed in html
    public class MoviesController : Controller
    {
        private readonly IConfiguration _configuration;
        public MoviesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Action : Public non-static Object member method inside the controller
        //[HttpGet] // Get: baseUrl/Movies/Index
        //public string Index() //Master action
        //{
        //    return "All Movies";
        //}


        // Model Value Provider
        // Form Data -> Input
        // Route Data -> segment
        // Query string -> Query param 
        // Request Header - > Header ---> Only work with attribute [FromHeader]
        // Request body ->  with complex object JSON or xml

        [HttpGet]
        // baseURL/Movies/GetMovies/{id}

        public IActionResult GetMovie(int id)
        {
            if (id == 0)
                return new BadRequestResult();

            ContentResult result = new ContentResult();
            result.Content = $"<h1>Id = {id} </h1>";
            return result;


        }

        /*   [HttpPost]*/ // POST : baseULR/Movies/Create

        //public IActionResult CreateMovie(Movie movie)
        //{
        //    return Ok();
        //}

        [HttpPost]
        public IActionResult CreateMovie(Movie movie)
        {
            return Ok();
        }




    }
}








