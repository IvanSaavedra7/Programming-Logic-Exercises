using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento6
    {

        Double a, b, c, x1, x2, Delta;

        public void LerValores()
        {

            Console.Write("Por vafor digite o valor A da equação -> ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Por vafor digite o valor B da -> ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Por vafor digite o valor C da equação -> ");
            c = Convert.ToDouble(Console.ReadLine());

        }

        public void metodo_1()
        {

            if (a == 0 && b != 0)
            {

                x1 = -(c) / b;
                Console.WriteLine("o valor de x é para mte1 :" + x1);

            }
            if (b == 0)
            {

                Console.Write("Ha conta é de 1° grau mas não pode ser realizada pois 'b' é  zero ");

            }

        }

        public void Metodo_2()
        {

            if (a >= 0)
            {

                Delta = Math.Pow(b, 2) - 4 * a * c;

                if (Delta < 0)
                {

                    Console.WriteLine("Não exixte valor real para sua equação");

                }

                if (Delta == 0 && a != 0)
                {

                    x1 = -(b) / 2 * a;

                    Console.WriteLine("o valor de x é:" + x1);

                }

                if (Delta > 0 && a != 0)
                {

                    x1 = (-(b) + Math.Sqrt(Delta)) / 2 * a;

                    x2 = (-(b) - Math.Sqrt(Delta)) / 2 * a;

                    Console.WriteLine(" o valor de x1 é :" + x1 + " e o x2 é:" + x2);

                }
            }


        }


    }
}
