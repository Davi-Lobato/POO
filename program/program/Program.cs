using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        List<Produto> produtos = new List<Produto>();
        bool continua = true;
        while (continua)
        {
            Console.WriteLine("\nEscolha uma opção\n");
            Console.WriteLine("[1] Adicionar um Produto");
            Console.WriteLine("[2] Listar Produto");
            Console.WriteLine("[3] Remover Produto");
            Console.WriteLine("[4] Sair");

            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o código do produto");
                    int produto = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a descrição do produto");
                    string descricao = Console.ReadLine();
                    string Defunidade = Produto.DefUnidade();
                    Console.WriteLine("Digite o preço do produto");
                    double preco = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a quantidade");
                    int quantidade = int.Parse(Console.ReadLine());

                    produtos.Add(new Produto(produto, descricao, Defunidade, preco, quantidade));
                    break;

                case 2:
                    Produto.Listar(produtos);
                    break;

                case 3:
                    Console.WriteLine("informe o código do produto a ser removido: ");
                    int cod = int.Parse(Console.ReadLine());
                    break;


                case 4:
                    continua = false;
                    break;

                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        }
    }


}

