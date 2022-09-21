using System;

namespace ControlFY.Estoque.Aplicacao.Produtos.ViewModels
{
    public class ProdutoViewModel
    {
        public long Id { get; set; }
        public long ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
