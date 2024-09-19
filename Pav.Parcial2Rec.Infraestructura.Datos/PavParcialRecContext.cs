using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pav.Parcial2Rec.Dominio.Entidades;
using Pav.Parcial2Rec.Infraestructura.Datos.Datos;
namespace Pav.Parcial2Rec.Infraestructura.Datos;

public class PavParcialRecContext : DbContext
{
    public const string CadenaDeConexion = "Server=(localdb)\\MSSQLLocalDB;Database=PavParcial2Rec";
    public DbSet<Mesa> Mesas { get; set; }
    public DbSet<Sector> Sectores { get; set; }
    public PavParcialRecContext(DbContextOptions<PavParcialRecContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        SectorConfig(modelBuilder);
        MesasConfig(modelBuilder);
    }

    private void SectorConfig(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sector>()
            .ToTable("Sectores");
        modelBuilder.Entity<Sector>()
            .HasData(Iniciales.Instance.Sectores.ToArray());
    }

    private void MesasConfig(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Mesa>()
            .ToTable("Mesas")
            .Property(m => m.Descripcion).HasMaxLength(100).IsRequired();
        modelBuilder.Entity<Mesa>()
            .Property(m => m.CantidadComensales).HasMaxLength(1).IsRequired();
        modelBuilder.Entity<Mesa>()
            .Property(m => m.Numero).ValueGeneratedOnAdd().IsRequired();
        modelBuilder.Entity<Mesa>()
            .HasData(Iniciales.Instance.Mesas.ToArray());
        modelBuilder.Entity<Mesa>()
            .Property(m => m.Estado).HasDefaultValue(true).IsRequired();
    }
}

