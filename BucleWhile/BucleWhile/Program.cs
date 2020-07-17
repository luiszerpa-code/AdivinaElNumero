using System;

namespace BucleAdivina
{
    class Program
    {
        public static void Main(string[] args)
        {
            string continuar = "si";
            while (continuar.Equals("si"))
            {
                Jugar();
                Console.WriteLine("¿Quieres volver a jugar? (si) (no)");
                continuar = Console.ReadLine();
            }
            Console.ReadKey();
        }
        public static void Jugar()
        {
            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);

            int minumero = 101;

            int intentos = 0;

            Console.WriteLine("¿Quieres jugar a ADIVINA EL NUMERO?");

            string jugar = Console.ReadLine();

            while (jugar != "no")
            {
                Console.WriteLine("PERFECTO. Entonces juguemos");

                Console.WriteLine("¿Cual es tu nombre?");

                string nombre = Console.ReadLine();

                Console.WriteLine($"{nombre}, veamos si adivinas el numero que estoy pensando");

                Console.WriteLine("Escribe un numero entre 1 y 100: ");

                while (aleatorio != minumero)
                {
                    intentos++;

                    try
                    {
                        minumero = int.Parse(Console.ReadLine());
                    }
                    catch(FormatException ex)
                    {
                        Console.WriteLine("Estoy pensando un numero no una letra");
                    }
                    catch (OverflowException ex)
                    {
                        Console.WriteLine("El numero es entre 0 y 100");
                    }

                    if (minumero > aleatorio) Console.WriteLine("el numero que pienso es mas bajo");

                    if (minumero < aleatorio) Console.WriteLine("el numero que pienso es mas alto");

                }
                jugar = "no";
            }
            Console.WriteLine($"CORRECTO! Has necesitado {intentos} intentos");


        }
    }
}