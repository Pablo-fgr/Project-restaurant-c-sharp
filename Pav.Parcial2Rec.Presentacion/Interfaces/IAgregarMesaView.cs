using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Parcial2Rec.Presentacion.Interfaces;

public interface IAgregarMesaView : IView
{
    event EventHandler CancelarClicked;
    event EventHandler ConfirmarClicked;

    void LimpiarCampos();

    public string Descripcion { get; set; }
    public int CantidadComensales { get; set; }
    public string OpcionReserva { get; set; }
}

