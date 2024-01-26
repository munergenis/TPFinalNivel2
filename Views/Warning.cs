using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace Views
{
    public partial class Warning : Form
    {
        public Warning()
        {
            InitializeComponent();
        }

        public bool Return { get; set; }

        public string WarningText { get; set; }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Return = true;
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Return = false;
            Close();
        }

        private void Warning_Load(object sender, EventArgs e)
        {
            LblWarning.Text = WarningText;
        }
    }
}
