using ControlFY.Catalogo.Aplicacao.Categorias.Comandos.Base;
using ControlFY.Catalogo.Aplicacao.Categorias.ViewModels;
using MediatR;

namespace ControlFY.Catalogo.Aplicacao.Categorias.Comandos.Editar
{
    public class EditarCategoriaComando : CategoriaComandoBase, IRequest<CategoriaViewModel>
    {
        public long? Id { get; set; }
    }
}
