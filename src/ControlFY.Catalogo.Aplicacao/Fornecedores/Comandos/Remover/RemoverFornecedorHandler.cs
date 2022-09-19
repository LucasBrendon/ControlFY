using ControlFY.Catalogo.Aplicacao.Comum.Contratos.Repositorio;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.Aplicacao.Fornecedores.Comandos.Remover
{
    public class RemoverFornecedorHandler : IRequestHandler<RemoverFornecedorComando>
    {
        private readonly IFornecedorRepositorio _fornecedorRepositorio;

        public RemoverFornecedorHandler(IFornecedorRepositorio fornecedorRepositorio)
        {
            _fornecedorRepositorio = fornecedorRepositorio;
        }

        public async Task<Unit> Handle(RemoverFornecedorComando request, CancellationToken cancellationToken)
        {
            var fornecedor = await _fornecedorRepositorio.RetornarFornecedorEndereco(request.Id.Value);

            await _fornecedorRepositorio.Excluir(fornecedor);

            return Unit.Value;
        }
    }
}
