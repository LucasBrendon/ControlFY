namespace ControlFY.Estoque.Aplicacao.Produtos.Comandos.Base
{
    public abstract class ProdutoComandoBase
    {
        public long? ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal? Valor { get; set; }
        public int? Quantidade { get; set; }
    }
}
