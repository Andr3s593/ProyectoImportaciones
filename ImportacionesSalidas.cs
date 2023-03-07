
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using OfficeOpenXml;
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
            EntradasSalidasImportacion salidaImportacion = new EntradasSalidasImportacion();
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
            var entradaes = dbFuncionImportacionesEntities.EntradasSalidasImportacion.ToList();
            this.dgRegistroSalidas.DataSource = entradaes;
        }

        private void CargarCombo()
        {
            DBFuncionImportacionesEntities dbFuncionImportacionesEntities = new DBFuncionImportacionesEntities();
            var establecimientoGraficos = dbFuncionImportacionesEntities.Importacion.ToList();
            this.cmbNumeroImportacion.DataSource = establecimientoGraficos;
            cmbNumeroImportacion.DisplayMember = "NumeroImportacion";
            cmbNumeroImportacion.ValueMember = "id";
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            //Crear DataTable.
            DataTable dt = new DataTable();

            //añadir columnas
            foreach (DataGridViewColumn column in dgRegistroSalidas.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            //añadir filas
            foreach (DataGridViewRow row in dgRegistroSalidas.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    try
                    {

                        dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                    }
                    catch { }
                }
            }


            //exportar a excel
            string folderPath = "C:\\REPORTES\\"; //directorio de exportación
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }


            var nombre = this.Name + DateTime.Now.ToString("ddMMyyyy") + ".xlsx";



            var pathGeneral = folderPath + DateTime.Now.ToString("ddMMyyyy") + "-" + DateTime.Now.ToShortTimeString().Replace(":", "") + "-" + nombre;
            FileInfo file = new FileInfo(pathGeneral);
            using (ExcelPackage excelPackage = new ExcelPackage(file))
            {
                ExcelWorkbook excelWorkBook = excelPackage.Workbook;

                ExcelWorksheet excelWorksheet = excelWorkBook.Worksheets.Add("Reporte " + this.Name + DateTime.Now.ToString("ddMMyyyy"));
                //excelWorksheet.Cells["C1"].Value = " REPORTE INVENTARIOS " + DateTime.Now.ToString();

                excelWorksheet.Cells["A5"].LoadFromDataTable(dt, true);
                excelWorksheet.Cells["A1"].LoadFromText("LOG TRANSACCIONAL");
                excelWorksheet.Cells["A2"].LoadFromText("ROBERT PRINTING DESIGN");
                excelWorksheet.Cells["A3"].LoadFromText("Generado por: " + "Usuario Ricardo");
                excelWorksheet.Cells["A4"].LoadFromText("Fecha:" + DateTime.Now.ToString());
                excelPackage.Save();
            }

            MessageBox.Show("Exportación Exitosa");

        }
    }
}

