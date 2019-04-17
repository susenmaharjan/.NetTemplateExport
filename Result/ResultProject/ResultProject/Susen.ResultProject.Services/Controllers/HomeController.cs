using System.Web.Mvc;
using Susen.ResultProject.Common.Extensions;


namespace Susen.ResultProject.Services.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string testData = "TestColumn";
            string result = testData.ToCamelCaseColumnName();
            ViewBag.Title = result;

            return View();
        }
    }
}
