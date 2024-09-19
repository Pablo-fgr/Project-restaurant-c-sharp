using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Parcial2Rec.Dominio.Entidades;

public class Sector : EntityBase
{
    public required int Numero { get; set; }

    public List<Mesa> Mesas { get; set; } = new();

}

