using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento25
    {


        double CodenadaX, CordenadaY, CordenadaR, CordenadaA , GrauTangente;


        public void Lervalor()
        {

            Console.Write(" Por vafor digite o valo da cordenada X ->");

            CodenadaX = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Por vafor digite o valo da cordenada y -> ");

            CordenadaY = Convert.ToDouble(Console.ReadLine());
            

        }

        public void Conta()
        {

            CordenadaR = Math.Sqrt((Math.Pow(CodenadaX, 2) + Math.Pow(CordenadaY, 2)));

            GrauTangente = 180 / (CordenadaY / CodenadaX);

            CordenadaA = Math.Atan(GrauTangente);


        }

        public void Exibir()
        {
            Console.Clear();

            Console.WriteLine( " a cordenada cartesiana: ({0} , {1}) \n Cordenada Polar: ( {2:00.000} , {3:00.000} ) " , CodenadaX , CordenadaY , CordenadaR , CordenadaA );



        }



    }
}
