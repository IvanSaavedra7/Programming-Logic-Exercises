using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento22
    {

        string nome;
        double Registro, HorasTrabalhadas, HorasExtras;
        double ValorHora, ValorhoraExtra;

        double SalarioBruto, SalarioLiquido;

        public void LerDados()
        {

            Console.Write(" por vafor Digite seu nome: ");

            nome = Convert.ToString(Console.ReadLine());

            Console.Write(" por vafor Digite seu numero de registro: ");

            Registro = Convert.ToDouble(Console.ReadLine());

            Console.Write(" por vafor Digite suas horas trabalhadas: ");

            HorasTrabalhadas = Convert.ToDouble(Console.ReadLine());

            Console.Write(" por vafor Digite suas horas extras: ");

            HorasExtras = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("------------------------------------------");

            Console.Write(" por vafor Digite O salário por Hora na impressa: ");

            ValorHora = Convert.ToDouble(Console.ReadLine());

            Console.Write(" por vafor Digite o salário da hora extra no impressa: ");

            ValorhoraExtra = Convert.ToDouble(Console.ReadLine());


        }


        public void Contas()
        {

            SalarioBruto = (HorasTrabalhadas * ValorHora) + (HorasExtras * ValorhoraExtra);

            SalarioLiquido = SalarioBruto - (SalarioBruto * (15 / 100)) - (SalarioBruto * (17 / 100));


        }

        public void Exibir()
        {

            Console.Clear();

            Console.WriteLine(" FUNCIONARIO; {0} \n REGISTRO: {1} \n HORAS DE TRABALHO: {2} \n HORAS EXTRAS: {3} ",
                                 nome, Registro, HorasTrabalhadas, HorasExtras);


            Console.WriteLine("===========================\n");

            Console.WriteLine(" SALARIO BRUTO: R${0}  \n SALARIO LIQUIDO = Salario bruto - 15% IRPF - 17% INSS = R${1} ", 
                                  SalarioBruto , SalarioLiquido  );


        }



    }
}
