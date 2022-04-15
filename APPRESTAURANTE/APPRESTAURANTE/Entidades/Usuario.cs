using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPRESTAURANTE.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public string UserName { get; set; }
        
        public string Clave { get; set; }

        public bool Estado { get; set; }

        public int IdEmpleado { get; set; }

        public int IdRol { get; set; }

        public Empleado Empleado { get; set; }

        private Usuario sgte { get; }

        public Usuario()
        {
            sgte = null;
            //Empleado = new Empleado();
        }
        public Usuario(int IdUsuario, string UserName, string Clave, bool Estado, int IdEmpleado, int IdRol, Empleado Empleado)
        {
            this.IdUsuario = IdUsuario;
            this.UserName = UserName;
            this.Clave = Clave;
            this.Estado = Estado;
            this.IdEmpleado = IdEmpleado;
            this.IdRol = IdRol;
            this.Empleado = Empleado;
        }
    }
}
