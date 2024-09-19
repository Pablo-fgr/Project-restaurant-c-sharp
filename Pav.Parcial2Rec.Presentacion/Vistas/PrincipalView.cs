using Pav.Parcial2Rec.Presentacion.Interfaces;
using Pav.Parcial2Rec.Presentacion.Presentadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pav.Parcial2Rec.Presentacion.Vistas;

public partial class PrincipalView : PrincipalViewWithPresenter, IPrincipalView
{
    public PrincipalView()
    {
        InitializeComponent();
    }

    public event EventHandler AdministrarMesasClicked
    {
        add { administrarMesasToolStripMenuItem.Click += value; }
        remove { administrarMesasToolStripMenuItem.Click -= value; }
    }

    private void administrarMesasToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }
}

public class PrincipalViewWithPresenter : ViewBase<PrincipalPresenter> { }