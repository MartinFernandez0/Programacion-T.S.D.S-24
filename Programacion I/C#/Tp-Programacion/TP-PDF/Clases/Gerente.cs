using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PDF.Clases
{
    internal class Gerente : Empleado
    {
        public Gerente(string apellido, string nombre) : base(nombre, apellido)
        {
        }
        public override string ImprimirInfo()
        {
            return "Gerente: "+ base.ImprimirInfo();
        }
    }
}
