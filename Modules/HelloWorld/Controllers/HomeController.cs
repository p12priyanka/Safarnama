using System.Web.Mvc;
using Orchard.Themes;

namespace HelloWorld.Controllers
{
    [Themed]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("HelloWorld");
        }
    }
}
