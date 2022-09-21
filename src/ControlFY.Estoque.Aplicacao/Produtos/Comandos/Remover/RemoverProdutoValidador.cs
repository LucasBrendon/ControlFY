using FluentValidation;

namespace ControlFY.Estoque.Aplicacao.Produtos.Comandos.Remover
{
    public class RemoverProdutoValidador : AbstractValidator<RemoverProdutoComando>
    {
        public RemoverProdutoValidador()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("O id não foi informado.");
        }
    }
}
