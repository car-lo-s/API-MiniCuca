using Microsoft.EntityFrameworkCore;
using ReceitaAPI.Models;

namespace ReceitaAPI.Context;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<Receita>? Receitas { get; set; }
    public DbSet<Usuario>? Usuarios { get; set; }
}
