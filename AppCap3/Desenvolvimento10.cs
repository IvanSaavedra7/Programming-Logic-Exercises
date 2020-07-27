using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento10
    {

        double Valor1 , Valor2, Valor3, soma, Media;

        public void LerValores()
        {

            Console.Write(" Digite o 1° valo: ");

            Valor1 = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Digite o 2° valo: ");

            Valor2 = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Digite o 3° valo: ");

            Valor3 = Convert.ToDouble(Console.ReadLine());


        }

        public void Conta()
        {

            soma = Valor1 + Valor2 + Valor3;

            Media = Valor1 + Valor2 + Valor3 / 3 ;

        }

        public void Exibir()
        {

            Console.Clear();
            Console.WriteLine(" 1° valor = {0} | 2° valor = {1} | 3° valor: {2} \n Soma = {3} \n Media aritmedica = {4:00.000} ",
                Valor1 , Valor2 , Valor3 , soma , Media );

        }

    }
}
