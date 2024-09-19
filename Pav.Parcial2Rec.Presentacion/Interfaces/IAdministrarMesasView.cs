using Pav.Parcial2Rec.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Parcial2Rec.Presentacion.Interfaces;

public interface IAdministrarMesasView : IView
{
    public event EventHandler AgregarMesasClicked;
    public event EventHandler EliminarMesasClicked;
    public void ActualizarMesas(Guid idSector);
    public void CargarSectores(List<Sector> sectores);
    public void CargarMesas(List<Mesa> mesas);
    public Guid ObtenerIdMesaSeleccionada();
    public Guid ObtenerIdSectorSeleccionado();
}

