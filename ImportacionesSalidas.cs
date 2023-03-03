
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyectoimportaciones_v1
{
    public partial class ImportacionesSalidas : Form
    {
        public ImportacionesSalidas()
        {
            InitializeComponent();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SalidaImportacion salidaImportacion = new SalidaImportacion();
            salidaImportacion.CodigoCliente = txtCodigoCliente.Text;
            salidaImportacion.NombreCliente = txtNombreCliente.Text;
            salidaImportacion.NumeroFactura = txtCantidadComprar.Text;            
            salidaImportacion.CantidadCompra = txtCantidadComprar.Text;           

            ImportacionesCRUD.RegistroImportacionesSalidas(salidaImportacion);

            //this.dgRegistroSalidas.DataSource = consultaImportaciones();

            MessageBox.Show("Los datos se guardaron correctamente.");
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           
            
        }

        
        private void ImportacionesSalidas_Load(object sender, EventArgs e)
        {
            // Crear conexión a la base de datos
            SqlConnection con = new SqlConnection("data source=DESKTOP-BI1QIIS\\SQLEXPRESS;initial catalog=DBFuncionImportaciones;integrated security=True;MultipleActiveResultSets=True");
            // Abrir la conexión
            con.Open();
            // Crear la consulta SQL
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.SalidaImportacion", con);
            // Crear el DataTable y llenarlo con los datos
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            // Asignar la tabla al DataSource del DataGridView
            dgRegistroSalidas.DataSource = dt;
            // Cerrar la conexión
            con.Close();
        }


        private void dgRegistroSalidas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoCliente.Text = dgRegistroSalidas.SelectedCells[0].Value.ToString();
            txtCodigoCliente.Text = dgRegistroSalidas.SelectedCells[1].Value.ToString();
            txtNombreCliente.Text = dgRegistroSalidas.SelectedCells[2].Value.ToString();
            txtNumeroFactura.Text = dgRegistroSalidas.SelectedCells[3].Value.ToString();
            txtCantidadComprar.Text = dgRegistroSalidas.SelectedCells[4].Value.ToString();
            dtFechaImportacion.Value = DateTime.Parse(dgRegistroSalidas.SelectedCells[5].Value.ToString());
            cmbNumeroImportacion.SelectedItem = dgRegistroSalidas.SelectedCells[4].Value.ToString();

        }
    }
}

