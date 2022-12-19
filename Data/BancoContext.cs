using Contact_Management_Web_application.Models;
using Microsoft.EntityFrameworkCore;

namespace Contact_Management_Web_application.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<ContatoModel> Contatos { get; set;}
    }
}
