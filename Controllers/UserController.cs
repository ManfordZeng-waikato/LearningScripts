using LearningScripts.Models;
using Microsoft.AspNetCore.Mvc;
namespace LearningScripts.Controllers
{
    public class UserController : Controller
    {
        [Route("register")]

        //[Bind(nameof(UserProfile.UserName), nameof(UserProfile.Password))]

        //[ModelBinder(BinderType = typeof(UserBinder))]
        public IActionResult Index(UserProfile user, [FromHeader(Name = "User-Agent")] string UserAgent)
        {
            if (!ModelState.IsValid)
            {
                //string errors = string.Join("\n", ModelState.Values.SelectMany(value =>
                //value.Errors).Select(err => err.ErrorMessage).ToList());

                var errors = string.Join("\n",
                    from v in ModelState.Values
                    from e in v.Errors
                    select e.ErrorMessage
                    );

                //foreach (var value in ModelState.Values)
                //{
                //    foreach (var error in value.Errors)
                //    {
                //        errorList.Add(error.ErrorMessage);
                //    }
                //}
                return BadRequest(errors);
            }
            return Content($"{user},{UserAgent}");
        }
    }
}
