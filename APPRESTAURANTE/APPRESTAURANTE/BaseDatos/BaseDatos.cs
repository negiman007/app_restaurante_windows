using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace APPRESTAURANTE.BaseDatos
{
    public class BaseDatos<T>
    {
        public List<T> valores = new List<T>();
        public string ruta;

        public BaseDatos(string ruta)
        {
            this.ruta = ruta;
        }

        public void Cargar()
        {
            try
            {
                string archivo = File.ReadAllText(ruta);
                valores = JsonConvert.DeserializeObject<List<T>>(archivo);
            }
            catch (Exception) { }
        }

        public void Guardar()
        {
            string texto = JsonConvert.SerializeObject(valores);
            File.WriteAllText(ruta, texto);
        }

        public void Insertar(T nuevo)
        {
            valores.Add(nuevo);
            Guardar();
        }

        public List<T> Buscar(Func<T, bool> criterio)
        {
            return valores.Where(criterio).ToList();
        }

        public void Eliminar(Func<T, bool> criterio)
        {
            valores = valores.Where(x => !criterio(x)).ToList();
        }

        public void Actualizar(Func<T, bool> criterio, T nuevo)
        {
            valores = valores.Select(x =>
            {
                if (criterio(x)) x = nuevo;
                return x;
            }).ToList();
        }
    }
}
