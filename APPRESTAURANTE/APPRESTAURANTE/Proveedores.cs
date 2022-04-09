using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using APPRESTAURANTE.Entidades;

namespace APPRESTAURANTE
{
    public partial class Proveedores : Form
    {
        Lista listaNodo = new Lista();
        int contadorIngresos = 0;
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            LimpiarDatos();
            ImprimirLista();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            ImprimirLista();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            int codigoProveedor = int.Parse(txtCodigo.Text);
            string ruc = txtRuc.Text;
            string razon = txtRazon.Text;
            string nombreContacto = txtNombre.Text;
            string telefonoContacto = txtTelefono.Text;
            string celularContacto = txtCelular.Text;
            string emailContacto = txtEmail.Text;
            listaNodo.InsertarProveedor(new Proveedor(codigoProveedor, ruc, razon, nombreContacto, telefonoContacto, celularContacto, emailContacto));
            contadorIngresos = contadorIngresos + 1;
            LimpiarDatos();
            ImprimirLista();
        }

        public void ImprimirLista()
        {
            Proveedor proveedor = new Proveedor();
            List<Proveedor> listaProveedores = listaNodo.GenerarListaProveedores();
            if (listaProveedores.Count > 0 || listaProveedores != null)
            {
                /* Ordenamos la lista */
                List<Proveedor> listaProveedoresOrder = listaProveedores.OrderBy(o => o.codigoProveedor).ToList();
                var bindingListProveedores = new BindingList<Proveedor>(listaProveedoresOrder);
                BindingSource origenProveedor = new BindingSource(bindingListProveedores, null);
                dgvProveedor.DataSource = origenProveedor;
            }
        }

        public void LimpiarDatos()
        {
            txtCodigo.Enabled = false;
            int codigoGenerado = listaNodo.GenerarCorrelativoProveedor(contadorIngresos);
            txtCodigo.Text = codigoGenerado.ToString();
            txtRuc.Text = String.Empty;
            txtRazon.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtTelefono.Text = String.Empty;
            txtCelular.Text = String.Empty;
            txtEmail.Text = String.Empty;
        }
        
    }
}
