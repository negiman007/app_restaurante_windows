using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPRESTAURANTE.Entidades
{
    class ProveedorList
    {
        public static List<Proveedor> listProveedor = new List<Proveedor>();


        static void listadoProveedor()
        {

            listProveedor.Add(Proveedor.Build(1001,"11122333343", "TRADISA S.A.C", "Ricardo", "chuchon", "rchuchon@gmail.com", "947002680"));
            listProveedor.Add(Proveedor.Build(1002,"12365478963", "CORPORACION ACEROS AREQUIPA", "Ricardo", "chuchon", "rchuchon@gmail.com", "947002680"));
            listProveedor.Add(Proveedor.Build(1003,"21459782145", "HOSPITAL", "Ricardo", "chuchon", "rchuchon@gmail.com", "947002680"));
            listProveedor.Add(Proveedor.Build(1004,"32145698752", "PIZZA", "Ricardo", "chuchon", "rchuchon@gmail.com", "947002680"));
            listProveedor.Add(Proveedor.Build(1005,"32145698755", "POLLITO", "Ricardo", "chuchon", "rchuchon@gmail.com", "947002680"));
            listProveedor.Add(Proveedor.Build(1006,"32145698756", "ARROZ", "Ricardo", "chuchon", "rchuchon@gmail.com", "947002680"));
            listProveedor.Add(Proveedor.Build(1007, "32145698757", "VERDURAS", "Ricardo", "chuchon", "rchuchon@gmail.com", "947002680"));

        }

        public List<Proveedor> generarLista()
        {
            List<Proveedor> listProveedor = new List<Proveedor>();
            List<Proveedor> listProveedor2 = new List<Proveedor>()
            {
                
            };

            listProveedor.Add(Proveedor.Build(1001,"11122333343", "TRADISA S.A.C", "Ricardo", "chuchon", "rchuchon@gmail.com", "947002680"));
            listProveedor.Add(Proveedor.Build(1002,"12365478963", "CORPORACION ACEROS AREQUIPA", "Ricardo", "chuchon", "rchuchon@gmail.com", "947002680"));
            listProveedor.Add(Proveedor.Build(1003,"21459782145", "HOSPITAL", "Ricardo", "chuchon", "rchuchon@gmail.com", "947002680"));
            listProveedor.Add(Proveedor.Build(1004,"32145698752", "PIZZA", "Ricardo", "chuchon", "rchuchon@gmail.com", "947002680"));
            listProveedor.Add(Proveedor.Build(1005,"32145698755", "POLLITO", "Ricardo", "chuchon", "rchuchon@gmail.com", "947002680"));
            listProveedor.Add(Proveedor.Build(1006,"32145698756", "ARROZ", "Ricardo", "chuchon", "rchuchon@gmail.com", "947002680"));
            listProveedor.Add(Proveedor.Build(1007,"32145698757", "VERDURAS", "Ricardo", "chuchon", "rchuchon@gmail.com", "947002680"));

            return listProveedor;
        }

    }
}
