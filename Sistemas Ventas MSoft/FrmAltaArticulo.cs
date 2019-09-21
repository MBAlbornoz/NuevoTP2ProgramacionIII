using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOMINIO;
using NEGOCIO;

namespace Sistemas_Ventas_MSoft
{
    public partial class FrmAltaArticulo : Form
    {
        Articulo articulo = new Articulo();
        public FrmAltaArticulo()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnAgregarA_Click(object sender, EventArgs e)
        {
            
            NArticulo negocioArticulo = new NArticulo();
            
            try
            {
                articulo.Codigo = txtCodigoArt.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = float.Parse(txtPrecio.Text);
                articulo.Imagen = "URL DE LA IMAGEN";

                articulo.Marca= (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                //Llama a funcion agregar y le mando por parametro el articulo a agregar
               
                negocioArticulo.AltaArticulo(articulo);
                MessageBox.Show("Se dio de alta el articulo");
                Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void FrmAltaArticulo_Load(object sender, EventArgs e)
        {
            NMarca negocioMarca = new NMarca();
            NCategoria negocioCategoria = new NCategoria();
            try
            {
                cboCategoria.DataSource = negocioCategoria.ListarCategorias(); //GUARDO LA LISTA EN EL COMBO
                cboCategoria.ValueMember = "Id"; //VALOR A TENER EN CUENTA
                cboCategoria.DisplayMember = "Descripcion"; //LO QUE MUESTRA AL USUARIO
                cboCategoria.SelectedIndex = -1; //MANEJA EL ID DE LA LISTA (INDEX)

                cboMarca.DataSource = negocioMarca.ListarMarcas(); //GUARDO LA LISTA EN EL COMBO
                cboMarca.ValueMember = "Id"; //VALOR A TENER EN CUENTA
                cboMarca.DisplayMember = "Descripcion"; //LO QUE MUESTRA AL USUARIO
                cboMarca.SelectedIndex = -1; //MANEJA EL ID DE LA LISTA (INDEX)
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
    }
}
