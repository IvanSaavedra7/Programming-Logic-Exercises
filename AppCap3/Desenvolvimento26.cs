using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento26
    {

        double RaioInterno, RaioExterno, Comprimentto;

        double AreaInterna, AreaExterna , volume;


        public void Lervalor()
        {

            Console.Write(" Por favor digite o valor do raio interno -> ");

            RaioInterno = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Por favor digite o valor do raio externo -> ");

            RaioExterno = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Por Favor digite o valor do comprimenyo do tubo ->");

            Comprimentto = Convert.ToDouble(Console.ReadLine());


        }

        

        public void Conta()
        {

            AreaInterna = (2 * Math.PI * RaioInterno) * Comprimentto;

            AreaExterna = (2 * Math.PI * RaioExterno) * Comprimentto;

            volume = (Math.PI * Math.Pow(RaioExterno, 2) * Comprimentto) - (Math.PI * Math.Pow(RaioInterno, 2) * Comprimentto);


        }

        public void Exibir()
        {
            if (RaioExterno < RaioInterno)
            {

                Console.Clear();

                Console.WriteLine(" o Raio externo é menor que o interno ISSO NÃO CORRESPONDE !! ");


            }

            else
            {

                Console.Clear();

                Console.WriteLine(" RAIO INTERNO DO TUBO = {0} | RAIO EXTERNO DO TUBO = {1} | COMPRIMENTO = {2} \n\n AREA INTERNA = {3:00000.000} cm2 | AREA EXTERNA = {4:00000.000} cm2 | VOLUME = {5:00.000} cm3 ",
                                    RaioInterno, RaioExterno, Comprimentto, AreaExterna, AreaInterna, volume);

            }

        }


    }
}
