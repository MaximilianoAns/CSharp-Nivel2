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
    public partial class frmApp : Form
    {
        private List<Articulos> listaArticulos;
        private List<MarcaId> listaMarcas;
        private List<CategoriasId> listaCategorias;
        public frmApp()
        {
            InitializeComponent();
        }

        private void frmApp_Load(object sender, EventArgs e)
        {
            Articulosdata dato = new Articulosdata();
            listaArticulos = dato.listar();

            dgvArticulo.DataSource = listaArticulos;
            dgvArticulo.Columns["ImagenUrl"].Visible = false;
            cargarImagen(listaArticulos[0].ImagenUrl);

            MarcaData datosMarcas = new MarcaData();
            listaMarcas = datosMarcas.listar();
            cboMarca.DataSource = listaMarcas;

            CategoriasData datosCategoria = new CategoriasData();
            listaCategorias = datosCategoria.listar();
            cboCategorias.DataSource = listaCategorias;
        }

        private void dgvMarca_SelectionChanged(object sender, EventArgs e)
        {
            Articulos seleccionado = (Articulos)dgvArticulo.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                picboxArticulo.Load(imagen);
            }
            catch (Exception )
            {

                picboxArticulo.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/6/65/No-Image-Placeholder.svg/1665px-No-Image-Placeholder.svg.png");
            }
        }
   
    }
}
