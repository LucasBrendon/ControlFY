using ControlFY.Estoque.Aplicacao.Comum.Contratos.Repositorio;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ControlFY.Estoque.Aplicacao.Produtos.Comandos.Remover
{
    public class RemoverPodutoHandler : IRequestHandler<RemoverProdutoComando>
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public RemoverPodutoHandler(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public async Task<Unit> Handle(RemoverProdutoComando request, CancellationToken cancellationToken)
        {
            var produto = await _produtoRepositorio.ConsultarPorId(x => x.Id == request.Id);

            await _produtoRepositorio.Excluir(produto);

            //Enviar evento para fila de produtoRemovido

            return Unit.Value;
        }
    }
}
