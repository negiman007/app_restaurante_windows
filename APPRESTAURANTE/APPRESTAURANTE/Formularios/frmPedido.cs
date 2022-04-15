using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using APPRESTAURANTE.Nodo;
using APPRESTAURANTE.Entidades;
using APPRESTAURANTE.Entidades.Constantes;
using APPRESTAURANTE.Entidades.Enum;

namespace APPRESTAURANTE.Formularios
{
    public partial class frmPedido : Form
    {

        ListaGenerica<Empleado> nodoEmpleado = new ListaGenerica<Empleado>(Constants.FUENTE_EMPLEADO);
        ListaGenerica<Entidades.Menu> nodoMenu = new ListaGenerica<Entidades.Menu>(Constants.FUENTE_MENU);
        ListaGenerica<MenuDetalle> nodoMenuDetalle = new ListaGenerica<MenuDetalle>(Constants.FUENTE_MENU_DETALLE);
        ListaGenerica<Mesa> nodoMesa = new ListaGenerica<Mesa>(Constants.FUENTE_MESA);
        ListaGenerica<Pedido> nodoPedido = new ListaGenerica<Pedido>(Constants.FUENTE_PEDIDO);

        public frmPedido()
        {
            InitializeComponent();
            nodoEmpleado.Cargar();
            nodoMenu.Cargar();
            nodoMenuDetalle.Cargar();
            nodoMesa.Cargar();
            nodoPedido.Cargar();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            obtenerTipos();
            obtenerEmpleados();
            obtenerMesas();
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

        }

        private void obtenerEmpleados()
        {
            nodoEmpleado.inicio = nodoEmpleado.GenerarListaGenerico();
            Empleado empleado = null;
            List<Empleado> listaEmpleado = new List<Empleado>();
            cboEmpleado.ValueMember = "0";
            cboEmpleado.DisplayMember = "seleccione";
            while (nodoEmpleado.inicio != null)
            {
                empleado = new Empleado
                {
                    idEmpleado = nodoEmpleado.inicio.objeto.idEmpleado,
                    nombre = $"{nodoEmpleado.inicio.objeto.nombre.ToUpper()} {nodoEmpleado.inicio.objeto.apellidoMaterno.ToUpper()} {nodoEmpleado.inicio.objeto.apellidoMaterno.ToUpper()}"
                };
                listaEmpleado.Add(empleado);
                nodoEmpleado.inicio = nodoEmpleado.inicio.sgte;
            }

            cboEmpleado.DataSource = listaEmpleado.OrderBy(e => e.idEmpleado).ToList();
            cboEmpleado.ValueMember = "idEmpleado";
            cboEmpleado.DisplayMember = "nombre";
        }

        private void obtenerMesas()
        {
            nodoMesa.inicio = nodoMesa.GenerarListaGenerico();
            Mesa mesa = null;
            List<Mesa> listaMesa = new List<Mesa>();
            cboMesa.ValueMember = "0";
            cboMesa.DisplayMember = "seleccione";
            while (nodoMesa.inicio != null)
            {
                mesa = new Mesa
                {
                    idMesa = nodoMesa.inicio.objeto.idMesa,
                    nombreMesa = $"{nodoMesa.inicio.objeto.nombreMesa.ToUpper()}"
                };
                listaMesa.Add(mesa);
                nodoMesa.inicio = nodoMesa.inicio.sgte;
            }
            cboMesa.DataSource = listaMesa.OrderBy(o => o.idMesa).ToList(); ;
            cboMesa.ValueMember = "idMesa";
            cboMesa.DisplayMember = "nombreMesa";
        }

        private void obtenerTipos()
        {
            List<KeyValuePair<int, string>> listaTipos = new List<KeyValuePair<int, string>>();
            Array tipos = Enum.GetValues(typeof(TipoPlato));
            foreach (var tipo in tipos)
            {
                listaTipos.Add(new KeyValuePair<int, string>(((int)tipo), tipo.ToString()));
            }
            cboTipo.DataSource = listaTipos.OrderBy(o => o.Key).ToList();
            cboTipo.DisplayMember = "Value";
            cboTipo.ValueMember = "Key";

        }
    }
}
