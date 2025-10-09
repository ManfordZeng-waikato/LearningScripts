using Microsoft.AspNetCore.Mvc;

namespace LearningScripts.Controllers
{
    public class HomeController2 : Controller
    {
        [Route("bookstore")]
        public IActionResult Index()
        {
            if (!Request.Query.ContainsKey("bookid"))
            {
                return BadRequest("Book ID is not supplied");
            }

            if (string.IsNullOrEmpty(Convert.ToString(Request.Query["bookid"])))
            {
                return BadRequest("book id can't be null or empty");
            }

            int bookId = Convert.ToInt32(ControllerContext.HttpContext.Request.Query["bookid"]);
            if (bookId <= 0)
            {
                return BadRequest("Book id can't be less or equal to zero");
            }
            if (bookId > 1000)
            {
                return BadRequest("Book Id can't greater  than 1000");
            }
            if (Convert.ToBoolean(Request.Query["isloggedin"]) == false)
            {
                return Unauthorized("User must be authenticated");
            }

            //302-found
            return RedirectToAction("Books", "Store", new { id = bookId });
            //return LocalRedirect($"store/books/{bookId}");
            //return Redirect($"store/books/{bookId}");

            //301-moved permanently
            //return RedirectToActionPermanent("Books", "Store", new { id = bookId });
            //return LocalRedirectPermanent($"store/books/{bookId}");
            //return RedirectPermanent($"store/books/{bookId}");



        }
    }
}
