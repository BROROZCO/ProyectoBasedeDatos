
namespace WindowsFormsApp1.FORMULARIOS
{
    partial class Producto
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
            this.dataGridProducto = new System.Windows.Forms.DataGridView();
            this.BTNAGREGAR = new System.Windows.Forms.Button();
            this.BNTMODIFICAR = new System.Windows.Forms.Button();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.BTNACTULIZAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducto)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridProducto
            // 
            this.dataGridProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducto.Location = new System.Drawing.Point(28, 198);
            this.dataGridProducto.Name = "dataGridProducto";
            this.dataGridProducto.RowHeadersWidth = 50;
            this.dataGridProducto.Size = new System.Drawing.Size(737, 222);
            this.dataGridProducto.TabIndex = 0;
            this.dataGridProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BTNAGREGAR
            // 
            this.BTNAGREGAR.Location = new System.Drawing.Point(26, 468);
            this.BTNAGREGAR.Name = "BTNAGREGAR";
            this.BTNAGREGAR.Size = new System.Drawing.Size(129, 38);
            this.BTNAGREGAR.TabIndex = 1;
            this.BTNAGREGAR.Text = "AGREGAR";
            this.BTNAGREGAR.UseVisualStyleBackColor = true;
            this.BTNAGREGAR.Click += new System.EventHandler(this.BTNAGREGAR_Click);
            // 
            // BNTMODIFICAR
            // 
            this.BNTMODIFICAR.Location = new System.Drawing.Point(243, 468);
            this.BNTMODIFICAR.Name = "BNTMODIFICAR";
            this.BNTMODIFICAR.Size = new System.Drawing.Size(129, 38);
            this.BNTMODIFICAR.TabIndex = 2;
            this.BNTMODIFICAR.Text = "MODIFICAR";
            this.BNTMODIFICAR.UseVisualStyleBackColor = true;
            this.BNTMODIFICAR.Click += new System.EventHandler(this.BNTMODIFICAR_Click);
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.Location = new System.Drawing.Point(438, 468);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(129, 38);
            this.BTNELIMINAR.TabIndex = 3;
            this.BTNELIMINAR.Text = "ELIMINAR";
            this.BTNELIMINAR.UseVisualStyleBackColor = true;
            this.BTNELIMINAR.Click += new System.EventHandler(this.BTNELIMINAR_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataGridProducto);
            this.panel1.Controls.Add(this.BTNACTULIZAR);
            this.panel1.Controls.Add(this.BTNELIMINAR);
            this.panel1.Controls.Add(this.BTNAGREGAR);
            this.panel1.Controls.Add(this.BNTMODIFICAR);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 527);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbTipoProducto);
            this.groupBox1.Controls.Add(this.txtPrecioProducto);
            this.groupBox1.Controls.Add(this.txtNombreProducto);
            this.groupBox1.Location = new System.Drawing.Point(28, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 164);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Codigo del Producto";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(275, 36);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(413, 20);
            this.txtId.TabIndex = 6;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo del Producto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio del Producto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del Producto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Items.AddRange(new object[] {
            "Comida",
            "Bebida",
            "Otro"});
            this.cmbTipoProducto.Location = new System.Drawing.Point(275, 114);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(413, 21);
            this.cmbTipoProducto.TabIndex = 2;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(275, 88);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(413, 20);
            this.txtPrecioProducto.TabIndex = 1;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(275, 62);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(413, 20);
            this.txtNombreProducto.TabIndex = 0;
            this.txtNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProducto_KeyPress);
            // 
            // BTNACTULIZAR
            // 
            this.BTNACTULIZAR.Location = new System.Drawing.Point(636, 468);
            this.BTNACTULIZAR.Name = "BTNACTULIZAR";
            this.BTNACTULIZAR.Size = new System.Drawing.Size(129, 38);
            this.BTNACTULIZAR.TabIndex = 4;
            this.BTNACTULIZAR.Text = "BUSCAR";
            this.BTNACTULIZAR.UseVisualStyleBackColor = true;
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.panel1);
            this.Name = "Producto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProducto;
        private System.Windows.Forms.Button BTNAGREGAR;
        private System.Windows.Forms.Button BNTMODIFICAR;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button BTNACTULIZAR;
    }
}