using System;
using System.IO;

namespace EditorTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("========Editor de Texto=========");
            Console.WriteLine("================================");
            Console.WriteLine("");
            Console.WriteLine("Oque queres fazer?");
            Console.WriteLine("1 - Abrir Arquivo");
            Console.WriteLine("2 - Criar Arquivo");
            Console.WriteLine("0 - Sair do Programa");
            short opcao = short.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 1:
                    AbrirArquivo();
                    break;
                case 2:
                    Editar();
                    break;
                case 0:
                    System.Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }

        }

        static void AbrirArquivo()
        {
            Console.Clear();
            Console.WriteLine("Qual é o caminho do arquivo desejado?");
            var path = Console.ReadLine();

            using(var file = new StreamReader(path))
            {
                string texto = file.ReadToEnd();
                Console.WriteLine("=========================================");
                Console.WriteLine(texto);
            }

            Console.WriteLine("");
            Console.WriteLine("Clique qualquer tecla para sair");
            Console.ReadKey();
            Menu();
        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite o seu texto(Digite ESC para sair):");
            Console.WriteLine("------------------------------------------");
            
            string texto = "";

            do{
                texto += Console.ReadLine();
                texto += Environment.NewLine;
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);
            
            Salvar(texto);
        }

        static void Salvar(string texto)
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using(var file = new StreamWriter(path))
            {
                file.Write(texto);
            }

            Console.Write($"O Arquivo foi salvo com sucesso em {path}");
            Console.WriteLine("Clique qualquer tecla para sair");
            Console.ReadKey();
            Menu();
        }
    }
}