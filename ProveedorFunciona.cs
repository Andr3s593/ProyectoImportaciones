using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectoimportaciones_v1
{
    public partial class ProveedorFunciona : Form
    {
        public ProveedorFunciona()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ProveedorImportacion proveedorImportacion = new ProveedorImportacion();
            proveedorImportacion.nombreProveedor = txtNombreProvedor.Text;

            ImportacionesCRUD.RegistroProveedor(proveedorImportacion);

            //this.dgRegistroSalidas.DataSource = consultaImportaciones();

            MessageBox.Show("Proveedor agregado correctamente.");
        }
    }
}
