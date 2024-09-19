namespace Pav.Parcial2Rec.Presentacion.Vistas
{
    partial class PrincipalView
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
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            administrarMesasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1584, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administrarMesasToolStripMenuItem });
            opcionesToolStripMenuItem.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(106, 29);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // administrarMesasToolStripMenuItem
            // 
            administrarMesasToolStripMenuItem.Name = "administrarMesasToolStripMenuItem";
            administrarMesasToolStripMenuItem.Size = new Size(248, 30);
            administrarMesasToolStripMenuItem.Text = "Administrar Mesas";
            administrarMesasToolStripMenuItem.Click += administrarMesasToolStripMenuItem_Click;
            // 
            // PrincipalView
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1584, 861);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "PrincipalView";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IL POSTINO";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem administrarMesasToolStripMenuItem;
    }
}