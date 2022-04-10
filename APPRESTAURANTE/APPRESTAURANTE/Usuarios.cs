using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APPRESTAURANTE.Entidades.Enum;
using APPRESTAURANTE.Entidades;

namespace APPRESTAURANTE
{
    public partial class Usuarios : Form
    {
        int contador = 0;
        UsuarioLista listaNodo = new UsuarioLista();
        public Usuarios()
        {
            InitializeComponent();
            comboEstados();
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboEstados()
        {
            foreach (var item in Enum.GetValues(typeof(Estado)))
            {
                cboEstado.Items.Add(item);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.idUsuario = txtCodigo.Text;
            usuario.usuario = txtUsuario.Text;
            usuario.clave = txtClave.Text;
            usuario.estado = cboEstado.Text == "inactivo" ? false: true ;            
            usuario.idEmpleado = txtEmpleado.Text;
            listaNodo.InsertarUsuario(usuario);
            //contador += contador;
            ImprimirLista();
        }

        public void ImprimirLista()
        {
            Usuario usuario = new Usuario();
            List<Usuario> listaUsuarios = listaNodo.GenerarListaProveedores();
            if (listaUsuarios.Count > 0 || listaUsuarios != null)
            {
                /* Ordenamos la lista */
                List<Usuario> listaProveedoresOrder = listaUsuarios.OrderBy(o => o.idUsuario).ToList();
                var bindingListProveedores = new BindingList<Usuario>(listaProveedoresOrder);
                BindingSource origenProveedor = new BindingSource(bindingListProveedores, null);
                dgvProveedor.DataSource = origenProveedor;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
