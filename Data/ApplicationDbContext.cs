using ControleVendas.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ControleVendas.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Produto> produtos {get; set;} = default!;
    public DbSet<CategoriaDoProduto> categoriaDoProdutos {get; set;} = default!;
    public DbSet<Categoria> categorias {get; set;} = default!;
}
