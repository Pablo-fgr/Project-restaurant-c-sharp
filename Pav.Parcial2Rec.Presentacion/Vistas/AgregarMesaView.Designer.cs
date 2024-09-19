namespace Pav.Parcial2Rec.Presentacion.Vistas
{
    partial class AgregarMesaView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtDescripcion = new TextBox();
            txtCantidadComensales = new TextBox();
            lblDescripcionMesa = new Label();
            cbReserva = new ComboBox();
            mesaBindingSource = new BindingSource(components);
            lblCantidadComensalesMesa = new Label();
            lblOpcionReservaMesa = new Label();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)mesaBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(43, 64);
            txtDescripcion.Margin = new Padding(4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(169, 26);
            txtDescripcion.TabIndex = 0;
            // 
            // txtCantidadComensales
            // 
            txtCantidadComensales.Location = new Point(43, 158);
            txtCantidadComensales.Margin = new Padding(4);
            txtCantidadComensales.Name = "txtCantidadComensales";
            txtCantidadComensales.Size = new Size(169, 26);
            txtCantidadComensales.TabIndex = 2;
            // 
            // lblDescripcionMesa
            // 
            lblDescripcionMesa.AutoSize = true;
            lblDescripcionMesa.Location = new Point(43, 28);
            lblDescripcionMesa.Name = "lblDescripcionMesa";
            lblDescripcionMesa.Size = new Size(96, 20);
            lblDescripcionMesa.TabIndex = 3;
            lblDescripcionMesa.Text = "Descripcion:";
            // 
            // cbReserva
            // 
            cbReserva.FormattingEnabled = true;
            cbReserva.Items.AddRange(new object[] { "Disponible", "No Disponible" });
            cbReserva.Location = new Point(43, 260);
            cbReserva.Name = "cbReserva";
            cbReserva.Size = new Size(169, 28);
            cbReserva.TabIndex = 6;
            // 
            // mesaBindingSource
            // 
            mesaBindingSource.DataSource = typeof(Dominio.Entidades.Mesa);
            // 
            // lblCantidadComensalesMesa
            // 
            lblCantidadComensalesMesa.AutoSize = true;
            lblCantidadComensalesMesa.Location = new Point(43, 124);
            lblCantidadComensalesMesa.Name = "lblCantidadComensalesMesa";
            lblCantidadComensalesMesa.Size = new Size(169, 20);
            lblCantidadComensalesMesa.TabIndex = 7;
            lblCantidadComensalesMesa.Text = "Cantidad Comensales:";
            // 
            // lblOpcionReservaMesa
            // 
            lblOpcionReservaMesa.AutoSize = true;
            lblOpcionReservaMesa.Location = new Point(43, 223);
            lblOpcionReservaMesa.Name = "lblOpcionReservaMesa";
            lblOpcionReservaMesa.Size = new Size(126, 20);
            lblOpcionReservaMesa.TabIndex = 8;
            lblOpcionReservaMesa.Text = "Opcion Reserva:";
            // 
            // btnCancelar
            // 
            btnCancelar.Dock = DockStyle.Fill;
            btnCancelar.Location = new Point(3, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(126, 42);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Dock = DockStyle.Fill;
            btnConfirmar.Location = new Point(135, 3);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(126, 42);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnConfirmar, 1, 0);
            tableLayoutPanel1.Controls.Add(btnCancelar, 0, 0);
            tableLayoutPanel1.Location = new Point(7, 311);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(264, 48);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // AgregarMesaView
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(283, 388);
            Controls.Add(lblOpcionReservaMesa);
            Controls.Add(lblCantidadComensalesMesa);
            Controls.Add(cbReserva);
            Controls.Add(lblDescripcionMesa);
            Controls.Add(txtCantidadComensales);
            Controls.Add(txtDescripcion);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            Name = "AgregarMesaView";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarMesa";
            ((System.ComponentModel.ISupportInitialize)mesaBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescripcion;
        private TextBox txtCantidadComensales;
        private Label lblDescripcionMesa;
        private ComboBox cbReserva;
        private Label lblCantidadComensalesMesa;
        private Label lblOpcionReservaMesa;
        private Button btnCancelar;
        private Button btnConfirmar;
        private TableLayoutPanel tableLayoutPanel1;
        private BindingSource mesaBindingSource;
    }
}