using FluentValidation;

namespace ControlFY.Catalogo.Aplicacao.Fornecedores.Consultas.ListarPorId
{
    public class ListarFornecedorPorIdValidador : AbstractValidator<ListarFornecedorPorIdConsulta>
    {
        public ListarFornecedorPorIdValidador()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("O id deve ser informado.");
        }
    }
}
