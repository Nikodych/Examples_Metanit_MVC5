using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class BookShopController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}