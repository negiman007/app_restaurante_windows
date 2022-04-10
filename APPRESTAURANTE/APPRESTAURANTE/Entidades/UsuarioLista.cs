using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPRESTAURANTE.Entidades
{
    class UsuarioLista
    {
        public NodoUsuario inicio;

        public UsuarioLista()
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
        
        public void Insertar(Usuario usuario)
        {
            NodoUsuario actual;
            if (EstaVacia())
            {
                actual = new NodoUsuario(usuario, null);
                inicio = actual;
            }
            else
            {
                actual = new NodoUsuario(usuario, null);
                inicio.sgte = actual;
            }
        }

        public List<Usuario> GenerarListaProveedores()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            NodoUsuario tempoLista = inicio;
            while (tempoLista != null)
            {
                listaUsuarios.Add(tempoLista.usuario);
                tempoLista = tempoLista.sgte;
            }
            return listaUsuarios;
        }


        public void InsertarUsuario(Usuario usuario)
        {
            NodoUsuario actual = new NodoUsuario(usuario, null);
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

        public void InsertarProveedorAlFinal(Usuario usuario)
        {
            NodoUsuario actual;
            NodoUsuario t = inicio;
            actual = new NodoUsuario(usuario, null);
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
