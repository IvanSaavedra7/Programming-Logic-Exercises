using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento21
    {

        int Segundos;
        int MinutosFinais , horasFinais , SegundosFinais ;
        int minutosAuxiliar;



        public void LerDados()
        {

            Console.Write(" Por Favor Digite Seu valor em segundo que deseja avaliar: ");
            Segundos = Convert.ToInt16(Console.ReadLine());



        }

        public void Conta()
        {



            SegundosFinais = Segundos % 60;  //Segundos que sobram

            minutosAuxiliar = Segundos / 60;

            MinutosFinais = (minutosAuxiliar) % 60;

            horasFinais = (minutosAuxiliar) / 60;





        }

        public void Exibir()
        {

            Console.Clear();

            Console.WriteLine(" SEGUNDOS : {0} \n ", Segundos);

            Console.WriteLine(" HORAS: {0} \n MINUTOS : {1} \n SEGUNDOS : {2} "
                                      , horasFinais, MinutosFinais, SegundosFinais);

        }


    }
}
