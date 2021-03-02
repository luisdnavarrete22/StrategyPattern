using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    // Definimos a esta como una clase de estrategia concreta.
    class AsarComida : EstrategiaDeCocina
    {
        public override void Cocina(string comida)
        {
            Console.WriteLine("\nAsando su " + comida + ", disfrute su comida!");
        }
    }
}
