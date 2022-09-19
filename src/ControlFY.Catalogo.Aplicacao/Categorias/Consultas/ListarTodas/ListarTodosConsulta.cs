using ControlFY.Catalogo.Aplicacao.Categorias.ViewModels;
using MediatR;
using System.Collections.Generic;

namespace ControlFY.Catalogo.Aplicacao.Categorias.Consultas.ListarTodas
{
    public class ListarTodosConsulta : IRequest<List<CategoriaViewModel>>
    {
    }
}
