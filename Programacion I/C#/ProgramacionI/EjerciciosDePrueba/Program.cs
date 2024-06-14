internal class Program
{
    private static void Main(string[] args)
    {
        ContarDiasDeVida();
    }

    // Creamos un Metodo ingreso nombre y saludo.

    private static void PedirNombreYSaludar()
    {
        // Declaramos las variables:
        string nombre, apellido;

        Console.Write("Ingrese su Nombre:");
        nombre = Console.ReadLine();

        Console.Write("Ingrese su Apellido:");
        apellido = Console.ReadLine();

        Console.WriteLine($"Bienvenido {apellido}, {nombre}");

    }

    private static void ContarDiasDeVida()
    {
        // Declaramos las variables:

        int año, meses, dias, diasDeVida;

        Console.Write("Ingrese su cantidad de años:");
        año = int.Parse(Console.ReadLine());

        Console.Write("Ingrese su cantidad de meses:");
        meses = int.Parse(Console.ReadLine());

        Console.Write("Ingrese su cantidad de dias:");
        dias = int.Parse(Console.ReadLine());

       

        diasDeVida = (año*356)+(meses*30)+(dias);
        Console.WriteLine($"Usted tiene: {diasDeVida} de dias acumulados.");
    }
}