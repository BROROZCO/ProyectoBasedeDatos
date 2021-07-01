
namespace WindowsFormsApp1.FORMULARIOS
{
    partial class Empledo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.DATOS = new System.Windows.Forms.GroupBox();
            this.txtSexoCB = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtApellidoSegundo = new System.Windows.Forms.TextBox();
            this.txtEstadoCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txTelefono = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtCodigoPuesto = new System.Windows.Forms.TextBox();
            this.txtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.txtApellidoPrimero = new System.Windows.Forms.TextBox();
            this.txtNombreSegundo = new System.Windows.Forms.TextBox();
            this.txtNombrePrimero = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.datadridEmpleados = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.DATOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datadridEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.DATOS);
            this.panel1.Controls.Add(this.datadridEmpleados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 578);
            this.panel1.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(773, 527);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(113, 39);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(532, 527);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 39);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(292, 527);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(113, 39);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 527);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 39);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // DATOS
            // 
            this.DATOS.Controls.Add(this.txtSexoCB);
            this.DATOS.Controls.Add(this.label13);
            this.DATOS.Controls.Add(this.txtApellidoSegundo);
            this.DATOS.Controls.Add(this.txtEstadoCB);
            this.DATOS.Controls.Add(this.label7);
            this.DATOS.Controls.Add(this.label8);
            this.DATOS.Controls.Add(this.label9);
            this.DATOS.Controls.Add(this.label10);
            this.DATOS.Controls.Add(this.label11);
            this.DATOS.Controls.Add(this.label12);
            this.DATOS.Controls.Add(this.label6);
            this.DATOS.Controls.Add(this.label5);
            this.DATOS.Controls.Add(this.label4);
            this.DATOS.Controls.Add(this.label3);
            this.DATOS.Controls.Add(this.label2);
            this.DATOS.Controls.Add(this.label1);
            this.DATOS.Controls.Add(this.txTelefono);
            this.DATOS.Controls.Add(this.txtfecha);
            this.DATOS.Controls.Add(this.txtEdad);
            this.DATOS.Controls.Add(this.txtCodigoPuesto);
            this.DATOS.Controls.Add(this.txtCodigoEmpleado);
            this.DATOS.Controls.Add(this.txtApellidoPrimero);
            this.DATOS.Controls.Add(this.txtNombreSegundo);
            this.DATOS.Controls.Add(this.txtNombrePrimero);
            this.DATOS.Controls.Add(this.txtpassword);
            this.DATOS.Controls.Add(this.txtUsuario);
            this.DATOS.Location = new System.Drawing.Point(12, 12);
            this.DATOS.Name = "DATOS";
            this.DATOS.Size = new System.Drawing.Size(874, 290);
            this.DATOS.TabIndex = 1;
            this.DATOS.TabStop = false;
            this.DATOS.Text = "DATOS";
            // 
            // txtSexoCB
            // 
            this.txtSexoCB.FormattingEnabled = true;
            this.txtSexoCB.Items.AddRange(new object[] {
            "M",
            "F"});
            this.txtSexoCB.Location = new System.Drawing.Point(161, 101);
            this.txtSexoCB.Name = "txtSexoCB";
            this.txtSexoCB.Size = new System.Drawing.Size(232, 21);
            this.txtSexoCB.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(474, 256);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Segundo Apellido";
            // 
            // txtApellidoSegundo
            // 
            this.txtApellidoSegundo.Location = new System.Drawing.Point(587, 254);
            this.txtApellidoSegundo.Name = "txtApellidoSegundo";
            this.txtApellidoSegundo.Size = new System.Drawing.Size(232, 20);
            this.txtApellidoSegundo.TabIndex = 25;
            // 
            // txtEstadoCB
            // 
            this.txtEstadoCB.FormattingEnabled = true;
            this.txtEstadoCB.Items.AddRange(new object[] {
            "Habilitada",
            "Deshabilitada"});
            this.txtEstadoCB.Location = new System.Drawing.Point(587, 98);
            this.txtEstadoCB.Name = "txtEstadoCB";
            this.txtEstadoCB.Size = new System.Drawing.Size(232, 21);
            this.txtEstadoCB.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(474, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Primer Apellido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(474, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Primer Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(474, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Segundo Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(474, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Estado de Cuenta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(474, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Contraseña";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(474, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha Ingreso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sexo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Codigo Puesto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Codigo Empleado";
            // 
            // txTelefono
            // 
            this.txTelefono.Location = new System.Drawing.Point(161, 217);
            this.txTelefono.Name = "txTelefono";
            this.txTelefono.Size = new System.Drawing.Size(232, 20);
            this.txTelefono.TabIndex = 11;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(161, 180);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(232, 20);
            this.txtfecha.TabIndex = 10;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(161, 139);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(232, 20);
            this.txtEdad.TabIndex = 9;
            // 
            // txtCodigoPuesto
            // 
            this.txtCodigoPuesto.Location = new System.Drawing.Point(161, 58);
            this.txtCodigoPuesto.Name = "txtCodigoPuesto";
            this.txtCodigoPuesto.Size = new System.Drawing.Size(232, 20);
            this.txtCodigoPuesto.TabIndex = 7;
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(161, 19);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(232, 20);
            this.txtCodigoEmpleado.TabIndex = 6;
            // 
            // txtApellidoPrimero
            // 
            this.txtApellidoPrimero.Location = new System.Drawing.Point(587, 217);
            this.txtApellidoPrimero.Name = "txtApellidoPrimero";
            this.txtApellidoPrimero.Size = new System.Drawing.Size(232, 20);
            this.txtApellidoPrimero.TabIndex = 5;
            // 
            // txtNombreSegundo
            // 
            this.txtNombreSegundo.Location = new System.Drawing.Point(587, 180);
            this.txtNombreSegundo.Name = "txtNombreSegundo";
            this.txtNombreSegundo.Size = new System.Drawing.Size(232, 20);
            this.txtNombreSegundo.TabIndex = 4;
            // 
            // txtNombrePrimero
            // 
            this.txtNombrePrimero.Location = new System.Drawing.Point(587, 139);
            this.txtNombrePrimero.Name = "txtNombrePrimero";
            this.txtNombrePrimero.Size = new System.Drawing.Size(232, 20);
            this.txtNombrePrimero.TabIndex = 3;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(587, 58);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(232, 20);
            this.txtpassword.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(587, 19);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(232, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // datadridEmpleados
            // 
            this.datadridEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datadridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datadridEmpleados.Location = new System.Drawing.Point(12, 308);
            this.datadridEmpleados.Name = "datadridEmpleados";
            this.datadridEmpleados.Size = new System.Drawing.Size(874, 201);
            this.datadridEmpleados.TabIndex = 0;
            this.datadridEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datadridEmpleados_CellContentClick);
            // 
            // Empledo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 578);
            this.Controls.Add(this.panel1);
            this.Name = "Empledo";
            this.Text = "Empledo";
            this.Load += new System.EventHandler(this.Empledo_Load);
            this.panel1.ResumeLayout(false);
            this.DATOS.ResumeLayout(false);
            this.DATOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datadridEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView datadridEmpleados;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox DATOS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtApellidoSegundo;
        private System.Windows.Forms.ComboBox txtEstadoCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txTelefono;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtCodigoPuesto;
        private System.Windows.Forms.TextBox txtCodigoEmpleado;
        private System.Windows.Forms.TextBox txtApellidoPrimero;
        private System.Windows.Forms.TextBox txtNombreSegundo;
        private System.Windows.Forms.TextBox txtNombrePrimero;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ComboBox txtSexoCB;
    }
}