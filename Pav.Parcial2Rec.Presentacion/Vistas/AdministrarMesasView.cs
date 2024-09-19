using Pav.Parcial2Rec.Dominio.Entidades;
using Pav.Parcial2Rec.Presentacion.Interfaces;
using Pav.Parcial2Rec.Presentacion.Presentadores;
using Pav.Parcial2Rec.Presentacion.Vistas.Controles;
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

public partial class AdministrarMesasView : AdministrarMesasViewWithPresenter, IAdministrarMesasView
{

    public SectorControl? _ultimoSectorSeleccionado;
    
    public AdministrarMesasView()
    {
        InitializeComponent();
        Dock = DockStyle.Fill;
    }

    public event EventHandler AgregarMesasClicked
    {
        add { btnAgregarMesa.Click += value; }
        remove { btnAgregarMesa.Click -= value; }
    }

    public event EventHandler EliminarMesasClicked
    {
        add { btnEliminarMesa.Click += value; }
        remove { btnEliminarMesa.Click -= value; }
    }


    public void CargarSectores(List<Sector> sectores)
    {
        foreach (Sector sector in sectores)
        {
            var control = new SectorControl(sector);
            control.Click += SectorControl_Click;
            control.LabelClicked += SectorControl_Click;
            flpSectores.Controls.Add(control);
        }
    }

    private void SectorControl_Click(object? sender, EventArgs e)
    {
        lblMesaSeleccionada.Text = $"Mesa seleccionada :";
        if (sender is SectorControl control)
        {
            if (_ultimoSectorSeleccionado != null)
            {
                _ultimoSectorSeleccionado.BackColor = Color.DimGray;
            }
            _idSectorSeleccionado = control.IdSector;
            control.BackColor = Color.AntiqueWhite;
            _ultimoSectorSeleccionado = control;
            Presentador!.MostrarInfoSector(control.IdSector);
            lblSectorSeleccionado.Text = $"Sector seleccionado : {control.NumeroSector}";
        }
    }
    public void CargarMesas(List<Mesa> mesas)
    {
        flpMesas.Controls.Clear();
        var mesasActivas = mesas.Where(m => m.Estado == true);
        foreach (Mesa mesa in mesasActivas)
        {
            var control = new MesaControl(mesa);
            control.MesaClicked += MesaControl_Click;
            flpMesas.Controls.Add(control);
        }
    }

    public void MesaControl_Click(object? sender, Guid idMesa)
    {
        if (sender is MesaControl control)
        {
            _idMesaSeleccionada = idMesa;
            lblMesaSeleccionada.Text = $"Mesa seleccionada : {control.NumeroMesa}";
        }
        
    }

    public void ActualizarMesas(Guid idSector)
    {
        var sector = Presentador!.ObtenerSector(idSector);
        if (sector == null) return;
        var mesas = Presentador!.ObtenerMesasSector(idSector);
        CargarMesas(mesas);
    }
    private Guid _idMesaSeleccionada;

    public Guid ObtenerIdMesaSeleccionada()
    {
        return _idMesaSeleccionada;
    }

    private Guid _idSectorSeleccionado;

    public Guid ObtenerIdSectorSeleccionado()
    {
        return _idSectorSeleccionado;
    }

}

public class AdministrarMesasViewWithPresenter : ViewBase<AdministrarMesasPresenter> { }
