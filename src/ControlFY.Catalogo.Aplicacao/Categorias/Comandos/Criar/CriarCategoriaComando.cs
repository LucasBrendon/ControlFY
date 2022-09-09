using ControlFY.Catalogo.Aplicacao.Categorias.Comandos.Base;
using ControlFY.Catalogo.Aplicacao.Categorias.ViewModels;
using MediatR;

namespace ControlFY.Catalogo.Aplicacao.Categorias.Comandos.Criar
{
    public class CriarCategoriaComando : CriarCategoriaComandoBase, IRequest<CategoriaViewModel>
    {
        
    }
}
