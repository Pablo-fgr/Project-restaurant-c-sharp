namespace Pav.Parcial2Rec.Presentacion.Vistas.Controles
{
    partial class MesaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNumero = new Label();
            lblDescripcion = new Label();
            lblCantComensales = new Label();
            lblOpcionReserva = new Label();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.Anchor = AnchorStyles.None;
            lblNumero.BackColor = SystemColors.Control;
            lblNumero.BorderStyle = BorderStyle.FixedSingle;
            lblNumero.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(60, 11);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(63, 17);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Mesa";
            lblNumero.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = AnchorStyles.None;
            lblDescripcion.BackColor = SystemColors.Control;
            lblDescripcion.BorderStyle = BorderStyle.FixedSingle;
            lblDescripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(39, 38);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(97, 19);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripcion";
            lblDescripcion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCantComensales
            // 
            lblCantComensales.Anchor = AnchorStyles.None;
            lblCantComensales.BackColor = SystemColors.Control;
            lblCantComensales.BorderStyle = BorderStyle.FixedSingle;
            lblCantComensales.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCantComensales.Location = new Point(39, 77);
            lblCantComensales.Name = "lblCantComensales";
            lblCantComensales.Size = new Size(106, 19);
            lblCantComensales.TabIndex = 2;
            lblCantComensales.Text = "Cantidad";
            lblCantComensales.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOpcionReserva
            // 
            lblOpcionReserva.Anchor = AnchorStyles.None;
            lblOpcionReserva.BackColor = SystemColors.Control;
            lblOpcionReserva.BorderStyle = BorderStyle.FixedSingle;
            lblOpcionReserva.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOpcionReserva.Location = new Point(13, 119);
            lblOpcionReserva.Name = "lblOpcionReserva";
            lblOpcionReserva.Size = new Size(147, 27);
            lblOpcionReserva.TabIndex = 3;
            lblOpcionReserva.Text = "Opcion Reserva";
            lblOpcionReserva.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MesaControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.GradientInactiveCaption;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblOpcionReserva);
            Controls.Add(lblCantComensales);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNumero);
            Name = "MesaControl";
            Size = new Size(176, 168);
            Click += MesaControl_Click_1;
            ResumeLayout(false);
        }

        #endregion

        private Label lblNumero;
        private Label lblDescripcion;
        private Label lblCantComensales;
        private Label lblOpcionReserva;
    }
}
