using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Importa la clase ImportacionesCRUD
using Proyectoimportaciones_v1;

namespace Proyectoimportaciones_v1
{
    public partial class ImportacionesEntradas : Form
    {
        public ImportacionesEntradas()
        {
            InitializeComponent();
        }
        private void btnExportarImportacionesEntradas_Click(object sender, EventArgs e)
        {
            // Crea un objeto de tipo EntradaImportaciones y asigna sus valores
            EntradaImportacion entradaImportacion = new EntradaImportacion();
            entradaImportacion.NumeroImportacion = txtNumerodeImportacion.Text;
            entradaImportacion.CodigoProducto = txtCodigoProducto.Text;
            entradaImportacion.NombreProducto = txtNombreProducto.Text;
            entradaImportacion.Lote = txtLoteEntradaImportacion.Text;
            entradaImportacion.Proveedor = cmbProveedor.SelectedItem.ToString();
            int cantidadImportada;
            if (Int32.TryParse(txtCantidadImportada.Text, out cantidadImportada))
            {
                entradaImportacion.CantidadImportada = cantidadImportada;
            }
            else
            {
                MessageBox.Show("El valor de cantidad importada solo acepta números.");
                return;
            }
            int cantidadRecibida;
            if (Int32.TryParse(txtCantidadRecibida.Text, out cantidadRecibida))
            {
                entradaImportacion.CantidadRecibida = cantidadRecibida;
            }
            else
            {
                MessageBox.Show("El valor de cantidad recibida solo acepta números.");
                return;
            }

            // Llama a la función RegistroImportacionesEntradas de la clase ImportacionesCRUD para guardar los datos en la BD
            ImportacionesCRUD.RegistroImportacionesEntradas(entradaImportacion);

            // Muestra un mensaje de éxito
            MessageBox.Show("Los datos se han guardado correctamente.");
        }
        //SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=BDFuncionImportaciones;User ID=DESKTOP-RMFGQNF;Password=Andres12345678;\r\n");
        /*private void dtgImportacionesEntradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string consulta = "select * from dbo.EntradaImmportes";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion); 
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dtgImportacionesEntradas.DataSource = dt;
        }*/
    }
}
