using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using APPRESTAURANTE.Nodo;
using APPRESTAURANTE.Entidades;
using APPRESTAURANTE.Entidades.Enum;
using APPRESTAURANTE.Entidades.Constantes;

namespace APPRESTAURANTE
{
    public partial class frmEmpleado : Form
    {

        ListaGenerica<Empleado> nodoEmpleado = new ListaGenerica<Empleado>(Constants.FUENTE_EMPLEADO);

        public frmEmpleado()
        {
            InitializeComponent();
            nodoEmpleado.Cargar();
            cargarEmpleadosNodo();
            limpiarDatos();
            cargarValores();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("¿Estás seguro de que quieres registrar?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialog == DialogResult.OK)
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

                nodoEmpleado.insertarAlInicioListaSimple(empleado);
                cargarEmpleadosNodo();
                limpiarDatos();
                cargarValores();
            }
            else if (dialog == DialogResult.Cancel)
            {
                MessageBox.Show("You have clicked Cancel Button");
            }
        }

        private void btnConsultaEmp_Click(object sender, EventArgs e)
        {
            cargarEmpleadosNodo();
        }

        private void btnBusquedaPorValor_Click(object sender, EventArgs e)
        {
            busquedaNodoPorDni(txtDocumento.Text.Trim());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarElementoPorValor(txtDocumento.Text.Trim());
            cargarEmpleadosNodo();
        }

        public void mostrarEmpleado(List<Empleado> lista)
        {
            nodoEmpleado.inicio = nodoEmpleado.GenerarListaGenerico();
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
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = ((p.estado) ? "Activo" : "Inactivo") });
                dgvEmpleados.Rows.Add(fila);
            }

        }

        public void ImprimirListaEmpleado()
        {
            Empleado empleado = new Empleado();
            List<Empleado> listaProveedores = nodoEmpleado.GenerarListaGenerica();
            if (listaProveedores.Count > 0 || listaProveedores != null)
            {
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

        public void imprimirLista()
        {
            Empleado empleado = new Empleado();
            List<Empleado> listaProveedores = nodoEmpleado.GenerarListaGenerica();
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
                txtDocumento.Text = dgvEmpleados.SelectedRows[0].Cells[7].Value.ToString();
                bool flag = bool.Parse(dgvEmpleados.SelectedRows[0].Cells[8].Value.ToString());
                cboEstado.SelectedIndex = (flag) ? (int)Estado.activo : (int)Estado.inactivo;

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
            nodoEmpleado.Actualizar(x => x.idEmpleado == int.Parse(txtCodigoEmpleado.Text), empleado);
            cargarEmpleadosNodo();
            limpiarDatos();
            cargarValores();
        }

        private void limpiarDatos()
        {
            txtCodigoEmpleado.Text = nodoEmpleado.GenerarCorrelativoEmpleado().ToString();
            txtNombreEmpleado.Text = String.Empty;
            txtApellidoPaternoEmpleado.Text = String.Empty;
            txtApellidoMaternoEmpleado.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtDocumento.Text = String.Empty;
            cboEstado.DataSource = null;
            cboTipoDocumento.Items.Clear();
        }

        private void cargarValores()
        {
            // TODO: Load state from previously suspended application

            /*Dictionary<string, int> dictionaryEstado = new Dictionary<string, int>();
            foreach (int enumValue in
            Enum.GetValues(typeof(Estado)))
            {
                dictionaryEstado.Add(Enum.GetName(typeof(Estado), enumValue), enumValue);
            }
            cboEstado.DisplayMember = "nombre_estado"; ;
            cboEstado.ValueMember = "value_estado";
            cboEstado.DataSource = new BindingSource(dictionaryEstado, null);*/

            cboEstado.Items.Add("---Seleccione---");
            List<KeyValuePair<string, string>> listEstado = new List<KeyValuePair<string, string>>();
            Array estados = Enum.GetValues(typeof(Estado));
            foreach (Estado estado in estados)
            {
                listEstado.Add(new KeyValuePair<string, string>(estado.ToString(), ((int)estado).ToString()));
            }
            cboEstado.DataSource = listEstado;
            cboEstado.DisplayMember = "Key";
            cboEstado.ValueMember = "Value";


            cboTipoDocumento.Items.Add("---Seleccione---");
            foreach (var item in Enum.GetValues(typeof(TipoDocumento)))
            {
                cboTipoDocumento.Items.Add(item);
            }
        }

        private void cargarEmpleadosNodo()
        {
            nodoEmpleado.inicio = nodoEmpleado.GenerarListaGenerico();
            NodoGenerico<Empleado> temporal = nodoEmpleado.inicio;

            dgvEmpleados.Rows.Clear();
            while (temporal != null)
            {
                cargarGrillaEmpleados(temporal.objeto);
                temporal = temporal.sgte;
            }
        }

        private void cargarGrillaEmpleados(Empleado empleado)
        {
            if (empleado == null)
            {
                return;
            }
            else
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = empleado.idEmpleado });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = empleado.nombre });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = empleado.apellidoPaterno });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = empleado.apellidoMaterno });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = empleado.direccion });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = empleado.tipoDocumento });
                fila.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = (int.Parse(empleado.tipoDocumento) == (int)TipoDocumento.DNI) ? TipoDocumento.DNI.ToString()
                            : (int.Parse(empleado.tipoDocumento) == (int)TipoDocumento.CARNET_EXTRANJERIA)
                            ? TipoDocumento.CARNET_EXTRANJERIA.ToString() : "SIN DATO"
                }
                );
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = empleado.documento });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = empleado.estado });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = ((empleado.estado) ? "Activo" : "Inactivo") });
                dgvEmpleados.Rows.Add(fila);
            }
        }

        private void eliminarElementoPorValor(string numeroDocumento)
        {
            NodoGenerico<Empleado> temporal = nodoEmpleado.inicio;
            int flag = 0;
            int contador = 0;

            if (nodoEmpleado.inicio != null)
            {
                while (temporal != null)
                {
                    contador++;
                    if (temporal.objeto != null)
                    {
                        if (temporal.objeto.documento.Trim().Equals(numeroDocumento.Trim()))
                        {
                            flag = 1;
                            nodoEmpleado.Eliminar(x => x.documento == numeroDocumento.Trim());
                            MessageBox.Show("El documento ha sido eliminado!");
                        }
                        temporal = temporal.sgte;
                    }
                }
                if (flag == 0)
                {
                    MessageBox.Show("El documento ingresado ha eliminar no existe");
                }
            }
            else
            {
                MessageBox.Show("Lista de empleados vacia");
            }
        }

        private void busquedaNodoPorDni(string documento)
        {
            NodoGenerico<Empleado> nodoTemporalEmpleado = new NodoGenerico<Empleado>();
            nodoTemporalEmpleado = nodoEmpleado.inicio;
            NodoGenerico<Empleado> temporalEmpleado = null;
            int flag = 0;
            if (nodoEmpleado.inicio != null)
            {
                while (nodoTemporalEmpleado != null)
                {
                    if (nodoTemporalEmpleado.objeto != null)
                    {
                        if (nodoTemporalEmpleado.objeto.documento.Trim().Equals(documento))
                        {
                            flag = 1;
                            temporalEmpleado = new NodoGenerico<Empleado>(nodoTemporalEmpleado.objeto, null, null);
                        }
                    }
                    nodoTemporalEmpleado = nodoTemporalEmpleado.sgte;
                }
                if (flag == 0)
                {
                    MessageBox.Show("La búsqueda por documento no coincide.");
                }
                else
                {
                    dgvEmpleados.Rows.Clear();
                    while (temporalEmpleado != null)
                    {
                        cargarGrillaEmpleados(temporalEmpleado.objeto);
                        temporalEmpleado = temporalEmpleado.sgte;
                    }
                }
            }
            else
            {
                MessageBox.Show("La lista de empleados esta vacia.");
            }
        }

    }
}
