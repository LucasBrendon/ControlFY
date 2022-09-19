using ControlFY.Catalogo.Aplicacao.Produtos.Comandos.Base;
using ControlFY.Catalogo.Aplicacao.Produtos.ViewModels;
using MediatR;

namespace ControlFY.Catalogo.Aplicacao.Produtos.Comandos.Editar
{
    public class EditarProdutoComando : ProdutoComandoBase, IRequest<ProdutoViewModel>
    {
        public long? Id { get; set; }
    }
}
