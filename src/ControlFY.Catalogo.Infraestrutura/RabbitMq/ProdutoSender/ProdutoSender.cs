using ControlFY.Catalogo.Infraestrutura.RabbitMq.Config;
using Microsoft.Extensions.Options;

namespace ControlFY.Catalogo.Infraestrutura.RabbitMq.ProdutoSender
{
    public class ProdutoSender : SenderBase<ProdutoEnvioViewModel>, IProdutoSender
    {
        protected override string Fila { get => "Teste"; }

        public ProdutoSender(IOptions<RabbitMqConfiguration> options) : base(options)
        {
        }
    }
}
