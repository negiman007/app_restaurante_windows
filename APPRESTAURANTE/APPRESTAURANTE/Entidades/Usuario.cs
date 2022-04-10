using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPRESTAURANTE.Entidades
{
    public class Usuario
    {
        public string idUsuario { get; set; }

        public string usuario { get; set; }

        public string clave { get; set; }

        public bool estado { get; set; }

        public string idEmpleado { get; set; }

        public Usuario sgte { get; }


        public Usuario()
        {
            sgte = null;
        }

        public Usuario(string idUsuario, string usuario, string clave, bool estado, string idEmpleado)
        {
            this.idUsuario = idUsuario;
            this.usuario = usuario;
            this.clave = clave;
            this.estado = estado;
            this.idEmpleado = idEmpleado;
            this.sgte = null;
        }
    }
}