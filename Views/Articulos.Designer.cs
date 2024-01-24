﻿namespace Views
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
            this.PnlArticulos = new System.Windows.Forms.Panel();
            this.LblArticulos = new System.Windows.Forms.Label();
            this.DgvArticulos = new System.Windows.Forms.DataGridView();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.PbxArticulo = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.GrbPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbPanel
            // 
            this.GrbPanel.Controls.Add(this.PbxArticulo);
            this.GrbPanel.Controls.Add(this.PnlArticulos);
            this.GrbPanel.Location = new System.Drawing.Point(-6, -11);
            this.GrbPanel.Name = "GrbPanel";
            this.GrbPanel.Size = new System.Drawing.Size(266, 655);
            this.GrbPanel.TabIndex = 2;
            this.GrbPanel.TabStop = false;
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
            this.DgvArticulos.Size = new System.Drawing.Size(607, 359);
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
            // PbxArticulo
            // 
            this.PbxArticulo.Location = new System.Drawing.Point(35, 39);
            this.PbxArticulo.Name = "PbxArticulo";
            this.PbxArticulo.Size = new System.Drawing.Size(200, 200);
            this.PbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxArticulo.TabIndex = 0;
            this.PbxArticulo.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxArticulo)).EndInit();
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
    }
}