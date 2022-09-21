using ControlFY.Estoque.Aplicacao.Produtos.ViewModels;
using MediatR;

namespace ControlFY.Estoque.Aplicacao.Produtos.Consultas.ListarPorId
{
    public class ListarPorIdConsulta : IRequest<ProdutoViewModel>
    {
        public long? Id { get; set; }
    }
}
