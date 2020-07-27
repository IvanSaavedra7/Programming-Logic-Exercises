using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento19
    {

        

        int DiasVividos;
        int dia, mesTemporario ,ano;
        int  mesResto;

        

        public void LerDados()
        {

            Console.Write(" Por Favor Digite Quantos dias coce esta vivo: ");
            DiasVividos = Convert.ToInt16(Console.ReadLine());

            

        }

        public void Conta()
        {



            mesTemporario = DiasVividos / 30;

            dia = DiasVividos % 30;

            ano = (DiasVividos / 30) / 12;

            mesResto = (DiasVividos / 30) % 12;





        }

        public void Exibir()
        {

            Console.Clear();

            Console.WriteLine(" DIAS VIVO : {0} \n ", DiasVividos );

            Console.WriteLine(" ANOS VIVO: {0} \n MESES VIVO : {1} \n DIAS VIVO : {2} "
                                      , ano , mesResto, dia);

        }



    }
}
