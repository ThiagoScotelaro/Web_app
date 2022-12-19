using Contact_Management_Web_application.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Contact_Management_Web_application.Controllers
{
    public class DetalhesContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public DetalhesContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Detalhes()
        {
            var contotatos = _contatoRepositorio.BuscarTodos();
            return View(contotatos);
        }
    }
}
