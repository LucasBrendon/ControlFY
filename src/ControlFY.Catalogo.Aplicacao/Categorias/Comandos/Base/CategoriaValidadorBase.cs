using FluentValidation;

namespace ControlFY.Catalogo.Aplicacao.Categorias.Comandos.Base
{
    public abstract class CategoriaValidadorBase<T> : AbstractValidator<T> where T : CategoriaComandoBase
    {
        public CategoriaValidadorBase()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage("O nome não foi informado.");
        }
    }
}
