using ControlFY.Catalogo.Aplicacao.Fornecedores.Comandos.Base;
using FluentValidation;

namespace ControlFY.Catalogo.Aplicacao.Fornecedores.Comandos.Editar
{
    public class EditarFornecedorValidador : FornecedorValidadorBase<EditarFornecedorComando>
    {
        public EditarFornecedorValidador()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("O id do fornecedor não foi informado.");
        }
    }
}
