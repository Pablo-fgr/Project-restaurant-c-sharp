using Pav.Parcial2Rec.Presentacion.Vistas;
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
    public partial class SectorControl : UserControl
    {
        private static SectorControl? _ultimoSectorSeleccionado;

        public event EventHandler? LabelClicked;
        public Guid IdSector { get; set; }
        public int NumeroSector { get; set; }

        public SectorControl(Sector sector)
        {
            InitializeComponent();
            IdSector = sector.Id;
            lblSector.Text = $"Sector {sector.Numero}";
            NumeroSector = sector.Numero;
        }

        private void lblSector_Click(object sender, EventArgs e)
        {
            if (_ultimoSectorSeleccionado != null)
            {
                _ultimoSectorSeleccionado.BackColor = Color.DimGray;
            }

            BackColor = Color.DeepPink;

            _ultimoSectorSeleccionado = this;
            LabelClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
