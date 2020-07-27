using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCap3
{
    class Desenvolvimento18
    {

        int  DiaNacimento, MesNacimento, AnoNacimento;

        string Nome;

        int dia, mes, ano;

        int DiasVividos;

        public void DtaAtual()
        {

            dia = DateTime.Now.Day;

            mes = DateTime.Now.Month;

            ano = DateTime.Now.Year;

        }

        public void LerDados()
        {

            Console.Write(" Por Favor Digite Seu Nome: ");
            Nome = Convert.ToString(Console.ReadLine());

            Console.Write("\n Por Favor Digite Seu Dia de Nascimento: ");
            DiaNacimento = Convert.ToInt16(Console.ReadLine());

            Console.Write(" \n Por Favor Digite Seu Mes de Nascimento: ");
            MesNacimento = Convert.ToInt16(Console.ReadLine());

            Console.Write(" \n Por Favor Digite Seu ano de Nascimento: ");
            AnoNacimento = Convert.ToInt16(Console.ReadLine());

        }

        public void Conta()
        {

            DiasVividos = (30 - DiaNacimento) + ((12 - MesNacimento) * 30) + (((ano - AnoNacimento) * 12) * 30) + (mes * 30) +  dia ;

        }

        public void Exibir()
        {

            Console.Clear();

            Console.WriteLine( " DATA ATUAL : {0}/{1}/{2} \n " , dia , mes , ano );

            Console.WriteLine(" NOME: {0} \n DATA DE NASCIMENTO : {1}/{2}/{3} \n DIAS VIVIDOS: {4} " 
                                      , Nome , DiaNacimento , MesNacimento , AnoNacimento , DiasVividos  );

        }

    }
}
