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
    
    public partial class FrmListarArticulos : Form
    {
        private List<Articulo> lista = new List<Articulo>();

        public FrmListarArticulos()
        {
            InitializeComponent();
        }

        private void FrmListarArticulos_Load(object sender, EventArgs e)
        {
            NArticulo negocioArticulo = new NArticulo();
            dgvListarArticulos.DataSource = negocioArticulo.ListarArticulos();
            dgvListarArticulos.Columns[0].Visible = false;
            dgvListarArticulos.Columns[6].Visible = false;
        }
    }
}
