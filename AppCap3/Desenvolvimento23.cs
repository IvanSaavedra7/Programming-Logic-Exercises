using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppCap3
{
    class Desenvolvimento23
    {

        double Altura , Largura , Comprimento , Diagonal;

        public void LerValores()
        {

            Console.Write(" Por vafor digite o valor da altura -> ");

            Altura = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Por vafor digite o valor da largura -> ");

            Largura = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Por vafor digite o valor do comprimento -> ");

            Comprimento = Convert.ToDouble(Console.ReadLine());


        }

        public void conta()
        {

            Diagonal = Math.Pow(Altura, 2) + Math.Pow(Largura, 2) + Math.Pow(Comprimento, 2);

        }

        public void Exibir()
        {

            Console.Clear();

            Console.WriteLine(" ALTURA: {0} | LARGURA: {1} | COMPRIMENTO: {2} \n\n\t DIAGONAL = {3} ",
                                 Altura , Largura , Comprimento , Diagonal  );


        }


    }
}
