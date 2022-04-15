using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPRESTAURANTE.Entidades
{
    public class PedidoDetalle
    {
        public int idPedidoDetalle { get; set; }
        public int idPedido { get; set; }
        public int idMenuDetalle { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
        public double subtotal { get; set; }
    }
}
