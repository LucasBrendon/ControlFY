using FluentValidation;

namespace ControlFY.Catalogo.Aplicacao.Fornecedores.Comandos.Base
{
    public class FornecedorValidadorBase<T> : AbstractValidator<T> where T : FornecedorComandoBase
    {
        public FornecedorValidadorBase()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage("O nome não foi informado.");

            RuleFor(x => x.Documento)
                .NotEmpty()
                .WithMessage("O documento não foi informado.");

            RuleFor(x => x.TipoDocumento)
                .NotEmpty()
                .WithMessage("O tipo de documento não foi informado.");

            RuleFor(x => x.Telefone)
                .NotEmpty()
                .WithMessage("O telefone não foi informado.");

            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("O email não foi informado.");

            RuleFor(x => x.Cep)
                .NotEmpty()
                .WithMessage("O cep não foi informado.");

            RuleFor(x => x.Logradouro)
                .NotEmpty()
                .WithMessage("O logradouro não foi informado.");

            RuleFor(x => x.Numero)
                .NotEmpty()
                .WithMessage("O número não foi informado.");

            RuleFor(x => x.Bairro)
                .NotEmpty()
                .WithMessage("O bairro não foi informado.");

            RuleFor(x => x.Cidade)
               .NotEmpty()
               .WithMessage("A cidade não foi informado.");

            RuleFor(x => x.Estado)
               .NotEmpty()
               .WithMessage("O estado não foi informado.");

            RuleFor(x => x.Pais)
               .NotEmpty()
               .WithMessage("O país não foi informado.");
        }
    }
}
