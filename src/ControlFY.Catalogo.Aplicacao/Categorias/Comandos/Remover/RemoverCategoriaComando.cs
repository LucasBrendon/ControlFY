using MediatR;

namespace ControlFY.Catalogo.Aplicacao.Categorias.Comandos.Remover
{
    public class RemoverCategoriaComando : IRequest
    {
        public long? Id { get; set; }
    }
}
