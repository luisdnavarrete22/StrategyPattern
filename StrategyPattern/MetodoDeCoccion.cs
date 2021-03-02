using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    //La clase Contexto, que mantiene una referencia a la estrategia elegida.
    class MetodoDeCoccion
    {
        private string comida;
        private EstrategiaDeCocina estrategiaDeCocina;
        
       public void EstablecerEstrategiaDeCocina(EstrategiaDeCocina estrategiaDeCocina)
       {
            this.estrategiaDeCocina = estrategiaDeCocina;
       }
        public void EstablecerComida(string nombredeplato)
        {
            comida = nombredeplato;
        }
        public void Cocina()
        {
            estrategiaDeCocina.Cocina(comida);
        }


    }
}
