using Contact_Management_Web_application.Models;

namespace Contact_Management_Web_application.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel Adicionar(ContatoModel contato);
    }
}
