using Microsoft.AspNetCore.Mvc;

namespace Deco.Controllers
{
    public class AdministrativoController : Controller
    {
        public IActionResult Triagem()
        {
            return View();
        }
    }
}
