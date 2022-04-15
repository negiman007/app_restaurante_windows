using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPRESTAURANTE.Entidades
{
    class Nodo
    {
        public Proveedor proveedor;
        public Nodo sgte;

        public Nodo(Proveedor proveedor, Nodo sgte)
        {
            this.proveedor = proveedor;
            this.sgte = sgte;
        }
    }
}
