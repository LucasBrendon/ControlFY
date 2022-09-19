using ControlFY.Catalogo.Aplicacao.Fornecedores.ViewModels;
using MediatR;
using System.Collections.Generic;

namespace ControlFY.Catalogo.Aplicacao.Fornecedores.Consultas.ListarTodos
{
    public class ListarFornecedoresConsulta : IRequest<List<FornecedorViewModel>>
    {
    }
}
