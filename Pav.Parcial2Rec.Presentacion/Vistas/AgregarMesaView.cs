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

public partial class AgregarMesaView : AdministrarMesasViewWithPresenter, IAgregarMesaView
{
    public AgregarMesaView()
    {
        InitializeComponent();
    }


    public event EventHandler CancelarClicked
    {
        add { btnCancelar.Click += value; }
        remove { btnCancelar.Click -= value; }
    }
    public event EventHandler ConfirmarClicked
    {
        add { btnConfirmar.Click += value; }
        remove { btnConfirmar.Click -= value; }
    }

    public void LimpiarCampos()
    {
        txtCantidadComensales.Text = String.Empty;
        txtDescripcion.Text = String.Empty;
    }

    public string Descripcion { get => txtDescripcion.Text; set => txtDescripcion.Text = value; }
    public int CantidadComensales 
    {
        get
        {
            if (int.TryParse(txtCantidadComensales.Text, out int cantidad))
            {
                return cantidad;
            }
            else
            {
                return 0;
            }
        }
        set
        {
            txtCantidadComensales.Text = value.ToString();
        }
    }
    public string OpcionReserva
    {
        get => cbReserva.SelectedItem?.ToString() ?? string.Empty;
        set => cbReserva.SelectedItem = value;
    }


}


public class AgregarMesaViewWithPresenter : ViewBase<AdministrarMesasPresenter> { }