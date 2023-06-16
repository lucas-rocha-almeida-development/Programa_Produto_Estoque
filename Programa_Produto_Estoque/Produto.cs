using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Produto_Estoque {
    internal class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;
        //CALCULAR O VALOR DO ESTOQUE X QUANTIDADE DIGITADA INICIALMENTE
        public double Valor_Total_Estoque() {

            return Preco* Quantidade;
        }// ADICIONAR QUANTIDADE DOS PRODUTOS
        public void AdicionarProduto (int quantidade) {
            Quantidade += quantidade;
        }//REMOVER QUANTIDADE DE PRODUTOS
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        //criar classe objeto
        public override string ToString() {
            return Nome 
                +
                ", $ " 
                + Preco.ToString("F2",CultureInfo.InvariantCulture)
                + ", "
                +Quantidade
                +" unidades, Total: $"
                +Valor_Total_Estoque().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
