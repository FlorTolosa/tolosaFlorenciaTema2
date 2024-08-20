using System.ComponentModel.Design;

namespace Pregunta2.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double superficieTrapecio1, superficieTrapecio2, superficieTrapecio3;
                double superficieTrapecio4, superficieTrapecio5;

                Console.Write("Ingrese la superficie del trapecio número 1:");
                superficieTrapecio1 = double.Parse(Console.ReadLine());
                if (superficieTrapecio1 > 0)
                    Console.WriteLine($"El primer trapecio ingresado es {superficieTrapecio1}");
                else
                    Console.WriteLine("La superficie del trapecio debe ser mayor a cero!!!");
                Console.Write("Ingrese la superficie del trapecio número 2:");
                superficieTrapecio2 = double.Parse(Console.ReadLine());
                if (superficieTrapecio2 > 0)
                    Console.WriteLine($"El segundo trapecio ingresado es {superficieTrapecio2}");
                else
                    Console.WriteLine("La superficie del trapecio debe ser mayor a cero!!!");
                Console.Write("Ingrese la superficie del trapecio número 3:");
                superficieTrapecio3 = double.Parse(Console.ReadLine());
                if (superficieTrapecio3 > 0)
                    Console.WriteLine($"El tercer trapecio ingresado es {superficieTrapecio3}");
                else
                    Console.WriteLine("La superficie del trapecio debe ser mayor a cero!!!");
                Console.Write("Ingrese la superficie del trapecio número 4:");
                superficieTrapecio4 = double.Parse(Console.ReadLine());
                if (superficieTrapecio4 > 0)
                    Console.WriteLine($"El cuarto trapecio ingresado es {superficieTrapecio4}");
                else
                    Console.WriteLine("La superficie del trapecio debe ser mayor a cero!!!");
                Console.Write("Ingrese la superficie del trapecio número 5:");
                superficieTrapecio5 = double.Parse(Console.ReadLine());
                if (superficieTrapecio5 > 0)
                    Console.WriteLine($"El quinto trapecio ingresado es {superficieTrapecio5}");
                else
                    Console.WriteLine("La superficie del trapecio debe ser mayor a cero!!!");
                                     }
            catch (Exception)
            {

                Console.WriteLine("Algo salió mal!!!");
            }
        }
    }
}
