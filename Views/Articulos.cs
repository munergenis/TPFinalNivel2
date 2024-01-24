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
        // Constructor
        public Articulos()
        {
            InitializeComponent();
        }

        // Atributos y Properties
        public Form RefToLobby { get; set; }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private bool expand = false;

        // Objetos
        List<Articulo> lista = null;
        ArticuloBusiness articuloBusiness = new ArticuloBusiness();
        Articulo seleccionado = null;

        // Eventos
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
            GrbPanel.Width = 266;
            BtnModificar.Width = 266;
            BtnEliminar.Width = 266;
            ListarArticulos();
            CargarLabels();
            EsconderBusquedaAvanzada();
            seleccionado = (Articulo)DgvArticulos.Rows[0].DataBoundItem;
        }

        private void DgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            seleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.ImagenUrl);
            CargarLabels(seleccionado);
        }

        private void BtnToogleBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            if (LblColumna.Visible == false)
            {
                LblColumna.Visible = true;
                CbxColumnaBusquedaAvanzada.Visible = true;
                LblCriterio.Visible = true;
                CbxCriterioBusquedaAvanzada.Visible = true;
                LblTexto.Visible = true;
                TxtBusquedaAvanzada.Visible = true;
                BtnBusquedaAvanzada.Visible=true;
            }
            else
            {
                EsconderBusquedaAvanzada();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                GrbPanel.Width += 25;
                BtnModificar.Width -= 9;
                BtnModificar.ForeColor = System.Drawing.Color.Khaki;
                BtnEliminar.Width -= 9;
                BtnEliminar.ForeColor = System.Drawing.Color.Salmon;
                LblCategoria.Visible = false;
                LblMarca.Visible = false;
                LblNombre.Visible = false;
                LblDescripcion.Visible = false;
                if (GrbPanel.Width >= 941)
                {
                    timer1.Stop();
                    expand = true;
                }
            }
            else
            {
                GrbPanel.Width -= 25;
                BtnModificar.Width += 9;
                BtnEliminar.Width += 9;
                if (GrbPanel.Width <= 266)
                {
                    timer1.Stop();
                    expand = false;
                    BtnModificar.ForeColor = System.Drawing.SystemColors.ControlText;
                    BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
                    LblCategoria.Visible = true;
                    LblMarca.Visible = true;
                    LblNombre.Visible = true;
                    LblDescripcion.Visible = true;
                }
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            timer1.Start();
            CargarImagen(string.Empty);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            timer1.Start();
            CargarModificar(seleccionado);
        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            timer1.Start();
            DgvArticulos.Focus();
            seleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.ImagenUrl);
            CargarLabels(seleccionado);
        }

        // Métodos
        private void ListarArticulos()
        {
            lista = articuloBusiness.ListarArticulos();
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
                PbxArticulo.Image = Properties.Resources.placeholder2;
            }
        }

        private void EsconderBusquedaAvanzada()
        {
            LblColumna.Visible = false;
            CbxColumnaBusquedaAvanzada.Visible = false;
            LblCriterio.Visible = false;
            CbxCriterioBusquedaAvanzada.Visible = false;
            LblTexto.Visible = false;
            TxtBusquedaAvanzada.Visible = false;
            BtnBusquedaAvanzada.Visible = false;
        }
        
        private void CargarLabels(Articulo articulo)
        {

            LblCategoria.Text = articulo.Categoria.Descripcion.ToUpper();
            LblMarca.Text = articulo.Marca.Descripcion;
            LblNombre.Text = articulo.Nombre;
            LblDescripcion.Text = articulo.Descripcion;
        }

        private void CargarLabels()
        {
            LblCategoria.Text = lista[0].Categoria.Descripcion.ToUpper();
            LblMarca.Text = lista[0].Marca.Descripcion;
            LblNombre.Text = lista[0].Nombre;
            LblDescripcion.Text = lista[0].Descripcion;
        }

        private void TxtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            CargarImagen(TxtUrlImagen.Text);
        }

        private void CargarModificar(Articulo seleccionado)
        {
            TxtCodigo.Text = seleccionado.Codigo;
            TxtNombre.Text = seleccionado.Nombre;
            TxtPrecio.Text = seleccionado.Precio.ToString();
            TxtUrlImagen.Text = seleccionado.ImagenUrl;
            TxtDescripcion.Text = seleccionado.Descripcion;
        }
    }
}
