using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AccountManagement.Controllers
{
    public class CurrencyConverterController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
