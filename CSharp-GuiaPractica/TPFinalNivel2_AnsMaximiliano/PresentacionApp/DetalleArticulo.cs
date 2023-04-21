using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Dominio;
using Data;
using System.Configuration;

namespace PresentacionApp
{
    public partial class DetalleArticulo : Form
    {
        private Articulos detalle = null;
        
        public DetalleArticulo()
        {
            InitializeComponent();
        }
        public DetalleArticulo(Articulos detalle)
        {
            InitializeComponent();
            this.detalle = detalle;
            Text = "Detalle Articulo";
        }
        private void DetalleArticulo_Load(object sender, EventArgs e)
        {
            CategoriasData dataCategoria = new CategoriasData();
            try
            {
                cboCategoria.DataSource = dataCategoria.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                if (detalle != null)
                {
                    txtCodigoArticulo.Text = detalle.Codigo;
                    txtNombre.Text = detalle.Nombre;
                    cboCategoria.SelectedValue = detalle.Categoria.Id;
                    cboMarca.SelectedValue = detalle.Marca.Id;
                    cargarImagen(detalle.ImagenUrl);
                    txtPrecio.Text = detalle.Precio.ToString();
                    txtDescripcion.Text = detalle.Descripcion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MarcaData dataMarca = new MarcaData();
            try
            {
                cboMarca.DataSource = dataMarca.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                if (detalle != null)
                {
                    txtCodigoArticulo.Text = detalle.Codigo;
                    txtNombre.Text = detalle.Nombre;
                    cboCategoria.SelectedValue = detalle.Categoria.Id;
                    cboMarca.SelectedValue = detalle.Marca.Id;
                    cargarImagen(detalle.ImagenUrl);
                    txtPrecio.Text = detalle.Precio.ToString();
                    txtDescripcion.Text = detalle.Descripcion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                picboxImagenes.Load(imagen);
            }
            catch (Exception)
            {

                picboxImagenes.Load("https://storage.googleapis.com/proudcity/mebanenc/uploads/2021/03/placeholder-image.png");
            }
        }

       
    }
}
