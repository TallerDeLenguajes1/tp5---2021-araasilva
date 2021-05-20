using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico5
{
    class Punto1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if (num > 0)
            {
                int inverso = 0, aux;
                while (num > 0)
                {
                    aux = num % 10;
                    num = num / 10;
                    inverso = inverso * 10 + aux;
                }
                Console.WriteLine("El numero invertido es: " + inverso);
            }else Console.WriteLine("el numero ingresado es menor o igual que 0");
            

        }
        
       
    }

}
