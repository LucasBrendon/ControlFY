using FluentValidation;

namespace ControlFY.Catalogo.Aplicacao.Produtos.Comandos.Base
{
    public class ProdutoValidadorBase<T> : AbstractValidator<T> where T : ProdutoComandoBase
    {
        public ProdutoValidadorBase()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage("o nome deve ser informado.");

            RuleFor(x => x.Descricao)
                .NotEmpty()
                .WithMessage("A decrição deve ser informado.");

            RuleFor(x => x.Valor)
                .NotEmpty()
                .WithMessage("O valor não foi informado.");

            RuleFor(x => x.CategoriaId)
                .NotEmpty()
                .WithMessage("A categoria deve ser informada.");

            RuleFor(x => x.FornecedorId)
                .NotEmpty()
                .WithMessage("O fornecedor deve ser informado.");
        }
    }
}
