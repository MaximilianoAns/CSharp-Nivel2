using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraPruebadeApp
{
    public partial class FrmCelulares : Form
    {
        public FrmCelulares()
        {
            InitializeComponent();
        }

        private void FrmCelulares_Load(object sender, EventArgs e)
        {
            CelularData datos = new CelularData();
            dgvpicCelular.DataSource = datos.listar();
        }
    }
}
