using ControlFY.Catalogo.Aplicacao.Categorias.ViewModels;
using MediatR;

namespace ControlFY.Catalogo.Aplicacao.Categorias.Comandos.Editar
{
    public class EditarCategoriaComando : IRequest<CategoriaViewModel>
    {
        public long? Id { get; set; }
        public string Nome { get; set; }
    }
}
