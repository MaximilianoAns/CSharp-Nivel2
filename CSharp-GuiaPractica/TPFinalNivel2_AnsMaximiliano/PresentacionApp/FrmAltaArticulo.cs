using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO; 
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Data;
using System.Configuration;

namespace PresentacionApp
{
    public partial class FrmAltaArticulo : Form
    {
        private Articulos articulo = null;
        private OpenFileDialog archivo = null;
        public FrmAltaArticulo()
        {
            InitializeComponent();
        }
        public FrmAltaArticulo(Articulos articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }
        private void FrmAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriasData dataCategoria = new CategoriasData();
            try
            {
                cboCategoria.DataSource = dataCategoria.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                if(articulo != null)
                {
                    txtCodigoArticulo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cargarImagen(articulo.ImagenUrl);
                    txtPrecio.Text = articulo.Precio.ToString();
                    txtDescripcion.Text = articulo.Descripcion;
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
                if (articulo != null)
                {
                    txtCodigoArticulo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cargarImagen(articulo.ImagenUrl);
                    txtPrecio.Text = articulo.Precio.ToString();
                    txtDescripcion.Text = articulo.Descripcion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulosdata dato = new Articulosdata();
            try
            {
                if (articulo == null)
                    articulo = new Articulos();

                    articulo.Codigo = txtCodigoArticulo.Text;
                    articulo.Nombre = txtNombre.Text;
                    articulo.Descripcion = txtDescripcion.Text;
                    articulo.Precio = decimal.Parse(txtPrecio.Text);
                    articulo.Marca = (MarcaId)cboMarca.SelectedItem;
                    articulo.Categoria = (CategoriasId)cboCategoria.SelectedItem;
                    articulo.ImagenUrl = txtImagenUrl.Text;

                if(articulo.Id != 0)
                {
                    dato.modificar(articulo);
                    MessageBox.Show("¡Se ha modificado exitosamente!");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtCodigoArticulo.Text) || string.IsNullOrEmpty(txtNombre.Text))
                    {
                        MessageBox.Show("Por favor, complete Nombre y codigo del articulo.");
                    }
                    else
                    {
                        dato.agregar(articulo);
                        MessageBox.Show("¡Agregado exitosamente!");
                    }
                }

                if (archivo != null && !(txtImagenUrl.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

                Close();

            }
            catch (FormatException ex) { MessageBox.Show("Campo Precio admite solo números y no puede estar vacío."); }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg | png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagenUrl.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
               
            }
        }
        private bool  soloNumeros(string cadena)
        {
            foreach(char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
                return true;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!soloNumeros(txtPrecio.Text))
            {
                MessageBox.Show("Solo se admiten numeros.");
            }
        }
    }
}
