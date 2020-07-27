using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento20
    {

        int Dia, Hora, minuto, Segundo, Total;

        public void LerValores()
        {

            Console.Write(" Digite os dias em que durou o evento: ");

            Dia = Convert.ToInt16(Console.ReadLine());

            Console.Write(" Digite as horas em que durou o evento: ");

            Hora = Convert.ToInt16(Console.ReadLine());

            Console.Write(" Digite os Minutos em que durou o evento: ");

            minuto = Convert.ToInt16(Console.ReadLine());

            Console.Write(" Digite os Segundos em que durou o evento: ");

            Segundo = Convert.ToInt16(Console.ReadLine());

        }

        public void Conta()
        {
            Total = ((Dia * 24) * 3600) + ((Hora * 3600)) + (minuto * 60) + Segundo;

        }

        public void Exibir()
        {

            Console.Clear();

            Console.WriteLine(" \n  DIAS:{0} |  HORAS:{1} | MINUTOS:{2} | SEGUNDOS:{3} \n DURAÇÃO DO EVENTO EM SEGUNDOS = {4} "
                              , Dia, Hora, minuto, Segundo, Total);

        }


    }
}
