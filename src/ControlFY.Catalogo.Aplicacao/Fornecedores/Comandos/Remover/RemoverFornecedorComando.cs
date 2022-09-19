using MediatR;

namespace ControlFY.Catalogo.Aplicacao.Fornecedores.Comandos.Remover
{
    public class RemoverFornecedorComando : IRequest
    {
        public long? Id { get; set; }
    }
}
