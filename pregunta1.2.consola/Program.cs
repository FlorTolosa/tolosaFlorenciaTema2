namespace pregunta1._2.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double baseMayor, baseMenor, altura, ladoLateral;
                double superficie;

                Console.Write("Ingrese valor de la base mayor:");
                baseMayor = double.Parse(Console.ReadLine());
                Console.Write("Ingrese valor de la base menor:");
                baseMenor = double.Parse(Console.ReadLine());
                Console.Write("Ingrese valor de la altura:");
                altura = double.Parse(Console.ReadLine());
                Console.Write("Ingrese valor del lado lateral:");
                ladoLateral = double.Parse(Console.ReadLine());

                superficie = ((baseMayor + baseMenor) * altura) / 2;
                Console.WriteLine($"La superficie del trapecio es {superficie}");
            }
            catch (Exception)
            {
                Console.WriteLine("¡Formato no válido, debe ingresar un número!");

            }

        }
    }
}
