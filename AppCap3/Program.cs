using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AppCap3
{
    class Program
    {


        static void Main(string[] args)
        {


            int opcao = 0; // VARIAVEL DA OPÇAO

            while (opcao != 99) // CONDIÇÃO PARA O PROGRAM SE REPETIR
            {
                ///////////////////   PARTE QUE APARECERA PARA O USUARIO ////////////////   


                Clear();
                WriteLine(" \t +------------------------------------------------------------+ ");

                WriteLine(" \t |   ESTE PROGRAMA REALIZA EXERCÍCIOS DO CAPITULO 3 DE DS101  | ");

                WriteLine(" \t +------------------------------------------------------------+ ");

                WriteLine("\n");

                WriteLine("[1] - Exercicio 3.1 \n ");

                WriteLine("[2] - Exercicio 3.2 \n ");

                WriteLine("[3] - Exercicio 3.3 \n ");

                WriteLine("[4] - Exercicio 3.4 \n ");

                WriteLine("[5] - Exercicio 3.5 \n ");

                WriteLine("[6] - Exercicio 3.6 \n ");

                WriteLine("[7] - Exercicio 3.7 \n ");

                WriteLine("[8] - Exercicio 3.8 \n ");

                WriteLine("[9] - Exercicio 3.9 \n ");

                WriteLine("[10] - Exercicio 3.10 \n ");

                WriteLine("[11] - Exercicio 3.11 \n ");

                WriteLine("[12] - Exercicio 3.12 \n ");

                WriteLine("[13] - Exercicio 3.13 \n ");

                WriteLine("[14] - Exercicio 3.14 \n ");

                WriteLine("[15] - Exercicio 3.15 \n ");

                WriteLine("[16] - Exercicio 3.16 \n ");

                WriteLine("[17] - Exercicio 3.17 \n ");

                WriteLine("[18] - Exercicio 3.18 \n ");

                WriteLine("[19] - Exercicio 3.19 \n ");

                WriteLine("[20] - Exercicio 3.20 \n ");

                WriteLine("[21] - Exercicio 3.21 \n ");

                WriteLine("[22] - Exercicio 3.22 \n");

                WriteLine("[23] - Exercicio 3.23 \n");

                WriteLine("[24] - Exercicio 3.24 \n");

                WriteLine("[25] - Exercicio 3.25 \n");

                WriteLine("[26] - Exercicio 3.26\n ");

                WriteLine("[27] - Exercicio 3.27\n ");

                WriteLine("[28] - Exercicio 3.28 ");

                WriteLine("  \n [99] - FINALIZAR PROGRAMA ");

                WriteLine("\n ------------------------------");

                Write(" \n Selecione o NUMERO da opção que deseja realizar -> ");
                opcao = int.Parse(ReadLine());



                ///////////////////////   EXERCICIOS  //////////////////////

                if (opcao == 1)  /////   IF PARA SER CONDIÇÃO PARA ENTRAR NO BLOCO DE COMANDO
                                 /////    E EXECUTAR AS OPERAÇOES DO EXERCICIOO // 3.1
                {
                    Clear();
                    Desenvolvimento1 desenvolvimento;
                    desenvolvimento = new Desenvolvimento1();
                    desenvolvimento.LerCelsi();
                    desenvolvimento.Calculo();
                    desenvolvimento.LerTemperatura();

                    WriteLine();

                    Enter Umenter; // METODO AUXILIAR PARA DAR ENTER AO TERMINAR O EXERCICIO
                    Umenter = new Enter();
                    Umenter.Ok();


                }


                if (opcao == 2)  //3.2
                {
                    Clear();
                    Desenvolvimento2 desenvolvimento;
                    desenvolvimento = new Desenvolvimento2();
                    desenvolvimento.LerValor1();
                    desenvolvimento.LerValor2();
                    desenvolvimento.LerValor3();
                    desenvolvimento.Comparador();


                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }

                if (opcao == 3)  //3.3
                {
                    Clear();
                    Desenvolvimento3 desenvolvimento;
                    desenvolvimento = new Desenvolvimento3();
                    desenvolvimento.LerTemperatura();
                    desenvolvimento.Comparador();


                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }

                if (opcao == 4)  //3.4
                {
                    Clear();
                    Desenvolvimento4 desenvolvimento;
                    desenvolvimento = new Desenvolvimento4();
                    desenvolvimento.LerNumero();
                    desenvolvimento.Comparador();


                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }

                if (opcao == 5)  //3.5
                {
                    Clear();
                    Desenvolvimento5 desenvolvimento;
                    desenvolvimento = new Desenvolvimento5();
                    desenvolvimento.LerValor1();
                    desenvolvimento.LerValor2();
                    desenvolvimento.LerValor3();
                    desenvolvimento.Classificador();


                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }

                if (opcao == 6)  //3.6
                {
                    Clear();
                    Desenvolvimento6 desenvolvimento;
                    desenvolvimento = new Desenvolvimento6();
                    desenvolvimento.LerValores();
                    desenvolvimento.metodo_1();
                    desenvolvimento.Metodo_2();


                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }

                if (opcao == 7)  //3.7
                {
                    Clear();
                    Desenvolvimento7 desenvolvimento;
                    desenvolvimento = new Desenvolvimento7();
                    desenvolvimento.LerDados();
                    desenvolvimento.Metodo();


                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }

                if (opcao == 8)  //3.8
                {
                    Clear();
                    Desenvolvimento8 desenvolvimento;
                    desenvolvimento = new Desenvolvimento8();
                    desenvolvimento.LerDados();
                    Clear();
                    desenvolvimento.CalcMedia();
                    desenvolvimento.Exibicao();


                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }

                if (opcao == 9)  //3.9
                {
                    Clear();



                    Desenvolvimento9 desenvolvimento;
                    desenvolvimento = new Desenvolvimento9();
                    desenvolvimento.LerValores();
                    desenvolvimento.Conta();
                    desenvolvimento.Exibir();


                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }

                if (opcao == 10)  //3.10
                {
                    Clear();
                    Desenvolvimento10 desenvolvimento;
                    desenvolvimento = new Desenvolvimento10();
                    desenvolvimento.LerValores();
                    desenvolvimento.Conta();
                    desenvolvimento.Exibir();


                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }

                if (opcao == 11)  //3.11
                {
                    Clear();
                    Desenvolvimento11 desenvolvimento;
                    desenvolvimento = new Desenvolvimento11();
                    desenvolvimento.LerValores();
                    desenvolvimento.Contas();
                    desenvolvimento.Exibir();


                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }

                if (opcao == 12)  //3.12
                {
                    Clear();
                    Desenvolvimento12 desenvolvimento;
                    desenvolvimento = new Desenvolvimento12();
                    desenvolvimento.LerValores();
                    desenvolvimento.Conta();
                    desenvolvimento.Exibir();


                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }

                if (opcao == 13)  //3.13
                {
                    Clear();
                    Desenvolvimento13 desenvolvimento;
                    desenvolvimento = new Desenvolvimento13();
                    desenvolvimento.Lervalor();
                    desenvolvimento.Contas();
                    desenvolvimento.Exibir();




                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }


                if (opcao == 14)  //3.14
                {
                    Clear();
                    Desenvolvimento14 desenvolvimento;
                    desenvolvimento = new Desenvolvimento14();
                    desenvolvimento.LerValores();

                    desenvolvimento.Operacao();


                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }

                if (opcao == 15)  //3.15
                {
                    Clear();
                    Desenvolvimento15 desenvolvimento;
                    desenvolvimento = new Desenvolvimento15();
                    desenvolvimento.lerValores();
                    desenvolvimento.Operacao();



                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }

                if (opcao == 16)  //3.16
                {
                    Clear();
                    Desenvolvimento16 desenvolvimento;
                    desenvolvimento = new Desenvolvimento16();
                    desenvolvimento.LerDados();
                    desenvolvimento.Conta();




                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }

                if (opcao == 17)  //3.17
                {
                    Clear();
                    Desenvolvimento17 desenvolvimento;
                    desenvolvimento = new Desenvolvimento17();
                    desenvolvimento.LerValores();
                    desenvolvimento.Conta();
                    desenvolvimento.Exibir();


                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }


                if (opcao == 18)  //3.18
                {
                    Clear();
                    Desenvolvimento18 desenvolvimento;
                    desenvolvimento = new Desenvolvimento18();
                    desenvolvimento.LerDados();
                    desenvolvimento.DtaAtual();
                    desenvolvimento.Conta();
                    desenvolvimento.Exibir();


                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }

                if (opcao == 19)  //3.19
                {
                    Clear();
                    Desenvolvimento19 desenvolvimento;
                    desenvolvimento = new Desenvolvimento19();
                    desenvolvimento.LerDados();
                    desenvolvimento.Conta();
                    desenvolvimento.Exibir();


                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }

                if (opcao == 20)  //3.20
                {
                    Clear();
                    Desenvolvimento20 desenvolvimento;
                    desenvolvimento = new Desenvolvimento20();
                    desenvolvimento.LerValores();
                    desenvolvimento.Conta();
                    desenvolvimento.Exibir();


                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }


                if (opcao == 21)  //3.21
                {
                    Clear();
                    Desenvolvimento21 desenvolvimento;
                    desenvolvimento = new Desenvolvimento21();
                    desenvolvimento.LerDados();
                    desenvolvimento.Conta();
                    desenvolvimento.Exibir();


                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }

                if (opcao == 22)  //3.22
                {
                    Clear();
                    Desenvolvimento22 desenvolvimento;
                    desenvolvimento = new Desenvolvimento22();
                    desenvolvimento.LerDados();
                    desenvolvimento.Contas();
                    desenvolvimento.Exibir();


                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }




                if (opcao == 23)  //3.23
                {
                    Clear();
                    Desenvolvimento23 desenvolvimento;
                    desenvolvimento = new Desenvolvimento23();
                    desenvolvimento.LerValores();
                    desenvolvimento.conta();
                    desenvolvimento.Exibir();


                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }


                if (opcao == 24)  //3.24
                {
                    Clear();
                    Desenvolvimento24 desenvolvimento;
                    desenvolvimento = new Desenvolvimento24();
                    desenvolvimento.LerValor();
                    desenvolvimento.Contas();
                    desenvolvimento.Exibir();


                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }

                if (opcao == 25)  //3.25
                {
                    Clear();
                    Desenvolvimento25 desenvolvimento;
                    desenvolvimento = new Desenvolvimento25();
                    desenvolvimento.Lervalor();
                    desenvolvimento.Conta();
                    desenvolvimento.Exibir();


                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }

                if (opcao == 26)  //3.26
                {
                    Clear();
                    Desenvolvimento26 desenvolvimento;
                    desenvolvimento = new Desenvolvimento26();
                    desenvolvimento.Lervalor();
                    desenvolvimento.Conta();
                    desenvolvimento.Exibir();


                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }

                if (opcao == 27)  //3.27
                {
                    Clear();
                    Desenvolvimento27 desenvolvimento;
                    desenvolvimento = new Desenvolvimento27();
                    desenvolvimento.Lervalor();
                    desenvolvimento.Conta();
                    desenvolvimento.Exibir();


                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }


                if (opcao == 28)  //3.28
                {
                    Clear();
                    Desenvolvimento28 desenvolvimento;
                    desenvolvimento = new Desenvolvimento28();
                    desenvolvimento.Lervalor();
                    desenvolvimento.Conta();
                    desenvolvimento.Exibir();


                    WriteLine();

                    Enter Umenter;
                    Umenter = new Enter();
                    Umenter.Ok();


                }



            }
        }
    }
}
