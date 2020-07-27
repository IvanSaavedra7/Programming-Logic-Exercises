using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento17
    {

        double Tempo, Hora, Segundos, Minutos;


        public void LerValores()
        {

            Console.Write(" Digite seu tempo em HORAS: ");

            Tempo = Convert.ToDouble(Console.ReadLine());


        }

        public void Conta()
        {

            Hora = Tempo * 1;

            Minutos = Tempo * 60;

            Segundos = Tempo * 3600;

        }

        public void Exibir()
        {

            Console.Clear();
            Console.WriteLine(" Do tempo: {0}H \n\n HORAS:{1} | MINUTOS:{2} | SEGUNDOS:{3} \n ", 
                                 Tempo , Hora , Minutos , Segundos );

        }




    }
}
