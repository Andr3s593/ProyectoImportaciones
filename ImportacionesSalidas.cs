
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
using System.Data.Entity;

namespace Proyectoimportaciones_v1
{
    public partial class ImportacionesSalidas : Form
    {
        public ImportacionesSalidas()
        {
            InitializeComponent();
            Obtener();
            CargarComboBox();
            resultadotxt();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EntradasSalidasImportacion salidaImportacion = new EntradasSalidasImportacion();
            salidaImportacion.CodigoCliente = txtCodigoCliente.Text;
            salidaImportacion.NombreCliente = txtNombreCliente.Text;
            salidaImportacion.NumeroFactura = txtNumeroFactura.Text;
            salidaImportacion.CantidadCompra = txtCantidadComprar.Text;
            salidaImportacion.NumeroImportacion = cmbNumeroImportacion.Text;
            

            ImportacionesCRUD.RegistroEntradaSalidaImportaciones(salidaImportacion);

            //this.dgRegistroSalidas.DataSource = consultaImportaciones();

            MessageBox.Show("Los datos se guardaron correctamente.");
            Obtener();
            actualizarCamtidadRestante();
        }
        private void Obtener()
        {
            DBFuncionImportacionesEntities dbFuncionImportacionesEntities = new DBFuncionImportacionesEntities();
            var entradaes = dbFuncionImportacionesEntities.EntradasSalidasImportacion.ToList();
            this.dgRegistroSalidas.DataSource = entradaes;
        }

        private void CargarComboBox()
        {
            DBFuncionImportacionesEntities dbFuncionImportacionesEntities = new DBFuncionImportacionesEntities();
            var importaciones = dbFuncionImportacionesEntities.Importacion.ToList();
            cmbNumeroImportacion.DataSource = importaciones;
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
        private void resultadotxt() 
        { 
            txtCantidadalComprar.ReadOnly = true;      
            txtCantidadalComprar.Enabled= false;
        }
        private void btnVerNumeroImportacion_Click(object sender, EventArgs e)
        {
            ObtenerDatosImportacionSeleccionada();
        }
        private void cmbNumeroImportacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObtenerDatosImportacionSeleccionada();
        }
        private void ObtenerDatosImportacionSeleccionada()
        {
            DBFuncionImportacionesEntities dbFuncionImportacionesEntities = new DBFuncionImportacionesEntities();
            // Obtener el id de la importación seleccionada en el ComboBox
            int idSeleccionado = (int)cmbNumeroImportacion.SelectedValue;
            // Buscar la importación correspondiente al id seleccionado
            var importacion = dbFuncionImportacionesEntities.Importacion.Where(x => x.id == idSeleccionado).FirstOrDefault();
            // Asignar los valores correspondientes a los cuadros de texto
            if (importacion != null)
            {
                txtNombreProducto.Text = importacion.NombreProducto;
                txtNombreProducto.ReadOnly = true;                
                txtCantidad.Text = importacion.CantidadImportada.ToString();
                txtCantidad.ReadOnly = true;                
            }
        }
        private void actualizarCamtidadRestante() 
        {
            DBFuncionImportacionesEntities dbFuncionImportacionesEntities = new DBFuncionImportacionesEntities();
            int idSeleccionado = (int)cmbNumeroImportacion.SelectedValue; // Obtener el valor seleccionado en el ComboBox
            var importaciones = dbFuncionImportacionesEntities.Importacion.Where(x => x.id == idSeleccionado).FirstOrDefault(); 
            importaciones.CantidadImportada = decimal.Parse(txtCantidadalComprar.Text);

            dbFuncionImportacionesEntities.Importacion.Attach(importaciones);
            dbFuncionImportacionesEntities.Entry(importaciones).State = EntityState.Modified;
            dbFuncionImportacionesEntities.SaveChanges();
            MessageBox.Show("Se Actualizó la Cantidad Importada Exitosamente");
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            CalcularResta();
        }

        private void txtCantidadComprar_TextChanged(object sender, EventArgs e)
        {
            CalcularResta();
        }
        private void CalcularResta()
        {
            if (double.TryParse(txtCantidad.Text, out double numero1) && double.TryParse(txtCantidadComprar.Text, out double numero2))
            {
                double resultado = numero1 - numero2;
                txtCantidadalComprar.Text = resultado.ToString();
            }
            else
            {
                txtCantidadalComprar.Text = "";
            }
        }        
    }
}

