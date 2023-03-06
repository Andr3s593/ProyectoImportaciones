
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
    public partial class Importaciones : Form
    {
        public Importaciones()
        {
            InitializeComponent();
        }

        private void mnuImportacionesEntradas_Click(object sender, EventArgs e)
        {
            ImportacionesES importacionesentradas = new ImportacionesES();
            importacionesentradas.MdiParent = this;
            importacionesentradas.Show();
        }

        private void mnuImportacionesSalidas_Click(object sender, EventArgs e)
        {
            ImportacionesSalidas importacionessalidas = new ImportacionesSalidas();
            importacionessalidas.MdiParent = this;
            importacionessalidas.Show();
        }

        private void Importaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
