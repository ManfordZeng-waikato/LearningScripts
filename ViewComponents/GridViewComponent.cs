using LearningScripts.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningScripts.ViewComponents
{
    public class GridViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            BookGridModel bookGridModel = new BookGridModel()
            {
                GridTitle = "Books List",
                Books = new List<Book>()
                {
                    new Book (){ BookId=1,Author="Manford", AuthorGender= Book.Gender.Male},
                    new Book (){ BookId=2,Author="Manf0rd", AuthorGender= Book.Gender.Female},
                    new Book (){ BookId=3,Author="Chang", AuthorGender= Book.Gender.Male},
                    new Book (){ BookId=4,Author="Wenji", AuthorGender= Book.Gender.Other}
                }
            };
            //Viwes/Shared/Components/Grid/Default.cshtml
            return View(bookGridModel);
        }
    }
}
