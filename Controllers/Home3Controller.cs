using LearningScripts.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningScripts.Controllers
{
    public class Home3Controller : Controller
    {
        [Route("home")]
        public IActionResult Index()
        {
            ViewData["appTitle"] = "ASP.NET CORE APP";
            List<Book> books = new List<Book>()
            {
             new Book() {BookId=3, Author= "Manford",AuthorGender= Book.Gender.Male, ReleaseDate=DateTime.Parse ("2001-09-15")},
             new Book() {BookId=2, Author= "Wenji",AuthorGender= Book.Gender.Female, ReleaseDate=DateTime.Parse ("2003-09-15")},
             new Book() {BookId=1, Author= "Manf0rd",AuthorGender= Book.Gender.Other,ReleaseDate=DateTime.Parse ("2002-09-15")},
             };
            ViewData["books"] = books;

            //views/Home/Index.cshtml
            return View();

            //abc.cshtnl
            //return View("abc");
        }
    }
}
