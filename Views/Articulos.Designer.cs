namespace Views
{
    partial class Articulos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrbPanel = new System.Windows.Forms.GroupBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblMarca = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.PbxArticulo = new System.Windows.Forms.PictureBox();
            this.PnlArticulos = new System.Windows.Forms.Panel();
            this.LblArticulos = new System.Windows.Forms.Label();
            this.DgvArticulos = new System.Windows.Forms.DataGridView();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.GrbPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbPanel
            // 
            this.GrbPanel.Controls.Add(this.BtnEliminar);
            this.GrbPanel.Controls.Add(this.BtnModificar);
            this.GrbPanel.Controls.Add(this.panel3);
            this.GrbPanel.Controls.Add(this.panel2);
            this.GrbPanel.Controls.Add(this.panel1);
            this.GrbPanel.Controls.Add(this.PbxArticulo);
            this.GrbPanel.Controls.Add(this.PnlArticulos);
            this.GrbPanel.Location = new System.Drawing.Point(-6, -11);
            this.GrbPanel.Name = "GrbPanel";
            this.GrbPanel.Size = new System.Drawing.Size(266, 655);
            this.GrbPanel.TabIndex = 2;
            this.GrbPanel.TabStop = false;
            // 
            // LblNombre
            // 
            this.LblNombre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblNombre.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(0, 37);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(200, 33);
            this.LblNombre.TabIndex = 7;
            this.LblNombre.Text = "label2";
            this.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LblNombre);
            this.panel2.Controls.Add(this.LblMarca);
            this.panel2.Location = new System.Drawing.Point(34, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 70);
            this.panel2.TabIndex = 9;
            // 
            // LblMarca
            // 
            this.LblMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblMarca.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMarca.Location = new System.Drawing.Point(0, 0);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(200, 40);
            this.LblMarca.TabIndex = 6;
            this.LblMarca.Text = "label1";
            this.LblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblCategoria);
            this.panel1.Location = new System.Drawing.Point(34, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 32);
            this.panel1.TabIndex = 8;
            // 
            // LblCategoria
            // 
            this.LblCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCategoria.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoria.Location = new System.Drawing.Point(0, 0);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(200, 32);
            this.LblCategoria.TabIndex = 5;
            this.LblCategoria.Text = "label1";
            this.LblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PbxArticulo
            // 
            this.PbxArticulo.Location = new System.Drawing.Point(34, 72);
            this.PbxArticulo.Name = "PbxArticulo";
            this.PbxArticulo.Size = new System.Drawing.Size(200, 200);
            this.PbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxArticulo.TabIndex = 0;
            this.PbxArticulo.TabStop = false;
            // 
            // PnlArticulos
            // 
            this.PnlArticulos.BackColor = System.Drawing.Color.Transparent;
            this.PnlArticulos.Location = new System.Drawing.Point(264, 61);
            this.PnlArticulos.Name = "PnlArticulos";
            this.PnlArticulos.Size = new System.Drawing.Size(677, 575);
            this.PnlArticulos.TabIndex = 4;
            // 
            // LblArticulos
            // 
            this.LblArticulos.AutoSize = true;
            this.LblArticulos.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArticulos.Location = new System.Drawing.Point(535, 61);
            this.LblArticulos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblArticulos.Name = "LblArticulos";
            this.LblArticulos.Size = new System.Drawing.Size(121, 27);
            this.LblArticulos.TabIndex = 1;
            this.LblArticulos.Text = "ARTICULOS";
            // 
            // DgvArticulos
            // 
            this.DgvArticulos.AllowUserToAddRows = false;
            this.DgvArticulos.AllowUserToDeleteRows = false;
            this.DgvArticulos.AllowUserToOrderColumns = true;
            this.DgvArticulos.AllowUserToResizeRows = false;
            this.DgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvArticulos.BackgroundColor = System.Drawing.Color.Ivory;
            this.DgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvArticulos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvArticulos.EnableHeadersVisualStyles = false;
            this.DgvArticulos.GridColor = System.Drawing.Color.Salmon;
            this.DgvArticulos.Location = new System.Drawing.Point(292, 119);
            this.DgvArticulos.MultiSelect = false;
            this.DgvArticulos.Name = "DgvArticulos";
            this.DgvArticulos.ReadOnly = true;
            this.DgvArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvArticulos.RowHeadersVisible = false;
            this.DgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvArticulos.Size = new System.Drawing.Size(607, 325);
            this.DgvArticulos.TabIndex = 3;
            this.DgvArticulos.SelectionChanged += new System.EventHandler(this.DgvArticulos_SelectionChanged);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.Image = global::Views.Properties.Resources.minimize_FILL0_wght400_GRAD0_opsz24;
            this.BtnMinimizar.Location = new System.Drawing.Point(857, 17);
            this.BtnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(27, 32);
            this.BtnMinimizar.TabIndex = 4;
            this.BtnMinimizar.UseVisualStyleBackColor = true;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Image = global::Views.Properties.Resources.close_FILL0_wght400_GRAD0_opsz24;
            this.BtnClose.Location = new System.Drawing.Point(892, 17);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(27, 32);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LblDescripcion);
            this.panel3.Location = new System.Drawing.Point(34, 373);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 82);
            this.panel3.TabIndex = 10;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDescripcion.Location = new System.Drawing.Point(0, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(200, 82);
            this.LblDescripcion.TabIndex = 0;
            this.LblDescripcion.Text = "label1";
            this.LblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Khaki;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Location = new System.Drawing.Point(0, 480);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(266, 53);
            this.BtnModificar.TabIndex = 11;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Salmon;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Location = new System.Drawing.Point(0, 553);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(266, 53);
            this.BtnEliminar.TabIndex = 12;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(933, 623);
            this.Controls.Add(this.BtnMinimizar);
            this.Controls.Add(this.DgvArticulos);
            this.Controls.Add(this.GrbPanel);
            this.Controls.Add(this.LblArticulos);
            this.Controls.Add(this.BtnClose);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Articulos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Articulos_FormClosed);
            this.Load += new System.EventHandler(this.Articulos_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Articulos_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Articulos_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Articulos_MouseUp);
            this.Resize += new System.EventHandler(this.Articulos_Resize);
            this.GrbPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.GroupBox GrbPanel;
        private System.Windows.Forms.PictureBox PbxArticulo;
        private System.Windows.Forms.Label LblArticulos;
        private System.Windows.Forms.DataGridView DgvArticulos;
        private System.Windows.Forms.Panel PnlArticulos;
        private System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
    }
}