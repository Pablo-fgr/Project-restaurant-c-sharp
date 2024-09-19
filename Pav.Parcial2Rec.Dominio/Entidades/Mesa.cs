using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Pav.Parcial2Rec.Dominio.Entidades;

public class Mesa : EntityBase
{
    public int Numero { get; init; }

    [Required(ErrorMessage = "La Descripcion de la Mesa es requerida.")]
    [StringLength(40, MinimumLength = 3, ErrorMessage = "La descripcion debe tener entre 3 y 40 caracteres.")]
    public required string Descripcion { get; set; }

    [Required(ErrorMessage = "Cantidad Comensales es requerida.")]
    [Range(1, 12, ErrorMessage = "La cantidad de comensales debe estar entre 1 y 12.")]
    public required int CantidadComensales { get; set; }

    [Required(ErrorMessage = "Opcion Reserva es requerida.")]
    [Range(0, 1, ErrorMessage = "No se selecciono una opcion.")]
    public required bool OpcionReserva { get; set; }

    [DefaultValue(true)]
    public required bool Estado { get; set; }
    public Guid SectorId { get; set; }
}

