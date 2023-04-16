using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Data;

namespace WinFormsApp
{
    public partial class FrmPokemons : Form
    {
        
        private List<Pokemon> listaPokemon;
        public FrmPokemons()
        {
            InitializeComponent();
        }
       
        private List<Elemento> listaElemento;

        private void FrmPokemons_Load(object sender, EventArgs e)
        {
            //PokemonData data = new PokemonData();
            //listaPokemon = data.listar();
            //dgvPokemon.DataSource = listaPokemon;
            //dgvPokemon.Columns["UrlImagen"].Visible = false;
            //dgvPokemon.Columns["Id"].Visible = false;
            //cargarImagen(listaPokemon[0].UrlImagen);
            //
            ElementoData dataElemento = new ElementoData();
            listaElemento = dataElemento.listar();
            cboxElemento.DataSource = listaElemento;
            cargar();
            cboCampo.Items.Add("Numero");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripcion");



        }
        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
            // MUESTRO LA IMAGEN CADA VEZ QUE CARGA UNA LINEA 
            if(dgvPokemon.CurrentRow != null)
            {
                Pokemon selecionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
                cargarImagen(selecionado.UrlImagen);
            }

        }
        private void cargar()
        {
            PokemonData data = new PokemonData();
            try
            {
                listaPokemon = data.listar();
                dgvPokemon.DataSource = listaPokemon;
                ocultarColumnas();
                cargarImagen(listaPokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void ocultarColumnas()
        {
                dgvPokemon.Columns["UrlImagen"].Visible = false;
                dgvPokemon.Columns["Id"].Visible = false;

        }

        // METODO QUE NO DEVUELVE NADA 
        private void cargarImagen(string imagen)
        {
            try
            {
                picboxPokemon.Load(imagen);
            }
            catch (Exception ex)
            {

                picboxPokemon.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/6/65/No-Image-Placeholder.svg/1665px-No-Image-Placeholder.svg.png");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaPokemon alta = new FrmAltaPokemon();
            alta.ShowDialog();
            cargar(); 
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado;
            seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;

            FrmAltaPokemon modificar = new FrmAltaPokemon(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }
        private void eliminar(bool logico = false)
        {

            PokemonData datos = new PokemonData();
            Pokemon seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Estas seguro de eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;

                    if (logico)
                        datos.eliminarLogica(seleccionado.Id);
                    else
                        datos.eliminar(seleccionado.Id);
                 cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

     

       

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Pokemon> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro.Length >= 2)
            {
                listaFiltrada = listaPokemon.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaPokemon;
            }

            dgvPokemon.DataSource = null;
            dgvPokemon.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if(opcion == "Numero")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            PokemonData datos = new PokemonData();
            try
            {
                if (validarFiltro())
                {
                    return;
                }

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvPokemon.DataSource = datos.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

          private bool validarFiltro()
          {
                // METODO PARA VALIDAR Y QUE ME COMPLETE EL CAMPO SI O SI
              if(cboCampo.SelectedIndex < 0)
              {
                  MessageBox.Show("Por favor, cargar campo para filtrar busqueda.");
                  return true;
              }
              if(cboCriterio.SelectedIndex < 0)
              {
                  MessageBox.Show("Por favor, cargar criterio para filtrar busqueda.");
                  return true;
              }
              // SELECCIONA LA LISTA RECORRIDA Y PREGUNTA SI EL STRING ESCRITO ES VACIO O NULO
              if(cboCampo.SelectedItem.ToString() == "Numero")
              {
                  if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                  {
                      MessageBox.Show("Por favor, cargar los campos");
                      return true;
                  }
                  // Y SI ES STRING NO ES SOLO NUMERO ENTONCES TIRAME EL CARTEL 
                  if (!(soloNumeros(txtFiltroAvanzado.Text)))
                  {
                      MessageBox.Show("Por favorm cargar solo numeros");
                      return true;
                  }
              }
        
              return false;
          }

        // CADENA PARA VALIDAR SOLO NUMEROS
         private bool soloNumeros(string cadena)
         {
             foreach(char caracter in cadena)
             {
                 if (!(char.IsNumber(caracter)))
                 {
                     return false;
                 }
             }
             return true;
         }
    }
}
