using System;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFinalBack;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Clase> Clases { get; set; }
    public DbSet<Socio> Socios { get; set; }
}

