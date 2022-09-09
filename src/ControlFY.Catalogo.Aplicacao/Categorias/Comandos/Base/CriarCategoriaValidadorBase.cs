using FluentValidation;

namespace ControlFY.Catalogo.Aplicacao.Categorias.Comandos.Base
{
    public abstract class CriarCategoriaValidadorBase<T> : AbstractValidator<T> where T : CriarCategoriaComandoBase
    {
        public CriarCategoriaValidadorBase()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage("O nome não foi informado.");
        }
    }
}
