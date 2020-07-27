using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento12
    {

        double Nota1, Nota2, Nota3, Nota4 , Media;

        public void LerValores ()
        {

            Console.Write(" Digite sua 1° notas bimestral: ");

            Nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Digite sua 2° notas bimestral: ");

            Nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Digite sua 3° notas bimestral: ");

            Nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Digite sua 4° notas bimestral: ");

            Nota4 = Convert.ToDouble(Console.ReadLine());

        }

        public void Conta()
        {
            Media = ((Nota1*2) + (Nota2*3) + (Nota3*5) + (Nota4*6)) / 4;

        }

        public void Exibir()
        {

            Console.Clear();

            Console.WriteLine(" \n 1° notas:{0} | 12° notas:{1} | 3° notas:{2} | 4° notas:{3} \n Media Anual = {4} "
                              , Nota1 , Nota2 , Nota3 , Nota4 , Media );

        }

    }
}
