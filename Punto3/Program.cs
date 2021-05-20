using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            float num = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Valor absoluto: " +Math.Abs(num));
            Console.WriteLine("El cuadrado: " + Math.Pow(num,2));
            Console.WriteLine("La raiz cuandrada: "+ Math.Sqrt(num));
            Console.WriteLine("Seno: " + Math.Sin(num));
            Console.WriteLine("Coseno: " + Math.Cos(num));
            Console.WriteLine("Parte entera: " + Math.Truncate(num));

            Console.WriteLine("Ingrese dos numeros: \nEl primero:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El segundo: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El mayor es: " + Math.Max(a, b) + " y el menor es: " + Math.Min(a, b));


        }
    }
}
