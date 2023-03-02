
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Importa la clase ImportacionesCRUD
using Proyectoimportaciones_v1;

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
    }
}
