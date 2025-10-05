namespace LearningScripts
{

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

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
            app.Run(async (HttpContext context) =>
            {
                await context.Response.WriteAsync("hello");



            });
            app.Run();
        }
    }
}


