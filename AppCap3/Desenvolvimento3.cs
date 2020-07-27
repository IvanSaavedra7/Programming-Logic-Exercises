using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento3
    {

        double TemperaturaAgua;

        public void LerTemperatura()
        {

            Console.Write(" Digite a temperatura (°c) que deseja classificar : ");
            String DadoDigitado = Console.ReadLine();
            TemperaturaAgua = double.Parse(DadoDigitado);


        }

        public void Comparador()
        {

            if (TemperaturaAgua >= 100)
                Console.WriteLine("A agua está fervendo");
            else
                if (TemperaturaAgua <= 0)
                Console.WriteLine(" Agua está congelada ");
            else
                if (TemperaturaAgua < 100 && TemperaturaAgua > 0)
                Console.WriteLine(" A tempearatura está em outro estado ( entre congelada e fervendo) ");

        }


    }
}
