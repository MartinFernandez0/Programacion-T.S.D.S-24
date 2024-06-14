using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PDF.Clases
{
    internal class persona
    {
        // Declarar los campos y propiedades

        // Campo: Las variables privadas de la clase - PRIVATE
        private string nombre;
        private string direccion;
        private int año_nacimiento;

        public persona(string nombre, string direccion, int año_nacimiento)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.año_nacimiento = año_nacimiento;
        }

        public void Decir(string texto)
        {
            Console.WriteLine($"{nombre} dice: {texto}");
        }
    }
}
