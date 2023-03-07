namespace Proyectoimportaciones_v1
{
    partial class ImportacionesSalidas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCantidadComprar = new System.Windows.Forms.TextBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.dgRegistroSalidas = new System.Windows.Forms.DataGridView();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblCantidadComprar = new System.Windows.Forms.Label();
            this.lblNumeroImportacion = new System.Windows.Forms.Label();
            this.lblFechaImportacion = new System.Windows.Forms.Label();
            this.dtFechaImportacion = new System.Windows.Forms.DateTimePicker();
            this.cmbNumeroImportacion = new System.Windows.Forms.ComboBox();
            this.gbMovimientoES = new System.Windows.Forms.GroupBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.btnVerNumeroImportacion = new System.Windows.Forms.Button();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistroSalidas)).BeginInit();
            this.gbMovimientoES.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCantidadComprar
            // 
            this.txtCantidadComprar.Location = new System.Drawing.Point(656, 117);
            this.txtCantidadComprar.Name = "txtCantidadComprar";
            this.txtCantidadComprar.Size = new System.Drawing.Size(203, 20);
            this.txtCantidadComprar.TabIndex = 13;
            // 
            // btnExportar
            // 
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(308, 200);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(84, 30);
            this.btnExportar.TabIndex = 12;
            this.btnExportar.Text = "Guardar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // dgRegistroSalidas
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRegistroSalidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgRegistroSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRegistroSalidas.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgRegistroSalidas.Location = new System.Drawing.Point(10, 252);
            this.dgRegistroSalidas.Name = "dgRegistroSalidas";
            this.dgRegistroSalidas.ReadOnly = true;
            this.dgRegistroSalidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRegistroSalidas.Size = new System.Drawing.Size(874, 286);
            this.dgRegistroSalidas.TabIndex = 10;
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(189, 117);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(203, 20);
            this.txtNumeroFactura.TabIndex = 9;
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFactura.Location = new System.Drawing.Point(5, 117);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(146, 20);
            this.lblNumeroFactura.TabIndex = 8;
            this.lblNumeroFactura.Text = "Número de Factura";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(472, 72);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(143, 20);
            this.lblNombreCliente.TabIndex = 7;
            this.lblNombreCliente.Text = "Nombre del Cliente";
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCliente.Location = new System.Drawing.Point(5, 72);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(134, 20);
            this.lblCodigoCliente.TabIndex = 0;
            this.lblCodigoCliente.Text = "Código de Cliente";
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(189, 72);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(203, 20);
            this.txtCodigoCliente.TabIndex = 3;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(656, 72);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(203, 20);
            this.txtNombreCliente.TabIndex = 4;
            // 
            // lblCantidadComprar
            // 
            this.lblCantidadComprar.AutoSize = true;
            this.lblCantidadComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadComprar.Location = new System.Drawing.Point(472, 117);
            this.lblCantidadComprar.Name = "lblCantidadComprar";
            this.lblCantidadComprar.Size = new System.Drawing.Size(151, 20);
            this.lblCantidadComprar.TabIndex = 2;
            this.lblCantidadComprar.Text = "Cantidad a Comprar";
            // 
            // lblNumeroImportacion
            // 
            this.lblNumeroImportacion.AutoSize = true;
            this.lblNumeroImportacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroImportacion.Location = new System.Drawing.Point(5, 30);
            this.lblNumeroImportacion.Name = "lblNumeroImportacion";
            this.lblNumeroImportacion.Size = new System.Drawing.Size(175, 20);
            this.lblNumeroImportacion.TabIndex = 14;
            this.lblNumeroImportacion.Text = "Número de Importación";
            // 
            // lblFechaImportacion
            // 
            this.lblFechaImportacion.AutoSize = true;
            this.lblFechaImportacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaImportacion.Location = new System.Drawing.Point(5, 158);
            this.lblFechaImportacion.Name = "lblFechaImportacion";
            this.lblFechaImportacion.Size = new System.Drawing.Size(164, 20);
            this.lblFechaImportacion.TabIndex = 15;
            this.lblFechaImportacion.Text = "Fecha de Importación";
            // 
            // dtFechaImportacion
            // 
            this.dtFechaImportacion.Location = new System.Drawing.Point(189, 158);
            this.dtFechaImportacion.Name = "dtFechaImportacion";
            this.dtFechaImportacion.Size = new System.Drawing.Size(203, 20);
            this.dtFechaImportacion.TabIndex = 16;
            // 
            // cmbNumeroImportacion
            // 
            this.cmbNumeroImportacion.FormattingEnabled = true;
            this.cmbNumeroImportacion.Location = new System.Drawing.Point(189, 29);
            this.cmbNumeroImportacion.Name = "cmbNumeroImportacion";
            this.cmbNumeroImportacion.Size = new System.Drawing.Size(121, 21);
            this.cmbNumeroImportacion.TabIndex = 17;
            // 
            // gbMovimientoES
            // 
            this.gbMovimientoES.Controls.Add(this.txtCantidad);
            this.gbMovimientoES.Controls.Add(this.lblCantidad);
            this.gbMovimientoES.Controls.Add(this.lblNombreProducto);
            this.gbMovimientoES.Controls.Add(this.txtNombreProducto);
            this.gbMovimientoES.Controls.Add(this.btnVerNumeroImportacion);
            this.gbMovimientoES.Controls.Add(this.btnExportarExcel);
            this.gbMovimientoES.Controls.Add(this.dgRegistroSalidas);
            this.gbMovimientoES.Controls.Add(this.lblCodigoCliente);
            this.gbMovimientoES.Controls.Add(this.btnExportar);
            this.gbMovimientoES.Controls.Add(this.txtCodigoCliente);
            this.gbMovimientoES.Controls.Add(this.cmbNumeroImportacion);
            this.gbMovimientoES.Controls.Add(this.lblNombreCliente);
            this.gbMovimientoES.Controls.Add(this.txtNombreCliente);
            this.gbMovimientoES.Controls.Add(this.lblNumeroImportacion);
            this.gbMovimientoES.Controls.Add(this.lblNumeroFactura);
            this.gbMovimientoES.Controls.Add(this.dtFechaImportacion);
            this.gbMovimientoES.Controls.Add(this.txtNumeroFactura);
            this.gbMovimientoES.Controls.Add(this.lblFechaImportacion);
            this.gbMovimientoES.Controls.Add(this.lblCantidadComprar);
            this.gbMovimientoES.Controls.Add(this.txtCantidadComprar);
            this.gbMovimientoES.Location = new System.Drawing.Point(12, 12);
            this.gbMovimientoES.Name = "gbMovimientoES";
            this.gbMovimientoES.Size = new System.Drawing.Size(902, 557);
            this.gbMovimientoES.TabIndex = 18;
            this.gbMovimientoES.TabStop = false;
            this.gbMovimientoES.Text = "Movimiento E/S";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(717, 27);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 20);
            this.lblCantidad.TabIndex = 22;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(472, 27);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(133, 20);
            this.lblNombreProducto.TabIndex = 21;
            this.lblNombreProducto.Text = "Nombre Producto";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(611, 30);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProducto.TabIndex = 20;
            
            // 
            // btnVerNumeroImportacion
            // 
            this.btnVerNumeroImportacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerNumeroImportacion.Location = new System.Drawing.Point(316, 17);
            this.btnVerNumeroImportacion.Name = "btnVerNumeroImportacion";
            this.btnVerNumeroImportacion.Size = new System.Drawing.Size(86, 43);
            this.btnVerNumeroImportacion.TabIndex = 19;
            this.btnVerNumeroImportacion.Text = "Ver Importación";
            this.btnVerNumeroImportacion.UseVisualStyleBackColor = true;
            this.btnVerNumeroImportacion.Click += new System.EventHandler(this.btnVerNumeroImportacion_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExcel.Location = new System.Drawing.Point(476, 201);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(127, 29);
            this.btnExportarExcel.TabIndex = 18;
            this.btnExportarExcel.Text = "Exportar a Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(796, 30);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 23;            
            // 
            // ImportacionesSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(926, 575);
            this.Controls.Add(this.gbMovimientoES);
            this.Name = "ImportacionesSalidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimiento E/S";
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistroSalidas)).EndInit();
            this.gbMovimientoES.ResumeLayout(false);
            this.gbMovimientoES.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgRegistroSalidas;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblCantidadComprar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.TextBox txtCantidadComprar;
        private System.Windows.Forms.ComboBox cmbNumeroImportacion;
        private System.Windows.Forms.DateTimePicker dtFechaImportacion;
        private System.Windows.Forms.Label lblFechaImportacion;
        private System.Windows.Forms.Label lblNumeroImportacion;
        private System.Windows.Forms.GroupBox gbMovimientoES;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Button btnVerNumeroImportacion;
        private System.Windows.Forms.TextBox txtCantidad;
    }
}