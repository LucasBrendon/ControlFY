using FluentValidation;

namespace ControlFY.Estoque.Aplicacao.Produtos.Comandos.Base
{
    public class ProdutoValidadorBase<T> : AbstractValidator<T> where T : ProdutoComandoBase
    {
        public ProdutoValidadorBase()
        {
            RuleFor(x => x.ProdutoId)
                .NotEmpty()
                .WithMessage("O id do produto não foi informado.");

            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage("O nome do produto não foi informado");

            RuleFor(x => x.Descricao)
                .NotEmpty()
                .WithMessage("A descrição do produto não foi informada.");

            RuleFor(x => x.Valor)
                .NotEmpty()
                .WithMessage("O valor não foi informado");

            RuleFor(x => x.Quantidade)
                .NotEmpty()
                .WithMessage("A quantidade não foi informada.");
        }
    }
}
