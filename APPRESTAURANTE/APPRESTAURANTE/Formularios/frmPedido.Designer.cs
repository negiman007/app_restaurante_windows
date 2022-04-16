namespace APPRESTAURANTE.Formularios
{
    partial class frmPedido
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
            this.lblTituloPedido = new System.Windows.Forms.Label();
            this.lblCodigoPedido = new System.Windows.Forms.Label();
            this.lblMesa = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblPlato = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.gbDatosPedidoDetalle = new System.Windows.Forms.GroupBox();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.nupCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.cboMenu = new System.Windows.Forms.ComboBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cboMesa = new System.Windows.Forms.ComboBox();
            this.txtNumeroPedido = new System.Windows.Forms.TextBox();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDatosPedido = new System.Windows.Forms.GroupBox();
            this.gbDatosPedidoDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.gbDatosPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloPedido
            // 
            this.lblTituloPedido.AutoSize = true;
            this.lblTituloPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPedido.Location = new System.Drawing.Point(346, 20);
            this.lblTituloPedido.Name = "lblTituloPedido";
            this.lblTituloPedido.Size = new System.Drawing.Size(199, 29);
            this.lblTituloPedido.TabIndex = 0;
            this.lblTituloPedido.Text = "Generar Pedido";
            // 
            // lblCodigoPedido
            // 
            this.lblCodigoPedido.AutoSize = true;
            this.lblCodigoPedido.Location = new System.Drawing.Point(82, 27);
            this.lblCodigoPedido.Name = "lblCodigoPedido";
            this.lblCodigoPedido.Size = new System.Drawing.Size(120, 16);
            this.lblCodigoPedido.TabIndex = 1;
            this.lblCodigoPedido.Text = "Código de Pedido:";
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Location = new System.Drawing.Point(82, 68);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(44, 16);
            this.lblMesa.TabIndex = 2;
            this.lblMesa.Text = "Mesa:";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(82, 41);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(91, 16);
            this.lblMenu.TabIndex = 3;
            this.lblMenu.Text = "Tipo de Plato:";
            // 
            // lblPlato
            // 
            this.lblPlato.AutoSize = true;
            this.lblPlato.Location = new System.Drawing.Point(82, 76);
            this.lblPlato.Name = "lblPlato";
            this.lblPlato.Size = new System.Drawing.Size(41, 16);
            this.lblPlato.TabIndex = 4;
            this.lblPlato.Text = "Plato:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(82, 102);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(73, 16);
            this.lblEmpleado.TabIndex = 5;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // gbDatosPedidoDetalle
            // 
            this.gbDatosPedidoDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDatosPedidoDetalle.Controls.Add(this.nupCantidad);
            this.gbDatosPedidoDetalle.Controls.Add(this.lblCantidad);
            this.gbDatosPedidoDetalle.Controls.Add(this.cboMenu);
            this.gbDatosPedidoDetalle.Controls.Add(this.cboTipo);
            this.gbDatosPedidoDetalle.Controls.Add(this.lblMenu);
            this.gbDatosPedidoDetalle.Controls.Add(this.lblPlato);
            this.gbDatosPedidoDetalle.Location = new System.Drawing.Point(54, 225);
            this.gbDatosPedidoDetalle.Name = "gbDatosPedidoDetalle";
            this.gbDatosPedidoDetalle.Size = new System.Drawing.Size(831, 155);
            this.gbDatosPedidoDetalle.TabIndex = 6;
            this.gbDatosPedidoDetalle.TabStop = false;
            this.gbDatosPedidoDetalle.Text = "Detalle del Pedido:";
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPedido.Location = new System.Drawing.Point(154, 386);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(231, 41);
            this.btnAgregarPedido.TabIndex = 14;
            this.btnAgregarPedido.Text = "Agregar";
            this.btnAgregarPedido.UseVisualStyleBackColor = true;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // nupCantidad
            // 
            this.nupCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nupCantidad.Location = new System.Drawing.Point(259, 107);
            this.nupCantidad.Name = "nupCantidad";
            this.nupCantidad.Size = new System.Drawing.Size(231, 22);
            this.nupCantidad.TabIndex = 13;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(82, 113);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 16);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(259, 99);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(231, 24);
            this.cboEmpleado.TabIndex = 10;
            // 
            // cboMenu
            // 
            this.cboMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMenu.FormattingEnabled = true;
            this.cboMenu.Location = new System.Drawing.Point(259, 68);
            this.cboMenu.Name = "cboMenu";
            this.cboMenu.Size = new System.Drawing.Size(231, 24);
            this.cboMenu.TabIndex = 9;
            // 
            // cboTipo
            // 
            this.cboTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(259, 33);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(231, 24);
            this.cboTipo.TabIndex = 8;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // cboMesa
            // 
            this.cboMesa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMesa.FormattingEnabled = true;
            this.cboMesa.Location = new System.Drawing.Point(259, 60);
            this.cboMesa.Name = "cboMesa";
            this.cboMesa.Size = new System.Drawing.Size(231, 24);
            this.cboMesa.TabIndex = 7;
            // 
            // txtNumeroPedido
            // 
            this.txtNumeroPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroPedido.Enabled = false;
            this.txtNumeroPedido.Location = new System.Drawing.Point(259, 21);
            this.txtNumeroPedido.Name = "txtNumeroPedido";
            this.txtNumeroPedido.ReadOnly = true;
            this.txtNumeroPedido.Size = new System.Drawing.Size(231, 22);
            this.txtNumeroPedido.TabIndex = 6;
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.subTotal,
            this.Column7,
            this.Column8});
            this.dgvPedido.Location = new System.Drawing.Point(54, 455);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.RowHeadersWidth = 51;
            this.dgvPedido.RowTemplate.Height = 24;
            this.dgvPedido.Size = new System.Drawing.Size(831, 190);
            this.dgvPedido.TabIndex = 7;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(313, 695);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(231, 50);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar Pedido";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(254, 667);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(151, 22);
            this.txtTotal.TabIndex = 15;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(136, 673);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 16);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(541, 386);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(231, 41);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero Pedido";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Codigo Menu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Menu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "cantidad";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // subTotal
            // 
            this.subTotal.HeaderText = "SubTotal";
            this.subTotal.MinimumWidth = 6;
            this.subTotal.Name = "subTotal";
            this.subTotal.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Codigo Mesa";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Codigo Empleado";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            this.Column8.Width = 125;
            // 
            // gbDatosPedido
            // 
            this.gbDatosPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDatosPedido.Controls.Add(this.lblCodigoPedido);
            this.gbDatosPedido.Controls.Add(this.txtNumeroPedido);
            this.gbDatosPedido.Controls.Add(this.cboMesa);
            this.gbDatosPedido.Controls.Add(this.lblMesa);
            this.gbDatosPedido.Controls.Add(this.cboEmpleado);
            this.gbDatosPedido.Controls.Add(this.lblEmpleado);
            this.gbDatosPedido.Location = new System.Drawing.Point(54, 86);
            this.gbDatosPedido.Name = "gbDatosPedido";
            this.gbDatosPedido.Size = new System.Drawing.Size(831, 133);
            this.gbDatosPedido.TabIndex = 17;
            this.gbDatosPedido.TabStop = false;
            this.gbDatosPedido.Text = "Datos del Pedido:";
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 754);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gbDatosPedido);
            this.Controls.Add(this.btnAgregarPedido);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.gbDatosPedidoDetalle);
            this.Controls.Add(this.lblTituloPedido);
            this.Name = "frmPedido";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.gbDatosPedidoDetalle.ResumeLayout(false);
            this.gbDatosPedidoDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.gbDatosPedido.ResumeLayout(false);
            this.gbDatosPedido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloPedido;
        private System.Windows.Forms.Label lblCodigoPedido;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblPlato;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.GroupBox gbDatosPedidoDetalle;
        private System.Windows.Forms.TextBox txtNumeroPedido;
        private System.Windows.Forms.NumericUpDown nupCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.ComboBox cboMenu;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ComboBox cboMesa;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.GroupBox gbDatosPedido;
    }
}