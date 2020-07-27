using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento4
    {

        int NumeroInt;

        public void LerNumero()
        {

            Console.Write(" Digite o numero que deseja testar : ");
            String DadoDigitado = Console.ReadLine();
            NumeroInt = int.Parse(DadoDigitado);


        }


        public void Comparador()
        {

            if (NumeroInt < 1000 || NumeroInt > 9999)

                Console.WriteLine("Seu numero não apresenta 4 digitos");
            else
                if ((NumeroInt / 100) * (NumeroInt / 100) + (NumeroInt % 100) * (NumeroInt % 100) == NumeroInt)

                Console.WriteLine(" Parabens seu numero atende as 2 condições ");

            else Console.WriteLine(" A soma dos quadrados dos 2 primeiro digitos e a soma dos quadrados dos 2 ultimos não é o proprio numero ");


        }
        //46 é meta de 
    }
}
