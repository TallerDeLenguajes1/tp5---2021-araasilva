using System;

namespace SegundoPunto
{
    class Punto2
    {
        public void calculadora()
        {
            int bandera;

            do
            {
                int operacion, resultado = 0;
                do
                {
                    Console.WriteLine("Que operacion desea realizar: Suma[1] - Resta[2] - Multiplicacion[3] - Division[4]");
                    operacion = Convert.ToInt32(Console.ReadLine());
                
                } while (1 < operacion && operacion > 4);

                Console.WriteLine("Ingrese el primer numero: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segudo numero: ");
                int b = Convert.ToInt32(Console.ReadLine());


                switch (operacion)
                {
                    case 1:
                        resultado = a + b; Console.WriteLine("Resultado: " + resultado);
                        break;
                    case 2:
                        resultado = a - b; Console.WriteLine("Resultado: " + resultado);
                        break;
                    case 3:
                        resultado = a * b; Console.WriteLine("Resultado: " + resultado);
                        break;
                    case 4:
                        if (b == 0)
                        {
                            Console.WriteLine("No se Puede dividir en 0");
                        }
                        else resultado = a / b; Console.WriteLine("Resultado: " + resultado);
                        break;
                }

                do
                {
                    Console.WriteLine("Desea realizar otra operacion? Si[1] - No [2]");
                    bandera = Convert.ToInt32(Console.ReadLine());
                } while (1 < bandera && bandera < 2);

            } while (bandera == 1);
            Console.WriteLine("Cerrando calculadora..");
        }
    }
}