﻿namespace Proyectoimportaciones_v1
{
    partial class Importaciones
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
            this.mnuimportacionesEntrada = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuimportaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMovimienES = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuimportacionesEntrada
            // 
            this.mnuimportacionesEntrada.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuimportaciones,
            this.mnuMovimienES});
            this.mnuimportacionesEntrada.Name = "mnuimportacionesEntrada";
            this.mnuimportacionesEntrada.Size = new System.Drawing.Size(95, 20);
            this.mnuimportacionesEntrada.Text = "Importaciones";
            // 
            // mnuimportaciones
            // 
            this.mnuimportaciones.Name = "mnuimportaciones";
            this.mnuimportaciones.Size = new System.Drawing.Size(180, 22);
            this.mnuimportaciones.Text = "Importaciones";
            this.mnuimportaciones.Click += new System.EventHandler(this.mnuImportacionesEntradas_Click);
            // 
            // mnuMovimienES
            // 
            this.mnuMovimienES.Name = "mnuMovimienES";
            this.mnuMovimienES.Size = new System.Drawing.Size(180, 22);
            this.mnuMovimienES.Text = "Movimiento E/S";
            this.mnuMovimienES.Click += new System.EventHandler(this.mnuImportacionesSalidas_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuimportacionesEntrada,
            this.mnuProveedor,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuProveedor
            // 
            this.mnuProveedor.Name = "mnuProveedor";
            this.mnuProveedor.Size = new System.Drawing.Size(73, 20);
            this.mnuProveedor.Text = "Proveedor";
            this.mnuProveedor.Click += new System.EventHandler(this.mnuProveedor_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 395);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Estado";
            // 
            // Importaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Importaciones";
            this.Text = "Importaciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuimportacionesEntrada;
        private System.Windows.Forms.ToolStripMenuItem mnuimportaciones;
        private System.Windows.Forms.ToolStripMenuItem mnuMovimienES;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuProveedor;
    }
}