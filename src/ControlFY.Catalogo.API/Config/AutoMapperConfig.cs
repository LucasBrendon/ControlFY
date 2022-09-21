using AutoMapper;
using ControlFY.Catalogo.Aplicacao.Categorias.ViewModels;
using ControlFY.Catalogo.Aplicacao.Fornecedores.ViewModels;
using ControlFY.Catalogo.Aplicacao.Produtos.ViewModels;
using ControlFY.Catalogo.Dominio.Entidades;

namespace ControlFY.Catalogo.API.Config
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CategoriaViewModel, Categoria>().ReverseMap();
            CreateMap<FornecedorViewModel, Fornecedor>().ReverseMap();
            CreateMap<EnderecoViewModel, Endereco>().ReverseMap();
            CreateMap<ProdutoViewModel, Produto>().ReverseMap();
        }
    }
}
