using ControlFY.Catalogo.Aplicacao.Categorias.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.Aplicacao.Categorias.Consultas.ConsultarPorId
{
    public class ConsultaPorIdComando : IRequest<CategoriaViewModel>
    {
        public long? Id { get; set; }

        public ConsultaPorIdComando(long? id)
        {
            Id = id;
        }
    }
}
