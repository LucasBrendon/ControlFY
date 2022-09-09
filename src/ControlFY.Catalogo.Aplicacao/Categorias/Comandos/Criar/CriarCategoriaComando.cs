using ControlFY.Catalogo.Aplicacao.Categorias.ViewModels;
using MediatR;

namespace ControlFY.Catalogo.Aplicacao.Categorias.Comandos.Criar
{
    public class CriarCategoriaComando : IRequest<CategoriaViewModel>
    {
        public string Nome { get; set; }
    }
}
