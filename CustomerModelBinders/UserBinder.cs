using LearningScripts.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace LearningScripts.CustomerModelBinders
{
    public class UserBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            UserProfile userProfile = new UserProfile();
            //UserName
            if (bindingContext.ValueProvider.GetValue("FirstName").Length > 0)
            {
                userProfile.UserName = bindingContext.ValueProvider.GetValue("FirstName").FirstValue;

                if (bindingContext.ValueProvider.GetValue("LastName").Length > 0)
                {
                    userProfile.UserName += " " + bindingContext.ValueProvider.GetValue("LastName").FirstValue;
                }
            }

            //Email
            if (bindingContext.ValueProvider.GetValue("Email").Length > 0)
            {
                userProfile.Email = bindingContext.ValueProvider.GetValue("Email").FirstValue;
            }

            //Phone
            if (bindingContext.ValueProvider.GetValue("Phone").Length > 0)
            {
                userProfile.Phone = bindingContext.ValueProvider.GetValue("Phone").FirstValue;
            }

            //Password
            if (bindingContext.ValueProvider.GetValue("Password").Length > 0)
            {
                userProfile.Password = bindingContext.ValueProvider.GetValue("Password").FirstValue;
            }

            //ConfirmPassword
            if (bindingContext.ValueProvider.GetValue("ConfirmPassword").Length > 0)
            {
                userProfile.ConfirmPassword = bindingContext.ValueProvider.GetValue("ConfirmPassword").FirstValue;
            }

            //Price
            if (bindingContext.ValueProvider.GetValue("Price").Length > 0)
            {
                userProfile.Price = Convert.ToDouble(bindingContext.ValueProvider.GetValue("Price").FirstValue);
            }

            //DateOfBirth
            if (bindingContext.ValueProvider.GetValue("DateOfBirth").Length > 0)
            {
                userProfile.DateOfBirth = Convert.ToDateTime(bindingContext.ValueProvider.GetValue("DateOfBirth").FirstValue);
            }


            bindingContext.Result = ModelBindingResult.Success(userProfile);
            return Task.CompletedTask;
        }
    }
}
