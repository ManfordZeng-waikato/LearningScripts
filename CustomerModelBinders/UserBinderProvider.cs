using LearningScripts.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace LearningScripts.CustomerModelBinders
{
    public class UserBinderProvider : IModelBinderProvider
    {
        public IModelBinder? GetBinder(ModelBinderProviderContext context)
        {
            if (context.Metadata.ModelType == typeof(UserProfile))
            {
                return new BinderTypeModelBinder(typeof(UserBinder));
            }
            return null;
        }
    }
}
