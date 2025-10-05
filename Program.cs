namespace LearningScripts
{

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //builder.Services.AddTransient<MycustomMiddleware>();

            var app = builder.Build();
            //useWhen example
            app.UseWhen(
                context => context.Request.Query.ContainsKey("username"),
                app =>
                {
                    app.Use(async (context, next) =>
                    {
                        await context.Response.WriteAsync("Hello from Middleware branch\n");
                        next();
                    });
                }
                );

            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello from Main branch\n");
            });

            //HTTP Requests and Responses

            // app.Run(async (HttpContext context) =>
            //{
            //context.Response.Headers["Content-type"] = "text/html";
            //if (context.Request.Headers.ContainsKey("AuthorizationKey"))
            //{
            //    string auth = context.Request.Headers["AuthorizationKey"];
            //    await context.Response.WriteAsync($"<p>{auth}</p>");
            //}


            //string path = context.Request.Path;
            //context.Response.Headers["Content-type"] = "text/html";
            //await context.Response.WriteAsync($"<p>{path}</p>");

            //    StreamReader reader = new StreamReader(context.Request.Body);
            //    string body = await reader.ReadToEndAsync();

            //    Dictionary<string, StringValues> queryDict =
            //    Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(body);

            //    if (queryDict.ContainsKey("firstName"))
            //    {
            //        string firstName = queryDict["firstName"][0];
            //        context.Response.WriteAsync($"<p>{firstName}</p>");

            //    }

            //});

            //MiddlewareExample
            //Middleware1
            //app.Use(async (HttpContext context, RequestDelegate next) =>
            //{
            //    await context.Response.WriteAsync("hello\n");
            //    await next(context);
            //});

            //Middleware2
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("hello");
            //    await next();
            //});
            //app.UseMiddleware<MycustomMiddleware>();
            //app.UseMyCustomMiddleware();
            //app.UseHelloCustomMiddleware();

            //Middleware3
            //app.Run(async (HttpContext context) =>
            //{
            //    await context.Response.WriteAsync("hello again\n");
            //});

            app.Run();
        }
    }
}


