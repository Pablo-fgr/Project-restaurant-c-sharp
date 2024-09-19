namespace Pav.Parcial2Rec.Presentacion.Vistas.Controles
{
    partial class SectorControl
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
            lblSector = new Label();
            SuspendLayout();
            // 
            // lblSector
            // 
            lblSector.AutoSize = true;
            lblSector.BackColor = SystemColors.Control;
            lblSector.BorderStyle = BorderStyle.Fixed3D;
            lblSector.FlatStyle = FlatStyle.Flat;
            lblSector.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSector.ImageAlign = ContentAlignment.BottomLeft;
            lblSector.Location = new Point(22, 12);
            lblSector.Name = "lblSector";
            lblSector.Size = new Size(71, 27);
            lblSector.TabIndex = 1;
            lblSector.Text = "Sector";
            lblSector.TextAlign = ContentAlignment.MiddleCenter;
            lblSector.Click += lblSector_Click;
            // 
            // SectorControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblSector);
            Name = "SectorControl";
            Size = new Size(156, 50);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSector;
    }
}
