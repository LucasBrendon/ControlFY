using MediatR;

namespace ControlFY.Estoque.Aplicacao.Produtos.Comandos.Remover
{
    public class RemoverProdutoComando : IRequest
    {
        public long? Id { get; set; }
    }
}
