using System;

namespace DIO.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoEscolhidaUsuario = Menu();

            while(opcaoEscolhidaUsuario.ToUpper() != "X")
            {
                switch(opcaoEscolhidaUsuario)
                {
                    case "1":
                        SerieService.ListSerie();
                        break;
                    case "2":
                        SerieService.InsertSerie();
                        break;
                    case "3":
                        SerieService.UpdateSerie();
                        break;
                    case "4":
                        SerieService.DeletSerie();
                        break;
                    case "5":
                        SerieService.GetById();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentException();
                }
                opcaoEscolhidaUsuario = Menu();
            }
        }

        static string Menu()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Bem vindo ao DIO Séries");
            Console.WriteLine("===================================");

            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir séries");
            Console.WriteLine("5 - Visualizar séries");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");

            Console.WriteLine();
            Console.Write("Informe a opção desejada: ");
            string opcaoEscolhida = Console.ReadLine().ToUpper();
            Console.Clear();

            return opcaoEscolhida;
        }
    }
}
