using System;

namespace CalculadoraNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Suma y Producto");
            Console.WriteLine("=============================");

            Console.Write("Ingrese el primer número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            double num3 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el cuarto número: ");
            double num4 = double.Parse(Console.ReadLine());

            double suma = num1 + num2;
            double producto = num3 * num4;

            Console.WriteLine($"Suma de los dos primeros números: {suma}");
            Console.WriteLine($"Producto del tercer número con el cuarto número: {producto}");
        }
    }
}