using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APPRESTAURANTE.Entidades;
using APPRESTAURANTE.BaseDatos;
using APPRESTAURANTE.Entidades.Enum;

namespace APPRESTAURANTE
{
    public partial class frmEmpleado : Form
    {


        ListaGenerica<Empleado> listaNodo = new ListaGenerica<Empleado>(@"D:\Json\bdEmpleado.json");
        
        //ListaGenerica<Empleado> listaNodo = new ListaGenerica<Empleado>("bd_Empleado.json");
        //BaseDatos<Empleado> bd = new BaseDatos<Empleado>("bdEmpleado.json");
        public frmEmpleado()
        {
            InitializeComponent();
            listaNodo.Cargar();
            mostrarEmpleado(listaNodo.listaObjeto);
            LimpiarDatos();
            CargarValores();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.idEmpleado = int.Parse(txtCodigoEmpleado.Text);
            empleado.nombre = txtNombreEmpleado.Text;
            empleado.apellidoPaterno = txtApellidoPaternoEmpleado.Text;
            empleado.apellidoMaterno = txtApellidoMaternoEmpleado.Text;
            empleado.direccion = txtDireccion.Text;
            empleado.tipoDocumento = cboTipoDocumento.SelectedIndex.ToString();
            empleado.documento = txtDocumento.Text;
            bool flag = cboEstado.SelectedIndex == 0 ? false : true;
            empleado.estado = flag;

            listaNodo.InsertarObjeto(empleado);
            mostrarEmpleado(listaNodo.listaObjeto);
            LimpiarDatos();
            CargarValores();

        }

        private void btnConsultaEmp_Click(object sender, EventArgs e)
        {
            mostrarEmpleado(listaNodo.listaObjeto);
        }

        public void mostrarEmpleado(List<Empleado> lista)
        {
            dgvEmpleados.Rows.Clear();

            foreach (Empleado p in lista)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.idEmpleado });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.nombre });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.apellidoPaterno });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.apellidoMaterno });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.direccion });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.tipoDocumento });
                fila.Cells.Add(new DataGridViewTextBoxCell() 
                { 
                    Value = (int.Parse(p.tipoDocumento) == (int)TipoDocumento.DNI) ? TipoDocumento.DNI.ToString() 
                            : (int.Parse(p.tipoDocumento) == (int)TipoDocumento.CARNET_EXTRANJERIA) 
                            ? TipoDocumento.CARNET_EXTRANJERIA.ToString() : "SIN DATO" 
                }
                );
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.documento });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.estado });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = ((p.estado) ? "Activo" : "Inactivo" ) });
                dgvEmpleados.Rows.Add(fila);
            }

        }

        public void ImprimirListaEmpleado()
        {
            Empleado empleado = new Empleado();
            List<Empleado> listaProveedores = listaNodo.GenerarListaGenerica();
            if (listaProveedores.Count > 0 || listaProveedores != null)
            {
                /* Ordenamos la lista */
                //List<Empleado> listaProveedoresOrder = listaProveedores.OrderBy(o => o.idEmpleado).ToList();
                //var bindingListProveedores = new BindingList<Empleado>(listaProveedoresOrder);
                //BindingSource origenProveedor = new BindingSource(bindingListProveedores, null);
                //dgvEmpleado.DataSource = origenProveedor;
                dgvEmpleados.Rows.Clear();

                foreach (Empleado p in listaProveedores)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.idEmpleado });
                    fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.nombre });
                    fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.apellidoPaterno });
                    fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.apellidoMaterno });
                    fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.direccion });
                    fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.tipoDocumento });
                    fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.documento });
                    dgvEmpleados.Rows.Add(fila);
                }
            }
        }

        public void ImprimirLista()
        {
            Empleado empleado = new Empleado();
            List<Empleado> listaProveedores = listaNodo.GenerarListaGenerica();
            if (listaProveedores.Count > 0 || listaProveedores != null)
            {
                /* Ordenamos la lista */
                List<Empleado> listaProveedoresOrder = listaProveedores.OrderBy(o => o.idEmpleado).ToList();
                var bindingListProveedores = new BindingList<Empleado>(listaProveedoresOrder);
                BindingSource origenProveedor = new BindingSource(bindingListProveedores, null);
                //dgvEmpleado.DataSource = origenProveedor;
            }
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                txtCodigoEmpleado.Text = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells[0].Value).ToString();
                txtNombreEmpleado.Text = dgvEmpleados.SelectedRows[0].Cells[1].Value.ToString();
                txtApellidoPaternoEmpleado.Text = dgvEmpleados.SelectedRows[0].Cells[2].Value.ToString();
                txtApellidoMaternoEmpleado.Text = dgvEmpleados.SelectedRows[0].Cells[3].Value.ToString();
                txtDireccion.Text = dgvEmpleados.SelectedRows[0].Cells[4].Value.ToString();
                cboTipoDocumento.SelectedIndex = int.Parse(dgvEmpleados.SelectedRows[0].Cells[5].Value.ToString());
                //txtTipoDocumento.Text = dgvEmpleados.SelectedRows[0].Cells[5].Value.ToString();
                txtDocumento.Text = dgvEmpleados.SelectedRows[0].Cells[7].Value.ToString();
                bool flag = bool.Parse(dgvEmpleados.SelectedRows[0].Cells[8].Value.ToString());
                cboEstado.SelectedIndex = (flag) ? (int)Estado.activo: (int)Estado.inactivo;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.idEmpleado = int.Parse(txtCodigoEmpleado.Text);
            empleado.nombre = txtNombreEmpleado.Text;
            empleado.apellidoPaterno = txtApellidoPaternoEmpleado.Text;
            empleado.apellidoMaterno = txtApellidoMaternoEmpleado.Text;
            empleado.direccion = txtDireccion.Text;
            empleado.tipoDocumento = cboTipoDocumento.SelectedIndex.ToString();
            empleado.documento = txtDocumento.Text;
            bool flag = cboEstado.SelectedIndex == 0 ? false : true;
            empleado.estado = flag;
            listaNodo.Actualizar(x => x.idEmpleado == int.Parse(txtCodigoEmpleado.Text), empleado);
            mostrarEmpleado(listaNodo.listaObjeto);
            LimpiarDatos();
            CargarValores();
        }

        private void LimpiarDatos()
        {
            txtCodigoEmpleado.Text = listaNodo.GenerarCorrelativoEmpleado().ToString();
            //txtCodigoEmpleado.Text = String.Empty;
            txtNombreEmpleado.Text = String.Empty;
            txtApellidoPaternoEmpleado.Text = String.Empty;
            txtApellidoMaternoEmpleado.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtDocumento.Text = String.Empty;
            cboEstado.Items.Clear();
            cboTipoDocumento.Items.Clear();
        }

        public void CargarValores()
        {
            foreach (var item in Enum.GetValues(typeof(Estado)))
            {
                cboEstado.Items.Add(item);
            }

            foreach (var item in Enum.GetValues(typeof(TipoDocumento)))
            {
                cboTipoDocumento.Items.Add(item);
            }

        }
    }
}
