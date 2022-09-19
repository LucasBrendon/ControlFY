using System;

namespace ControlFY.Catalogo.Aplicacao.Produtos.ViewModels
{
    public class ProdutoViewModel
    {
        public long? Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal? Valor { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public long? CategoriaId { get; set; }
        public long? FornecedorId { get; set; }
    }
}
