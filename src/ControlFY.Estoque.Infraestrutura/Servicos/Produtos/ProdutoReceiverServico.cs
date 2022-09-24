using ControlFY.Estoque.Aplicacao.Produtos.Comandos.Criar;
using ControlFY.Estoque.Infraestrutura.RabbitMq.ProdutoConsumer;
using MediatR;
using System.Threading.Tasks;

namespace ControlFY.Estoque.Infraestrutura.Servicos.Produtos
{
    public class ProdutoReceiverServico : IProdutoReceiverServico
    {
        private readonly IMediator _mediator;

        public ProdutoReceiverServico(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task CriarProduto(ProdutoReceiverViewModel receiver)
        {
            var produtoComando = new CriarProdutoComando
            {
                ProdutoId = receiver.ProdutoId,
                Nome = receiver.Nome,
                Descricao = receiver.Descricao,
                Valor = receiver.Valor,
                Quantidade = receiver.Quantidade,
            };

            await _mediator.Send(produtoComando);
        }
    }
}
