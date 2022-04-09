using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPRESTAURANTE.Entidades
{
    class Lista
    {
        public Nodo inicio;

        public Lista()
        {
            inicio = null;
        }

        public Boolean EstaVacia()
        {
            if (inicio == null)
            {
                return true;
            } else { return false; }
        }
        
        public void Insertar(Proveedor proveedor)
        {
            Nodo actual;
            if (EstaVacia())
            {
                actual = new Nodo(proveedor, null);
                inicio = actual;
            }
            else
            {
                actual = new Nodo(proveedor, null);
                inicio.sgte = actual;
            }
        }

        public List<Proveedor> GenerarListaProveedores()
        {
            List<Proveedor> listaProveedores = new List<Proveedor>();
            Nodo tempoLista = inicio;
            while (tempoLista != null)
            {
                listaProveedores.Add(tempoLista.proveedor);
                tempoLista = tempoLista.sgte;
            }
            return listaProveedores;
        }


        public void InsertarProveedor(Proveedor proveedor)
        {
            Nodo actual = new Nodo(proveedor, null);
            if (EstaVacia())
            {
                actual.sgte = inicio;
                inicio = actual;
            }
            else
            {
                actual.sgte = inicio;
                inicio = actual;
            }
        }

        public void InsertarProveedorAlFinal(Proveedor proveedor)
        {
            Nodo actual;
            Nodo t = inicio;
            actual = new Nodo(proveedor, null);
            if (EstaVacia())
            {
                inicio = actual;
            }
            else
            {
                while (t.sgte != null)
                {
                    t = t.sgte;
                }
                t.sgte = actual;
            }
        }

        public int GenerarCorrelativoProveedor(int numerador)
        {
            Random rand = new Random();
            int codigo = 1000 + numerador;
            return codigo;
        }

        public int GenerarCorrelativo()
        {
            Random rand = new Random();
            int codigo; int numerador = 0;
            for (int i = 0; i < 20; i++)
            {
                codigo = rand.Next(4) + 1001;
                numerador = codigo;
            }
            return numerador;
        }

    }
}
