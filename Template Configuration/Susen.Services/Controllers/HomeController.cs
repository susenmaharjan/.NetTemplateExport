using System.Web.Mvc;


namespace $safeprojectname$.Controllers
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
