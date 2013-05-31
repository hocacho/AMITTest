using System.Web.Mvc;

namespace AMITTest.Controllers
{
    public class DefaultController : Controller
    {
        //
        // GET: /Default/

        public ActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public ActionResult Display(string inputText)
		{
			ViewBag.displayText = inputText;
			return View();
		}
    }
}
