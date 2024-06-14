
using TP_PDF.Clases;
using TP_PDF.Enum;
using TP_PDF.Enums;

public class ProgramEjercicios
{
    private static void Main(string[] args)
    {
        //Ingresar:

        //CalcularDiasDeVida();
        //MostrarMenorNumeroIngresado();
        //Triangulos();
        //IngresarFechaValida();
        //calcularValorPago();
        //PruebaDeObjetosSplit();
        //PruebaDeObjetosPersona();
        //Estereo();
        //PruebaDeClaseAbstractasYHerencias();
        //PasajePorReferenciaCalculadora();
        //PruebaDeClasesGenericas();

        Console.ReadLine();
    }
    private static void PruebaDeClasesGenericas()
    {
        Empresa<Empleado> empresa = new Empresa<Empleado>("Neumaticos Debona");
        Gerente empleado1 = new Gerente("Juan", "Perez");
        Gerente empleado2 = new Gerente("Pedro", "Gomez");

        empresa.agregarEmpleado(empleado1);
        empresa.agregarEmpleado(empleado2);
        Console.WriteLine(empresa.listarPersonas());

        empresa.quitarEmpleado(empleado2);
        Console.WriteLine(empresa.listarPersonas());
    }
    private static void PasajePorReferenciaCalculadora()
    {
        int a = 123;
        int b = 10;
        int total = 0;

        Calculadora calculadora = new Calculadora();
        calculadora.Sumar(a, b, ref total);
        Console.WriteLine($"La Suma total es: " + total);
    }
    private static void PruebaDeClaseAbstractasYHerencias()
    {
        Gerente Juan = new Gerente("Fernandez","Martin Exequiel");
        Console.WriteLine(Juan.ImprimirInfo());
    }
    private static void Estereo()
    {
        Estereo miEstereo = new Estereo("Sony", "Negro"); 

        miEstereo.Encender();

        miEstereo.IncrementarVolumen(); // Subir el volumen
        miEstereo.EstablecerModo(ModoEstereoEnum.Radio); // Cambiar al modo Radio
        miEstereo.AjustarFrecuenciaFM(101.5); // Cambiar la frecuencia
        miEstereo.Mostrar(); // Mostrar display

        miEstereo.EstablecerModo(ModoEstereoEnum.Bluetooth); 
        miEstereo.SeleccionarCancionBT("BT Martin: Imagine Dragons - Believer");
        miEstereo.Mostrar(); 

        miEstereo.EstablecerModo(ModoEstereoEnum.CD);
        miEstereo.CambiarPistaCD("Rock Nacional - Pista 03");
        miEstereo.Mostrar();

        miEstereo.EstablecerModo(ModoEstereoEnum.Aux);
        miEstereo.SeleccionarCancionAux("Salida Martin / Abel Pintos - Somos Uno");
        miEstereo.Mostrar();

        miEstereo.EstablecerModo(ModoEstereoEnum.Usb);
        miEstereo.ReproducirDesdeUSB("USB MARTIN - Cancion 03 - ACDC Black in Black");
        miEstereo.Mostrar();
    }
    private static void PavaElectrica()
    {
        PavaElectrica miPava = new PavaElectrica("Liliana", "Plateado", "Acero inoxidable");
        miPava.PresionarBotonEncendido();
        miPava.CambiarModo(ModoEnum.Minimo);
        miPava.CalentarAgua();
        Console.WriteLine($"La pava está en modo {miPava.Modo}");

        Thread.Sleep(2000);

        miPava.PresionarBotonEncendido();
        miPava.CambiarModo(ModoEnum.Maximo);
        miPava.CalentarAgua();
        Console.WriteLine($"La pava está en modo {miPava.Modo}");

    }
    private static void PruebaDeObjetosPersona()
    {
        persona albert = new persona("ALbert Einstein", "9 de julio 1071", 1879);
        persona robert = new persona("Robert Oppenheider", "Manhattan 2222", 1904);

        robert.Decir("Albert, sabés como se despiden los químicos?");
        albert.Decir("No, ni idea");
        robert.Decir("Acido un placer");
    }
    private static void PruebaDeObjetosSplit()
    {
        // Instanciamos el objeto Split
        Split miSplit = new Split("Blanco", 3000, "Marshal");
        miSplit.SubirTemperatura();
        miSplit.SubirTemperatura();
        miSplit.PresionarBotonEncendido();
        miSplit.CambiarModo("Deshumidificacion");
        miSplit.SubirTemperatura();
        Console.WriteLine("El modo definido del split es:"+miSplit.modo);
    }
    private static void calcularValorPago()
    {
        //Declaramos Variables:

        double valorCuota;
        int nrodia;

        Console.Write("Ingrese valor de la Cuota:");
        valorCuota = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el Numero del dia de pago:");
        nrodia = int.Parse(Console.ReadLine());

        switch (nrodia)
        {
            case < 3:
                valorCuota = valorCuota - (valorCuota * 0.03);
                break;

            case >= 6 and <= 10:
                valorCuota = valorCuota + (valorCuota * 0.1);
                break;

            case >= 11 and <= 20:
                valorCuota = valorCuota + (valorCuota * 0.12);
                break;

            case >= 21 and <= 31:
                valorCuota = valorCuota + (valorCuota * 0.15);
                break;
        }
        Console.WriteLine($"El valor de la cuota para el dia de pago es:{valorCuota}");
    }
    public static bool FechasValidasInvalidas(int dia, int mes, int año)
    {

        if ((dia >= 1 && dia <= 31) && (mes == 1 || mes == 3 ||
                mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12))
            return true;

        else if ((dia >= 1 && dia <= 30) && (mes == 4 || mes == 6 || mes == 9 || mes == 11))
            return true;

        else if ((dia == 29) && (mes == 2) && (año % 4 == 0) || (dia >= 1 && dia <= 28) && (mes == 2))

            return true;

        else
            return false;
    }
    private static void IngresarFechaValida()
    {
        //Declaramos las variables
        int dia, mes, año;

        do
        {
            Console.Write("Ingrese el Día: ");
            dia = int.Parse(Console.ReadLine());
            if (dia <= 0 || dia > 31)
            {
                Console.WriteLine("El dia ingresado NO ES VALIDO, ingrese denuevo:");
            }
        } while (dia < 0 || dia > 31);

        do
        {
            Console.Write("Ingrese el Mes: ");
            mes = int.Parse(Console.ReadLine());
            if (mes <= 0 || mes > 12)
            {
                Console.WriteLine("El mes ingresado NO ES VALIDO, ingrese denuevo:");
            }
        } while (mes <= 0 || mes > 12);

        do
        {
            Console.Write("Ingrese el Año: ");
            año = int.Parse(Console.ReadLine());
            if (año <= 0 || año > 9999)
            {
                Console.WriteLine("El año ingresado NO ES VALIDO, ingrese denuevo:");
            }
        } while (año <= 0 || año > 9999);

        // VERIFICAR AÑO BICIESTO

        bool esBisiesto = EsBisiesto(año);

        // VERIFICACION VALIDA - NO VALIDA

        bool fechaValida = true;

        if (mes < 1 || mes > 12)
        {
            fechaValida = false;
        }
        else if ((mes == 2 && (dia < 1 || dia > 29)))
        {
            if (!esBisiesto && dia == 29)
            {
                fechaValida = false;
            }
        }
        else if ((mes == 4 || mes == 6 || mes == 9 || mes == 11) && (dia < 1 || dia > 30))
        {
            fechaValida = false;
        }
        else if (dia < 1 || dia > 31)
        {
            fechaValida = false;
        }

        if (!fechaValida)
        {
            Console.WriteLine("La fecha no es válida");
        }
        else
        {
            Console.WriteLine("La fecha que ingresaste es válida");
        }


        // Imprimir el resultado

        Console.WriteLine($"La fecha ingresada es: {dia}/{mes}/{año}, el año ingresado {(esBisiesto ? "es" : "no es")} bisiesto.");
    }
    private static bool EsBisiesto(int año)
    {
        return (año % 4 == 0 || (( año %  100== 0) && (año % 400 == 0)));
    }// AÑO BISIESTO EJERCICIO - F. INGRESAR FECHA
    private static void MostrarMenorNumeroIngresado()
    {
        //Declaramos las variables
        int numero1, numero2, numero3, numero4;

        Console.Write("Ingrese el 1er Numero:");
        numero1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el 2do Numero:");
        numero2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el 3er Numero:");
        numero3 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el 4to Numero:");
        numero4 = int.Parse(Console.ReadLine());

        int MenorNumero = numero1;

        if (numero2 < MenorNumero)
        {
            MenorNumero = numero2;
        }
        if (numero3 < MenorNumero)
        {
            MenorNumero = numero3;
        }
        if (numero4 < MenorNumero)
        {
            MenorNumero = numero4;
        }

        Console.WriteLine($"El menor número ingresado es: {MenorNumero}");

        // 2DO METODO HECHO EN CLASES

        if (numero1 < numero2 && numero1 < numero3 && numero1 < numero4)
            Console.WriteLine($"El número menor es el primero: {numero1}");

        if (numero2 < numero1 && numero2 < numero3 && numero2 < numero4)
            Console.WriteLine($"El número menor es el segundo: {numero2}");

        if (numero3 < numero1 && numero3 < numero2 && numero3 < numero4)
            Console.WriteLine($"El número menor es el tercero: {numero3}");

        if (numero4 < numero1 && numero4 < numero2 && numero4 < numero3)
            Console.WriteLine($"El número menor es el cuarto: {numero4}");
    }
    private static void Triangulos()
    {
        // Declaramos las variables 
        int lado1, lado2, lado3;

        Console.Write("Ingrese el 1er Lado del triángulo: ");
        lado1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el 2do Lado del triángulo: ");
        lado2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el 3er Lado del triángulo: ");
        lado3 = int.Parse(Console.ReadLine());

        if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("El triángulo es equilátero.");
        }
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            Console.WriteLine("El triángulo es isósceles.");
        }
        else
        {
            Console.WriteLine("El triángulo es escaleno.");
        }
    }
    public static string Triangulos(int lado1, int lado2, int lado3)
    {

        if (lado1 == lado2 && lado2 == lado3)
        {
            return "Equilatero";
        }
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            return "Isoseles";
        }
        else
        {
            return "Escaleno"; 
        }
    }
    private static void CalcularDiasDeVida()
    {
        //declaramos las variables
        int años, meses, dias, diasDeVida;

        Console.Write("Ingrese sus años de vida:");
        años = int.Parse(Console.ReadLine());

        Console.Write("Ingrese sus meses de vida:");
        meses = int.Parse(Console.ReadLine());

        Console.Write("Ingrese sus días de vida:");
        dias = int.Parse(Console.ReadLine());

        diasDeVida = (años * 365) + (meses * 30) + dias;

        Console.WriteLine($"Los días de vida totales son:{diasDeVida}");
    }
    public static int CalcularDiasDeVida(int años, int meses, int dias)
    {
        //declaramos las variables
        int diasDeVida;
        return diasDeVida = (años * 365) + (meses * 30) + dias;
    }
}
