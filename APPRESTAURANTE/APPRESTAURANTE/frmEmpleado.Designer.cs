namespace APPRESTAURANTE
{
    partial class frmEmpleado
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
            this.btnConsultaEmp = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblCodigoEmpelado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellidoPaternoEmpleado = new System.Windows.Forms.TextBox();
            this.txtApellidoMaternoEmpleado = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTipoDocumento = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultaEmp
            // 
            this.btnConsultaEmp.AutoSize = true;
            this.btnConsultaEmp.Location = new System.Drawing.Point(211, 227);
            this.btnConsultaEmp.Name = "btnConsultaEmp";
            this.btnConsultaEmp.Size = new System.Drawing.Size(143, 46);
            this.btnConsultaEmp.TabIndex = 0;
            this.btnConsultaEmp.Text = "Consultar";
            this.btnConsultaEmp.UseVisualStyleBackColor = true;
            this.btnConsultaEmp.Click += new System.EventHandler(this.btnConsultaEmp_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoSize = true;
            this.btnRegistrar.Location = new System.Drawing.Point(398, 227);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(180, 46);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar Empleado";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblCodigoEmpelado
            // 
            this.lblCodigoEmpelado.AutoSize = true;
            this.lblCodigoEmpelado.Location = new System.Drawing.Point(102, 154);
            this.lblCodigoEmpelado.Name = "lblCodigoEmpelado";
            this.lblCodigoEmpelado.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoEmpelado.TabIndex = 2;
            this.lblCodigoEmpelado.Text = "Código:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(102, 195);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombres:";
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.Enabled = false;
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(196, 151);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoEmpleado.TabIndex = 4;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(196, 189);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(100, 22);
            this.txtNombreEmpleado.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Apellido Materno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido Paterno:";
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.Location = new System.Drawing.Point(381, 42);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(328, 29);
            this.lblEtiqueta.TabIndex = 9;
            this.lblEtiqueta.Text = "Mantenedor de Empleados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(642, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(642, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo Documento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(936, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Documento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(947, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // txtApellidoPaternoEmpleado
            // 
            this.txtApellidoPaternoEmpleado.Location = new System.Drawing.Point(478, 148);
            this.txtApellidoPaternoEmpleado.Name = "txtApellidoPaternoEmpleado";
            this.txtApellidoPaternoEmpleado.Size = new System.Drawing.Size(100, 22);
            this.txtApellidoPaternoEmpleado.TabIndex = 14;
            // 
            // txtApellidoMaternoEmpleado
            // 
            this.txtApellidoMaternoEmpleado.Location = new System.Drawing.Point(478, 189);
            this.txtApellidoMaternoEmpleado.Name = "txtApellidoMaternoEmpleado";
            this.txtApellidoMaternoEmpleado.Size = new System.Drawing.Size(100, 22);
            this.txtApellidoMaternoEmpleado.TabIndex = 15;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(765, 151);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 22);
            this.txtDireccion.TabIndex = 16;
            // 
            // txtTipoDocumento
            // 
            this.txtTipoDocumento.Location = new System.Drawing.Point(765, 186);
            this.txtTipoDocumento.Name = "txtTipoDocumento";
            this.txtTipoDocumento.Size = new System.Drawing.Size(100, 22);
            this.txtTipoDocumento.TabIndex = 17;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(1036, 151);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 22);
            this.txtDocumento.TabIndex = 18;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvEmpleados.Location = new System.Drawing.Point(46, 338);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(1121, 348);
            this.dgvEmpleados.TabIndex = 19;
            this.dgvEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo Empleado";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 134;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre de Empleado";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 155;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apellido Paterno";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Apellido Materno";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 127;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Dirección";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 93;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tipo de Documento";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 142;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Numero de Documento";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 160;
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSize = true;
            this.btnModificar.Location = new System.Drawing.Point(627, 227);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(175, 46);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar Empleado";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1224, 808);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtTipoDocumento);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellidoMaternoEmpleado);
            this.Controls.Add(this.txtApellidoPaternoEmpleado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.txtCodigoEmpleado);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigoEmpelado);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnConsultaEmp);
            this.Name = "frmEmpleado";
            this.Text = "frmEmpleado";
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultaEmp;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblCodigoEmpelado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigoEmpleado;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApellidoPaternoEmpleado;
        private System.Windows.Forms.TextBox txtApellidoMaternoEmpleado;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTipoDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnModificar;
    }
}