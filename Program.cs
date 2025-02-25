using System;
using System.IO;

namespace CriarTxt
{
    class Program
    {
        static string diretorioRaiz = "C:\\Users\\vitor\\Desktop\\Aula Raicley\\C#\\Atividade\\Atividade\\data";
        static void Main()
        {
            if (!Directory.Exists(diretorioRaiz))
            {
                Directory.CreateDirectory(diretorioRaiz);
            }
             while (true)
             {
                     Console.Clear();
                     Console.WriteLine("Menu Principal:");
                     Console.WriteLine("1 - Criar pasta");
                     Console.WriteLine("2 - Criar arquivo");
                     Console.WriteLine("3 - Deletar Pasta");
                     Console.WriteLine("4 - Deletar Arquivo");
                     Console.WriteLine("5 - Sair");
                     Console.Write("Escolha uma opção: ");
                    string opcao = Console.ReadLine();

                   switch (opcao)
                   {
                    case "1":
                         MenuCriarPasta();
                       break;

                    case "2":
                         MenuCriarArquivo();
                       break;

                    case "3":
                         Pastas pastas = new Pastas();
                        pastas.DeletarPasta();
                       break;

                    case "4":
                        Arquivos arquivos = new Arquivos();
                          arquivos.DeletarArquivo();
                       break;

                    case "5":
                          return;
                        default:
                        Console.WriteLine("Opção inválida!");
                        break;
                   }
             }
        }
        static void MenuCriarPasta()
        {
            Pastas pastas = new Pastas();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu Criar Pasta:");
                Console.WriteLine("1 - Exibir pastas existentes");
                Console.WriteLine("2 - Criar pasta");
                Console.WriteLine("3 - Editar nome da pasta");
                Console.WriteLine("4 - Voltar");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        pastas.ExibirPastas();
                        break;
                    case "2":
                        pastas.CriarPasta();
                        break;
                    case "3":
                        pastas.EditarPasta();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
        static void MenuCriarArquivo()
        {
            Arquivos arquivos = new Arquivos();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu Criar Arquivo:");
                Console.WriteLine("1 - Exibir arquivos existentes");
                Console.WriteLine("2 - Criar arquivo");
                Console.WriteLine("3 - Editar nome do arquivo");
                Console.WriteLine("4 - Adicionar texto ao arquivo");
                Console.WriteLine("5 - Voltar");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        arquivos.ExibirArquivos();
                        break;
                    case "2":
                        arquivos.CriarArquivo();
                        break;
                    case "3":
                        arquivos.EditarArquivo();
                        break;
                    case "4":
                        arquivos.AdicionarTextoArquivo();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}
