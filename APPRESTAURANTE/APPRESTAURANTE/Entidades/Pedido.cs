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

        public string tipoPago { get; set; }

        public int idEmpleado { get; set; }

        public int idUsuario { get; set; }

        public int estadoPago { get; set; }

        public IEnumerable<PedidoDetalle> pedidoDetalles { get; set; }

        public Pedido()
        {

        }

    }
}
