﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerPunto
{
    class Punto1
    {
        static void Main()
        {
            Console.WriteLine("Ingrese un numero");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                int inverso = 0, aux;
                while (num > 0)
                {
                    aux = num % 10;
                    num /= 10;
                    inverso = inverso * 10 + aux;
                }
                Console.WriteLine("El numero invertido es: " + inverso);
            }
            else Console.WriteLine("el numero ingresado es menor o igual que 0, no se pudo realizar la conversion");
            int num2 = Convert.ToInt32(Console.ReadLine());

        }
    }
}
