using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Pav.Parcial2Rec.Infraestructura.Datos;

public class PavParcial2ContextFactory : IDesignTimeDbContextFactory<PavParcialRecContext>
{
    public PavParcialRecContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<PavParcialRecContext>();
        optionsBuilder.UseSqlServer(PavParcialRecContext.CadenaDeConexion);

        return new PavParcialRecContext(optionsBuilder.Options);
    }
}

