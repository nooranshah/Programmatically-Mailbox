using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class MailBoxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
