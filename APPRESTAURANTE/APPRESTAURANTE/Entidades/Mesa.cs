using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPRESTAURANTE.Entidades
{
    public class Mesa
    {
        public int idMesa { get; set; }

        public string fechaCreacion { get; set; }

        public string nombreMesa { get; set; }

        public int idUsuario { get; set; }

        public string fechaRegistro { get; set; }

        public bool estadoMesa { get; set; }

        public Mesa sgte { get; }

        public Mesa()
        {
            sgte = null;
        }

        public Mesa(int idMesa, string fechaCreacion, string nombreMesa, int idUsuario, string fechaRegistro, bool estadoMesa)
        {
            this.idMesa = idMesa;
            this.fechaCreacion = fechaCreacion;
            this.nombreMesa = nombreMesa;
            this.idUsuario = idUsuario;
            this.fechaRegistro = fechaRegistro;
            this.estadoMesa = estadoMesa;
            this.sgte = null;
        }
    }
}
