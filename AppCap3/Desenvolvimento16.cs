using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento16
    {

        int HInicio, Minicio, Sinicio;
        int Hfim, Mfim, Sfim;
        int SegundosHora, SegundosMin, SegundoSeg;
        int total;

        //  11 - 2


        public void LerDados()
        {

            Console.Write(" Digite a HORA (p.m) de INICIO do evento: ");

            HInicio = Convert.ToInt16(Console.ReadLine());

            Console.Write(" Digite o MINUTO (p.m) de INICIO do evento: ");

            Minicio = Convert.ToInt16(Console.ReadLine());

            Console.Write(" Digite o SEGUNDOS (p.m) de INICIO do evento: ");

            Sinicio = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("-----------------------------------------");

     

            Console.WriteLine("-----------------------------------------");

            Console.Write(" Digite a HORA (A.m) de TERMINO do evento: ");

            Hfim = Convert.ToInt16(Console.ReadLine());

            Console.Write(" Digite o MINUTO (A.m) de TERMINO do evento: ");

            Mfim = Convert.ToInt16(Console.ReadLine());

            Console.Write(" Digite o SEGUNDOS (A.m) de TERMINO do evento: ");

            Sfim = Convert.ToInt16(Console.ReadLine());

        }

        public void Conta()
        {

            if( HInicio <= 24 && HInicio >= 0 && Hfim <= 24 && Hfim >= 0 && Minicio <= 59 && Minicio >= 0 && Mfim <= 59 && Mfim >= 0 && Sinicio <= 59 && Sinicio >= 0 && Sfim <= 59 && Sfim >= 0)
            {

                // CODIGO NECESSARIO CASO O HORAIO ESTIVESSE EM P.M


                if (Hfim < HInicio)
                {



                    Console.Clear();

                    Console.WriteLine(" O HORAIO DIGITADO NÃO CORREPONDE A UM CICLO DE 1 DIA !!! ");



                    /*
                    SegundosHora = ((12 - HInicio) + Hfim) * 3600;


                    SegundosMin = (Mfim - Minicio) * 60;

                    SegundoSeg = (Sfim - Sinicio);

                    total = SegundosHora + SegundosMin + SegundoSeg;
                    */

                }
                else
                {

                    SegundosHora = (Hfim - HInicio) * 3600;


                    SegundosMin = (Mfim - Minicio) * 60;

                    SegundoSeg = (Sfim - Sinicio);

                    total = SegundosHora + SegundosMin + SegundoSeg;





                    //////////////////////  

                    Console.Clear();

                    Console.WriteLine(" Inicio: {0}H {1}MIN {2} SEG \n", HInicio, Minicio, Sinicio);

                    Console.WriteLine(" Fim: {0}H {1}MIN {2} SEG ", Hfim, Mfim, Sfim);

                    Console.WriteLine("-----------------------------------\n");

                    Console.WriteLine(" Duração do Evento:  " + total + " SEGUNDOS");
                }



            }
            else
            {
                Console.Clear();

                Console.WriteLine( " O horário digitado não esta em (p.m) " );

            }





        }

        

    }
}
