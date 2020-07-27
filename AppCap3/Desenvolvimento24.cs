using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento24
    {

        double Angulo, Radiano;
        double seno, cosseno, tangente;
        double cossecante;


        public void LerValor()
        {

            Console.Write(" Por vafor digite o valor do angulo em GRAUS -> ");

            Angulo = Convert.ToDouble(Console.ReadLine()); 

            


        }


        public void Contas()
        {

            tangente = Math.Tan(Angulo);

            cossecante = 1 / Math.Sin(Angulo);

            Radiano = (Math.PI * Angulo) / 180;

            
            
        }
        
        public void Exibir()
        {

            Console.Clear();

            Console.WriteLine(" Do ANGULO : " + Angulo + "°" + "\n");

            Console.WriteLine(" RADIANO = {0:0.000} | TANGENTE = {1:0.000} | COSSECANTE = {2:0.000} \n\n ", Radiano, tangente, cossecante);


        }


    }
}
