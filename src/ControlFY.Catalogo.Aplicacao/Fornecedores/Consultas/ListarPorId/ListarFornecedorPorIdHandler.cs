using AutoMapper;
using ControlFY.Catalogo.Aplicacao.Comum.Contratos.Repositorio;
using ControlFY.Catalogo.Aplicacao.Fornecedores.ViewModels;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.Aplicacao.Fornecedores.Consultas.ListarPorId
{
    public class ListarFornecedorPorIdHandler : IRequestHandler<ListarFornecedorPorIdConsulta, FornecedorViewModel>
    {
        private readonly IFornecedorRepositorio _fornecedorRepositorio;
        private readonly IMapper _mapper;

        public ListarFornecedorPorIdHandler(IFornecedorRepositorio fornecedorRepositorio, IMapper mapper)
        {
            _fornecedorRepositorio = fornecedorRepositorio;
            _mapper = mapper;
        }

        public async Task<FornecedorViewModel> Handle(ListarFornecedorPorIdConsulta request, CancellationToken cancellationToken)
        {
            var fornecedor = await _fornecedorRepositorio.RetornarFornecedorEndereco(request.Id.Value);

            return _mapper.Map<FornecedorViewModel>(fornecedor);
        }
    }
}
