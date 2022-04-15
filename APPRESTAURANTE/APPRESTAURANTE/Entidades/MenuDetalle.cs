using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPRESTAURANTE.Entidades
{
    public class MenuDetalle
    {
        public int idMenuDetalle { get; set; }
        public int idMenu { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public int tipoPlato { get; set; }
        public double precio { get; set; }
        public int estado { get; set; }

        public MenuDetalle sgte { get; set; }

        public MenuDetalle()
        {
            sgte = null;
        }

        public MenuDetalle(int idMenuDetalle, int idMenu, string titulo, string descripcion, int tipoPlato, double precio, int estado)
        {
            this.idMenuDetalle = idMenuDetalle;
            this.idMenu = idMenu;
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.tipoPlato = tipoPlato;
            this.precio = precio;
            this.estado = estado;
            this.sgte = null;
        }
    }
}
