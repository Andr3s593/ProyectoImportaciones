
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
            Obtener();
            CargarCombo();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SalidaImportacion salidaImportacion = new SalidaImportacion();
            salidaImportacion.CodigoCliente = txtCodigoCliente.Text;
            salidaImportacion.NombreCliente = txtNombreCliente.Text;
            salidaImportacion.NumeroFactura = txtCantidadComprar.Text;
            salidaImportacion.CantidadCompra = txtCantidadComprar.Text;
            salidaImportacion.NumeroImportacion = txtCantidadComprar.Text;
            

            ImportacionesCRUD.RegistroImportacionesSalidas(salidaImportacion);

            //this.dgRegistroSalidas.DataSource = consultaImportaciones();

            MessageBox.Show("Los datos se guardaron correctamente.");
            Obtener();
        }
        private void Obtener()
        {
            DBFuncionImportacionesEntities dbFuncionImportacionesEntities = new DBFuncionImportacionesEntities();
            var entradaes = dbFuncionImportacionesEntities.SalidaImportacion.ToList();
            this.dgRegistroSalidas.DataSource = entradaes;
        }

        private void CargarCombo()
        {
            DBFuncionImportacionesEntities dbFuncionImportacionesEntities = new DBFuncionImportacionesEntities();
            var establecimientoGraficos = dbFuncionImportacionesEntities.EntradaImportacion.ToList();
            this.cmbNumeroImportacion.DataSource = establecimientoGraficos;
            cmbNumeroImportacion.DisplayMember = "NumeroImportacion";
            cmbNumeroImportacion.ValueMember = "id";
        }

    }
}

