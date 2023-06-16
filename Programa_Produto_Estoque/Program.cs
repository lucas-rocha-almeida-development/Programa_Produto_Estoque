using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Produto_Estoque {
    internal class Program {
        static void Main(string[] args) {
            Produto p = new Produto();

           

           

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------");
            Console.WriteLine("Dados do produto: " + p);


            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado: ");
            /*Usuario ira digitar a quantidade de produtos adicionados
             Logo apos , a operação p.AdicionarProdutos criada na paginas de class, ira capturar o valor
            digitado na variavel "qte" e adiconar dentro da quantidade ja existente*/
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);
            Console.WriteLine("\n");
            Console.WriteLine("Dados Atualizados: " +p);
            //Pode-se observar que apos atualização os valores impressos estão atualizados, com nova quantidade de produtos.
            Console.WriteLine();
            //ABAIXO IREMOS DIGITAR A QUANTIDADE QUE DESEJAMOS REMOVER
            Console.Write("Digite a quantidade que sera REMOVIDA: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine("Quantidade Removida:" + p);
            Console.ReadKey();
        }
    }
}
