using Microsoft.AspNetCore.Mvc;

namespace HotelManagementAPI.Controllers
{
    public class AboutUsController : Controller
    {
        // GET: AboutUs
        public IActionResult Index()
        {
            return View();
        }
    }
}
