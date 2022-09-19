using System;

namespace ControlFY.Catalogo.Aplicacao.Produtos.Comandos.Base
{
    public class ProdutoComandoBase
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal? Valor { get; set; }
        public long? CategoriaId { get; set; }
        public long? FornecedorId { get; set; }
    }
}
