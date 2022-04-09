using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPRESTAURANTE.Entidades
{
    public class ListaGenerica<T>
    {
        public NodoGenerico<T> inicio;
        public string ruta;
        public List<T> listaObjeto = new List<T>();

        public ListaGenerica(string ruta)
        {
            inicio = null;
            this.ruta = ruta;
        }

        /*public ListaGenerica(string ruta)
        {
            this.ruta = ruta;
        }*/
        public void Cargar()
        {
            try
            {
                //ruta = @"D:\Cursos\UPN\5 CICLO\ESTRUCTURA DE DATOS\Grupo_3\APPRESTAURANTE\empleado.json";
                bool result = File.Exists(ruta);
                if (result)
                {
                    string archivo = File.ReadAllText(ruta);
                    if (archivo.Equals(String.Empty))
                    {
                        //inicio.listaGenerica = new List<T>();
                        listaObjeto = new List<T>();
                    }
                    else
                    {
                        //inicio.listaGenerica = JsonConvert.DeserializeObject<List<T>>(archivo);
                        listaObjeto = JsonConvert.DeserializeObject<List<T>>(archivo);
                    }
                    
                    //Console.WriteLine("File Found");
                }
                else
                {
                    StreamWriter file = File.CreateText(ruta);
                    file.Close();
                    file.Dispose();

                    //FileStream createStream = File.Create(ruta);
                    //createStream.Close();
                    //createStream.Dispose();

                    /*using (StreamWriter sw = File.CreateText(ruta))
                    {
                        sw.Write(jsonstring);
                        sw.Close();
                        sw.Dispose();
                    }*/
                    //Console.WriteLine("File Not Found");
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

        /*public void Insertar(T nuevo)
        {
            //inicio.Add(nuevo);
            Guardar();
        }*/

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
                actual = new NodoGenerico<T>(objeto, null);
                inicio = actual;
                Guardar();
            }
            else
            {
                actual = new NodoGenerico<T>(objeto, null);
                inicio.sgte = actual;

                Guardar();
            }
        }

        public List<T> GenerarListaGenerica()
        {
            List<T> listaProveedores = new List<T>();
            NodoGenerico<T> tempoLista = inicio;
            while (tempoLista != null)
            {
                listaProveedores.Add(tempoLista.objeto);
                tempoLista = tempoLista.sgte;
            }
            return listaProveedores;
        }

        public void InsertarObjeto(T objeto)
        {
            NodoGenerico<T> actual = new NodoGenerico<T>(objeto, null);
            if (EstaVacia())
            {
                actual.sgte = inicio;
                inicio = actual;
                //inicio.listaGenerica.Add(objeto);
                //GuardarListaGenerico(actual.listaGenerica);
                listaObjeto.Add(objeto);
                GuardarGenerico(listaObjeto);
            }
            else
            {
                actual.sgte = inicio;
                inicio = actual;
                //inicio.listaGenerica.Add(objeto);
                //GuardarListaGenerico(actual.listaGenerica);
                listaObjeto.Add(objeto);
                GuardarGenerico(listaObjeto);
            }
        }

        public void InsertarProveedorAlFinal(T objeto)
        {
            NodoGenerico<T> actual;
            NodoGenerico<T> t = inicio;
            actual = new NodoGenerico<T>(objeto, null);
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

        public List<T> GenerarListaGenericaEmpleado()
        {
            List<T> listaGenerica = new List<T>();
            NodoGenerico<T> tempoLista = inicio;
            if (listaObjeto.Count > 0)
            {
                foreach (var item in listaObjeto)
                {
                    listaGenerica.Add(item);
                    tempoLista = tempoLista.sgte;
                }
            } else
            {
                while (tempoLista != null)
                {
                    listaGenerica.Add(tempoLista.objeto);
                    tempoLista = tempoLista.sgte;
                }
            }
            /*NodoGenerico<T> tempoLista = inicio;
            while (tempoLista != null)
            {
                listaGenerica.Add(tempoLista.objeto);
                tempoLista = tempoLista.sgte;
            }
            return listaGenerica;*/
            return listaGenerica;
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
