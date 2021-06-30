using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.FORMULARIOS;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void tABLASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto FormCliente = new Producto();
            FormCliente.MdiParent = this;
            FormCliente.Show();
        }

        private void paogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pago FormPago = new Pago();
            FormPago.MdiParent = this;
            FormPago.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedor FormProvedor = new Proveedor();
            FormProvedor.MdiParent = this;
            FormProvedor.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente ClienteForm = new Cliente();
            ClienteForm.MdiParent = this;
            ClienteForm.Show();
        }

        private void habitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Habitacion FormHabitacion = new Habitacion();
            FormHabitacion.MdiParent = this;
            FormHabitacion.Show();
        }

        private void puestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Puesto FormPuesto = new Puesto();
            FormPuesto.MdiParent = this;
            FormPuesto.Show();
        }
        private void insumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empledo FormEmpledo = new Empledo();
            FormEmpledo.MdiParent = this;
            FormEmpledo.Show();

        }

        private void facturaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacturaCompra FormFacturaCompra = new FacturaCompra();
            FormFacturaCompra.MdiParent = this;
            FormFacturaCompra.Show();
        }

        private void facturaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacturaVenta FormFacturaVenta = new FacturaVenta();
            FormFacturaVenta.MdiParent = this;
            FormFacturaVenta.Show();
        }

        private void detalleCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetalleCompra FormDetalleComapra = new DetalleCompra();
            FormDetalleComapra.MdiParent = this;
            FormDetalleComapra.Show();
        }

        private void insumoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Insumo Forminsumo = new Insumo();
            Forminsumo.MdiParent = this;
            Forminsumo.Show();
        }

        private void detalleVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetalleVenta FormDetalleVenta = new DetalleVenta();
            FormDetalleVenta.MdiParent = this;
            FormDetalleVenta.Show();
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
