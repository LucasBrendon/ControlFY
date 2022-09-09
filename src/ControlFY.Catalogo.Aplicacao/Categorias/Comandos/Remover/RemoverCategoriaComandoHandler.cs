using ControlFY.Catalogo.Aplicacao.Comum.Contratos.Repositorio;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.Aplicacao.Categorias.Comandos.Remover
{
    public class RemoverCategoriaComandoHandler : IRequestHandler<RemoverCategoriaComando>
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public RemoverCategoriaComandoHandler(ICategoriaRepositorio categoriaRepositorio)
        {
            _categoriaRepositorio = categoriaRepositorio;
        }

        public async Task<Unit> Handle(RemoverCategoriaComando request, CancellationToken cancellationToken)
        {
            var categoria = await _categoriaRepositorio.ConsultarPorId(x => x.Id == request.Id);

            await _categoriaRepositorio.Excluir(categoria);

            return Unit.Value;
        }
    }
}
