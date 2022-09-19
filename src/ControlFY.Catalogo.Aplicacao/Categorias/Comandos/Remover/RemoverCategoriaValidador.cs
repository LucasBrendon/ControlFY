using FluentValidation;

namespace ControlFY.Catalogo.Aplicacao.Categorias.Comandos.Remover
{
    public class RemoverCategoriaValidador : AbstractValidator<RemoverCategoriaComando>
    {
        public RemoverCategoriaValidador()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("O id não foi informado.");
        }
    }
}
