using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    // Definimos a esta como una clase de estrategia concreta.
    class FreirComida : EstrategiaDeCocina
    {
        public override void Cocina(string comida)
        {
            Console.WriteLine("\nFriendo su " + comida + ", disfrute su comida!");
        }
    }
}
