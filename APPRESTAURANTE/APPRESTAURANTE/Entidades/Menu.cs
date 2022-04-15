using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPRESTAURANTE.Entidades
{
    public class Menu
    {
        public int id { get; set; }
        public string fecha { get; set; }
        public int idUsuario { get; set; }
        public string fecha_registro { get; set; }

        public Menu sgte { get; set; }

        public Menu()
        {
            sgte = null;
        }

        public Menu(int id, string fecha, int idUsuario, string fecha_registro)
        {
            this.id = id;
            this.fecha = fecha;
            this.idUsuario = idUsuario;
            this.fecha_registro = fecha_registro;
            this.sgte = null;
        }
    }
}
