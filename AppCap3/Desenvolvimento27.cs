using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento27
    {

        double A, B, C, Discriminante;

        


        public void Lervalor()
        {

            Console.Write(" Por favor digite o valor A da equação -> ");

            A = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Por favor digite o valor B da equação -> ");

            B = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Por Favor digite o valor c da equação ->");

            C = Convert.ToDouble(Console.ReadLine());


        }



        public void Conta()
        {

            Discriminante = ( Math.Pow(B,2) - 4 * A * C);


        }

        public void Exibir()
        {
            

      
            

           Console.Clear();

            Console.WriteLine(" Com A = {0} | Com B = {1} | Com C = {2} \n\n Discriminate = {3} ",
                                 A, B ,C , Discriminante );

            

        }


    }
}
