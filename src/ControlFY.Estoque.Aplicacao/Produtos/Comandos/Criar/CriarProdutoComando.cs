using ControlFY.Estoque.Aplicacao.Produtos.Comandos.Base;
using ControlFY.Estoque.Aplicacao.Produtos.ViewModels;
using MediatR;

namespace ControlFY.Estoque.Aplicacao.Produtos.Comandos.Criar
{
    public class CriarProdutoComando : ProdutoComandoBase, IRequest<ProdutoViewModel>
    {
    }
}
