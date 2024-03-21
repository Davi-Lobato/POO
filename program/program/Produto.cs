using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

    internal class Produto
    {
    public int cod_prod;
    public string desc_prod;
    public string unidade_prod;
    private double preco_prod;
    public int quantidade;

    public double GetPrecoProd()
    {
        return this.preco_prod;
    }

    public void SetPrecoProd(double preco)
    {
        if (preco > 0)
        {
            this.preco_prod = preco;
        }
        else
        {
            Console.WriteLine("Preço Inválido");
        }
    }

    public Produto(int a, string b, string c, double e, int f)
    {
        this.cod_prod = a;
        this.desc_prod = b;
        this.unidade_prod = c;
        SetPrecoProd(e);
        this.quantidade = f;
    }

    public static string DefUnidade()
    {

        /*
         Ou colocar unidade = unidade.ToUpper();

        if (unidade == "LT" || unidade == "CX"
        || unidade == "KG"
        || unidade == "MT
        || unidade == "UN")
        {
        this.unidade = unidade;
        }
        else{interação com ususario}
        }   
         */

        bool continua = true;
        string unidade = "";
        while (continua)
        {
            Console.WriteLine("\nEscolha uma unidade de produto");
            Console.WriteLine("[1] LT");
            Console.WriteLine("[2] CX");
            Console.WriteLine("[3] KG");
            Console.WriteLine("[4] UN");
            Console.WriteLine("[5] MT");

            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    unidade = "LT";
                    continua = false;
                    break;
                case 2:
                    unidade = "CX";
                    continua = false;
                    break;
                case 3:
                    unidade = "KG";
                    continua = false;
                    break;
                case 4:
                    unidade = "LT";
                    continua = false;
                    break;
                case 5:
                    unidade = "MT";
                    continua = false;
                    break;
                default:
                    Console.WriteLine("Inválido");
                    break;
            }
        }
        return unidade;
    }

    public static void Listar(List<Produto> produtos)
    {
        if (produtos.Count == 0)
        {
            Console.WriteLine("Lista vazia");
        }
        else
        {
           foreach (Produto produto in produtos)
            {
                Console.WriteLine(produto);
                Console.WriteLine(produto.cod_prod);
                Console.WriteLine(produto.desc_prod);
                Console.WriteLine(produto.unidade_prod);
                Console.WriteLine(produto.GetPrecoProd());
                Console.WriteLine(produto.quantidade);
            }
        }
        
    }

    public static void Remover(List<Produto> produtos, int cod)
    {
        Produto produtoExcluir = produtos.FirstOrDefault(x => x.cod_prod == cod);
        produtos.Remove(produtoExcluir);

        /*
         Produto produtoExcluir = produtos.FirstOrDefault(x => x.id ==cod);
         produtos.Remove(produto);
         */
    }

    
    }

