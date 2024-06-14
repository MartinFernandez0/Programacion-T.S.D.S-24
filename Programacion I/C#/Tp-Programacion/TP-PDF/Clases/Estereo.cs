using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PDF.Enum;
using TP_PDF.Enums;



namespace TP_PDF.Clases
{
    internal class Estereo
    {
        public string fabricante;
        public string color;

        private ModoEstereoEnum Modo;
        private bool Encendido;
        private int NivelVolumen;
        private double SintoniaFM;
        private string ConexionBluetooth;
        private string ReproductorCD;
        private string NombreEntradaAux;
        private string NombreDispositivoUsb;

        public Estereo(string fabricante, string color)
        {
            this.fabricante = fabricante;
            this.color = color;

            this.Encendido = false;
            this.Modo = ModoEstereoEnum.Radio;
            this.SintoniaFM = 99.9;
            this.NivelVolumen = 80;
            this.ConexionBluetooth = "Bluettoth conectado";
            this.ReproductorCD = "CD insertado";
            this.NombreEntradaAux = "Canción AUX";
            this.NombreDispositivoUsb = "Reproduciendo desde USB";
        }

        public void Encender()
        {
            this.Encendido = !this.Encendido;
            this.Modo = ModoEstereoEnum.Radio;
        }

        public void IncrementarVolumen()
        {
            while (Encendido && NivelVolumen < 100)
            {
                NivelVolumen ++;
                Console.Clear();
                Console.WriteLine($"Aumentando Nivel sonido...:{NivelVolumen}%");
                Thread.Sleep(100);
            }
        }
        public void DisminuirVolumen()
        {
            NivelVolumen--;
            Console.Clear();
            Console.WriteLine($"Disminuyendo Nivel sonido...:{NivelVolumen}%");
            Thread.Sleep(100);
        }

        public void EstablecerModo(ModoEstereoEnum modo)
        {
            if (Encendido)
                this.Modo = modo;
            else
                Console.WriteLine("ERROR: El sistema de sonido debe estar activo.");
        }

        public void AjustarFrecuenciaFM(double nuevaSintonia)
        {
            if (Encendido && Modo == ModoEstereoEnum.Radio)
                SintoniaFM = nuevaSintonia;
            else
                Console.WriteLine("El sistema de sonido debe estar en modo Radio para ajustar la frecuencia FM.");
        }
        public void SeleccionarCancionBT(string nuevaCancion)
        {
            if (Encendido && Modo == ModoEstereoEnum.Bluetooth)
                ConexionBluetooth = nuevaCancion;
            else
                Console.WriteLine("El sistema de sonido debe estar en modo Bluetooth para seleccionar una canción.");
        }
        public void CambiarPistaCD(string nuevaPista)
        {
            if (Encendido && Modo == ModoEstereoEnum.CD)
                ReproductorCD = nuevaPista;
            else
                Console.WriteLine("El sistema de sonido debe estar en modo CD para cambiar la pista.");
        }
        public void SeleccionarCancionAux(string nuevaCancion)
        {
            if (Encendido && Modo == ModoEstereoEnum.Aux)
                NombreEntradaAux = nuevaCancion;
            else
                Console.WriteLine("El sistema de sonido debe estar en modo AUX para seleccionar una canción.");
        }
        public void ReproducirDesdeUSB(string archivo)
        {
            if (Encendido && Modo == ModoEstereoEnum.Usb)
                NombreDispositivoUsb = $"Reproduciendo archivo: {archivo}";
            else
                Console.WriteLine("El sistema de sonido debe estar en modo USB para reproducir archivos.");
        }
        public void Mostrar()
        {
            Console.WriteLine("**********************************");

            if (Encendido)
            {
                Console.WriteLine($"Modo actual: {Modo}");
                Console.WriteLine($"Nivel de volumen: {NivelVolumen}");

                switch (Modo)
                {
                    case ModoEstereoEnum.Radio:
                        Console.WriteLine($"Sintonía FM actual: {SintoniaFM}");
                        break;
                    case ModoEstereoEnum.Bluetooth:
                        Console.WriteLine($"Reproduciendo vía Bluetooth: {ConexionBluetooth}");
                        break;
                    case ModoEstereoEnum.CD:
                        Console.WriteLine($"Reproduciendo pista de CD: {ReproductorCD}");
                        break;
                    case ModoEstereoEnum.Aux:
                        Console.WriteLine($"Reproduciendo Cancion AUX: {NombreEntradaAux}");
                        break;
                    case ModoEstereoEnum.Usb:
                        Console.WriteLine($"Reproduciendo USB: {NombreDispositivoUsb}");
                        break;
                }
            }
            else
            {
                Console.WriteLine("El sistema de sonido está apagado.");
            }
            Console.ReadLine();
        }
    }
}
