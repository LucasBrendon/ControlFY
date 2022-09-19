using ControlFY.Catalogo.Aplicacao.Fornecedores.ViewModels;
using MediatR;

namespace ControlFY.Catalogo.Aplicacao.Fornecedores.Consultas.ListarPorId
{
    public class ListarFornecedorPorIdConsulta : IRequest<FornecedorViewModel>
    {
        public long? Id { get; set; }
    }
}
