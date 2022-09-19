using AutoMapper;
using ControlFY.Catalogo.Aplicacao.Comum.Contratos.Repositorio;
using ControlFY.Catalogo.Aplicacao.Produtos.ViewModels;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.Aplicacao.Produtos.Consultas.ListarPorId
{
    public class ListarProdutoPorIdHandler : IRequestHandler<ListarProdutoPorIdConsulta, ProdutoViewModel>
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        private readonly IMapper _mapper;

        public ListarProdutoPorIdHandler(IProdutoRepositorio produtoRepositorio, IMapper mapper)
        {
            _produtoRepositorio = produtoRepositorio;
            _mapper = mapper;
        }

        public async Task<ProdutoViewModel> Handle(ListarProdutoPorIdConsulta request, CancellationToken cancellationToken)
        {
            var produto = await _produtoRepositorio.ConsultarPorId(x => x.Id == request.Id.Value);

            return _mapper.Map<ProdutoViewModel>(produto);
        }
    }
}
