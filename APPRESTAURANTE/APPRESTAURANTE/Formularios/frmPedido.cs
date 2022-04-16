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
        ListaGenerica<PedidoDetalle> nodoPedidoDetalle = new ListaGenerica<PedidoDetalle>(Constants.FUENTE_PEDIDO_DETALLE);
        int numerador = 1;
        public frmPedido()
        {
            InitializeComponent();
            nodoEmpleado.Cargar();
            nodoMenu.Cargar();
            nodoMenuDetalle.Cargar();
            nodoMesa.Cargar();
            nodoPedido.Cargar();
            nodoPedidoDetalle.Cargar();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            obtenerTipos();
            obtenerEmpleados();
            obtenerMesas();
            obtenerMenu();
            LimpiarDatosDetalle();
            LimpiarDatosPedido();
            SeteoCodigo();
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipo.SelectedIndex > 0)
            {
                int tipoSeleccionado = (int)cboTipo.SelectedValue;
                obtenerMenuPorTipo(tipoSeleccionado);
            }
            else
            {
                List<MenuDetalle> listaMenuDetalle = new List<MenuDetalle>();
                listaMenuDetalle.Add(new MenuDetalle() { idMenuDetalle = 0, titulo = "-- Seleccione --" });
                cboMenu.DataSource = listaMenuDetalle.OrderBy(o => o.idMenuDetalle).ToList(); ;
                cboMenu.ValueMember = "idMenuDetalle";
                cboMenu.DisplayMember = "titulo";
            }
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            if (validaDatos())
            {
                MessageBox.Show("Ingrese los datos faltantes");
            }
            else
            {
                int codigoEmpleado = 0;
                int codigoMesa = 0;
                PedidoDetalle pedidoDetalle = new PedidoDetalle();
                pedidoDetalle.idPedidoDetalle = obtenerUltimoIdPedidoDet(numerador);
                pedidoDetalle.idPedido = int.Parse(txtNumeroPedido.Text);
                pedidoDetalle.idMenuDetalle = int.Parse(cboMenu.SelectedValue.ToString());
                pedidoDetalle.menuDetalle = new MenuDetalle();
                pedidoDetalle.menuDetalle.idMenuDetalle = int.Parse(cboMenu.SelectedValue.ToString());
                pedidoDetalle.menuDetalle.titulo = ((MenuDetalle)cboMenu.SelectedItem).titulo;
                pedidoDetalle.precio = obtenerPrecio((int)cboMenu.SelectedValue);
                pedidoDetalle.cantidad = int.Parse(nupCantidad.Value.ToString());
                pedidoDetalle.subtotal = pedidoDetalle.cantidad * pedidoDetalle.precio;
                codigoMesa = int.Parse(cboMesa.SelectedValue.ToString());
                codigoEmpleado = int.Parse(cboEmpleado.SelectedValue.ToString());
                nodoPedidoDetalle.insertarAlFinalListaDoble(pedidoDetalle);
                numerador = numerador + 1;

                refrescarGrillaConListaSimple(nodoPedidoDetalle.inicio, codigoEmpleado, codigoMesa);
                deshabilitarMesaYEmpleado(false);
                refrescarTotal();
                LimpiarDatosDetalle();
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (dgvPedido.Rows.Count == 0)
            {
                MessageBox.Show("Favor añada los items para registrar el pedido");
            }
            else
            {
                DialogResult dialogPedido = MessageBox.Show("¿Estás seguro de que quieres registrar el pedido?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogPedido == DialogResult.OK) 
                {
                    Pedido pedido = new Pedido();
                    pedido.idPedido = int.Parse(txtNumeroPedido.Text);
                    pedido.fechaPedido = DateTime.Now.ToString("yyyy-MM-dd");
                    pedido.totalPedido = double.Parse(txtTotal.Text);
                    pedido.idMesa = int.Parse(cboMesa.SelectedValue.ToString()); ;
                    pedido.tipoPago = 0;
                    pedido.idEmpleado = int.Parse(cboEmpleado.SelectedValue.ToString()); ;
                    pedido.idUsuario = 1; 
                    pedido.estadoPago = 0;
                    //pedido.pedidoDetalles = new List<PedidoDetalle>();                    
                    nodoPedido.insertarAlFinalListaDoble(pedido);
                    ///Guardamos los datos del pedido en el archivo JSON
                    nodoPedido.listaObjeto.Add(pedido);
                    nodoPedido.GuardarListaGenerico(nodoPedido.listaObjeto);
                    ///Guardamos los datos del detalle de pedido en el archivo JSON
                    List<PedidoDetalle> listaGenericaDetalle = new List<PedidoDetalle>();
                    listaGenericaDetalle = nodoPedidoDetalle.GenerarListaGenerica();
                    nodoPedidoDetalle.listaObjeto = listaGenericaDetalle;
                    nodoPedidoDetalle.GuardarListaGenerico(nodoPedidoDetalle.listaObjeto);
                    MessageBox.Show("El pedido fue enviado");
                    deshabilitarMesaYEmpleado(true);
                    LimpiarDatosDetalle();
                    LimpiarDatosPedido();
                    dgvPedido.Rows.Clear();
                    SeteoCodigo();
                }
                else if (dialogPedido == DialogResult.Cancel)
                {
                    MessageBox.Show("Ha hecho clic en el botón Cancelar");
                }
            }
        }

        private void obtenerEmpleados()
        {
            nodoEmpleado.inicio = nodoEmpleado.GenerarListaGenerico();
            List<Empleado> listaEmpleado = new List<Empleado>();
            Empleado empleado = null;
            listaEmpleado.Add(new Empleado() { idEmpleado = 0, nombre = "-- Seleccione --" });
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
            listaMesa.Add(new Mesa() { idMesa = 0, nombreMesa = "-- Seleccione --" });
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
            listaTipos.Add(new KeyValuePair<int, string>(0, "-- Seleccione --"));
            foreach (var tipo in tipos)
            {
                listaTipos.Add(new KeyValuePair<int, string>(((int)tipo), tipo.ToString()));
            }
            cboTipo.DataSource = listaTipos.OrderBy(o => o.Key).ToList();
            cboTipo.DisplayMember = "Value";
            cboTipo.ValueMember = "Key";
        }

        private void obtenerMenu()
        {
            nodoMenu.inicio = nodoMenu.GenerarListaGenerico();
            NodoGenerico<Entidades.Menu> temporalMenu = nodoMenu.inicio;

            List<Entidades.Menu> listaMenu = new List<Entidades.Menu>();
            listaMenu = nodoMenu.GenerarListaGenerica();
            foreach (var menu in listaMenu)
            {

            }

            List<MenuDetalle> listaMenuDetalle = new List<MenuDetalle>();
            listaMenuDetalle = nodoMenuDetalle.GenerarListaGenerica();
            foreach (var item in listaMenuDetalle)
            {

            }
        }

        private bool validaDatos()
        {
            bool bValida = false;
            if (txtNumeroPedido.Text.Equals(string.Empty))
            {
                bValida = true;
            }
            else if (cboMesa.SelectedIndex == 0)
            {
                bValida = true;
            }
            else if (cboTipo.SelectedIndex == 0)
            {
                bValida = true;
            }
            else if (cboMenu.SelectedIndex == 0)
            {
                bValida = true;
            }
            else if (cboEmpleado.SelectedIndex == 0)
            {
                bValida = true;
            }
            else if (nupCantidad.Value == 0)
            {
                bValida = true;
            }
            else
            {
                bValida = false;
            }
            return bValida;
        }

        private void SeteoCodigo()
        {
            txtNumeroPedido.Text = nodoPedido.GenerarCorrelativoEmpleado().ToString();
        }

        private void LimpiarDatosPedido() 
        {
            cboEmpleado.SelectedIndex = 0;
            cboMesa.SelectedIndex = 0;
            txtTotal.Text = String.Empty;
        }

        private void LimpiarDatosDetalle()
        {
            cboTipo.SelectedIndex = 0;
            nupCantidad.Value = 0;
        }

        public void deshabilitarMesaYEmpleado(bool habilita) 
        {
            cboMesa.Enabled = habilita;
            cboEmpleado.Enabled = habilita;
        }

        private void obtenerMenuPorTipo(int valorTipo)
        {
            if (valorTipo > 0)
            {
                string fechaActual = DateTime.Now.ToString("yyyy-MM-dd");

                ///cargamos el Menu cabecera y filtramos el menu con la fecha de hoy
                nodoMenu.inicio = nodoMenu.GenerarListaGenerico();
                NodoGenerico<Entidades.Menu> temporalMenu = nodoMenu.inicio;
                NodoGenerico<Entidades.Menu> menuGenerico = null;
                while (temporalMenu != null)
                {

                    if (temporalMenu.objeto.fecha.Equals(fechaActual))
                    {
                        if (menuGenerico != null)
                        {
                            //menuGenerico = new NodoGenerico<Entidades.Menu>(temporalMenu.objeto, null, null);
                            menuGenerico.sgte = temporalMenu;
                        }
                        else
                        {
                            menuGenerico = new NodoGenerico<Entidades.Menu>(temporalMenu.objeto, null, null);
                            //menuGenerico.sgte = null;
                        }
                    }
                    temporalMenu = temporalMenu.sgte;
                }

                ///cargamos el Menu Detalle y filtramos los menu que se registraron la fecha de hoy y por el tipo de entrada
                nodoMenuDetalle.inicio = nodoMenuDetalle.GenerarListaGenerico();
                NodoGenerico<MenuDetalle> temporalMenuDetalle = nodoMenuDetalle.inicio;
                NodoGenerico<MenuDetalle> nodoItemMenu = null;
                NodoGenerico<MenuDetalle> actualMenu;
                int flagDetalleMenu = 0;
                if (temporalMenuDetalle != null)
                {
                    while (temporalMenuDetalle != null)
                    {
                        if (menuGenerico != null)
                        {
                            if (menuGenerico.objeto.id == temporalMenuDetalle.objeto.idMenu && valorTipo == temporalMenuDetalle.objeto.tipoPlato)
                            {
                                actualMenu = new NodoGenerico<MenuDetalle>(temporalMenuDetalle.objeto, null, null);
                                if (nodoItemMenu == null)
                                {
                                    actualMenu.sgte = null;
                                    nodoItemMenu = actualMenu;
                                }
                                else
                                {
                                    while (nodoItemMenu.sgte != null)
                                    {
                                        nodoItemMenu = nodoItemMenu.sgte;
                                    }
                                    nodoItemMenu.sgte = actualMenu;
                                }
                            }
                            else
                            {
                                // TODO: Proximamente a codear
                            }
                        }
                        else
                        {
                            // TODO: Proximamente a codear
                        }
                        temporalMenuDetalle = temporalMenuDetalle.sgte;
                    }
                    flagDetalleMenu = 1;
                }
                else
                {
                    flagDetalleMenu = 0;
                }

                // TODO: Procedemos a cargar los menus del día de hoy en un listado de menu
                List<MenuDetalle> listaMenuDetalle = new List<MenuDetalle>();
                if (flagDetalleMenu != 0) ///verifica si hay items
                {
                    listaMenuDetalle.Add(new MenuDetalle() { idMenuDetalle = 0, titulo = "-- Seleccione --" });
                    MenuDetalle menuDetalle = null;
                    while (nodoItemMenu != null)
                    {
                        menuDetalle = new MenuDetalle
                        {
                            idMenuDetalle = nodoItemMenu.objeto.idMenuDetalle,
                            titulo = $"{nodoItemMenu.objeto.titulo.ToUpper()}"
                        };
                        listaMenuDetalle.Add(menuDetalle);
                        nodoItemMenu = nodoItemMenu.sgte;
                    }
                    cboMenu.DataSource = listaMenuDetalle.OrderBy(o => o.idMenuDetalle).ToList(); ;
                    cboMenu.ValueMember = "idMenuDetalle";
                    cboMenu.DisplayMember = "titulo";
                }
                else
                {
                    listaMenuDetalle.Add(new MenuDetalle() { idMenuDetalle = 0, titulo = "-- Seleccione --" });
                    cboMenu.DataSource = listaMenuDetalle.OrderBy(o => o.idMenuDetalle).ToList(); ;
                    cboMenu.ValueMember = "idMenuDetalle";
                    cboMenu.DisplayMember = "titulo";
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatosPedido();
            LimpiarDatosDetalle();
            deshabilitarMesaYEmpleado(true);
            dgvPedido.Rows.Clear();
        }

        private double obtenerPrecio(int idMenu)
        {
            double obtenerPrecio = 0;
            string precio = string.Empty;
            NodoGenerico<MenuDetalle> temporalMenuDetalle = nodoMenuDetalle.GenerarListaGenerico();

            if (temporalMenuDetalle != null)
            {
                while (temporalMenuDetalle != null)
                {
                    if (idMenu == temporalMenuDetalle.objeto.idMenuDetalle)
                    {
                        obtenerPrecio = temporalMenuDetalle.objeto.precio;
                    }
                    temporalMenuDetalle = temporalMenuDetalle.sgte;
                }
            }
            else
            {
                obtenerPrecio = 0;
            }
            return obtenerPrecio;
        }

        private double obtenerSubTotal(int cantidad, double precio)
        {
            double subTotal = 0;
            subTotal = cantidad * precio;
            return subTotal;
        }

        private void refrescarTotal() {
            double refrescarTotal = 0;
            foreach (DataGridViewRow row in dgvPedido.Rows)
            {
                if (row != null)
                {
                    refrescarTotal += double.Parse(row.Cells["subTotal"].Value.ToString());
                } 
            }
            txtTotal.Text = refrescarTotal.ToString();
        }

        private void refrescarGrilla() 
        {
            DataGridViewRow data = new DataGridViewRow();
            data.Cells.Add(new DataGridViewTextBoxCell() { Value = txtNumeroPedido.Text });
            data.Cells.Add(new DataGridViewTextBoxCell() { Value = cboMenu.SelectedValue });
            data.Cells.Add(new DataGridViewTextBoxCell() { Value = ((MenuDetalle)cboMenu.SelectedItem).titulo });
            data.Cells.Add(new DataGridViewTextBoxCell() { Value = obtenerPrecio((int)cboMenu.SelectedValue) });
            data.Cells.Add(new DataGridViewTextBoxCell() { Value = nupCantidad.Value });
            data.Cells.Add(new DataGridViewTextBoxCell() { Value = obtenerSubTotal(int.Parse(nupCantidad.Value.ToString()), obtenerPrecio((int)cboMenu.SelectedValue)) });
            data.Cells.Add(new DataGridViewTextBoxCell() { Value = cboMesa.SelectedValue });
            data.Cells.Add(new DataGridViewTextBoxCell() { Value = cboEmpleado.SelectedValue });
            dgvPedido.Rows.Add(data);
        }

        private void refrescarGrillaConListaSimple(NodoGenerico<PedidoDetalle> nodo, int codigoEmpleado, int codigoMesa)
        {
            ///limpiamos la grilla
            dgvPedido.Rows.Clear();

            NodoGenerico<PedidoDetalle> nodoPedidoDetTemp = nodo;
            if (nodoPedidoDetTemp != null)
            {
                while (nodoPedidoDetTemp != null)
                {
                    DataGridViewRow data = new DataGridViewRow();
                    data.Cells.Add(new DataGridViewTextBoxCell() { Value = nodoPedidoDetTemp.objeto.idPedido });
                    data.Cells.Add(new DataGridViewTextBoxCell() { Value = nodoPedidoDetTemp.objeto.menuDetalle.idMenuDetalle });
                    data.Cells.Add(new DataGridViewTextBoxCell() { Value = nodoPedidoDetTemp.objeto.menuDetalle.titulo });
                    data.Cells.Add(new DataGridViewTextBoxCell() { Value = nodoPedidoDetTemp.objeto.precio });
                    data.Cells.Add(new DataGridViewTextBoxCell() { Value = nodoPedidoDetTemp.objeto.cantidad });
                    data.Cells.Add(new DataGridViewTextBoxCell() { Value = nodoPedidoDetTemp.objeto.subtotal });
                    data.Cells.Add(new DataGridViewTextBoxCell() { Value = codigoMesa });
                    data.Cells.Add(new DataGridViewTextBoxCell() { Value = codigoEmpleado });
                    dgvPedido.Rows.Add(data);
                    nodoPedidoDetTemp = nodoPedidoDetTemp.sgte;
                }
            }
        }

        private int obtenerUltimoIdPedidoDet(int numerador)
        {
            int contadorPedido = 0;
            if (nodoPedidoDetalle.listaObjeto.Count > 0)
            {
                contadorPedido = nodoPedidoDetalle.listaObjeto.Count + numerador;
            } else {
                contadorPedido = contadorPedido + numerador;
            }
            return contadorPedido;
        }
    }
}
