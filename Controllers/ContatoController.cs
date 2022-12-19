using Contact_Management_Web_application.Models;
using Contact_Management_Web_application.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Contact_Management_Web_application.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }

        public IActionResult Index()
        {
            var contotatos = _contatoRepositorio.BuscarTodos();
            return View(contotatos);
        }

        public IActionResult Editar(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }

        [HttpPost]
        public IActionResult Alterar(ContatoModel contato)
        {
            _contatoRepositorio.Atualizar(contato);
            return RedirectToAction("Index");
        }

        public IActionResult Apagar(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
            
        }

        public IActionResult excluir(int id)
        {
            _contatoRepositorio.excluir(id);
            return RedirectToAction("Index");
        }
    }
}
