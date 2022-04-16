using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPRESTAURANTE.Entidades
{
    public class Pedido
    {
        public int idPedido { get; set; }

        public string fechaPedido { get; set; }

        public double totalPedido { get; set; }

        public int idMesa { get; set; }

        public int tipoPago { get; set; }

        public int idEmpleado { get; set; }

        public int idUsuario { get; set; }

        public int estadoPago { get; set; }

        public IEnumerable<PedidoDetalle> pedidoDetalles { get; set; }

        public Pedido sgte { get; set; }

        public Pedido()
        {
            sgte = null;
        }
        public Pedido(int idPedido, string fechaPedido, double totalPedido, int idMesa, int tipoPago, int idEmpleado, int idUsuario, int estadoPago)
        {
            this.idPedido = idPedido;
            this.fechaPedido = fechaPedido;
            this.totalPedido = totalPedido;
            this.tipoPago = tipoPago;
            this.idEmpleado = idEmpleado;
            this.idUsuario = idUsuario;
            this.estadoPago = estadoPago;
            this.sgte = null;
        }

    }
}
