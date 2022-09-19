using ControlFY.Catalogo.Aplicacao.Fornecedores.Comandos.Base;
using ControlFY.Catalogo.Aplicacao.Fornecedores.ViewModels;
using MediatR;

namespace ControlFY.Catalogo.Aplicacao.Fornecedores.Comandos.Editar
{
    public class EditarFornecedorComando : FornecedorComandoBase, IRequest<FornecedorViewModel>
    {
        public long? Id { get; set; }
    }
}
