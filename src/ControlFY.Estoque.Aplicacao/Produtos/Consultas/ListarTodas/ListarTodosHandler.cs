using AutoMapper;
using ControlFY.Estoque.Aplicacao.Comum.Contratos.Repositorio;
using ControlFY.Estoque.Aplicacao.Produtos.ViewModels;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ControlFY.Estoque.Aplicacao.Produtos.Consultas.ListarTodas
{
    public class ListarTodosHandler : IRequestHandler<ListarTodosConsulta, List<ProdutoViewModel>>
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        private readonly IMapper _mapper;

        public ListarTodosHandler(IProdutoRepositorio produtoRepositorio, IMapper mapper)
        {
            _produtoRepositorio = produtoRepositorio;
            _mapper = mapper;
        }

        public async Task<List<ProdutoViewModel>> Handle(ListarTodosConsulta request, CancellationToken cancellationToken)
        {
            var produtos = await _produtoRepositorio.Listar();

            return _mapper.Map<List<ProdutoViewModel>>(produtos);
        }
    }
}
