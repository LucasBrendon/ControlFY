using FluentValidation;

namespace ControlFY.Catalogo.Aplicacao.Fornecedores.Comandos.Remover
{
    public class RemoverFornecedorValidador : AbstractValidator<RemoverFornecedorComando>
    {
        public RemoverFornecedorValidador()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("O id não foi informado.");
        }
    }
}
