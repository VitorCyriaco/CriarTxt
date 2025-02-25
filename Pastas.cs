using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriarTxt
{
    public class Pastas
    {
        string diretorioRaiz = "C:\\Users\\vitor\\Desktop\\Aula Raicley\\C#\\Atividade\\Atividade\\data";
        public void ExibirPastas()
        {
            Console.Clear();
            Console.WriteLine("Pastas existentes:");
            string[] pastas = Directory.GetDirectories(diretorioRaiz);
            foreach (string pasta in pastas)
            {
                Console.WriteLine(pasta);
            }
            Console.WriteLine("Pressione qualquer tecla para voltar.");
            Console.ReadKey();
        }
        public void CriarPasta()
        {
            Console.Clear(); // Limpa o Console
            Console.Write("Digite o nome da pasta: ");
            string nomePasta = Console.ReadLine();
            string caminhoPasta = Path.Combine(diretorioRaiz, nomePasta);

            if (Directory.Exists(caminhoPasta))
            {
                Console.WriteLine("A pasta já existe!");
            }
            else
            {
                Directory.CreateDirectory(caminhoPasta);
                Console.WriteLine("Pasta criada com sucesso!");
            }
            Console.WriteLine("Pressione qualquer tecla para voltar.");
            Console.ReadKey();
        }
        public void EditarPasta()
        {
            Console.Clear(); // Limpa o Console
            Console.Write("Digite o nome da pasta a ser editada: ");
            string nomeAntigo = Console.ReadLine();
            string caminhoAntigo = Path.Combine(diretorioRaiz, nomeAntigo);

            if (Directory.Exists(caminhoAntigo))
            {
                Console.Write("Digite o novo nome da pasta: ");
                string novoNome = Console.ReadLine();
                string caminhoNovo = Path.Combine(diretorioRaiz, novoNome);

                Directory.Move(caminhoAntigo, caminhoNovo);
                Console.WriteLine("Pasta renomeada com sucesso!");
            }
            else
            {
                Console.WriteLine("A pasta não existe!");
            }
            Console.WriteLine("Pressione qualquer tecla para voltar.");
            Console.ReadKey();
        }

        public void DeletarPasta()
        {
            Console.Clear(); // Limpa o Console
            Console.Write("Digite o nome da pasta a ser deletada: ");
            string nomePasta = Console.ReadLine();
            string caminhoPasta = Path.Combine(diretorioRaiz, nomePasta);

            if (Directory.Exists(caminhoPasta))
            {
                Directory.Delete(caminhoPasta, true); // Deleta a pasta e o conteúdo
                Console.WriteLine("Pasta deletada com sucesso!");
            }
            else
            {
                Console.WriteLine("A pasta não existe!");
            }
            Console.WriteLine("Pressione qualquer tecla para voltar.");
            Console.ReadKey();
        }
    }
}
