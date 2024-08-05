using Microsoft.EntityFrameworkCore;
using ProductAPI.Domains;
using System.Buffers.Text;

namespace ProductAPI.Contexts
{
    public class Context : DbContext
    {
        //Definindo as entidades do banco de dados

        public DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE17-S21\\SQLSERVER; Database=ProductAPI; User Id=sa; Password=Senai@134; TrustServerCertificate=True;");
        }
    }
}
