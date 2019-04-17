using System.Web.Mvc;


namespace Susen.SourceProject.Services.Controllers
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
