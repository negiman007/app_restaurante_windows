using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPRESTAURANTE.Entidades
{
    public class Proveedor
    {
        public int codigoProveedor { get; set; }
        public string rucProveedor { get; set; }
        public string razonSocial { get; set; }
        public string nombreContacto { get; set; }
        public string telefonoContacto { get; set; }
        public string celularContacto { get; set; }
        public string emailContacto { get; set; }
        private Proveedor sgte { get; }

        public Proveedor()
        {
            sgte = null;
        }
        public Proveedor(int codigoProveedor, string rucProveedor, string razonSocial, string nombreContacto, string telefonoContacto, string celularContacto, string emailContacto)
        {
            this.codigoProveedor = codigoProveedor;
            this.rucProveedor = rucProveedor;
            this.razonSocial = razonSocial;
            this.nombreContacto = nombreContacto;
            this.telefonoContacto = telefonoContacto;
            this.celularContacto = celularContacto;
            this.emailContacto = emailContacto;
            this.sgte = null;
        }

        public static Proveedor Build(int codigoProveedor, string rucProveedor, string razonSocial, string nombreContacto, string telefonoContacto, string celularContacto, string emailContacto)
        {

            return new Proveedor(codigoProveedor, rucProveedor, razonSocial, nombreContacto, telefonoContacto, celularContacto, emailContacto);

        }

        public List<Proveedor> GenerarLista()
        {
            List<Proveedor> listProveedor = new List<Proveedor>();
            listProveedor.Add(Proveedor.Build(1001, "11122333343", "TRADISA S.A.C", "javier", "terrazas", "javictorterrazas@gmail.com", "947002680"));
            listProveedor.Add(Proveedor.Build(1002, "12365478963", "CORPORACION ACEROS AREQUIPA", "javier", "terrazas", "javictorterrazas@gmail.com", "947002680"));
            listProveedor.Add(Proveedor.Build(1003, "21459782145", "HOSPITAL", "javier", "terrazas", "javictorterrazas@gmail.com", "947002680"));
            listProveedor.Add(Proveedor.Build(1004, "32145698752", "PIZZA", "javier", "terrazas", "javictorterrazas@gmail.com", "947002680"));
            listProveedor.Add(Proveedor.Build(1005, "32145698755", "POLLITO", "javier", "terrazas", "javictorterrazas@gmail.com", "947002680"));
            listProveedor.Add(Proveedor.Build(1006, "32145698756", "ARROZ", "javier", "terrazas", "javictorterrazas@gmail.com", "947002680"));
            listProveedor.Add(Proveedor.Build(1007, "32145698757", "VERDURAS", "javier", "terrazas", "javictorterrazas@gmail.com", "947002680"));
            return listProveedor;
        }
    }
}
