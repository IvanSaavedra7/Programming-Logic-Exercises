using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento5
    {

        double L1, L2, L3;


        public void LerValor1()
        {

            Console.Write("Por vafor digite o 1° valor do lado do seu triangulo -> ");
            string DadoDigitado = Console.ReadLine();
            L1 = double.Parse(DadoDigitado);

        }

        public void LerValor2()
        {

            Console.Write("Por vafor digite o 2° valor do lado do seu triangulo -> ");
            string DadoDigitado = Console.ReadLine();
            L2 = double.Parse(DadoDigitado);

        }

        public void LerValor3()
        {

            Console.Write("Por vafor digite o 3° valor do lado do seu triangulo -> ");
            string DadoDigitado = Console.ReadLine();
            L3 = double.Parse(DadoDigitado);

        }

        public void Classificador()
        {

            if (Math.Abs(L2 - L3) < L1 && L1 < L2 + L3 && Math.Abs(L1 - L3) < L2 && L2 < L1 + L3 && Math.Abs(L1 - L2) < L3 && L3 < L2 + L3)
            {

                Console.WriteLine("Seus lados forman um triangulo !");

                if (L1 != L2 && L2 != L3 && L1 != L3 && Math.Pow(L1, 2) != Math.Pow(L2, 2) + Math.Pow(L3, 2) && Math.Pow(L2, 2) != Math.Pow(L1, 2) + Math.Pow(L3, 2) && Math.Pow(L3, 2) != Math.Pow(L1, 2) + Math.Pow(L2, 2) && L2 - L3 < L1 && L1 < L2 + L3 && L1 - L3 < L2 && L2 < L1 + L3 && L1 - L2 < L3 && L3 < L2 + L3)
                    Console.WriteLine("Seus triangulo é ESCALENO !");

                if (L1 == L2 && L2 == L3 && L1 == L3 && L2 - L3 < L1 && L1 < L2 + L3 && L1 - L3 < L2 && L2 < L1 + L3 && L1 - L2 < L3 && L3 < L2 + L3)
                    Console.WriteLine("Seus triangulo é EQUILATERO !");

                if (L1 == L2 && L2 != L3 || L3 == L2 && L2 != L1 || L1 == L3 && L1 != L2)
                    Console.WriteLine("Seus triangulo é ISOSCELES !");

                if (Math.Pow(L1, 2) == Math.Pow(L2, 2) + Math.Pow(L3, 2) || Math.Pow(L2, 2) == Math.Pow(L1, 2) + Math.Pow(L3, 2) || Math.Pow(L3, 2) == Math.Pow(L1, 2) + Math.Pow(L2, 2))
                    Console.WriteLine("Seus triangulo é RETANGULO !");

            }
            else
                Console.WriteLine("Seus lados não forman um triangulo");
        }

    }
}
