using Contact_Management_Web_application.Models;
using Contact_Management_Web_application.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Contact_Management_Web_application.Controllers
{
    public class AdicionarContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public AdicionarContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Adicionar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Adicionar(ContatoModel contato) 
        {
          _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Adicionar");
        }
    }
}
