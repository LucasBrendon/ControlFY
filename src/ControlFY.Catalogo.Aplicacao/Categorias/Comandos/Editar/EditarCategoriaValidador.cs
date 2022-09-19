using FluentValidation;

namespace ControlFY.Catalogo.Aplicacao.Categorias.Comandos.Editar
{
    public class EditarCategoriaValidador : AbstractValidator<EditarCategoriaComando>
    {
        public EditarCategoriaValidador()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("O id não foi informado.");
        }
    }
}
