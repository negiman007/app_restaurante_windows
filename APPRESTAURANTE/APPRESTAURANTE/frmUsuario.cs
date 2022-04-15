using System;
using System.Collections.Generic;
using System.Windows.Forms;
using APPRESTAURANTE.Entidades;
using APPRESTAURANTE.Entidades.Enum;
using APPRESTAURANTE.Nodo;

namespace APPRESTAURANTE
{
    public partial class frmUsuario : Form
    {
        private Form _parent;
        ListaGenerica<Usuario> listaNodoUsuario = new ListaGenerica<Usuario>(@"D:\Json\bdUsuario.json");
        ListaGenerica<Empleado> listaNodoEmpleado = new ListaGenerica<Empleado>(@"D:\Json\bdEmpleado.json");

        public frmUsuario(Form parent)
        {
            _parent = parent;
        }

        public frmUsuario()
        {
            
            InitializeComponent();
            listaNodoUsuario.Cargar();
            listaNodoEmpleado.Cargar();
            SeteoCodigo();
            LimpiarDatos();
            CargaEmpleado();
            CargarValores();
        }


        private void frmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void CargaEmpleado()
        {
            listaNodoEmpleado.inicio = listaNodoEmpleado.GenerarListaGenerico();
            Empleado empleado = null;
            List<Empleado> listaEmpleado = new List<Empleado>();
            cboEmpleado.ValueMember = "0";
            cboEmpleado.DisplayMember = "seleccione";
            while (listaNodoEmpleado.inicio != null)
            {
                empleado = new Empleado
                {
                    idEmpleado = listaNodoEmpleado.inicio.objeto.idEmpleado,
                    nombre = $"{listaNodoEmpleado.inicio.objeto.nombre} {listaNodoEmpleado.inicio.objeto.apellidoMaterno} {listaNodoEmpleado.inicio.objeto.apellidoMaterno}"
                };
                listaEmpleado.Add(empleado);
                listaNodoEmpleado.inicio = listaNodoEmpleado.inicio.sgte;             
            }

            cboEmpleado.DataSource = listaEmpleado;
            cboEmpleado.ValueMember = "idEmpleado";
            cboEmpleado.DisplayMember = "nombre";

        }
        private void CargarValores()
        {
            cboRol.Items.Add("---Seleccion---");
            foreach (var item in Enum.GetValues(typeof(Rol)))
            {
                cboRol.Items.Add(item);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidaDatos())
            {
                MessageBox.Show("Ingrese los datos faltantes");
            }
            else 
            {
                Usuario usuario = new Usuario();
                usuario.IdUsuario = int.Parse(txtCodigoUsuario.Text);
                usuario.UserName = txtUsuario.Text;
                usuario.Clave = txtClave.Text;
                usuario.IdEmpleado = (int)cboEmpleado.SelectedValue;
                usuario.IdRol = (int)cboRol.SelectedIndex;
                usuario.Estado = true;

                listaNodoUsuario.insertarAlInicioListaSimple(usuario);
                SeteoCodigo();
            }
            
            LimpiarDatos();
            CargaEmpleado();
            CargarValores();
        }

        private bool ValidaDatos()
        {
            bool bValida = false;
            if (txtUsuario.Text.Equals(string.Empty))
            {
                bValida = true;
            }

            if (txtClave.Text.Equals(string.Empty))
            {
                bValida = true;
            }

            if (cboEmpleado.SelectedValue.Equals("0") || cboEmpleado.SelectedValue.Equals("-1"))
            {
                bValida = true;
            }

            if (cboRol.SelectedIndex.Equals("0") || cboRol.SelectedIndex.Equals("-1"))
            {
                bValida = true;
            }

            return bValida;
        }

        private void SeteoCodigo()
        {
            txtCodigoUsuario.Text = listaNodoUsuario.GenerarCorrelativoEmpleado().ToString();
        }
        private void LimpiarDatos()
        {
            txtUsuario.Text = String.Empty;
            txtClave.Text = String.Empty;
            cboEmpleado.DataSource = null;
            cboRol.Items.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBusquedaUsuario form = new FrmBusquedaUsuario();
            form.Show();
            //frmUsuario form = new frmUsuario(this);
            // Hacer con form lo que consideres oportuno, por ejemplo mostrarlo
            //form.Show();
        }
    }
}
