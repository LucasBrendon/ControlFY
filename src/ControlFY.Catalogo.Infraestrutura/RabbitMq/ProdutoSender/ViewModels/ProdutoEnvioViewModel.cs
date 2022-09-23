using ControlFY.Catalogo.Infraestrutura.RabbitMq.Contratos;

namespace ControlFY.Catalogo.Infraestrutura.RabbitMq.ProdutoSender
{
    public class ProdutoEnvioViewModel : IRabbitMessage
    {
        public long ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }

        public ProdutoEnvioViewModel(long produtoId, string nome, string descricao, decimal valor, int quantidade)
        {
            ProdutoId = produtoId;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            Quantidade = quantidade;
        }
    }
}
