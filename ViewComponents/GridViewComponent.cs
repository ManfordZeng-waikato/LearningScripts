using LearningScripts.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningScripts.ViewComponents
{
    public class GridViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(BookGridModel grid)
        {
            //Viwes/Shared/Components/Grid/Default.cshtml
            return View(grid);
        }
    }
}
