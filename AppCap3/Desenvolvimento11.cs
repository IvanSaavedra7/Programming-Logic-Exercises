using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento11
    {

        double Dividendo, Divisor, Quociente , Resto;


        public void LerValores()
        {

            Console.Write(" Digite o deu dividendo: ");

            Dividendo = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Digite o 2° divisor: ");

            Divisor = Convert.ToDouble(Console.ReadLine());

        }

        public void Contas()
        {

            if( Divisor == 0 )
            {
                Console.Clear();
                Console.WriteLine("\n não é possivel realizar a conta pois o divisor é zero");

            }
            else
            {
                
                Quociente = Dividendo / Divisor;

                Resto = Dividendo % Divisor;

            }

            

        }

        public void Exibir()
        {

            Console.Clear();
            Console.WriteLine(" Da divisão {0} / {1} \n Quociente = {2} \n Resto = {3} "
                                , Dividendo, Divisor , Quociente , Resto );

        }

    }
}
