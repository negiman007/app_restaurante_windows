using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace APPRESTAURANTE.Nodo
{
    public class ListaGenerica<T>
    {
        public NodoGenerico<T> inicio;
        public string ruta;
        public List<T> listaObjeto = new List<T>();

        public ListaGenerica()
        {
            inicio = null;
        }

        public ListaGenerica(string ruta)
        {
            inicio = null;
            this.ruta = ruta;
        }

        /// <summary>
        /// Cargar Archivo de base de datos JSON con una sola instancia generica
        /// </summary>
        public void Cargar()
        {
            try
            {
                bool result = File.Exists(ruta);
                if (result)
                {
                    string archivo = File.ReadAllText(ruta);
                    if (archivo.Equals(String.Empty))
                    {
                        listaObjeto = new List<T>();
                    }
                    else
                    {
                        listaObjeto = JsonConvert.DeserializeObject<List<T>>(archivo);
                    }
                }
                else
                {
                    StreamWriter file = File.CreateText(ruta);
                    file.Close();
                    file.Dispose();
                }
            }
            catch (Exception) { }
        }

        public void Guardar()
        {
            string texto = JsonConvert.SerializeObject(inicio.objeto);
            File.WriteAllText(ruta, texto);
        }

        public void GuardarGenerico(T objeto)
        {
            string texto = JsonConvert.SerializeObject(objeto);
            File.WriteAllText(ruta, texto);
        }

        public void GuardarListaGenerico(List<T> objeto)
        {
            string texto = JsonConvert.SerializeObject(objeto);
            File.WriteAllText(ruta, texto);
        }

        private void GuardarGenerico(List<T> listaGenerica)
        {
            string texto = JsonConvert.SerializeObject(listaGenerica);
            File.WriteAllText(ruta, texto);
        }


        public Boolean EstaVacia()
        {
            if (inicio == null)
            {
                return true;
            }
            else { return false; }
        }

        public void InsertarAlInicio(T objeto)
        {
            NodoGenerico<T> actual;
            if (EstaVacia())
            {
                actual = new NodoGenerico<T>(objeto, null, null);
                inicio = actual;
                Guardar();
            }
            else
            {
                actual = new NodoGenerico<T>(objeto, null, null);
                inicio.sgte = actual;

                Guardar();
            }
        }

        public List<T> GenerarListaGenerica()
        {
            List<T> listaGenerica = new List<T>();
            NodoGenerico<T> tempoLista = inicio;
            while (tempoLista != null)
            {
                listaGenerica.Add(tempoLista.objeto);
                tempoLista = tempoLista.sgte;
            }
            return listaGenerica;
        }

        public void InsertarObjeto(T objeto)
        {
            NodoGenerico<T> actual = new NodoGenerico<T>(objeto, null, null);
            if (EstaVacia())
            {
                actual.sgte = inicio;
                inicio = actual;
                listaObjeto.Add(objeto);
                GuardarGenerico(listaObjeto);
            }
            else
            {
                actual.sgte = inicio;
                inicio = actual;
                listaObjeto.Add(objeto);
                GuardarGenerico(listaObjeto);
            }
        }

        public void InsertarObjetoAlFinal(T objeto)
        {
            NodoGenerico<T> actual;
            NodoGenerico<T> t = inicio;
            actual = new NodoGenerico<T>(objeto, null, null);
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

        public int GenerarCorrelativoObjeto(int numerador)
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

        public int GenerarCorrelativoEmpleado()
        {
            Random random = new Random();
            int numerador = 0;
            numerador = random.Next(10000000, 99999999);
            return numerador;
        }

        public List<T> GenerarListaGenericaEmpleado()
        {
            List<T> listaGenerica = new List<T>();
            NodoGenerico<T> tempoLista = inicio;
            if (listaObjeto.Count > 0)
            {
                foreach (var item in listaObjeto)
                {
                    NodoGenerico<T> actual;
                    if (EstaVacia())
                    {
                        actual = new NodoGenerico<T>(item, null, null);
                        inicio = actual; ///primera vez entra aqui
                    }
                    else
                    {
                        actual = new NodoGenerico<T>(item, null, null);
                        actual.sgte = inicio;
                        inicio = actual;
                    }
                }
            } else
            {
                while (tempoLista != null)
                {
                    listaGenerica.Add(tempoLista.objeto);
                    tempoLista = tempoLista.sgte;
                }
            }
            return listaGenerica;
        }

        public NodoGenerico<T> GenerarListaGenerico()
        {
            List<T> listaGenerica = new List<T>();
            inicio = null;
            if (listaObjeto.Count > 0)
            {
                foreach (var item in listaObjeto)
                {
                    NodoGenerico<T> actual;
                    if (EstaVacia())
                    {
                        actual = new NodoGenerico<T>(item, null, null);
                        inicio = actual; ///primera vez entra aqui
                    }
                    else
                    {
                        actual = new NodoGenerico<T>(item, null, null);
                        actual.sgte = inicio;
                        inicio = actual;
                    }
                }
            }
            return inicio;
        }

        public List<T> Buscar(Func<T, bool> criterio)
        {
            return listaObjeto.Where(criterio).ToList();
        }

        public void Eliminar(Func<T, bool> criterio)
        {
            listaObjeto = listaObjeto.Where(x => !criterio(x)).ToList();
        }

        public void Actualizar(Func<T, bool> criterio, T nuevo)
        {
            listaObjeto = listaObjeto.Select(x =>
            {
                if (criterio(x)) x = nuevo;
                return x;
            }).ToList();
        }
    }
}
