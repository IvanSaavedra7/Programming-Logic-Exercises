using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento28
    {

        double A, B, C, Area , Perimetro;




        public void Lervalor()
        {

            Console.Write(" Por favor digite o lado A do seu triangulo -> ");

            A = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Por favor digite o lado B do seu triangulo -> ");

            B = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Por Favor digite o lado C do seu triangulo -> ");

            C = Convert.ToDouble(Console.ReadLine());


        }



        public void Conta()
        {

            Perimetro = (A + B + C) / 2;

            Area = Math.Sqrt((Perimetro * (Perimetro - A) * (Perimetro - B) * (Perimetro - C)));


        }

        public void Exibir()
        {





            Console.Clear();

            Console.WriteLine(" Com A = {0} | Com B = {1} | Com C = {2} \n\n AREA DO TRIANGULO = {3:000.000} ",
                                 A, B, C, Area);



        }


    }
}
