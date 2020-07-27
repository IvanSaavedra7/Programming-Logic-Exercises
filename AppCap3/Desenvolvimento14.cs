using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento14
    {

        int numeroNovo , numero100 , numero50 , numero10, numero2, numer01 ;
        int resto;

        public void LerValores()
        {

            Console.Write(" digite o valor de sua quantidade de dinheiro R$") ;
            numeroNovo = Convert.ToInt32(Console.ReadLine());

        }

        public void Operacao()
        {

            resto = numeroNovo / 100;

            Console.WriteLine("o numero de notas de 100 necessarias são ->" + resto);

            numero100 = numeroNovo - (resto * 100);

            Console.WriteLine();

            resto = numero100 / 50;

            Console.WriteLine("o numero de notas de 50 necessarias são ->" + resto);

            numero50 = numero100 - (resto * 50);

            Console.WriteLine();

            resto = numero50 / 10;

            Console.WriteLine("o numero de notas de 10 necessarias são ->" + resto);

            numero10 = numero50 - (resto * 10);

            Console.WriteLine();

            resto = numero10 / 2;

            Console.WriteLine("o numero de notas de 2 necessarias são ->" + resto);

            numero2 = numero10 - (resto * 2);

            Console.WriteLine();

            resto = numero2 / 1;

            Console.WriteLine("o numero de notas de 1 necessarias são ->" + resto);

           

        }

    }
}
