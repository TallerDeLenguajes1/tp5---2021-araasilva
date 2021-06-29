using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("introduzca una cadena: ");
            string str = Console.ReadLine();
            Console.WriteLine("Primer componente de la cadena: " + str[0]);
            Console.WriteLine("longitud de la cadena: " + str.Length);
            string str2 = " + cadena 2";
            str += str2;
            Console.WriteLine("cadenas concatenadas: ", str);
            Console.WriteLine("sub cadena: " + str.Substring(2, 4));
            //ToString()


        }
    }
}
