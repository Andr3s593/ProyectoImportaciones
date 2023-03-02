namespace Proyectoimportaciones_v1
{
    partial class ImportacionesEntradas
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
            this.lblImportacionesTItle = new System.Windows.Forms.Label();
            this.dtFechaImportacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaImportacion = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.gbImportacionesEntradas = new System.Windows.Forms.GroupBox();
            this.lblCantidadRecibida = new System.Windows.Forms.Label();
            this.btnExportarImportacionesEntradas = new System.Windows.Forms.Button();
            this.btnActualizarRegistroEntradas = new System.Windows.Forms.Button();
            this.lblCantidadImportada = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.lblLote = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.txtNumerodeImportacion = new System.Windows.Forms.TextBox();
            this.lblNumerodeImportacion = new System.Windows.Forms.Label();
            this.dtgImportacionesEntradas = new System.Windows.Forms.DataGridView();
            this.txtCantidadImportada = new System.Windows.Forms.TextBox();
            this.txtCantidadRecibida = new System.Windows.Forms.TextBox();
            this.gbImportacionesEntradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgImportacionesEntradas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImportacionesTItle
            // 
            this.lblImportacionesTItle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImportacionesTItle.AutoSize = true;
            this.lblImportacionesTItle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportacionesTItle.ForeColor = System.Drawing.Color.Navy;
            this.lblImportacionesTItle.Location = new System.Drawing.Point(6, 28);
            this.lblImportacionesTItle.Name = "lblImportacionesTItle";
            this.lblImportacionesTItle.Size = new System.Drawing.Size(229, 24);
            this.lblImportacionesTItle.TabIndex = 0;
            this.lblImportacionesTItle.Text = "Importaciones Entradas";
            // 
            // dtFechaImportacion
            // 
            this.dtFechaImportacion.Location = new System.Drawing.Point(126, 422);
            this.dtFechaImportacion.Name = "dtFechaImportacion";
            this.dtFechaImportacion.Size = new System.Drawing.Size(200, 20);
            this.dtFechaImportacion.TabIndex = 1;
            // 
            // lblFechaImportacion
            // 
            this.lblFechaImportacion.AutoSize = true;
            this.lblFechaImportacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaImportacion.ForeColor = System.Drawing.Color.Navy;
            this.lblFechaImportacion.Location = new System.Drawing.Point(7, 425);
            this.lblFechaImportacion.Name = "lblFechaImportacion";
            this.lblFechaImportacion.Size = new System.Drawing.Size(113, 13);
            this.lblFechaImportacion.TabIndex = 2;
            this.lblFechaImportacion.Text = "Fecha de Importación:";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.Color.Navy;
            this.lblProveedor.Location = new System.Drawing.Point(332, 425);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(59, 13);
            this.lblProveedor.TabIndex = 3;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Items.AddRange(new object[] {
            "ESENSI ",
            "SHANDONG ",
            "SCHOTT ",
            "AMENI ",
            "ARMESSO"});
            this.cmbProveedor.Location = new System.Drawing.Point(397, 421);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(121, 21);
            this.cmbProveedor.TabIndex = 4;
            this.cmbProveedor.Text = "-- Seleccione --";
            // 
            // gbImportacionesEntradas
            // 
            this.gbImportacionesEntradas.Controls.Add(this.txtCantidadRecibida);
            this.gbImportacionesEntradas.Controls.Add(this.txtCantidadImportada);
            this.gbImportacionesEntradas.Controls.Add(this.lblCantidadRecibida);
            this.gbImportacionesEntradas.Controls.Add(this.btnExportarImportacionesEntradas);
            this.gbImportacionesEntradas.Controls.Add(this.btnActualizarRegistroEntradas);
            this.gbImportacionesEntradas.Controls.Add(this.lblCantidadImportada);
            this.gbImportacionesEntradas.Controls.Add(this.txtLote);
            this.gbImportacionesEntradas.Controls.Add(this.lblLote);
            this.gbImportacionesEntradas.Controls.Add(this.txtNombreProducto);
            this.gbImportacionesEntradas.Controls.Add(this.lblNombreProducto);
            this.gbImportacionesEntradas.Controls.Add(this.txtCodigoProducto);
            this.gbImportacionesEntradas.Controls.Add(this.lblCodigoProducto);
            this.gbImportacionesEntradas.Controls.Add(this.txtNumerodeImportacion);
            this.gbImportacionesEntradas.Controls.Add(this.lblNumerodeImportacion);
            this.gbImportacionesEntradas.Controls.Add(this.dtgImportacionesEntradas);
            this.gbImportacionesEntradas.Controls.Add(this.dtFechaImportacion);
            this.gbImportacionesEntradas.Controls.Add(this.cmbProveedor);
            this.gbImportacionesEntradas.Controls.Add(this.lblImportacionesTItle);
            this.gbImportacionesEntradas.Controls.Add(this.lblProveedor);
            this.gbImportacionesEntradas.Controls.Add(this.lblFechaImportacion);
            this.gbImportacionesEntradas.Location = new System.Drawing.Point(13, 9);
            this.gbImportacionesEntradas.Name = "gbImportacionesEntradas";
            this.gbImportacionesEntradas.Size = new System.Drawing.Size(872, 496);
            this.gbImportacionesEntradas.TabIndex = 5;
            this.gbImportacionesEntradas.TabStop = false;
            this.gbImportacionesEntradas.Text = "Importaciones Entradas";
            // 
            // lblCantidadRecibida
            // 
            this.lblCantidadRecibida.AutoSize = true;
            this.lblCantidadRecibida.ForeColor = System.Drawing.Color.Navy;
            this.lblCantidadRecibida.Location = new System.Drawing.Point(708, 425);
            this.lblCantidadRecibida.Name = "lblCantidadRecibida";
            this.lblCantidadRecibida.Size = new System.Drawing.Size(97, 13);
            this.lblCantidadRecibida.TabIndex = 17;
            this.lblCantidadRecibida.Text = "Cantidad Recibida:";
            // 
            // btnExportarImportacionesEntradas
            // 
            this.btnExportarImportacionesEntradas.Location = new System.Drawing.Point(451, 467);
            this.btnExportarImportacionesEntradas.Name = "btnExportarImportacionesEntradas";
            this.btnExportarImportacionesEntradas.Size = new System.Drawing.Size(120, 23);
            this.btnExportarImportacionesEntradas.TabIndex = 16;
            this.btnExportarImportacionesEntradas.Text = "Exportar";
            this.btnExportarImportacionesEntradas.UseVisualStyleBackColor = true;
            this.btnExportarImportacionesEntradas.Click += new System.EventHandler(this.btnExportarImportacionesEntradas_Click);
            // 
            // btnActualizarRegistroEntradas
            // 
            this.btnActualizarRegistroEntradas.Location = new System.Drawing.Point(283, 467);
            this.btnActualizarRegistroEntradas.Name = "btnActualizarRegistroEntradas";
            this.btnActualizarRegistroEntradas.Size = new System.Drawing.Size(120, 23);
            this.btnActualizarRegistroEntradas.TabIndex = 15;
            this.btnActualizarRegistroEntradas.Text = "Actualizar";
            this.btnActualizarRegistroEntradas.UseVisualStyleBackColor = true;
            // 
            // lblCantidadImportada
            // 
            this.lblCantidadImportada.AutoSize = true;
            this.lblCantidadImportada.ForeColor = System.Drawing.Color.Navy;
            this.lblCantidadImportada.Location = new System.Drawing.Point(533, 425);
            this.lblCantidadImportada.Name = "lblCantidadImportada";
            this.lblCantidadImportada.Size = new System.Drawing.Size(102, 13);
            this.lblCantidadImportada.TabIndex = 14;
            this.lblCantidadImportada.Text = "Cantidad Importada:";
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(722, 378);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(100, 20);
            this.txtLote.TabIndex = 13;
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.ForeColor = System.Drawing.Color.Navy;
            this.lblLote.Location = new System.Drawing.Point(685, 381);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(31, 13);
            this.lblLote.TabIndex = 12;
            this.lblLote.Text = "Lote:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(566, 378);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProducto.TabIndex = 11;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.ForeColor = System.Drawing.Color.Navy;
            this.lblNombreProducto.Location = new System.Drawing.Point(467, 381);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(93, 13);
            this.lblNombreProducto.TabIndex = 10;
            this.lblNombreProducto.Text = "Nombre Producto:";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(347, 378);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoProducto.TabIndex = 9;
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.ForeColor = System.Drawing.Color.Navy;
            this.lblCodigoProducto.Location = new System.Drawing.Point(252, 381);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(89, 13);
            this.lblCodigoProducto.TabIndex = 8;
            this.lblCodigoProducto.Text = "Código Producto:";
            // 
            // txtNumerodeImportacion
            // 
            this.txtNumerodeImportacion.Location = new System.Drawing.Point(133, 378);
            this.txtNumerodeImportacion.Name = "txtNumerodeImportacion";
            this.txtNumerodeImportacion.Size = new System.Drawing.Size(100, 20);
            this.txtNumerodeImportacion.TabIndex = 7;
            // 
            // lblNumerodeImportacion
            // 
            this.lblNumerodeImportacion.AutoSize = true;
            this.lblNumerodeImportacion.ForeColor = System.Drawing.Color.Navy;
            this.lblNumerodeImportacion.Location = new System.Drawing.Point(7, 381);
            this.lblNumerodeImportacion.Name = "lblNumerodeImportacion";
            this.lblNumerodeImportacion.Size = new System.Drawing.Size(120, 13);
            this.lblNumerodeImportacion.TabIndex = 6;
            this.lblNumerodeImportacion.Text = "Número de Importación:";
            // 
            // dtgImportacionesEntradas
            // 
            this.dtgImportacionesEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgImportacionesEntradas.Location = new System.Drawing.Point(6, 65);
            this.dtgImportacionesEntradas.Name = "dtgImportacionesEntradas";
            this.dtgImportacionesEntradas.Size = new System.Drawing.Size(860, 292);
            this.dtgImportacionesEntradas.TabIndex = 5;
            // 
            // txtCantidadImportada
            // 
            this.txtCantidadImportada.Location = new System.Drawing.Point(641, 422);
            this.txtCantidadImportada.Name = "txtCantidadImportada";
            this.txtCantidadImportada.Size = new System.Drawing.Size(60, 20);
            this.txtCantidadImportada.TabIndex = 18;
            // 
            // txtCantidadRecibida
            // 
            this.txtCantidadRecibida.Location = new System.Drawing.Point(806, 422);
            this.txtCantidadRecibida.Name = "txtCantidadRecibida";
            this.txtCantidadRecibida.Size = new System.Drawing.Size(60, 20);
            this.txtCantidadRecibida.TabIndex = 19;
            // 
            // ImportacionesEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(897, 517);
            this.Controls.Add(this.gbImportacionesEntradas);
            this.Name = "ImportacionesEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImportacionesEntradas";
            this.gbImportacionesEntradas.ResumeLayout(false);
            this.gbImportacionesEntradas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgImportacionesEntradas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblImportacionesTItle;
        private System.Windows.Forms.DateTimePicker dtFechaImportacion;
        private System.Windows.Forms.Label lblFechaImportacion;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.GroupBox gbImportacionesEntradas;
        private System.Windows.Forms.Label lblNumerodeImportacion;
        private System.Windows.Forms.DataGridView dtgImportacionesEntradas;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.TextBox txtNumerodeImportacion;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label lblCantidadImportada;
        private System.Windows.Forms.Button btnActualizarRegistroEntradas;
        private System.Windows.Forms.Button btnExportarImportacionesEntradas;
        private System.Windows.Forms.Label lblCantidadRecibida;
        private System.Windows.Forms.TextBox txtCantidadRecibida;
        private System.Windows.Forms.TextBox txtCantidadImportada;
    }
}