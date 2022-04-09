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


namespace APPRESTAURANTE
{
    public partial class frmEmpleado : Form
    {
        //ListaGenerica<Empleado> listaNodo = new ListaGenerica<Empleado>();
        //string ruta = @"D:\\Cursos\\UPN\\bd_Empleado.json";
        //ruta = "D:\\Cursos\\UPN\\bd_Empleado.json";
        //string rutaArchivo = @"D:\Cursos\UPN\5 CICLO\ESTRUCTURA DE DATOS\Grupo_3\APPRESTAURANTE\BD_APPRESTAURANTE\";
        //string archivo = "bd_Empleado.json";
        //string rutaCompleta = $"@"D:\Cursos\UPN\5 CICLO\ESTRUCTURA DE DATOS\Grupo_3\APPRESTAURANTE\BD_APPRESTAURANTE\" {archivo}";
        ListaGenerica<Empleado> listaNodo = new ListaGenerica<Empleado>(@"D:\Cursos\UPN\BD\bdEmpleado.json");
        //ListaGenerica<Empleado> listaNodo = new ListaGenerica<Empleado>("bd_Empleado.json");
        //BaseDatos<Empleado> bd = new BaseDatos<Empleado>("bdEmpleado.json");
        public frmEmpleado()
        {
            InitializeComponent();
            //string ruta = "D:\\Cursos\\UPN\\bd_Empleado.json";
            //ListaGenerica<Empleado> listaNodo = new ListaGenerica<Empleado>(ruta);
            listaNodo.Cargar();
            mostrarEmpleado(listaNodo.listaObjeto);
            //bd.Cargar();
            //mostrarEmpleado(bd.valores);
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.idEmpleado = int.Parse((new Random()).Next(100000, 999999).ToString());//(new Random()).Next(10000000, 99999999);
            empleado.nombre = txtNombreEmpleado.Text;
            empleado.apellidoPaterno = txtApellidoPaternoEmpleado.Text;
            empleado.apellidoMaterno = txtApellidoMaternoEmpleado.Text;
            empleado.direccion = txtDireccion.Text;
            empleado.tipoDocumento = txtTipoDocumento.Text;
            empleado.documento = txtDocumento.Text;

            /*Mascota.TIPO t;
            switch (cbmascota.SelectedIndex)
            {
                case 1: t = Mascota.TIPO.PERRO; break;
                case 2: t = Mascota.TIPO.GATO; break;
                case 3: t = Mascota.TIPO.PEZ; break;
                default: t = Mascota.TIPO.NINGUNA; break;
            }

            Mascota m = new Mascota(txtmascota.Text, t);
            Persona p = new Persona((new Random()).Next(10000000, 99999999), txtnombre.Text, m);*/
            //listaNodo.InsertarProveedor(new Proveedor(codigoProveedor, ruc, razon, nombreContacto, telefonoContacto, celularContacto, emailContacto));
            listaNodo.InsertarObjeto(empleado);
            //ImprimirLista();
            //ImprimirListaEmpleado();
            mostrarEmpleado(listaNodo.listaObjeto);
            //mostrarEmpleado(listaNodo.listaObjeto);
            //bd.Insertar(empleado);
            //mostrarEmpleado(bd.valores);
            //mostrarEmpleado(listaNodo.GenerarListaGenerica);
        }

        private void btnConsultaEmp_Click(object sender, EventArgs e)
        {

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
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.documento });
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
                txtTipoDocumento.Text = dgvEmpleados.SelectedRows[0].Cells[5].Value.ToString();
                txtDocumento.Text = dgvEmpleados.SelectedRows[0].Cells[6].Value.ToString();

                /*
                empleado.idEmpleado = int.Parse((new Random()).Next(100000, 999999).ToString());//(new Random()).Next(10000000, 99999999);
                empleado.nombre = txtNombreEmpleado.Text;
                empleado.apellidoPaterno = txtApellidoPaternoEmpleado.Text;
                empleado.apellidoMaterno = txtApellidoMaternoEmpleado.Text;
                empleado.direccion = txtDireccion.Text;
                empleado.tipoDocumento = txtTipoDocumento.Text;
                empleado.documento = txtDocumento.Text;
                */

            }
            catch (Exception)
            {

                throw;
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
            empleado.tipoDocumento = txtTipoDocumento.Text;
            empleado.documento = txtDocumento.Text;
            listaNodo.Actualizar(x => x.idEmpleado == int.Parse(txtCodigoEmpleado.Text), empleado);
            mostrarEmpleado(listaNodo.listaObjeto);

            /*int DNI = int.Parse(txtdni.Text);
            Mascota.TIPO t;
            switch (cbmascota.SelectedIndex)
            {
                case 1: t = Mascota.TIPO.PERRO; break;
                case 2: t = Mascota.TIPO.GATO; break;
                case 3: t = Mascota.TIPO.PEZ; break;
                default: t = Mascota.TIPO.NINGUNA; break;
            }
            Mascota m = new Mascota(txtmascota.Text, t);
            Persona p = new Persona(DNI, txtnombre.Text, m);*/
            //bd.Actualizar(x => x.DNI == DNI, p);
            //mostrar(bd.valores);
        }
    }
}
