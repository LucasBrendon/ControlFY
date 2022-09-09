using ControlFY.Catalogo.Aplicacao.Categorias.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.Aplicacao.Categorias.Consultas.ListarTodas
{
    public class ListarTodosConsulta : IRequest<List<CategoriaViewModel>>
    {
    }
}
