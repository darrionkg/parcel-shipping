using Microsoft.AspNetCore.Mvc;

namespace ParcelsShippingStore.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
    }
}
