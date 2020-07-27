using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento13
    {

        double Angulo, Senh, Cosh, Tangh;

        public void Lervalor()
        {

            Console.Write(" Digite o valor do angulo(°):  ");

            Angulo = Convert.ToDouble(Console.ReadLine());

        }


        public void Contas()
        {

            Senh = (Math.Exp(Angulo) - Math.Exp(-(Angulo))) / 2;

            Cosh = (Math.Exp(Angulo) + Math.Exp(-(Angulo))) / 2;

            Tangh = Senh / Cosh;

        }

        public void Exibir()
        {

            Console.Clear();

            Console.WriteLine(" ANGULO: " + Angulo + " \n Seno: " + Senh + " \n Cosseno: " + Cosh + " \n Tangente: " + Tangh );


        }


    }
}
