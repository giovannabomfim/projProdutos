using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Produtos produtos = new Produtos();
            int choice = 0;
            do
            {

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(25, 2);
                Console.Write("MENU");
                Console.SetCursorPosition(19, 4);
                Console.Write("0. Sair");
                Console.SetCursorPosition(19, 6);
                Console.Write("1. Adicionar produto");
                Console.SetCursorPosition(19, 8);
                Console.Write("2. Pesquisar produto");
                Console.SetCursorPosition(19, 10);
                Console.Write("3. Remover produto");
                Console.SetCursorPosition(19, 12);
                Console.Write("4. Listar produto");
                Console.SetCursorPosition(19, 14);
                Console.Write("OPÇÃO:");
                choice = int.Parse(Console.ReadLine());

                Console.Clear();


                if (choice == 1)
                {
                    Console.WriteLine("Digite o Codigo: ");
                    int codigo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a Descricão: ");
                    string descricao = Console.ReadLine();
                    Console.WriteLine("Digite a Qtde: ");
                    int qtde = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o Preço: ");
                    double preco = double.Parse(Console.ReadLine());
                    produtos.adicionar(new Produto(codigo, descricao, qtde, preco));
                   

                }
                else if (choice == 2)
                {
                    Console.WriteLine("Digite o Codigo: ");
                    int codigo = int.Parse(Console.ReadLine());
                    Produto result = produtos.pesquisar(new Produto(codigo, "", 0, 0));
                    Console.WriteLine("Codigo : " + result.Codigo + "\nDescrição : " + result.Descricao + "\nQtde : " + result.Qtde + "\nPreco : " + result.Preco);
                    Console.ReadKey();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Digite o Codigo: ");
                    int codigo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Tem certeza S p/sim ou N p/ não? ");
                    string x = Console.ReadLine();
                    bool decisao = x == "S" ? true : false;
                    if (decisao)
                    {
                        bool result = produtos.remover(new Produto(codigo, "", 0, 0));
                        if (result)
                        {
                            Console.WriteLine("Apagado com sucesso");
                        }
                        else
                        {
                            Console.WriteLine("Não foi possivel apagar");
                        }
                    }
                    Console.ReadKey();

                }
                else if (choice == 4)
                {
                    foreach (Produto elemento in produtos.ListaProdutos)
                    {
                        Produto result = produtos.pesquisar(new Produto(elemento.Codigo, "", 0, 0));
                        Console.WriteLine("Codigo : " + result.Codigo + "\nDescrição : " + result.Descricao + "\nQtde : " + result.Qtde + "\nPreco : " + result.Preco + "\n");
                    }
                    Console.WriteLine("Custo total= " + produtos.custoTotal());

                    Console.ReadKey();
                }
                Console.Clear();
            }
            while (choice != 0);        
        }
    }
}
