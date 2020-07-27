using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento8
    {

        string Nome;
        double Nota1, Nota2, Nota3 , Media ;

        public void LerDados()
        {

            Console.Write(" Digite seu nome: ");

            Nome = Convert.ToString(Console.ReadLine());

            Console.Write(" Digite sua 1° nota: ");

            Nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Digite sua 2° nota: ");

            Nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Digite sua 3° nota: ");

            Nota3 = Convert.ToDouble(Console.ReadLine());

            

        }

        public void CalcMedia()
        {

            Media = 3 / (1 / Nota1 + 1 / Nota2 + 1 / Nota3);

        }

        public void Exibicao()
        {
            
            Console.WriteLine(" Aluno:{0} \n Nota: {1} | Nota: {2} | Nota: {3} | \n Media harmônica: {4:0.000} ", 
                 Nome , Nota1 , Nota2 , Nota3 , Media );

        }

    }
}
