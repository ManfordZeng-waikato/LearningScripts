
namespace LearningScripts.CustomMiddleware
{
    public class MycustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("My custom middleware - Starts\n");
            await next(context);
            await context.Response.WriteAsync("My custom middleware - Ends\n");
        }
    }

    public static class CustomMiddlewareExtension
    {
        public static IApplicationBuilder UseMyCustomMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<MycustomMiddleware>();
        }
    }
}
