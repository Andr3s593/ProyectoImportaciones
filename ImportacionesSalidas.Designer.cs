﻿namespace Proyectoimportaciones_v1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCantidadComprar = new System.Windows.Forms.TextBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgRegistroSalidas = new System.Windows.Forms.DataGridView();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblMovimientoES = new System.Windows.Forms.Label();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblCantidadComprar = new System.Windows.Forms.Label();
            this.lblNumeroImportacion = new System.Windows.Forms.Label();
            this.lblFechaImportacion = new System.Windows.Forms.Label();
            this.dtFechaImportacion = new System.Windows.Forms.DateTimePicker();
            this.cmbNumeroImportacion = new System.Windows.Forms.ComboBox();
            this.gbMovimientoES = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistroSalidas)).BeginInit();
            this.gbMovimientoES.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCantidadComprar
            // 
            this.txtCantidadComprar.Location = new System.Drawing.Point(656, 144);
            this.txtCantidadComprar.Name = "txtCantidadComprar";
            this.txtCantidadComprar.Size = new System.Drawing.Size(203, 20);
            this.txtCantidadComprar.TabIndex = 13;
            // 
            // btnExportar
            // 
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(476, 287);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(84, 30);
            this.btnExportar.TabIndex = 12;
            this.btnExportar.Text = "Guardar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(135, 287);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(90, 30);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgRegistroSalidas
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRegistroSalidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgRegistroSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRegistroSalidas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgRegistroSalidas.Location = new System.Drawing.Point(61, 349);
            this.dgRegistroSalidas.Name = "dgRegistroSalidas";
            this.dgRegistroSalidas.ReadOnly = true;
            this.dgRegistroSalidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRegistroSalidas.Size = new System.Drawing.Size(739, 283);
            this.dgRegistroSalidas.TabIndex = 10;
            this.dgRegistroSalidas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRegistroSalidas_CellClick_1);
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(176, 142);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(203, 20);
            this.txtNumeroFactura.TabIndex = 9;
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFactura.Location = new System.Drawing.Point(6, 142);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(146, 20);
            this.lblNumeroFactura.TabIndex = 8;
            this.lblNumeroFactura.Text = "Número de Factura";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(472, 85);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(143, 20);
            this.lblNombreCliente.TabIndex = 7;
            this.lblNombreCliente.Text = "Nombre del Cliente";
            // 
            // lblMovimientoES
            // 
            this.lblMovimientoES.AutoSize = true;
            this.lblMovimientoES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimientoES.Location = new System.Drawing.Point(361, 34);
            this.lblMovimientoES.Name = "lblMovimientoES";
            this.lblMovimientoES.Size = new System.Drawing.Size(133, 20);
            this.lblMovimientoES.TabIndex = 6;
            this.lblMovimientoES.Text = "Movimiento E/S";
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCliente.Location = new System.Drawing.Point(6, 83);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(134, 20);
            this.lblCodigoCliente.TabIndex = 0;
            this.lblCodigoCliente.Text = "Código de Cliente";
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(176, 85);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(203, 20);
            this.txtCodigoCliente.TabIndex = 3;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(656, 85);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(203, 20);
            this.txtNombreCliente.TabIndex = 4;
            // 
            // lblCantidadComprar
            // 
            this.lblCantidadComprar.AutoSize = true;
            this.lblCantidadComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadComprar.Location = new System.Drawing.Point(472, 142);
            this.lblCantidadComprar.Name = "lblCantidadComprar";
            this.lblCantidadComprar.Size = new System.Drawing.Size(151, 20);
            this.lblCantidadComprar.TabIndex = 2;
            this.lblCantidadComprar.Text = "Cantidad a Comprar";
            // 
            // lblNumeroImportacion
            // 
            this.lblNumeroImportacion.AutoSize = true;
            this.lblNumeroImportacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroImportacion.Location = new System.Drawing.Point(472, 207);
            this.lblNumeroImportacion.Name = "lblNumeroImportacion";
            this.lblNumeroImportacion.Size = new System.Drawing.Size(175, 20);
            this.lblNumeroImportacion.TabIndex = 14;
            this.lblNumeroImportacion.Text = "Número de Importación";
            // 
            // lblFechaImportacion
            // 
            this.lblFechaImportacion.AutoSize = true;
            this.lblFechaImportacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaImportacion.Location = new System.Drawing.Point(6, 208);
            this.lblFechaImportacion.Name = "lblFechaImportacion";
            this.lblFechaImportacion.Size = new System.Drawing.Size(164, 20);
            this.lblFechaImportacion.TabIndex = 15;
            this.lblFechaImportacion.Text = "Fecha de Importación";
            // 
            // dtFechaImportacion
            // 
            this.dtFechaImportacion.Location = new System.Drawing.Point(176, 207);
            this.dtFechaImportacion.Name = "dtFechaImportacion";
            this.dtFechaImportacion.Size = new System.Drawing.Size(200, 20);
            this.dtFechaImportacion.TabIndex = 16;
            // 
            // cmbNumeroImportacion
            // 
            this.cmbNumeroImportacion.FormattingEnabled = true;
            this.cmbNumeroImportacion.Location = new System.Drawing.Point(656, 206);
            this.cmbNumeroImportacion.Name = "cmbNumeroImportacion";
            this.cmbNumeroImportacion.Size = new System.Drawing.Size(121, 21);
            this.cmbNumeroImportacion.TabIndex = 17;
            // 
            // gbMovimientoES
            // 
            this.gbMovimientoES.Controls.Add(this.lblMovimientoES);
            this.gbMovimientoES.Controls.Add(this.dgRegistroSalidas);
            this.gbMovimientoES.Controls.Add(this.lblCodigoCliente);
            this.gbMovimientoES.Controls.Add(this.btnExportar);
            this.gbMovimientoES.Controls.Add(this.txtCodigoCliente);
            this.gbMovimientoES.Controls.Add(this.btnActualizar);
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
            this.gbMovimientoES.Location = new System.Drawing.Point(3, 1);
            this.gbMovimientoES.Name = "gbMovimientoES";
            this.gbMovimientoES.Size = new System.Drawing.Size(914, 688);
            this.gbMovimientoES.TabIndex = 18;
            this.gbMovimientoES.TabStop = false;
            this.gbMovimientoES.Text = "Movimiento E/S";
            // 
            // ImportacionesSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 701);
            this.Controls.Add(this.gbMovimientoES);
            this.Name = "ImportacionesSalidas";
            this.Text = "ImportacionesSalidas";
            this.Load += new System.EventHandler(this.ImportacionesSalidas_Load);
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
        private System.Windows.Forms.Label lblMovimientoES;
        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblCantidadComprar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.TextBox txtCantidadComprar;
        private System.Windows.Forms.ComboBox cmbNumeroImportacion;
        private System.Windows.Forms.DateTimePicker dtFechaImportacion;
        private System.Windows.Forms.Label lblFechaImportacion;
        private System.Windows.Forms.Label lblNumeroImportacion;
        private System.Windows.Forms.GroupBox gbMovimientoES;
    }
}