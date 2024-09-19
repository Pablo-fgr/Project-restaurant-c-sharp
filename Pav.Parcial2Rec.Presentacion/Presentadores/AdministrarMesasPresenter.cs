using Pav.Parcial2Rec.Dominio.Entidades;
using Pav.Parcial2Rec.Dominio.Repositorios;
using Pav.Parcial2Rec.Presentacion.Interfaces;
using Pav.Parcial2Rec.Presentacion.Tareas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Parcial2Rec.Presentacion.Presentadores;

public class AdministrarMesasPresenter : PresenterBase<AdministrarMesasTarea, IAdministrarMesasView>
{
    private readonly IRepositorio _repositorio;
    public AdministrarMesasPresenter(IAdministrarMesasView vista, AdministrarMesasTarea tarea
        , IRepositorio repositorio) : base(vista, tarea)
    {
        _repositorio = repositorio;
        Vista!.AgregarMesasClicked += Vista_AgregarMesaClicked;
        Vista!.EliminarMesasClicked += EliminarMesasClicked;
        Vista!.CargarSectores(_repositorio.ListarTodos<Sector>(nameof(Sector.Mesas)));
    }

    private void EliminarMesasClicked(object? sender, EventArgs e)
    {
        var idMesa = Vista!.ObtenerIdMesaSeleccionada();
        var mesa = ObtenerMesa(idMesa);
        if (mesa == null) return;
        if (!Vista!.MostrarConfirmacion("¿Seguro desea eliminar la mesa?")) return;
        mesa.Estado = false;
        _repositorio.ActualizarSoloLosCamposIncluidos(mesa, m => m.Estado);
        Vista!.CargarMesas(ObtenerMesasSector(mesa.SectorId));
    }

    public void MostrarInfoSector(Guid idSector)
    {
        Tarea!.SectorId = idSector; 
        var mesas = ObtenerMesasSector(idSector);
        Vista!.CargarMesas(mesas);
    }
    private void Vista_AgregarMesaClicked(object? sender, EventArgs e)
    {
        Tarea!.Navigator.NavegarA<AgregarMesaPresenter>(true);
        MostrarInfoSector(Tarea.SectorId);
    }

    public List<Mesa> ObtenerMesasSector(Guid idSector)
    {
        var mesas = _repositorio.Listar<Mesa>(a => a.SectorId == idSector);

        foreach (var mesa in mesas)
        {
            mesa.SectorId = idSector;
        }

        return mesas;
    }
    public Sector? ObtenerSector(Guid idSector) => _repositorio.ObtenerPorId<Sector>(idSector);
    public Mesa? ObtenerMesa(Guid idMesa) => _repositorio.ObtenerPorId<Mesa>(idMesa);

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            // Nos aseguramos de eliminar el contexto
            _repositorio.Dispose();
        }
        base.Dispose(disposing);
    }
}

