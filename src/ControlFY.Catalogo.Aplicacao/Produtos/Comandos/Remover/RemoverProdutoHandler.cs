using ControlFY.Catalogo.Aplicacao.Comum.Contratos.Repositorio;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.Aplicacao.Produtos.Comandos.Remover
{
    public class RemoverProdutoHandleromandoBase : IRequestHandler<RemoverProdutoComando>
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public RemoverProdutoHandleromandoBase(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public async Task<Unit> Handle(RemoverProdutoComando request, CancellationToken cancellationToken)
        {
            var produto = await _produtoRepositorio.ConsultarPorId(x => x.Id == request.Id);

            await _produtoRepositorio.Excluir(produto);

            return Unit.Value;
        }
    }
}
