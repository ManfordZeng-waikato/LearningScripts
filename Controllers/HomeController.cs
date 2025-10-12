using LearningScripts.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningScripts.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ContentResult method1()
        {

            //return new ContentResult()
            //{
            //    Content = "Hello from method1",
            //    ContentType = "text/plain"
            //};
            return Content("Hello from method1", "text/plain");

        }

        [Route("person")]
        public JsonResult person()
        {
            Person person = new Person() { Id = Guid.NewGuid(), FirstName = "Manford", Age = 25, LastName = "Zeng" };
            return Json(person);

        }

        [Route("file-download")]
        //for files inside folder wwwroot
        public VirtualFileResult FileDownload()
        {
            Person person = new Person() { Id = Guid.NewGuid(), FirstName = "Manford", Age = 25, LastName = "Zeng" };
            return File("/hashes.txt", "text/txt");

        }

        [Route("file-download2")]
        //for files outside folder wwwroot
        public PhysicalFileResult FileDownload2()
        {
            return PhysicalFile("D:\\Projects\\ASP.NET\\LearningScripts\\CV-Manford Zeng.pdf", "application/pdf");

        }

        [Route("file-download3")]
        //for request from the byte
        public FileContentResult FileDownload3()
        {
            byte[] bytes =
                System.IO.File.ReadAllBytes("D:\\Projects\\ASP.NET\\LearningScripts\\CV-Manford Zeng.pdf");
            return File(bytes, "application/pdf");

        }

    }

}
