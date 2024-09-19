using Pav.Parcial2Rec.Presentacion.Presentadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Parcial2Rec.Presentacion.Tareas;

public class AdministrarMesasTarea : TaskBase
{
    public Guid SectorId  { get; set; }
    public Guid MesaId { get; set; }

    public event Action<Guid>? MesaAgregada;
    
    public AdministrarMesasTarea(Navigator navigator) : base(navigator)
    {
    }

    public void ActualizarSector(Guid idSector)
    {
        if (MesaAgregada == null) return;
        MesaAgregada.Invoke(idSector);
    }

    public override void Iniciar()
    {
        Navigator.NavegarA<AdministrarMesasPresenter>();
    }
}

