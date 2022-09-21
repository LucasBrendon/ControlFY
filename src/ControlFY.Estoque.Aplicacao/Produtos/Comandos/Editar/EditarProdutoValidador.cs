using ControlFY.Estoque.Aplicacao.Produtos.Comandos.Base;
using FluentValidation;

namespace ControlFY.Estoque.Aplicacao.Produtos.Comandos.Editar
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
