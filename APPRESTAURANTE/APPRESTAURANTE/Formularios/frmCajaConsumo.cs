using System;
using System.Windows.Forms;
using APPRESTAURANTE.Nodo;
using APPRESTAURANTE.Entidades;
using APPRESTAURANTE.Entidades.Constantes;
using APPRESTAURANTE.Entidades.Enum;

namespace APPRESTAURANTE.Formularios
{
    public partial class frmCajaConsumo : Form
    {
        ListaGenerica<Pedido> nodoPedido = new ListaGenerica<Pedido>(Constants.FUENTE_PEDIDO);
        ListaGenerica<PedidoDetalle> nodoPedidoDetalle = new ListaGenerica<PedidoDetalle>(Constants.FUENTE_PEDIDO_DETALLE);
        ListaGenerica<Mesa> nodoMesa = new ListaGenerica<Mesa>(Constants.FUENTE_MESA);

        public frmCajaConsumo()
        {
            InitializeComponent();
            nodoPedido.Cargar();
            nodoPedidoDetalle.Cargar();
            nodoMesa.Cargar();
        }

        private void frmCajaConsumo_Load(object sender, EventArgs e)
        {
            mostrarPedidos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string fechaFiltro = dtpFechaPedido.Value.ToString("yyyy-MM-dd");
            //TODO: filtrar los pedidos por Fecha
            NodoGenerico<Pedido> nodoPedidoTemp = nodoPedido.GenerarListaGenerico();
            NodoGenerico<Pedido> nodoPedidoBusqueda = null;
            NodoGenerico<Pedido> actual;
            if (nodoPedidoTemp != null)
            {
                while (nodoPedidoTemp != null)
                {
                    if (nodoPedidoTemp.objeto.fechaPedido.Equals(fechaFiltro))
                    {
                        if (nodoPedidoBusqueda == null)
                        {
                            actual = new NodoGenerico<Pedido>(nodoPedidoTemp.objeto, null, null);
                            nodoPedidoBusqueda = actual;
                        }
                        else
                        {
                            actual = new NodoGenerico<Pedido>(nodoPedidoTemp.objeto, null, null);
                            actual.sgte = nodoPedidoBusqueda;
                            nodoPedidoBusqueda = actual;
                        }
                    }
                    nodoPedidoTemp = nodoPedidoTemp.sgte;
                }
            }

            if (nodoPedidoBusqueda != null) 
            {
                dgvPedidos.Rows.Clear();
                while (nodoPedidoBusqueda != null)
                {
                    cargarGrillaPedidos(nodoPedidoBusqueda.objeto);
                    nodoPedidoBusqueda = nodoPedidoBusqueda.sgte;
                }
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            mostrarPedidos();
        }

        private void mostrarPedidos()
        {
            NodoGenerico<Pedido> nodoPedidoTemp = nodoPedido.GenerarListaGenerico();
            dgvPedidos.Rows.Clear();
            if (nodoPedidoTemp != null)
            {
                while (nodoPedidoTemp != null)
                {
                    cargarGrillaPedidos(nodoPedidoTemp.objeto);
                    nodoPedidoTemp = nodoPedidoTemp.sgte;
                }
            }
        }

        private void cargarGrillaPedidos(Pedido pedido)
        {
            if (pedido == null)
            {
                return;
            }
            else
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = pedido.idPedido });
                fila.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = ((int)EstadoPago.PENDIENTE == pedido.estadoPago) ? EstadoPago.PENDIENTE.ToString() : EstadoPago.CANCELADO.ToString()
                });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = pedido.estadoPago });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = pedido.fechaPedido });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = pedido.idMesa });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = obtenerMesa(pedido.idMesa) });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = pedido.tipoPago });
                fila.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = ((int)TipoPago.Efectivo == pedido.tipoPago) ? TipoPago.Efectivo.ToString().ToUpper()
                            : ((int)TipoPago.Visa == pedido.tipoPago) ? TipoPago.Visa.ToString().ToUpper()
                            : ((int)TipoPago.Mastercard == pedido.tipoPago) ? TipoPago.Mastercard.ToString().ToUpper()
                            : ((int)TipoPago.Otros == pedido.tipoPago) ? TipoPago.Otros.ToString().ToUpper()
                            : ""
                });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = pedido.totalPedido });
                dgvPedidos.Rows.Add(fila);
            }
        }

        private string obtenerMesa(int idMesa)
        {
            string descripcionMesa = string.Empty;
            NodoGenerico<Mesa> nodoMesaTemp = nodoMesa.GenerarListaGenerico();
            if (nodoMesaTemp != null)
            {
                while (nodoMesaTemp != null)
                {
                    if (idMesa == nodoMesaTemp.objeto.idMesa)
                    {
                        descripcionMesa = nodoMesaTemp.objeto.nombreMesa.ToUpper();
                        break;
                    }
                    nodoMesaTemp = nodoMesaTemp.sgte;
                }
            }
            return descripcionMesa;
        }
    }
}
