using AutoMapper;
using ControlFY.Catalogo.Aplicacao.Comum.Contratos.Repositorio;

using ControlFY.Catalogo.Aplicacao.Produtos.ViewModels;
using ControlFY.Catalogo.Dominio.Entidades;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.Aplicacao.Produtos.Comandos.Criar
{
    public class CriarProdutoHandler : IRequestHandler<CriarProdutoComando, ProdutoViewModel>
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        private readonly IMapper _mapper;


        public CriarProdutoHandler(IProdutoRepositorio produtoRepositorio,
                                   IMapper mapper)
        {
            _produtoRepositorio = produtoRepositorio;
            _mapper = mapper;

        }

        public async Task<ProdutoViewModel> Handle(CriarProdutoComando request, CancellationToken cancellationToken)
        {
            var produto = new Produto(request.Nome, request.Descricao, request.Valor.Value, request.CategoriaId.Value, request.FornecedorId.Value);

            await _produtoRepositorio.Cadastrar(produto);

            return _mapper.Map<ProdutoViewModel>(produto);
        }
    }
}
