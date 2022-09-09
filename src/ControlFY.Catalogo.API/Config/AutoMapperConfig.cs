using AutoMapper;
using ControlFY.Catalogo.Aplicacao.Categorias.ViewModels;
using ControlFY.Catalogo.Dominio.Entidades;

namespace ControlFY.Catalogo.API.Config
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CategoriaViewModel, Categoria>().ReverseMap();
        }
    }
}
