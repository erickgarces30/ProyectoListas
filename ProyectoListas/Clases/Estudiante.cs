using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoListas.Clases
{
    class Estudiante
    {
        public String NombreCompleto { get; set; }
        public String Genero { get; set; }
        public String EstadoCivil { get; set; }
        public string edad { get; set; }
    }

    class producto
    {
        public String codigo { get; set; }
        public String nombre { get; set; }
        public double precio { get; set; }
        public DateTime fecha { get; set; }
        public int unidad { get; set; }
    }
}
