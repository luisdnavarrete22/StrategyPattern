using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    // Definimos a esta como una clase de estrategia concreta.
    class HornearComida : EstrategiaDeCocina
    {
        public override void Cocina(string comida)
        {
            Console.WriteLine("\nHorneando su " + comida + ", disfrute su comida!");
        }
    }
}
