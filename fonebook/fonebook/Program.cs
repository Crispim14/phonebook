using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
namespace fonebook
{
    class Programa
    {
        static string caminhoArquivo = "./contatos.json";
        static List<Contato> contatos = new List<Contato>();

        static void Main(string[] args)
        {
            CarregarContatos();
            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("\nAgenda Telefônica");
                Console.WriteLine("1. Adicionar Contato");
                Console.WriteLine("2. Remover Contato");
                Console.WriteLine("3. Atualizar Contato");
                Console.WriteLine("4. Listar Contatos");
                Console.WriteLine("5. Buscar Contato");
                Console.WriteLine("6. Sair");
                Console.Write("Escolha uma opção: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        AdicionarContato();
                        break;
                    case "2":
                        RemoverContato();
                        break;
                    case "3":
                        AtualizarContato();
                        break;
                    case "4":
                        ListarContatos();
                        break;
                    case "5":
                        BuscarContato();
                        break;
                    case "6":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
                SalvarContatos();
            }
        }
        static void CarregarContatos()
        {
            if (File.Exists(caminhoArquivo))
            {
                string json = File.ReadAllText(caminhoArquivo);
                contatos = JsonConvert.DeserializeObject<List<Contato>>(json) ?? new List<Contato>();
            }
        }
    }
}
    
