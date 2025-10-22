using LearningScripts.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningScripts.Controllers
{
    public class Home1Controller : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("about-company")]
        public IActionResult About()
        {
            return View();
        }

        [Route("contact-support")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("language")]
        public IActionResult Language()
        {
            ListModel listModel = new ListModel()
            {
                ListTitle = "Language",
                ListItems = new List<string>()
                {
                "Chinese",
                "Japanese",
                "English",
                "Hindi",
                }
            };

            return PartialView("_ListPartialView", listModel);
        }

        [Route("authors-list")]
        public IActionResult LoadAuthorsList()
        {
            BookGridModel bookGridModel = new BookGridModel()
            {
                GridTitle = "Authors List",
                Books = new List<Book>()
                {
                    new Book (){ BookId=1,Author="VIM", AuthorGender= Book.Gender.Male},
                    new Book (){ BookId=2,Author="Will", AuthorGender= Book.Gender.Female},
                    new Book (){ BookId=3,Author="Ibsen", AuthorGender= Book.Gender.Male},
                    new Book (){ BookId=4,Author="Wenji", AuthorGender= Book.Gender.Other}
                }
            };
            return ViewComponent("Grid", new { grid = bookGridModel });
        }
    }
}
