using ControlFY.Catalogo.Aplicacao.Categorias.ViewModels;
using MediatR;

namespace ControlFY.Catalogo.Aplicacao.Categorias.Consultas.ConsultarPorId
{
    public class ListarCategoriaPorIdConsulta : IRequest<CategoriaViewModel>
    {
        public long? Id { get; set; }

    }
}
