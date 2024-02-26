using crudCliente.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudClientes.Models
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }

    }

}