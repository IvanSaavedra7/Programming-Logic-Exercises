using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento9
    {

         double Raio, Perimetro, Area, Volume;

        

        public void LerValores()
        {

            Console.Write(" Digite o raio do seu circulo: ");

            Raio = Convert.ToDouble(Console.ReadLine());


        }

        public void Conta()
        {

            Perimetro = 2 * Math.PI * Raio;

            Area = Math.PI * Math.Pow(Raio, 2);

            Volume = (4 / 3) * Math.PI * Math.Pow(Raio, 3);

        }

        public void Exibir()
        {

            Console.Clear();
            Console.WriteLine(" Raio = {0} \n Perimetro = {1:0000.000} \n Area = {2:0000.000} \n volume = {3:0000.000} ", Raio , Perimetro , Area , Volume );

        }

    }
}
