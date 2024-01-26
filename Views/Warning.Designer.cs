namespace Views
{
    partial class Warning
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PbxWarning = new System.Windows.Forms.PictureBox();
            this.LblWarning = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.PbxWarning);
            this.panel1.Controls.Add(this.LblWarning);
            this.panel1.Location = new System.Drawing.Point(67, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 162);
            this.panel1.TabIndex = 0;
            // 
            // PbxWarning
            // 
            this.PbxWarning.Image = global::Views.Properties.Resources.priority_high_FILL0_wght400_GRAD0_opsz24;
            this.PbxWarning.Location = new System.Drawing.Point(47, 63);
            this.PbxWarning.Name = "PbxWarning";
            this.PbxWarning.Size = new System.Drawing.Size(42, 38);
            this.PbxWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxWarning.TabIndex = 1;
            this.PbxWarning.TabStop = false;
            // 
            // LblWarning
            // 
            this.LblWarning.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblWarning.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWarning.Location = new System.Drawing.Point(123, 0);
            this.LblWarning.Name = "LblWarning";
            this.LblWarning.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.LblWarning.Size = new System.Drawing.Size(372, 162);
            this.LblWarning.TabIndex = 0;
            this.LblWarning.Text = "label1";
            this.LblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAceptar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnAceptar.FlatAppearance.BorderSize = 0;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Location = new System.Drawing.Point(67, 229);
            this.BtnAceptar.MaximumSize = new System.Drawing.Size(266, 53);
            this.BtnAceptar.MinimumSize = new System.Drawing.Size(23, 53);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(204, 53);
            this.BtnAceptar.TabIndex = 18;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancelar.BackColor = System.Drawing.Color.Salmon;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCancelar.Location = new System.Drawing.Point(358, 229);
            this.BtnCancelar.MaximumSize = new System.Drawing.Size(266, 53);
            this.BtnCancelar.MinimumSize = new System.Drawing.Size(23, 53);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(204, 53);
            this.BtnCancelar.TabIndex = 19;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Warning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(629, 323);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Warning";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Warning_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxWarning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PbxWarning;
        private System.Windows.Forms.Label LblWarning;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}