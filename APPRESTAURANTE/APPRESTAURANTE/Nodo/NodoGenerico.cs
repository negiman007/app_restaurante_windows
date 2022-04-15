using System.Collections.Generic;

namespace APPRESTAURANTE.Nodo
{
    public class NodoGenerico<T>
    {
        public T objeto;
        public NodoGenerico<T> sgte;
        public NodoGenerico<T> ant;
        public List<T> listaGenerica;

        public NodoGenerico(T objeto, NodoGenerico<T> sgte, NodoGenerico<T> ant)
        {
            this.objeto = objeto;
            this.sgte = sgte;
            this.ant = ant;
            this.listaGenerica = new List<T>();
        }

        public NodoGenerico()
        {
            this.listaGenerica = new List<T>();
        }
    }
}
