using Pav.Parcial2Rec.Dominio.Entidades;

namespace Pav.Parcial2Rec.Infraestructura.Datos.Datos;

public class Iniciales
{
    private static Iniciales? _instance = null;
    private static readonly object _lock = new();

    private Iniciales()
    {
        Inicializar();
    }

    public static Iniciales Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance = new Iniciales();
                }
            }
            return _instance;
        }
    }
    public List<Sector> Sectores { get; } = new();
    public List<Mesa> Mesas { get; } = new();

    private void Inicializar()
    {
        InicializarSectores();
    }

    private void InicializarSectores()
    {
        var sector1 = new Sector
        {
            Id = Guid.NewGuid(),
            Numero = 1
        };
        var sector2 = new Sector
        {
            Id = Guid.NewGuid(),
            Numero = 2
        };
        var sector3 = new Sector
        {
            Id = Guid.NewGuid(),
            Numero = 3
        };
        var sector4 = new Sector
        {
            Id = Guid.NewGuid(),
            Numero = 4
        };
        Sectores.Add(sector1);
        Sectores.Add(sector2);
        Sectores.Add(sector3);
        Sectores.Add(sector4);
        Mesas.AddRange(
        [
            new Mesa
            {
                Id = Guid.NewGuid(),
                Numero = 1,
                Descripcion = $"Mesa 1",
                CantidadComensales = 4,
                OpcionReserva = true,
                Estado = true,
                SectorId = sector1.Id
            },
            new Mesa
            {
                Id = Guid.NewGuid(),
                Numero = 2,
                Descripcion = $"Mesa 2",
                CantidadComensales = 7,
                OpcionReserva = true,
                Estado = true,
                SectorId = sector2.Id
            }
        ]);

        
        
    }
}

