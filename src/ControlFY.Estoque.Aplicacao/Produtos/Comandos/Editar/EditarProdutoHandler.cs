using AutoMapper;
using ControlFY.Estoque.Aplicacao.Comum.Contratos.Repositorio;
using ControlFY.Estoque.Aplicacao.Produtos.ViewModels;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ControlFY.Estoque.Aplicacao.Produtos.Comandos.Editar
{
    public class EditarProdutoHandler : IRequestHandler<EditarProdutoComando, ProdutoViewModel>
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        private readonly IMapper _mapper;

        public EditarProdutoHandler(IProdutoRepositorio produtoRepositorio, IMapper mapper)
        {
            _produtoRepositorio = produtoRepositorio;
            _mapper = mapper;
        }

        public async Task<ProdutoViewModel> Handle(EditarProdutoComando request, CancellationToken cancellationToken)
        {
            var produto = await _produtoRepositorio.ConsultarPorId(x => x.Id == request.Id);

            produto.AtualizarProduto(request.Nome, request.Descricao, request.Valor.Value, request.Quantidade.Value);

            await _produtoRepositorio.Atualizar(produto);

            return _mapper.Map<ProdutoViewModel>(produto);
        }
    }
}
