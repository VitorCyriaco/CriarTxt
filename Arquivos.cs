using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriarTxt
{
    public class Arquivos
    {
        static string diretorioRaiz = "C:\\Users\\vitor\\Desktop\\Aula Raicley\\C#\\Atividade\\Atividade\\data";
        public void ExibirArquivos()
        {
            Console.Clear();
            Console.WriteLine("Arquivos existentes:");
            string[] arquivos = Directory.GetFiles(diretorioRaiz);
            foreach (string arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }
            Console.WriteLine("Pressione qualquer tecla para voltar.");
            Console.ReadKey();
        }

        public void CriarArquivo()
        {
            Console.Clear();
            Console.Write("Digite o nome do arquivo (.txt): ");
            string nomeArquivo = Console.ReadLine();
            string caminhoArquivo = Path.Combine(diretorioRaiz, nomeArquivo);

            if (File.Exists(caminhoArquivo))
            {
                Console.WriteLine("O arquivo já existe!");
            }
            else
            {
                Console.Write("Digite o texto para o arquivo: ");
                string texto = Console.ReadLine();
                File.WriteAllText(caminhoArquivo, texto);
                Console.WriteLine("Arquivo criado com sucesso!");
            }
            Console.WriteLine("Pressione qualquer tecla para voltar.");
            Console.ReadKey();
        }

        public void EditarArquivo()
        {
            Console.Clear();
            Console.Write("Digite o nome do arquivo a ser editado: ");
            string nomeArquivo = Console.ReadLine();
            string caminhoArquivo = Path.Combine(diretorioRaiz, nomeArquivo);

            if (File.Exists(caminhoArquivo))
            {
                Console.Write("Digite o novo nome do arquivo: ");
                string novoNome = Console.ReadLine();
                string novoCaminho = Path.Combine(diretorioRaiz, novoNome);
                File.Move(caminhoArquivo, novoCaminho);
                Console.WriteLine("Arquivo renomeado com sucesso!");
            }
            else
            {
                Console.WriteLine("O arquivo não existe!");
            }
            Console.WriteLine("Pressione qualquer tecla para voltar.");
            Console.ReadKey();
        }
        public void DeletarArquivo()
        {
            Console.Clear();
            Console.Write("Digite o nome do arquivo a ser deletado: ");
            string nomeArquivo = Console.ReadLine();
            string caminhoArquivo = Path.Combine(diretorioRaiz, nomeArquivo);

            if (File.Exists(caminhoArquivo))
            {
                File.Delete(caminhoArquivo);
                Console.WriteLine("Arquivo deletado com sucesso!");
            }
            else
            {
                Console.WriteLine("O arquivo não existe!");
            }
            Console.WriteLine("Pressione qualquer tecla para voltar.");
            Console.ReadKey();
        }
        public void AdicionarTextoArquivo()
        {
            Console.Clear();
            Console.Write("Digite o nome do arquivo para adicionar texto: ");
            string nomeArquivo = Console.ReadLine();
            string caminhoArquivo = Path.Combine(diretorioRaiz, nomeArquivo);

            if (File.Exists(caminhoArquivo))
            {
                Console.Write("Digite o texto a ser adicionado: ");
                string texto = Console.ReadLine();
                File.AppendAllText(caminhoArquivo, texto);
                Console.WriteLine("Texto adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("O arquivo não existe!");
            }
            Console.WriteLine("Pressione qualquer tecla para voltar.");
            Console.ReadKey();
        }
    }
}
