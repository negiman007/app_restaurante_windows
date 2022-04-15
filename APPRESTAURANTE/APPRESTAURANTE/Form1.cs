using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPRESTAURANTE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.Show();
        }

        private void tsmiEmpleado_Click(object sender, EventArgs e)
        {
            frmEmpleado empleadoVista = new frmEmpleado();
            empleadoVista.Show();
        }

        private void tsmiUsuario_Click(object sender, EventArgs e)
        {
            FrmBusquedaUsuario frmBusquedaUsuario = new FrmBusquedaUsuario();
            frmBusquedaUsuario.Show();
        }

        private void tsmiMesa_Click(object sender, EventArgs e)
        {

        }

        private void stmiPedidos_Click(object sender, EventArgs e)
        {

        }
    }
}
