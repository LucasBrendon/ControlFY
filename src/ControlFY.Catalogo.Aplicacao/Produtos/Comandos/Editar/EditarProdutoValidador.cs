using ControlFY.Catalogo.Aplicacao.Produtos.Comandos.Base;
using FluentValidation;

namespace ControlFY.Catalogo.Aplicacao.Produtos.Comandos.Editar
{
    public class EditarProdutoValidador : ProdutoValidadorBase<EditarProdutoComando>
    {
        public EditarProdutoValidador()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("O id não foi informado.");
        }
    }
}
