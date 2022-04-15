using System;
using System.Windows.Forms;
using APPRESTAURANTE.Entidades;
using APPRESTAURANTE.Entidades.Enum;
using APPRESTAURANTE.Nodo;

namespace APPRESTAURANTE
{
    public partial class FrmBusquedaUsuario : Form
    {
        ListaGenerica<Usuario> listaNodoUsuarioConsulta = new ListaGenerica<Usuario>(@"D:\Json\bdUsuario.json");
        ListaGenerica<Empleado> listaNodoEmpleadoConsulta = new ListaGenerica<Empleado>(@"D:\Json\bdEmpleado.json");

        public FrmBusquedaUsuario()
        {
            InitializeComponent();
            listaNodoUsuarioConsulta.Cargar();
            listaNodoEmpleadoConsulta.Cargar();
            CargaUsuarios();
        }

        private void FrmBusquedaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmUsuario frmUsuario = new frmUsuario();
            frmUsuario.ShowDialog();
        }

        private void CargaUsuarios()
        {
            listaNodoUsuarioConsulta.inicio = listaNodoUsuarioConsulta.GenerarListaGenerico();
            listaNodoEmpleadoConsulta.inicio = listaNodoEmpleadoConsulta.GenerarListaGenerico();
            ListaGenerica<Usuario> ActualTemporal = new ListaGenerica<Usuario>();
            ActualTemporal.inicio = null;

            while (listaNodoUsuarioConsulta.inicio != null)
            {
                if (ActualTemporal.inicio == null)
                {
                    foreach (var item in listaNodoEmpleadoConsulta.listaObjeto)
                    {
                        if (item.idEmpleado == listaNodoUsuarioConsulta.inicio.objeto.IdEmpleado)
                        {
                            string nombreCompleto = $"{listaNodoEmpleadoConsulta.inicio.objeto.nombre} {listaNodoEmpleadoConsulta.inicio.objeto.apellidoPaterno} {listaNodoEmpleadoConsulta.inicio.objeto.apellidoMaterno}";
                            listaNodoUsuarioConsulta.inicio.objeto.Empleado = new Empleado();
                            listaNodoUsuarioConsulta.inicio.objeto.Empleado.nombre = nombreCompleto;
                        }
                    }
                    ActualTemporal.inicio = listaNodoUsuarioConsulta.inicio;
                    listaNodoUsuarioConsulta.inicio = listaNodoUsuarioConsulta.inicio.sgte;   
                }
                else
                {
                    foreach (var item in listaNodoEmpleadoConsulta.listaObjeto)
                    {
                        if (item.idEmpleado == listaNodoUsuarioConsulta.inicio.objeto.IdEmpleado)
                        {
                            string nombreCompleto = $"{listaNodoEmpleadoConsulta.inicio.objeto.nombre} {listaNodoEmpleadoConsulta.inicio.objeto.apellidoPaterno} {listaNodoEmpleadoConsulta.inicio.objeto.apellidoMaterno}";
                            listaNodoUsuarioConsulta.inicio.objeto.Empleado = new Empleado();
                            listaNodoUsuarioConsulta.inicio.objeto.Empleado.nombre = nombreCompleto;
                        }
                    }
                    ActualTemporal.inicio.sgte = listaNodoUsuarioConsulta.inicio;
                    listaNodoUsuarioConsulta.inicio = ActualTemporal.inicio;
                }
                
                /*if (temporal.inicio.objeto.IdEmpleado == listaNodoEmpleadoConsulta.inicio.objeto.idEmpleado)
                {
                    temporal.inicio.objeto.Empleado.nombre = $"{listaNodoEmpleadoConsulta.inicio.objeto.nombre} {listaNodoEmpleadoConsulta.inicio.objeto.apellidoPaterno} {listaNodoEmpleadoConsulta.inicio.objeto.apellidoMaterno}";
                }*/
                
            }

            while (listaNodoUsuarioConsulta.inicio != null)
            {

                DataGridViewRow fila = new DataGridViewRow();
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = listaNodoUsuarioConsulta.inicio.objeto.IdUsuario });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = listaNodoUsuarioConsulta.inicio.objeto.UserName });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = listaNodoUsuarioConsulta.inicio.objeto.IdEmpleado });
                fila.Cells.Add(new DataGridViewTextBoxCell() {
                    
                    
                        Value = ""
                });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = listaNodoUsuarioConsulta.inicio.objeto.IdRol });
                fila.Cells.Add(new DataGridViewTextBoxCell() 
                    { 
                        Value = (listaNodoUsuarioConsulta.inicio.objeto.IdRol == (int)Rol.Administrador) ? Rol.Administrador.ToString() : (listaNodoUsuarioConsulta.inicio.objeto.IdRol == (int)Rol.Cajero) ? Rol.Cajero.ToString() : (Rol.Cocinero.ToString())
                    }
                );
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = listaNodoUsuarioConsulta.inicio.objeto.Estado });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = ((listaNodoUsuarioConsulta.inicio.objeto.Estado) ? "Activo" : "Inactivo") });
                dgvUsuarios.Rows.Add(fila);
                listaNodoUsuarioConsulta.inicio = listaNodoUsuarioConsulta.inicio.sgte;
            }


            /*while (listaNodoUsuarioConsulta.inicio != null || listaNodoEmpleadoConsulta.inicio != null)
            {
                if (listaNodoUsuarioConsulta.inicio != null)
                {
                    listaNodoUsuarioConsulta.InsertarObjetoAlFinal(listaNodoUsuarioConsulta.inicio.objeto);
                    listaNodoUsuarioConsulta.inicio = listaNodoUsuarioConsulta.inicio.sgte;
                }
                if (listaNodoEmpleadoConsulta.inicio != null)
                {
                    listaNodoEmpleadoConsulta.InsertarObjetoAlFinal(listaNodoEmpleadoConsulta.inicio.objeto);
                    listaNodoEmpleadoConsulta.inicio = listaNodoEmpleadoConsulta.inicio.sgte;
                }
            }*/
        }
    }
}
