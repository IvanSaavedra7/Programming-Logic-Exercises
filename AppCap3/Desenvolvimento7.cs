using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento7
    {

        double a, b, c, d, e, f, X, Y;
        double Denominador;


        public void LerDados()
        {

            Console.Write("digite o valor de a->");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite o valor de b->");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite o valor de c->");
            c = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite o valor de d->");
            d = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite o valor de e->");
            e = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite o valor de f->");
            f = Convert.ToDouble(Console.ReadLine());

        }

        public void Metodo()
        {

            Denominador = a * e - b * d;


            if (Denominador == 0)
            {

                Console.WriteLine("não existe soluição");

            }
            else
            {

                X = (c * e - b * f) / Denominador;

                Y = a * f - c * d / Denominador;

                Console.WriteLine("o valor de x na sua equação linear é " + X + "e o valor de y é" + Y);

            }

        }

    }
}
