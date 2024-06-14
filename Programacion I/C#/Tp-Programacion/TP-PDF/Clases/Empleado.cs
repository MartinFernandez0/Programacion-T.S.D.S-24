using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PDF.Clases
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set;}

        public Empleado(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public virtual string ImprimirInfo()
        {
            return $"{Apellido},{Nombre}";
        }

    }
}
