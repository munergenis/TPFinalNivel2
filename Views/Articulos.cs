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
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private bool expand = false;
        private bool isNew = false;
        public Form RefToLobby { get; set; }

        // Objetos
        List<Articulo> lista = null;
        ArticuloBusiness articuloBusiness = new ArticuloBusiness();
        Articulo seleccionado = null;

        // Eventos
        private void Articulos_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefToLobby.Close();
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
            CargarCbx();
        }

        private void DgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvArticulos.Rows.Count > 0 || expand == false)
            {
                try
                {
                    seleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
                    CargarImagen(seleccionado.ImagenUrl);
                    CargarLabels(seleccionado);
                }
                catch (Exception ex)
                {
                    seleccionado = null;
                    //MessageBox.Show(ex.ToString());
                }
            }
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
                BtnModificar.Text = string.Empty;
                BtnModificar.Enabled = false;
                BtnEliminar.Width -= 9;
                BtnEliminar.Text = string.Empty;
                BtnEliminar.Enabled = false;
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
                    BtnModificar.Text = "Modificar";
                    BtnEliminar.Text = "Eliminar";
                    BtnModificar.Enabled = true;
                    BtnEliminar.Enabled = true;
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
            CargarTextBox();
            CbxCategoria.SelectedIndex = -1;
            CbxMarca.SelectedIndex = -1;
            isNew = true;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DgvArticulos.Rows.Count > 0)
            {
                timer1.Start();
                CargarTextBox(seleccionado);
                CbxCategoria.SelectedValue = seleccionado.Categoria.Id;
                CbxMarca.SelectedValue = seleccionado.Marca.Id;
                isNew = false;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Warning cancelar = new Warning();
            cancelar.WarningText = "¿Quieres cerrar? Se perderan los cambios";
            cancelar.ShowDialog();

            if (cancelar.Return == true)
            {
                CerrarEditor();
            }
        }

        private void TxtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            CargarImagen(TxtUrlImagen.Text);
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                Articulo nuevo = new Articulo();
                CargarNuevoModificar(nuevo);
                articuloBusiness.Agregar(nuevo);
            }
            else
            {
                CargarNuevoModificar(seleccionado);
                articuloBusiness.Modificar(seleccionado);
            }
            ListarArticulos();
            CerrarEditor();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Mostrar warning
            // Si devueve true
                // articulobusines.eliminar(selec)
                // listarArticulos
            Warning eliminar = new Warning();
            eliminar.WarningText = "¿Quieres eliminar? No se podrá recuperar el artículo!";
            eliminar.ShowDialog();
            if (eliminar.Return == true)
            {
                articuloBusiness.Eliminar(seleccionado);
                ListarArticulos();
                DgvArticulos.Focus();
            }
        }
       
        // Métodos
        private void ListarArticulos()
        {
            if (lista != null)
            {
                lista.Clear();
            }
            DgvArticulos.DataSource = null;
            DgvArticulos.Update();
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
                PbxArticulo.Image = Properties.Resources.techplaceholder;
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

        private void CargarTextBox(Articulo seleccionado)
        {
            TxtCodigo.Text = seleccionado.Codigo;
            TxtNombre.Text = seleccionado.Nombre;
            TxtPrecio.Text = seleccionado.Precio.ToString();
            TxtUrlImagen.Text = seleccionado.ImagenUrl;
            TxtDescripcion.Text = seleccionado.Descripcion;
        }

        private void CargarTextBox()
        {
            TxtCodigo.Text = string.Empty;
            TxtNombre.Text = string.Empty;
            TxtPrecio.Text = string.Empty;
            TxtUrlImagen.Text = string.Empty;
            TxtDescripcion.Text = string.Empty;
        }

        private void CargarCbx()
        {
            CategoriaBusiness categoriaBusiness = new CategoriaBusiness();
            MarcaBusiness marcaBusiness = new MarcaBusiness();
            CbxCategoria.DataSource = categoriaBusiness.Listar();
            CbxCategoria.ValueMember = "Id";
            CbxCategoria.DisplayMember = "Descripcion";
            CbxMarca.DataSource = marcaBusiness.Listar();
            CbxMarca.ValueMember = "Id";
            CbxMarca.DisplayMember = "Descripcion";
        }

        private void CargarNuevoModificar(Articulo articulo)
        {
            articulo.Codigo = TxtCodigo.Text;
            articulo.Nombre = TxtNombre.Text;
            articulo.Descripcion = TxtDescripcion.Text;
            articulo.Marca = (Marca)CbxMarca.SelectedItem;
            articulo.Categoria = (Categoria)CbxCategoria.SelectedItem;
            articulo.ImagenUrl = TxtUrlImagen.Text;
            articulo.Precio = decimal.Parse(TxtPrecio.Text);
        }

        private void CerrarEditor()
        {
            timer1.Start();
            DgvArticulos.Focus();
            seleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.ImagenUrl);
            CargarLabels(seleccionado);
        }

    }
}
