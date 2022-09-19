using FluentValidation;

namespace ControlFY.Catalogo.Aplicacao.Produtos.Consultas.ListarPorId
{
    public class ListarProdutoPorIdValidador : AbstractValidator<ListarProdutoPorIdConsulta>
    {
        public ListarProdutoPorIdValidador()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("O id não foi informado.");
        }
    }
}
