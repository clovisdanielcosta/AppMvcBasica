using AppMvcBasica.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppMvcBasica.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        DbSet<Produto> Produtos { get; set; }
        DbSet<Fornecedor> Fornecedores { get; set; }
        DbSet<Endereco> Enderecos { get; set; }

    }
}