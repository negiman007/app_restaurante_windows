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
        public MenuDetalle menuDetalle { get; set; }
        public PedidoDetalle sgte { get; set; }

        public PedidoDetalle()
        {
            sgte = null;
        }

        public PedidoDetalle(int idPedidoDetalle, int idPedido, int idMenuDetalle, int cantidad, double precio, double subtotal, MenuDetalle menuDetalle)
        {
            this.idPedidoDetalle = idPedidoDetalle;
            this.idPedido = idPedido;
            this.idMenuDetalle = idMenuDetalle;
            this.cantidad = cantidad;
            this.precio = precio;
            this.subtotal = subtotal;
            this.sgte = null;
            this.menuDetalle = menuDetalle;
        }
    }
}
