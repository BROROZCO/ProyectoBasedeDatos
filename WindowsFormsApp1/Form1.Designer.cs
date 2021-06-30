
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tABLASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insumoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cERRARAPLICACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROBARCONEXIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tABLASToolStripMenuItem,
            this.rEPORTESToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tABLASToolStripMenuItem
            // 
            this.tABLASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem,
            this.proveedorToolStripMenuItem,
            this.paogToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.habitacionToolStripMenuItem,
            this.puestoToolStripMenuItem,
            this.insumoToolStripMenuItem,
            this.facturaCompraToolStripMenuItem,
            this.facturaVentaToolStripMenuItem,
            this.detalleCompraToolStripMenuItem,
            this.insumoToolStripMenuItem1,
            this.detalleVentaToolStripMenuItem});
            this.tABLASToolStripMenuItem.Name = "tABLASToolStripMenuItem";
            this.tABLASToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.tABLASToolStripMenuItem.Text = "TABLAS";
            this.tABLASToolStripMenuItem.Click += new System.EventHandler(this.tABLASToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            this.proveedorToolStripMenuItem.Click += new System.EventHandler(this.proveedorToolStripMenuItem_Click);
            // 
            // paogToolStripMenuItem
            // 
            this.paogToolStripMenuItem.Name = "paogToolStripMenuItem";
            this.paogToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.paogToolStripMenuItem.Text = "Pago";
            this.paogToolStripMenuItem.Click += new System.EventHandler(this.paogToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // habitacionToolStripMenuItem
            // 
            this.habitacionToolStripMenuItem.Name = "habitacionToolStripMenuItem";
            this.habitacionToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.habitacionToolStripMenuItem.Text = "Habitacion";
            this.habitacionToolStripMenuItem.Click += new System.EventHandler(this.habitacionToolStripMenuItem_Click);
            // 
            // puestoToolStripMenuItem
            // 
            this.puestoToolStripMenuItem.Name = "puestoToolStripMenuItem";
            this.puestoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.puestoToolStripMenuItem.Text = "Puesto";
            this.puestoToolStripMenuItem.Click += new System.EventHandler(this.puestoToolStripMenuItem_Click);
            // 
            // insumoToolStripMenuItem
            // 
            this.insumoToolStripMenuItem.Name = "insumoToolStripMenuItem";
            this.insumoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.insumoToolStripMenuItem.Text = "Empledo";
            this.insumoToolStripMenuItem.Click += new System.EventHandler(this.insumoToolStripMenuItem_Click);
            // 
            // facturaCompraToolStripMenuItem
            // 
            this.facturaCompraToolStripMenuItem.Name = "facturaCompraToolStripMenuItem";
            this.facturaCompraToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.facturaCompraToolStripMenuItem.Text = "FacturaCompra";
            this.facturaCompraToolStripMenuItem.Click += new System.EventHandler(this.facturaCompraToolStripMenuItem_Click);
            // 
            // facturaVentaToolStripMenuItem
            // 
            this.facturaVentaToolStripMenuItem.Name = "facturaVentaToolStripMenuItem";
            this.facturaVentaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.facturaVentaToolStripMenuItem.Text = "FacturaVenta";
            this.facturaVentaToolStripMenuItem.Click += new System.EventHandler(this.facturaVentaToolStripMenuItem_Click);
            // 
            // detalleCompraToolStripMenuItem
            // 
            this.detalleCompraToolStripMenuItem.Name = "detalleCompraToolStripMenuItem";
            this.detalleCompraToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.detalleCompraToolStripMenuItem.Text = "DetalleCompra";
            this.detalleCompraToolStripMenuItem.Click += new System.EventHandler(this.detalleCompraToolStripMenuItem_Click);
            // 
            // insumoToolStripMenuItem1
            // 
            this.insumoToolStripMenuItem1.Name = "insumoToolStripMenuItem1";
            this.insumoToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.insumoToolStripMenuItem1.Text = "Insumo";
            this.insumoToolStripMenuItem1.Click += new System.EventHandler(this.insumoToolStripMenuItem1_Click);
            // 
            // detalleVentaToolStripMenuItem
            // 
            this.detalleVentaToolStripMenuItem.Name = "detalleVentaToolStripMenuItem";
            this.detalleVentaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.detalleVentaToolStripMenuItem.Text = "DetalleVenta";
            this.detalleVentaToolStripMenuItem.Click += new System.EventHandler(this.detalleVentaToolStripMenuItem_Click);
            // 
            // rEPORTESToolStripMenuItem
            // 
            this.rEPORTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeVentasToolStripMenuItem});
            this.rEPORTESToolStripMenuItem.Name = "rEPORTESToolStripMenuItem";
            this.rEPORTESToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.rEPORTESToolStripMenuItem.Text = "REPORTES";
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cERRARAPLICACIONToolStripMenuItem,
            this.pROBARCONEXIONToolStripMenuItem});
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            // 
            // cERRARAPLICACIONToolStripMenuItem
            // 
            this.cERRARAPLICACIONToolStripMenuItem.Name = "cERRARAPLICACIONToolStripMenuItem";
            this.cERRARAPLICACIONToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cERRARAPLICACIONToolStripMenuItem.Text = "CERRAR APLICACION";
            // 
            // pROBARCONEXIONToolStripMenuItem
            // 
            this.pROBARCONEXIONToolStripMenuItem.Name = "pROBARCONEXIONToolStripMenuItem";
            this.pROBARCONEXIONToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.pROBARCONEXIONToolStripMenuItem.Text = "PROBAR CONEXION";
            // 
            // reporteDeVentasToolStripMenuItem
            // 
            this.reporteDeVentasToolStripMenuItem.Name = "reporteDeVentasToolStripMenuItem";
            this.reporteDeVentasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reporteDeVentasToolStripMenuItem.Text = "Reporte de ventas";
            this.reporteDeVentasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVentasToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tABLASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cERRARAPLICACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROBARCONEXIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habitacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insumoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insumoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem detalleVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentasToolStripMenuItem;
    }
}

