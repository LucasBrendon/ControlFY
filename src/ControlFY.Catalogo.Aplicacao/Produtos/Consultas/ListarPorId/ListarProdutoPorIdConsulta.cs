using ControlFY.Catalogo.Aplicacao.Produtos.ViewModels;
using MediatR;

namespace ControlFY.Catalogo.Aplicacao.Produtos.Consultas.ListarPorId
{
    public class ListarProdutoPorIdConsulta : IRequest<ProdutoViewModel>
    {
        public long? Id { get; set; }
    }
}
