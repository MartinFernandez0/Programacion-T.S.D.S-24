using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PDF.Clases
{
    internal class Split
    {
        // Declarar los campos y propiedades

        // Campo: Las variables privadas de la clasesoe - PRIVATE
        private string color;
        private int frigorias;
        private string marca;
        private bool encendido;

        // Propiedades: Las vadriables publicas de la clase - PUBLIC
        public int temperatura;
        public string modo;

        //CONSTRUCTOR - Metodo que se ejecuta cunado la clase se crea, se instancia en memoria, es decir cuando se consturye el objeto
        public Split(string pColor, int pFrigorias, string pMarca)
        {
            this.color = pColor;
            this.frigorias = pFrigorias;
            this.marca = pMarca;

            this.temperatura = 24;
            this.modo = "Frio";
            this.encendido = false;

    }
        public void PresionarBotonEncendido()
        {
            this.encendido=! this.encendido;
        }
        public void SubirTemperatura()
        {
            if(this.encendido)
            {
                this.temperatura++;
            }
            else
            {
                Console.WriteLine("Error: El split esta apagado");
            }
        }
        public void BajarTemperatura()
        {
            if (this.encendido)
            {
                this.temperatura--;
            }
            else
            {
                Console.WriteLine("Error: El split esta apagado");
            }
        }
        public void CambiarModo(string modo)
        {
            if (this.encendido)
                this.modo = modo;
            else
                Console.WriteLine("Error: El split debe estar Encendido");
        }
    }
}
