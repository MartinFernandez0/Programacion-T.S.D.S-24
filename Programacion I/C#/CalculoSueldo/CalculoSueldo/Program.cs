using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horasTrabajadas;
            float costoHora;
            float sueldo;
            string linea;

            Console.Write("Ingrese Horas trabajadas por el operario:");
            linea = Console.ReadLine();
            horasTrabajadas = int.Parse(linea);

            Console.Write("Ingrese el pago por hora:");
            linea = Console.ReadLine();
            costoHora = float.Parse(linea);

            sueldo = horasTrabajadas * costoHora;

            Console.Write("El sueldo es");
            Console.Write((int)sueldo);
            Console.ReadKey();

        }
    }
}
