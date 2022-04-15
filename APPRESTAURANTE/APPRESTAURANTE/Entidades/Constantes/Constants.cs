using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPRESTAURANTE.Entidades.Constantes
{
    static class Constants
    {
        public const string RUTA = @"D:\Json\";
        public const string TABLA_EMPLEADO = "bdEmpleado.json";
        public const string TABLA_USUARIO = "bdUsuario.json";
        public const string TABLA_MESA = "bdMesa.json";
        public const string TABLA_MENU = "bdMenu.json";
        public const string TABLA_PEDIDO = "bdPedido.json";
        public static string FUENTE_EMPLEADO = $"{RUTA}{TABLA_EMPLEADO}";
        public static string FUENTE_USUARIO = $"{RUTA}{TABLA_USUARIO}";
        public static string FUENTE_PEDIDO = $"{RUTA}{TABLA_PEDIDO}";
    }
}
