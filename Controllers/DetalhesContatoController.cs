using Microsoft.AspNetCore.Mvc;

namespace Contact_Management_Web_application.Controllers
{
    public class DetalhesContatoController : Controller
    {
        public IActionResult Detalhes()
        {
            return View();
        }
    }
}
