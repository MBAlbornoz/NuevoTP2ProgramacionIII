using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEGOCIO;
using DOMINIO;

namespace Sistemas_Ventas_MSoft
{
    public partial class FrmModificar : Form
    {
        List<Articulo> lista = new List<Articulo>();

        public FrmModificar()
        {
            InitializeComponent();
        }


        private void cargarDatos()
        {
            NArticulo negocioArticulo = new NArticulo();

            try
            {

                lista = negocioArticulo.ListarArticulos();
                dgvModificar.DataSource = lista;
                dgvModificar.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmModificar_Load(object sender, EventArgs e)
        {
           NMarca negocioMarca = new NMarca();
           NCategoria negocioCategoria = new NCategoria();
            

            try
            {
                cargarDatos();
                cboMarcas.DataSource = negocioMarca.ListarMarcas();
                cboCategorias.DataSource = negocioCategoria.ListarCategorias();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
