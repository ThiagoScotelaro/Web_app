using Microsoft.AspNetCore.Mvc;

namespace Contact_Management_Web_application.Controllers
{
    public class AdicionarContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Adicionar()
        {
            return View();
        }
    }
}
