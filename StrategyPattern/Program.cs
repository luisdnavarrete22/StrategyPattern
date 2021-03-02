using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            do
            {
                MetodoDeCoccion metodoDeCoccion = new MetodoDeCoccion();

                Console.WriteLine("*****Bienvenidos al restaurante Omega****");
                Console.WriteLine("¿Qué clase de comida te gustaría ordenar?");
                var comida = Console.ReadLine();
                metodoDeCoccion.EstablecerComida(comida);

                Console.WriteLine("¿Qué estrategia de cocción te gustaría seleccionar?");
                Console.WriteLine("<1> -------------- Asar comida --------------------");
                Console.WriteLine("<2> ------------ Hornear comida -------------------");
                Console.WriteLine("<3> ------------- Freír comida --------------------");
                Console.WriteLine("<4> ------------ Dejar de cocinar -----------------");
                int entrada = int.Parse(Console.ReadKey().KeyChar.ToString());

                switch (entrada)
                {
                    case 1:
                        metodoDeCoccion.EstablecerEstrategiaDeCocina(new AsarComida());
                        metodoDeCoccion.Cocina();
                        break;

                    case 2:
                        metodoDeCoccion.EstablecerEstrategiaDeCocina(new HornearComida());
                        metodoDeCoccion.Cocina();
                        break;

                    case 3:
                        metodoDeCoccion.EstablecerEstrategiaDeCocina(new FreirComida());
                        metodoDeCoccion.Cocina();
                        break;

                    case 4:
                        Console.WriteLine("\n¡Gracias por preferirnos!");
                        break;
                    
                    default:
                        Console.WriteLine("\nPor favor, seleccione una opción válida");
                        break;
                }
                Console.ReadKey();

            } while (opcion != 4);
        }
    }
}
