using Pav.Parcial2Rec.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pav.Parcial2Rec.Presentacion.Vistas.Controles
{
    public partial class MesaControl : UserControl
    {
        public Guid IdMesa { get; set; }
        public int NumeroMesa { get; set; }
        public EventHandler<Guid>? MesaClicked;
        public MesaControl(Mesa mesa)
        {
            InitializeComponent();
            IdMesa = mesa.Id;
            lblNumero.Text = $"Mesa {mesa.Numero}";
            NumeroMesa = mesa.Numero;
            lblDescripcion.Text = mesa.Descripcion.ToString();
            lblCantComensales.Text = $"{mesa.CantidadComensales}";
            lblOpcionReserva.Text = mesa.OpcionReserva ? "Disponible" : "No Disponible";
        }

        private void MesaControl_Click_1(object sender, EventArgs e)
        {
            MesaClicked?.Invoke(this, IdMesa);
        }
    }
}
