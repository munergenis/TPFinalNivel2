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
using Dominio;

namespace Views
{
    public partial class Articulos : Form
    {
        public Articulos()
        {
            InitializeComponent();
        }

        public Form RefToLobby { get; set; }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        ArticuloBusiness articuloBusiness = new ArticuloBusiness();

        private void Articulos_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefToLobby.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Minimized;
        }

        private void Articulos_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
        }

        private void Articulos_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Articulos_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Articulos_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Articulos_Load(object sender, EventArgs e)
        {
            ListarArticulos();
        }

        private void ListarArticulos()
        {
            List<Articulo> lista = articuloBusiness.ListarArticulos();
            DgvArticulos.DataSource = lista;
            OcultarColumna("Id");
            OcultarColumna("Descripcion");
            OcultarColumna("ImagenUrl");
            CargarImagen(lista[0].ImagenUrl);
        }

        private void OcultarColumna(string header)
        {
            DgvArticulos.Columns[header].Visible = false;
        }

        private void CargarImagen(string url)
        {
            try
            {
                PbxArticulo.Load(url);
            }
            catch (Exception)
            {
                PbxArticulo.Image = Properties.Resources.placeholder;
            }
        }

        private void DgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.ImagenUrl);
        }
    }
}
