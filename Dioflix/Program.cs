using System;
using DioFlix.Classes;
using DioFlix.Enumeravel;

namespace DioFlix
{
    class Program
    {

        static void Main(string[] args)
        {
            string opcaoUsuario = Tela.ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.Clear();
                        opcaoUsuario = Tela.MenuFilme();
                        while (opcaoUsuario.ToUpper() != "X")
                        {
                            switch (opcaoUsuario)
                            {
                                case "1":
                                    Tela.ListaFimes();
                                    break;
                                case "2":
                                    Tela.InserirFilme();
                                    break;
                                case "3":
                                    Tela.AtualizarFilme();
                                    break;
                                case "4":
                                    Tela.ExcluiFilme();
                                    break;
                                case "5":
                                    Tela.VisualizarFilme();
                                    break;
                                default:
                                    throw new ArgumentOutOfRangeException();
                            }
                            Console.ReadLine();
                            Console.Clear();

                            opcaoUsuario = Tela.MenuFilme();

                        }

                        break;
                    case "2":
                        Console.Clear();
                        opcaoUsuario = Tela.MenuSerie();
                        while (opcaoUsuario.ToUpper() != "X")
                        {
                            switch (opcaoUsuario)
                            {
                                case "1":
                                    Tela.ListaSeries();
                                    break;
                                case "2":
                                    Tela.InserirSerie();
                                    break;
                                case "3":
                                    Tela.AtualizarSerie();
                                    break;
                                case "4":
                                    Tela.ExcluiSerie();
                                    break;
                                case "5":
                                    Tela.VisualizarSerie();
                                    break;
                                default:
                                    throw new ArgumentOutOfRangeException();
                            }
                            Console.ReadLine();
                            Console.Clear();

                            opcaoUsuario = Tela.MenuSerie();

                        }
                        break;

                }
                Console.ReadLine();
                Console.Clear();

                opcaoUsuario = Tela.ObterOpcaoUsuario();
            }


            Console.WriteLine("Obrigado por utilzar os nossos serviços.");

        }
    }
}
