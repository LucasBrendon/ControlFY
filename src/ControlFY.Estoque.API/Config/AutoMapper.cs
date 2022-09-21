using AutoMapper;
using ControlFY.Estoque.Aplicacao.Produtos.ViewModels;
using ControlFY.Estoque.Dominio.Entidades;

namespace ControlFY.Estoque.API.Config
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }
    }
}
