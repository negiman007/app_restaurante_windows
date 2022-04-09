using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPRESTAURANTE.Entidades
{
    public class NodoGenerico<T>
    {
        public T objeto;
        public NodoGenerico<T> sgte;
        public List<T> listaGenerica;

        public NodoGenerico(T objeto, NodoGenerico<T> sgte)
        {
            this.objeto = objeto;
            this.sgte = sgte;
            this.listaGenerica = new List<T>();
        }

        public NodoGenerico()
        {
            this.listaGenerica = new List<T>();
        }
    }
}
