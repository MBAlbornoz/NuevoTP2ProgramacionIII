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
        Articulo articulo = new Articulo();
        Articulo modificar;

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
                dgvModificar.Columns[6].Visible = false;


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

                cboMarcas.ValueMember = "Id";
                cboMarcas.DisplayMember = "Descripcion";
                cboMarcas.SelectedIndex = -1;

                cboCategorias.ValueMember = "Id";
                cboCategorias.DisplayMember = "Descripcion";
                cboCategorias.SelectedIndex = -1;

                txtCodigoArt.Text = articulo.Codigo;
                txtNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.Descripcion;
                txtPrecio.Text = articulo.Precio.ToString();
                cboMarcas.SelectedValue = articulo.Marca.Id;
                cboCategorias.SelectedValue = articulo.Categoria.Id;

                modificar = (Articulo)dgvModificar.CurrentRow.DataBoundItem;

                /*
                cargarDatos();
                cboMarcas.DataSource = negocioMarca.ListarMarcas();
                cboCategorias.DataSource = negocioCategoria.ListarCategorias();

                articulo.Codigo = txtCodigoArt.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = float.Parse(txtPrecio.Text);
                articulo.Marca = (Marca)cboMarcas.SelectedItem;
                articulo.Categoria = (Categoria)cboCategorias.SelectedItem;

               */
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

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            NArticulo negocioArticulo = new NArticulo();
            negocioArticulo.ModificarArticulo(articulo);

        }
    }
}
