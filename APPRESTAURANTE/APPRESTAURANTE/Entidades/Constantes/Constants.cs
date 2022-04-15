using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPRESTAURANTE.Entidades.Constantes
{
    static class Constants
    {
        private const string RUTA = @"D:\Json\";
        private const string TABLA_EMPLEADO = "bdEmpleado.json";
        private const string TABLA_USUARIO = "bdUsuario.json";
        private const string TABLA_MESA = "bdMesa.json";
        private const string TABLA_MENU = "bdMenu.json";
        private const string TABLA_MENU_DETALLE = "bdMenuDetalle.json";
        private const string TABLA_PEDIDO = "bdPedido.json";
        public static string FUENTE_EMPLEADO = $"{RUTA}{TABLA_EMPLEADO}";
        public static string FUENTE_USUARIO = $"{RUTA}{TABLA_USUARIO}";
        public static string FUENTE_MENU = $"{RUTA}{TABLA_MENU}";
        public static string FUENTE_MENU_DETALLE = $"{RUTA}{TABLA_MENU_DETALLE}";
        public static string FUENTE_MESA = $"{RUTA}{TABLA_MESA}";
        public static string FUENTE_PEDIDO = $"{RUTA}{TABLA_PEDIDO}";
    }
}
