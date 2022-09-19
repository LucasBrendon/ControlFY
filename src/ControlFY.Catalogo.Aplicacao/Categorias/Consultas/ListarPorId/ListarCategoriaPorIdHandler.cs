using AutoMapper;
using ControlFY.Catalogo.Aplicacao.Categorias.ViewModels;
using ControlFY.Catalogo.Aplicacao.Comum.Contratos.Repositorio;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.Aplicacao.Categorias.Consultas.ConsultarPorId
{
    public class ListarCategoriaPorIdHandler : IRequestHandler<ListarCategoriaPorIdConsulta, CategoriaViewModel>
    {
        private readonly IMapper _mapper;
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public ListarCategoriaPorIdHandler(IMapper mapper, ICategoriaRepositorio categoriaRepositorio)
        {
            _mapper = mapper;
            _categoriaRepositorio = categoriaRepositorio;
        }

        public async Task<CategoriaViewModel> Handle(ListarCategoriaPorIdConsulta request, CancellationToken cancellationToken)
        {
            var categoria = await _categoriaRepositorio.ConsultarPorId(x => x.Id == request.Id);

            return _mapper.Map<CategoriaViewModel>(categoria);
        }
    }
}
