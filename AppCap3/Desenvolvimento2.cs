using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento2
    {

        double Valor1, Valor2, Valor3;

        public void LerValor1()
        {

            Console.Write("digite o 1° valor:");
            string DadoDiGITADO = Console.ReadLine();
            Valor1 = double.Parse(DadoDiGITADO);

        }

        public void LerValor2()
        {

            Console.Write("digite o 2° valor:");
            string DadoDigitado = Console.ReadLine();
            Valor2 = double.Parse(DadoDigitado);

        }

        public void LerValor3()
        {

            Console.Write("digite o 3° valor :");
            string DadoDigitado = Console.ReadLine();
            Valor3 = double.Parse(DadoDigitado);

        }

        public void Comparador()
        {

            if (Valor1 > Valor2 && Valor2 > Valor3)
                Console.WriteLine(Valor3 + "," + Valor2 + "," + Valor1);
            else
                if (Valor1 > Valor2 && Valor2 < Valor3)
                Console.WriteLine(Valor2 + "," + Valor3 + "," + Valor1);
            else
                if (Valor2 > Valor1 && Valor1 > Valor3)
                Console.WriteLine(Valor3 + "," + Valor1 + "," + Valor2);
            else
                if (Valor2 > Valor1 && Valor1 < Valor3)
                Console.WriteLine(Valor1 + "," + Valor3 + "," + Valor2);
            else
                if (Valor3 > Valor1 && Valor1 < Valor2)
                Console.WriteLine(Valor1 + "," + Valor2 + "," + Valor3);
            else
                if (Valor3 > Valor1 && Valor1 > Valor2)
                Console.WriteLine(Valor2 + "," + Valor1 + "," + Valor3);

        }

    }
}
