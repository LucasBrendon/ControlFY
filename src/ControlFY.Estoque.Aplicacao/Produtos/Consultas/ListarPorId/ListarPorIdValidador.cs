using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFY.Estoque.Aplicacao.Produtos.Consultas.ListarPorId
{
    public class ListarPorIdValidador : AbstractValidator<ListarPorIdConsulta>
    {
        public ListarPorIdValidador()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("O id não foi informado.");
        }
    }
}
