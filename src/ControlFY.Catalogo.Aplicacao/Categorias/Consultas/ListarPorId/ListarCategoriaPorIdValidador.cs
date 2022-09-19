using ControlFY.Catalogo.Aplicacao.Categorias.Consultas.ConsultarPorId;
using FluentValidation;

namespace ControlFY.Catalogo.Aplicacao.Categorias.Consultas.ListarPorId
{
    public class ListarCategoriaPorIdValidador : AbstractValidator<ListarCategoriaPorIdConsulta>
    {
        public ListarCategoriaPorIdValidador()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("O id não foi informando.");
        }
    }
}
