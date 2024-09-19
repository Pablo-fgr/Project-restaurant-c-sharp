using Pav.Parcial2Rec.Dominio.Entidades;
using Pav.Parcial2Rec.Dominio.Repositorios;
using Pav.Parcial2Rec.Infraestructura.Datos.Repositorios;
using Pav.Parcial2Rec.Presentacion.Interfaces;
using Pav.Parcial2Rec.Presentacion.Tareas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace Pav.Parcial2Rec.Presentacion.Presentadores;

public class AgregarMesaPresenter : PresenterBase<AdministrarMesasTarea, IAgregarMesaView>
{
    private readonly IRepositorio _repositorio;
    public AgregarMesaPresenter(IAgregarMesaView vista, AdministrarMesasTarea tarea, IRepositorio repositorio) : base(vista, tarea)
    {
        _repositorio = repositorio;
        Vista!.CancelarClicked += CancelarClicked;
        Vista!.ConfirmarClicked += ConfirmarClicked;
    }

    private void ConfirmarClicked(object? sender, EventArgs e)
    {
        var reserva = Vista!.OpcionReserva.Equals("Disponible");
        var mesa = new Mesa()
        {
            Id = Guid.NewGuid(),
            Descripcion = Vista!.Descripcion,
            CantidadComensales = Vista!.CantidadComensales,
            OpcionReserva = reserva,
            Estado = true,
            SectorId = Tarea!.SectorId
        };

        try
        {
            new Comun.ModelDataValidation().Validate(mesa);
            _repositorio.Agregar(mesa);
            Vista!.MostrarMensaje("Mesa agregada satisfactoriamente", Enums.Mensaje.EXITO);
            Vista!.LimpiarCampos();
            Tarea!.ActualizarSector(mesa.SectorId);
            Vista!.CerrarDialogo();
        }
        catch (Exception ex)
        {
            Vista!.MostrarMensaje(ex.Message, Enums.Mensaje.ERROR);
        }
    }

    private void CancelarClicked(object? sender, EventArgs e)
    {
        Tarea!.Iniciar();
        Vista?.Dispose();
    }

}

