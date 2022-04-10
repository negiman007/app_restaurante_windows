using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPRESTAURANTE.Entidades
{
    //class Nodo<T>
    class Nodo
    {
        //public T proveedor;
        //public Nodo<T> next;
        public Proveedor proveedor;
        public Nodo sgte;

        /*public Nodo()
        {
            sgte = null;
        }*/
        public Nodo(Proveedor proveedor, Nodo sgte)
        {
            this.proveedor = proveedor;
            this.sgte = sgte;
        }
    }

    class NodoUsuario
    {
        //public T proveedor;
        //public Nodo<T> next;
        public Usuario usuario;
        public NodoUsuario sgte;

        /*public Nodo()
        {
            sgte = null;
        }*/
        public NodoUsuario(Usuario usuario, NodoUsuario sgte)
        {
            this.usuario = usuario;
            this.sgte = sgte;
        }
    }
}
