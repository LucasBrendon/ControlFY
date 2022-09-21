using System;

namespace ControlFY.Estoque.Dominio.Entidades
{
    public class Produto
    {
        public long Id { get; private set; }
        public long ProdutoId { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public int Quantidade { get; private set; }
        public decimal ValorTotal { get; private set; }
        public DateTime DataEntrada { get; private set; }
        public DateTime? DataAtualizacao { get; private set; }

        protected Produto()
        {
        }

        public Produto(long produtoId, string nome, string descricao, decimal valor, int quantidade)
        {
            ProdutoId = produtoId;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            Quantidade = quantidade;
            ValorTotal = RetornarValorTotalProduto();
            DataEntrada = DateTime.Now;
        }

        public void AtualizarProduto(string nome, string descricao, decimal valor, int quantidade)
        {
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            Quantidade = quantidade;
            ValorTotal = RetornarValorTotalProduto();
            DataAtualizacao = DateTime.Now;
        }

        private decimal RetornarValorTotalProduto()
        {
            return Valor * Quantidade;
        }
    }
}
