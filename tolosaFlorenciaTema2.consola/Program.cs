using System;

namespace pregunta01.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseMayor, baseMenor, altura, ladoLateral;
            double perimetro, superficie;

            Console.Write("Ingrese valor de la base mayor:");
            baseMayor = double.Parse(Console.ReadLine());
            Console.Write("Ingrese valor de la base menor:");
            baseMenor = double.Parse(Console.ReadLine());
            Console.Write("Ingrese valor de la altura:");
            altura = double.Parse(Console.ReadLine());
            Console.Write("Ingrese valor del lado lateral:");
            ladoLateral = double.Parse(Console.ReadLine());

            perimetro = baseMenor + baseMayor + 2 * ladoLateral;
            Console.WriteLine($"El perimetro del trapecio es {perimetro}");



