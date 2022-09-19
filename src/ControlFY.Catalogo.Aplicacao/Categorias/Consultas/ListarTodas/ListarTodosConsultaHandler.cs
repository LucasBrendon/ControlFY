using AutoMapper;
using ControlFY.Catalogo.Aplicacao.Categorias.ViewModels;
using ControlFY.Catalogo.Aplicacao.Comum.Contratos.Repositorio;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.Aplicacao.Categorias.Consultas.ListarTodas
{
    public class ListarTodosConsultaHandler : IRequestHandler<ListarTodosConsulta, List<CategoriaViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public ListarTodosConsultaHandler(IMapper mapper, ICategoriaRepositorio categoriaRepositorio)
        {
            _mapper = mapper;
            _categoriaRepositorio = categoriaRepositorio;
        }

        public async Task<List<CategoriaViewModel>> Handle(ListarTodosConsulta request, CancellationToken cancellationToken)
        {
            var categorias = await _categoriaRepositorio.Listar();

            return _mapper.Map<List<CategoriaViewModel>>(categorias);
        }
    }
}
