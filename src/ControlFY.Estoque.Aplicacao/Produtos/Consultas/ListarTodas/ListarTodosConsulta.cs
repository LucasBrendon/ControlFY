using ControlFY.Estoque.Aplicacao.Produtos.ViewModels;
using MediatR;
using System.Collections.Generic;

namespace ControlFY.Estoque.Aplicacao.Produtos.Consultas.ListarTodas
{
    public class ListarTodosConsulta : IRequest<List<ProdutoViewModel>>
    {
    }
}
