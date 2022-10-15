using Microsoft.AspNetCore.Mvc;

namespace CareProWeb.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
