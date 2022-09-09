using AutoMapper;
using ControlFY.Catalogo.Aplicacao.Categorias.ViewModels;
using ControlFY.Catalogo.Aplicacao.Comum.Contratos.Repositorio;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.Aplicacao.Categorias.Comandos.Editar
{
    public class EditarCategoriaComandoHandler : IRequestHandler<EditarCategoriaComando, CategoriaViewModel>
    {
        private readonly IMapper _mapper;
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public EditarCategoriaComandoHandler(IMapper mapper, ICategoriaRepositorio categoriaRepositorio)
        {
            _mapper = mapper;
            _categoriaRepositorio = categoriaRepositorio;
        }

        public async Task<CategoriaViewModel> Handle(EditarCategoriaComando request, CancellationToken cancellationToken)
        {
            var categoria = await _categoriaRepositorio.ConsultarPorId(x => x.Id == request.Id.Value);

            categoria.AtualizarCategoria(request.Nome);

            await _categoriaRepositorio.Atualizar(categoria);

            return _mapper.Map<CategoriaViewModel>(categoria);
        }
    }
}
