namespace Pav.Parcial2Rec.Presentacion.Vistas
{
    partial class AdministrarMesasView
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flpMesas = new FlowLayoutPanel();
            panel1 = new Panel();
            lblMesaSeleccionada = new Label();
            lblSectorSeleccionado = new Label();
            btnEliminarMesa = new Button();
            btnAgregarMesa = new Button();
            lblSectores = new Label();
            flpSectores = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1320F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(flpMesas, 3, 2);
            tableLayoutPanel1.Controls.Add(panel1, 3, 1);
            tableLayoutPanel1.Controls.Add(lblSectores, 1, 1);
            tableLayoutPanel1.Controls.Add(flpSectores, 1, 2);
            tableLayoutPanel1.Location = new Point(2, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 600F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1580, 760);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flpMesas
            // 
            flpMesas.BackColor = Color.Silver;
            flpMesas.BorderStyle = BorderStyle.FixedSingle;
            flpMesas.Dock = DockStyle.Fill;
            flpMesas.Location = new Point(244, 144);
            flpMesas.Margin = new Padding(4);
            flpMesas.Name = "flpMesas";
            flpMesas.Size = new Size(1312, 592);
            flpMesas.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblMesaSeleccionada);
            panel1.Controls.Add(lblSectorSeleccionado);
            panel1.Controls.Add(btnEliminarMesa);
            panel1.Controls.Add(btnAgregarMesa);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(244, 24);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1312, 112);
            panel1.TabIndex = 1;
            // 
            // lblMesaSeleccionada
            // 
            lblMesaSeleccionada.AutoSize = true;
            lblMesaSeleccionada.Location = new Point(4, 76);
            lblMesaSeleccionada.Margin = new Padding(4, 0, 4, 0);
            lblMesaSeleccionada.Name = "lblMesaSeleccionada";
            lblMesaSeleccionada.Size = new Size(152, 20);
            lblMesaSeleccionada.TabIndex = 3;
            lblMesaSeleccionada.Text = "Mesa Seleccionada:";
            // 
            // lblSectorSeleccionado
            // 
            lblSectorSeleccionado.AutoSize = true;
            lblSectorSeleccionado.Location = new Point(0, 29);
            lblSectorSeleccionado.Margin = new Padding(4, 0, 4, 0);
            lblSectorSeleccionado.Name = "lblSectorSeleccionado";
            lblSectorSeleccionado.Size = new Size(160, 20);
            lblSectorSeleccionado.TabIndex = 2;
            lblSectorSeleccionado.Text = "Sector Seleccionado:";
            // 
            // btnEliminarMesa
            // 
            btnEliminarMesa.Anchor = AnchorStyles.None;
            btnEliminarMesa.AutoSize = true;
            btnEliminarMesa.Location = new Point(1140, 29);
            btnEliminarMesa.Margin = new Padding(4);
            btnEliminarMesa.Name = "btnEliminarMesa";
            btnEliminarMesa.Size = new Size(148, 49);
            btnEliminarMesa.TabIndex = 1;
            btnEliminarMesa.Text = "Eliminar";
            btnEliminarMesa.UseVisualStyleBackColor = true;
            // 
            // btnAgregarMesa
            // 
            btnAgregarMesa.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAgregarMesa.AutoSize = true;
            btnAgregarMesa.Location = new Point(903, 29);
            btnAgregarMesa.Margin = new Padding(4);
            btnAgregarMesa.Name = "btnAgregarMesa";
            btnAgregarMesa.Size = new Size(170, 49);
            btnAgregarMesa.TabIndex = 0;
            btnAgregarMesa.Text = "Agregar";
            btnAgregarMesa.UseVisualStyleBackColor = true;
            // 
            // lblSectores
            // 
            lblSectores.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSectores.AutoSize = true;
            lblSectores.BorderStyle = BorderStyle.Fixed3D;
            lblSectores.ImageAlign = ContentAlignment.BottomLeft;
            lblSectores.Location = new Point(24, 118);
            lblSectores.Margin = new Padding(4, 0, 4, 0);
            lblSectores.Name = "lblSectores";
            lblSectores.Size = new Size(75, 22);
            lblSectores.TabIndex = 2;
            lblSectores.Text = "Sectores";
            // 
            // flpSectores
            // 
            flpSectores.BackColor = Color.DimGray;
            flpSectores.BorderStyle = BorderStyle.FixedSingle;
            flpSectores.Dock = DockStyle.Fill;
            flpSectores.Location = new Point(24, 144);
            flpSectores.Margin = new Padding(4);
            flpSectores.Name = "flpSectores";
            flpSectores.Size = new Size(192, 592);
            flpSectores.TabIndex = 3;
            // 
            // AdministrarMesasView
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightGray;
            ClientSize = new Size(1584, 761);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "AdministrarMesasView";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "AdministrarMesas";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label lblMesaSeleccionada;
        private Label lblSectorSeleccionado;
        private Button btnEliminarMesa;
        private Button btnAgregarMesa;
        private Label lblSectores;
        private FlowLayoutPanel flpMesas;
        private FlowLayoutPanel flpSectores;
    }
}