namespace Salidas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbRegistroSalidas = new System.Windows.Forms.GroupBox();
            this.dgRegistroSalidas = new System.Windows.Forms.DataGridView();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigoFactura = new System.Windows.Forms.TextBox();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblRegistroSalida = new System.Windows.Forms.Label();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.nudCantidadComprar = new System.Windows.Forms.NumericUpDown();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblCantidadComprar = new System.Windows.Forms.Label();
            this.gbRegistroSalidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistroSalidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadComprar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRegistroSalidas
            // 
            this.gbRegistroSalidas.Controls.Add(this.dgRegistroSalidas);
            this.gbRegistroSalidas.Controls.Add(this.txtCodigoFactura);
            this.gbRegistroSalidas.Controls.Add(this.lblNumeroFactura);
            this.gbRegistroSalidas.Controls.Add(this.lblNombreCliente);
            this.gbRegistroSalidas.Controls.Add(this.lblRegistroSalida);
            this.gbRegistroSalidas.Controls.Add(this.lblCodigoCliente);
            this.gbRegistroSalidas.Controls.Add(this.nudCantidadComprar);
            this.gbRegistroSalidas.Controls.Add(this.txtCodigoCliente);
            this.gbRegistroSalidas.Controls.Add(this.txtNombreCliente);
            this.gbRegistroSalidas.Controls.Add(this.lblCantidadComprar);
            this.gbRegistroSalidas.Location = new System.Drawing.Point(12, 12);
            this.gbRegistroSalidas.Name = "gbRegistroSalidas";
            this.gbRegistroSalidas.Size = new System.Drawing.Size(908, 548);
            this.gbRegistroSalidas.TabIndex = 7;
            this.gbRegistroSalidas.TabStop = false;
            this.gbRegistroSalidas.Text = "Registro de Salidas";
            // 
            // dgRegistroSalidas
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRegistroSalidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgRegistroSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRegistroSalidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRegistroSalidas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgRegistroSalidas.Location = new System.Drawing.Point(39, 246);
            this.dgRegistroSalidas.Name = "dgRegistroSalidas";
            this.dgRegistroSalidas.Size = new System.Drawing.Size(848, 257);
            this.dgRegistroSalidas.TabIndex = 10;
            // 
            // column1
            // 
            this.column1.HeaderText = "Código de Cliente";
            this.column1.Name = "column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre del Cliente";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Número de Factura";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad a Comprar";
            this.Column4.Name = "Column4";
            // 
            // txtCodigoFactura
            // 
            this.txtCodigoFactura.Location = new System.Drawing.Point(205, 188);
            this.txtCodigoFactura.Name = "txtCodigoFactura";
            this.txtCodigoFactura.Size = new System.Drawing.Size(203, 20);
            this.txtCodigoFactura.TabIndex = 9;
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFactura.Location = new System.Drawing.Point(35, 186);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(146, 20);
            this.lblNumeroFactura.TabIndex = 8;
            this.lblNumeroFactura.Text = "Número de Factura";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(462, 101);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(143, 20);
            this.lblNombreCliente.TabIndex = 7;
            this.lblNombreCliente.Text = "Nombre del Cliente";
            // 
            // lblRegistroSalida
            // 
            this.lblRegistroSalida.AutoSize = true;
            this.lblRegistroSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroSalida.Location = new System.Drawing.Point(358, 38);
            this.lblRegistroSalida.Name = "lblRegistroSalida";
            this.lblRegistroSalida.Size = new System.Drawing.Size(147, 20);
            this.lblRegistroSalida.TabIndex = 6;
            this.lblRegistroSalida.Text = "Registro de Salidas";
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCliente.Location = new System.Drawing.Point(35, 101);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(134, 20);
            this.lblCodigoCliente.TabIndex = 0;
            this.lblCodigoCliente.Text = "Código de Cliente";
            // 
            // nudCantidadComprar
            // 
            this.nudCantidadComprar.Location = new System.Drawing.Point(622, 186);
            this.nudCantidadComprar.Name = "nudCantidadComprar";
            this.nudCantidadComprar.Size = new System.Drawing.Size(103, 20);
            this.nudCantidadComprar.TabIndex = 5;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(205, 101);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(203, 20);
            this.txtCodigoCliente.TabIndex = 3;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(622, 103);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(203, 20);
            this.txtNombreCliente.TabIndex = 4;
            // 
            // lblCantidadComprar
            // 
            this.lblCantidadComprar.AutoSize = true;
            this.lblCantidadComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadComprar.Location = new System.Drawing.Point(454, 188);
            this.lblCantidadComprar.Name = "lblCantidadComprar";
            this.lblCantidadComprar.Size = new System.Drawing.Size(151, 20);
            this.lblCantidadComprar.TabIndex = 2;
            this.lblCantidadComprar.Text = "Cantidad a Comprar";
            // 
            // ImportacionesSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 569);
            this.Controls.Add(this.gbRegistroSalidas);
            this.Name = "ImportacionesSalidas";
            this.Text = "ImportacionesSalidas";
            this.gbRegistroSalidas.ResumeLayout(false);
            this.gbRegistroSalidas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistroSalidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadComprar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistroSalidas;
        private System.Windows.Forms.DataGridView dgRegistroSalidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtCodigoFactura;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblRegistroSalida;
        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.NumericUpDown nudCantidadComprar;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblCantidadComprar;
    }
}