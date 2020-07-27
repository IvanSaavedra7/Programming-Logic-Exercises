using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento1
    {

        double celsius, fahrenheit;

        public void LerCelsi()
        {

            Console.WriteLine("digite o valor em celsius:");
            string dadoDigitado = Console.ReadLine();
            celsius = Double.Parse(dadoDigitado);

        }

        public void Calculo()
        {

            fahrenheit = 9.0 / 5.0 * celsius + 32;

        }

        public void LerTemperatura()
        {

            Console.WriteLine("converção de celsis para farienti sera : " + fahrenheit);


        }

    }
}
