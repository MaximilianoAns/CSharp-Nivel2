using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Dominio;

namespace PresentacionApp
{
    public partial class FrmPrincipal : Form
    {
        private List<Articulos> listaArticulos;
        
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("¡Bienvenidos a la aplicacion!");
            cargar();
            cboCampo.Items.Add("Código");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripción");
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulos seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
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
        private void nuevoArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaArticulo ventana = new FrmAltaArticulo();
            ventana.ShowDialog();
            cargar();
        }
        private void cargar()
        {
            Articulosdata datosArticulos = new Articulosdata();
            try
            {
                listaArticulos = datosArticulos.listar();
                dgvArticulos.DataSource = listaArticulos;
                ocultarColumnas();
                cargarImagen(listaArticulos[0].ImagenUrl);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ocultarColumnas()
        {
                dgvArticulos.Columns["ImagenUrl"].Visible = false;
                dgvArticulos.Columns["Id"].Visible = false;
        }
        private void modificarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Articulos seleccionado;
            if(dgvArticulos.CurrentRow != null)
            {
                seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                FrmAltaArticulo modificar = new FrmAltaArticulo(seleccionado);
                modificar.ShowDialog();
            }

            cargar();
        }
        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if(opcion == "Código")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con ");
                cboCriterio.Items.Add("Termina con ");
                cboCriterio.Items.Add("Contiene ");
            }
            else if(opcion == "Nombre")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con ");
                cboCriterio.Items.Add("Termina con ");
                cboCriterio.Items.Add("Contiene ");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con ");
                cboCriterio.Items.Add("Termina con ");
                cboCriterio.Items.Add("Contiene ");
            }
        }
        private void btnFiltroAvanzado_Click(object sender, EventArgs e)
        {
            Articulosdata data = new Articulosdata();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado2.Text;
                dgvArticulos.DataSource = data.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private bool validarFiltro()
        {
            if(cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, cargar campo para filtrar");
                return true;
            }
            if(cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, completar criterio para filtrar");
                return true;
            }
            
            return false;
        }
        private void txtFiltroAvanzado2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            List<Articulos> listaFiltrada;
            string filtro = txtFiltroAvanzado2.Text;
            if (filtro.Length >= 2)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;

            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulosdata datos = new Articulosdata();
            Articulos seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                    datos.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDetalleArt_Click(object sender, EventArgs e)
        {
            Articulos seleccionado;
            seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            DetalleArticulo ventana = new DetalleArticulo(seleccionado);
            ventana.ShowDialog();
            cargar();
        }
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("¡Gracias por elegirnos!");
        }
    }

}
 