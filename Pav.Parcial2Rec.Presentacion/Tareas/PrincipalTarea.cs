using Pav.Parcial2Rec.Presentacion.Presentadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Parcial2Rec.Presentacion.Tareas;

public class PrincipalTarea : TaskBase
{
    public PrincipalTarea(Navigator navigator) : base(navigator)
    {
    }

    public override void Iniciar()
    {
        Navigator.NavegarA<PrincipalPresenter>();
    }
}

