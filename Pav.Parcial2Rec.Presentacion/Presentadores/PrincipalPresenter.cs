using Pav.Parcial2Rec.Presentacion.Interfaces;
using Pav.Parcial2Rec.Presentacion.Tareas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Parcial2Rec.Presentacion.Presentadores;

public class PrincipalPresenter : PresenterBase<PrincipalTarea, IPrincipalView>
{
    public PrincipalPresenter(IPrincipalView vista, PrincipalTarea tarea) : base(vista, tarea)
    {
        Vista!.AdministrarMesasClicked += Vista_AdministrarMesasClicked;
    }

    private void Vista_AdministrarMesasClicked(object? sender, EventArgs e)
    {
        AdministradorDeTareas.Instance.Iniciar<AdministrarMesasTarea>(Vista);
    }
}

