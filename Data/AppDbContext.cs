using OliCook.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OliCook.Data;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
{    
}

public DbSet<Categoria> Categorias { get; set; }
public DbSet<Comentario> Comentatios { get; set; }
public DbSet<Ingrediente> Ingredientes { get; set; }
public DbSet<Receita> Receitas { get; set; }
public DbSet<ReceitaIngrediente> ReceitaIngredientes { get; set; }
public DbSet<Usuario> Usuarios { get; set; }


protected override voide OnModelCreating(ModelBuilder builder)

{
    base.OnModelCreating(builder);
    AppDbSeed seed = new(builder);

    builder.Entity<ReceitaIngredientes>()
    .Haskey(ri => new { ri.ReceitaId, ri.IngredienteId});

}
}