using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemas_Ventas_MSoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    
        private void SalirTSMenuItem_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void AltaArticuloTSMenuItem_Click(object sender, EventArgs e)
        { 
            FrmAltaArticulo alta = new FrmAltaArticulo();
            alta.ShowDialog();
        }

        private void ListarTSMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarArticulos listarArticulos = new FrmListarArticulos();
            listarArticulos.ShowDialog();
        }

        private void ModificacionArticuloTSMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificar modificarArticulos = new FrmModificar();
            modificarArticulos.ShowDialog();
        }

        private void BajaArticuloTlSMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificar bajaArticulos = new FrmModificar();
            bajaArticulos.Text = "Eliminar";
            bajaArticulos.ShowDialog();
        }
    }
}
