using AutoMapper;
using ControlFY.Estoque.Aplicacao.Comum.Contratos.Repositorio;
using ControlFY.Estoque.Aplicacao.Produtos.ViewModels;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ControlFY.Estoque.Aplicacao.Produtos.Consultas.ListarPorId
{
    public class ListarPorIdHandler : IRequestHandler<ListarPorIdConsulta, ProdutoViewModel>
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        private readonly IMapper _mapper;

        public ListarPorIdHandler(IProdutoRepositorio produtoRepositorio, IMapper mapper)
        {
            _produtoRepositorio = produtoRepositorio;
            _mapper = mapper;
        }

        public async Task<ProdutoViewModel> Handle(ListarPorIdConsulta request, CancellationToken cancellationToken)
        {
            var produto = await _produtoRepositorio.ConsultarPorId(x => x.Id == request.Id.Value);

            return _mapper.Map<ProdutoViewModel>(produto);
        }
    }
}
