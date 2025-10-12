using LearningScripts.CustomConstraints;

namespace LearningScripts
{

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(new WebApplicationOptions()
            {
                WebRootPath = "myroot"
            });
            //builder.Services.AddTransient<MycustomMiddleware>();

            //register custom custom constraints service
            builder.Services.AddRouting(options =>
            {
                options.ConstraintMap.Add("months", typeof(MonthsCustomConstraints));
            });

            //add all the controllers as services
            builder.Services.AddControllers();

            var app = builder.Build();

            //GetEndpoint Example
            //app.Use(async (context, next) =>
            //{
            //    Microsoft.AspNetCore.Http.Endpoint? endpoint = context.GetEndpoint();
            //    if (endpoint != null)
            //    {
            //        await context.Response.WriteAsync($"Endpoint:{endpoint.DisplayName}\n");
            //    }
            //    await next(context);
            //});

            //Webroot and UseStaticFiles
            app.UseStaticFiles();


            app.MapControllers();


            ////enable routing
            //app.UseRouting();

            //GetEndpoint Example   
            //app.Use(async (context, next) =>
            //{
            //    Microsoft.AspNetCore.Http.Endpoint? endpoint = context.GetEndpoint();
            //    if (endpoint != null)
            //    {
            //        await context.Response.WriteAsync($"Endpoint:{endpoint.DisplayName}\n");
            //    }
            //    await next(context);
            //});


            //creating end points
            //app.UseEndpoints(endpoints =>
            //{
            //    //endpoints.MapGet("map1", async (context) =>
            //    //{
            //    //    await context.Response.WriteAsync("in map1 now");
            //    //});

            //    //endpoints.MapPost("map2", async (context) =>
            //    //{
            //    //    await context.Response.WriteAsync("in map2 now");
            //    //});

            //    endpoints.Map("files/{filename}.{extension}", async context =>
            //    {
            //        string? fileName = Convert.ToString(context.Request.RouteValues["filename"]);
            //        string? extension = Convert.ToString(context.Request.RouteValues["extension"]);
            //        await context.Response.WriteAsync($"in files - {fileName}.{extension}");
            //    });
            //    //default parameter and  constraints example
            //    endpoints.Map("employee/profile/{employeename:length(4,7):alpha=Manford}", async context =>
            //    {
            //        string? employeeName = Convert.ToString(context.Request.RouteValues["employeename"]);
            //        await context.Response.WriteAsync($"in employee profile - {employeeName}");
            //    });

            //    endpoints.Map("products/details/{id:int?}", async context =>
            //    {
            //        if (context.Request.RouteValues.ContainsKey("id"))
            //        {
            //            int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            //            await context.Response.WriteAsync($"Products details- {id}");
            //        }
            //        else
            //        {
            //            await context.Response.WriteAsync("Products details - id is not suplied");
            //        }
            //    });

            //    //Eg: daily-digest-report/{reportdate}
            //    endpoints.Map("daily-digest-report/{reportdate:datetime}", async context =>
            //    {
            //        DateTime reportDate = Convert.ToDateTime(context.Request.RouteValues["reportdate"]);
            //        await context.Response.WriteAsync($"In daily digest report - {reportDate.ToShortDateString()}");
            //    });

            //    //Use GUID
            //    endpoints.Map("cities/{cityid:guid}", async context =>
            //    {
            //        Guid cityId = Guid.Parse(Convert.ToString(context.Request.RouteValues["cityid"])!);
            //        await context.Response.WriteAsync($"City informaton - {cityId}");
            //    });

            //    //use custom constraints class
            //    endpoints.Map("sales-report/{year:int:min(1900)}/{month:months}", async context =>
            //    {
            //        int year = Convert.ToInt32(context.Request.RouteValues["year"]);
            //        string? month = Convert.ToString(context.Request.RouteValues["month"]);

            //        if (month == "apr" || month == "jul" || month == "oct" || month == "jan")
            //        {
            //            await context.Response.WriteAsync($"sales report-{year}-{month}");
            //        }
            //        else
            //        {
            //            await context.Response.WriteAsync($"{month}is not allowed for sales report");
            //        }
            //    });
            //});




            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync($"No route matched at {context.Request.Path}");
            //});
            //useWhen example
            //app.UseWhen(
            //    context => context.Request.Query.ContainsKey("username"),
            //    app =>
            //    {
            //        app.Use(async (context, next) =>
            //        {
            //            await context.Response.WriteAsync("Hello from Middleware branch\n");
            //            next();
            //        });
            //    }
            //    );

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello from Main branch\n");
            //});

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


