using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.Aplicacao.Produtos.Comandos.Remover
{
    public class RemoverProdutoValidador : AbstractValidator<RemoverProdutoComando>
    {
        public RemoverProdutoValidador()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("O id não foi informado.");
        }
    }
}
