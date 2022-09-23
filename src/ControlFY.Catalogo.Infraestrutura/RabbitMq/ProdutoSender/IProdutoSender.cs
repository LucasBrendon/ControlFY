using ControlFY.Catalogo.Infraestrutura.RabbitMq.Contratos;

namespace ControlFY.Catalogo.Infraestrutura.RabbitMq.ProdutoSender
{
    public interface IProdutoSender : ISenderBase<ProdutoEnvioViewModel>
    {
    }
}
