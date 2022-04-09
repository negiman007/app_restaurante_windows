using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPRESTAURANTE.Entidades
{
    public class Empleado
    {
        public int idEmpleado { get; set; }
        public string nombre { get; set; }

        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }

        public string direccion { get; set; }

        public string tipoDocumento { get; set; }

        public string documento { get; set; }

        public bool estado { get; set; }

        public Empleado sgte { get; }


        public Empleado()
        {
            sgte = null;
        }

        public Empleado(int idEmpleado, string nombre, string apellidoPaterno, string apellidoMaterno, string direccion, string tipoDocumento, string documento, bool estado)
        {
            this.idEmpleado = idEmpleado;
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.direccion = direccion;
            this.tipoDocumento = tipoDocumento;
            this.documento = documento;
            this.estado = estado;
            this.sgte = null;
        }
    }
}
