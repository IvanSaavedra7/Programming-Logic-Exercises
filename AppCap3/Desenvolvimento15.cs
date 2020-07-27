using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento15
    {

        double Aatual, Ametade, Lado;

        public void lerValores()
        {

            Console.Write(" escreva o valor da area atual -> ");
            Aatual = Convert.ToDouble(Console.ReadLine());


        }

        public void Operacao()
        {

            Ametade = Aatual / 2;

            Console.WriteLine(" a metade da area é : " + Ametade);

            Lado = Math.Sqrt(Aatual);

            Console.WriteLine(" o valor do lado da metade é " + Lado );
            



        }

    }
}
