using ControlFY.Catalogo.Aplicacao.Fornecedores.Comandos.Base;
using ControlFY.Catalogo.Aplicacao.Fornecedores.ViewModels;
using MediatR;

namespace ControlFY.Catalogo.Aplicacao.Fornecedores.Comandos.Criar
{
    public class CriarFornecedorComando : FornecedorComandoBase, IRequest<FornecedorViewModel>
    {
    }
}
