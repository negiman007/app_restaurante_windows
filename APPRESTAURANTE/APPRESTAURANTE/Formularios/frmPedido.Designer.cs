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
            this.SuspendLayout();
            // 
            // lblTituloPedido
            // 
            this.lblTituloPedido.AutoSize = true;
            this.lblTituloPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPedido.Location = new System.Drawing.Point(239, 30);
            this.lblTituloPedido.Name = "lblTituloPedido";
            this.lblTituloPedido.Size = new System.Drawing.Size(199, 29);
            this.lblTituloPedido.TabIndex = 0;
            this.lblTituloPedido.Text = "Generar Pedido";
            // 
            // lblCodigoPedido
            // 
            this.lblCodigoPedido.AutoSize = true;
            this.lblCodigoPedido.Location = new System.Drawing.Point(76, 106);
            this.lblCodigoPedido.Name = "lblCodigoPedido";
            this.lblCodigoPedido.Size = new System.Drawing.Size(117, 16);
            this.lblCodigoPedido.TabIndex = 1;
            this.lblCodigoPedido.Text = "Código de Pedido";
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Location = new System.Drawing.Point(76, 140);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(41, 16);
            this.lblMesa.TabIndex = 2;
            this.lblMesa.Text = "Mesa";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(76, 174);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(88, 16);
            this.lblMenu.TabIndex = 3;
            this.lblMenu.Text = "Tipo de Plato";
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.lblCodigoPedido);
            this.Controls.Add(this.lblTituloPedido);
            this.Name = "frmPedido";
            this.Text = "frmPedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloPedido;
        private System.Windows.Forms.Label lblCodigoPedido;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label lblMenu;
    }
}