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
    public partial class Articulos : Form
    {
        public Articulos()
        {
            InitializeComponent();
        }

        public Form RefToLobby { get; set; }

        private void Articulos_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefToLobby.Show();
        }
    }
}
