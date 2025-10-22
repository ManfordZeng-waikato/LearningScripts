using Microsoft.AspNetCore.Mvc;

namespace LearningScripts.ViewComponents
{
    public class GridViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //Viwes/Shared/Components/Grid/Default.cshtml
            return View();
        }
    }
}
