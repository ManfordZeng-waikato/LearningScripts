using Microsoft.AspNetCore.Mvc;

namespace LearningScripts.Controllers
{
    public class StoreController : Controller
    {
        [Route("store/books/{id}")]
        public IActionResult Books()
        {
            int id = Convert.ToInt32(Request.RouteValues["id"]);
            return Content($"Book Store{id}");
        }
    }
}
