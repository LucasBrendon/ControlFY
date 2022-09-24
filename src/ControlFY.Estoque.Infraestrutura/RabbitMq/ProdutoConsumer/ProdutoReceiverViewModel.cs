namespace ControlFY.Estoque.Infraestrutura.RabbitMq.ProdutoConsumer
{
    public class ProdutoReceiverViewModel
    {
        public long ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
    }
}
