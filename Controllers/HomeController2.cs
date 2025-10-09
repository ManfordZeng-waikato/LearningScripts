using Microsoft.AspNetCore.Mvc;

namespace LearningScripts.Controllers
{
    public class HomeController2 : Controller
    {
        [Route("bookstore/{bookid?}/{isloggedin?}")]
        //URL: /bookstore?bookid=10&isloggedin=true
        public IActionResult Index([FromQuery] int? bookid, [FromQuery] bool? isloggedin)
        {
            if (!bookid.HasValue)
            {
                return BadRequest("Book ID is not supplied or empty");
            }

            if (bookid <= 0)
            {
                return BadRequest("book id can't be less or equal to zero");
            }
            if (bookid > 1000)
            {
                return BadRequest("Book Id can't greater  than 1000");
            }
            if (isloggedin == false)
            {
                return Unauthorized("User must be authenticated");
            }

            //302-found
            return RedirectToAction("Books", "Store", new { id = bookid });
            //return LocalRedirect($"store/books/{bookId}");
            //return Redirect($"store/books/{bookId}");

            //301-moved permanently
            //return RedirectToActionPermanent("Books", "Store", new { id = bookId });
            //return LocalRedirectPermanent($"store/books/{bookId}");
            //return RedirectPermanent($"store/books/{bookId}");



        }
    }
}
