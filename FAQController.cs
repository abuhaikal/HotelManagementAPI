using Microsoft.AspNetCore.Mvc;

namespace HotelManagementAPI.Controllers
{
    public class FAQController : Controller
    {
        // GET: FAQ
        public IActionResult Index()
        {
            return View();
        }
    }
}