using ControlFY.Catalogo.Aplicacao.Produtos.Comandos.Base;
using ControlFY.Catalogo.Aplicacao.Produtos.ViewModels;
using MediatR;

namespace ControlFY.Catalogo.Aplicacao.Produtos.Comandos.Criar
{
    public class CriarProdutoComando : ProdutoComandoBase, IRequest<ProdutoViewModel>
    {
    }
}
