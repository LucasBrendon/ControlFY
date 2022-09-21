using AutoMapper;
using ControlFY.Estoque.Aplicacao.Comum.Contratos.Repositorio;
using ControlFY.Estoque.Aplicacao.Produtos.ViewModels;
using ControlFY.Estoque.Dominio.Entidades;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ControlFY.Estoque.Aplicacao.Produtos.Comandos.Criar
{
    public class CriarProdutoHandler : IRequestHandler<CriarProdutoComando, ProdutoViewModel>
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        private readonly IMapper _mapper;

        public CriarProdutoHandler(IProdutoRepositorio produtoRepositorio, IMapper mapper)
        {
            _produtoRepositorio = produtoRepositorio;
            _mapper = mapper;
        }

        public async Task<ProdutoViewModel> Handle(CriarProdutoComando request, CancellationToken cancellationToken)
        {
            var produto = new Produto(request.ProdutoId.Value,
                                      request.Nome,
                                      request.Descricao,
                                      request.Valor.Value,
                                      request.Quantidade.Value);

            await _produtoRepositorio.Cadastrar(produto);

            return _mapper.Map<ProdutoViewModel>(produto);
        }
    }
}
