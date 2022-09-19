using AutoMapper;
using ControlFY.Catalogo.Aplicacao.Comum.Contratos.Repositorio;
using ControlFY.Catalogo.Aplicacao.Fornecedores.ViewModels;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.Aplicacao.Fornecedores.Consultas.ListarTodos
{
    public class ListarFornecedoresHandler : IRequestHandler<ListarFornecedoresConsulta, List<FornecedorViewModel>>
    {
        private readonly IFornecedorRepositorio _fornecedorRepositorio;
        private readonly IMapper _mapper;

        public ListarFornecedoresHandler(IFornecedorRepositorio fornecedorRepositorio, IMapper mapper)
        {
            _fornecedorRepositorio = fornecedorRepositorio;
            _mapper = mapper;
        }

        public async Task<List<FornecedorViewModel>> Handle(ListarFornecedoresConsulta request, CancellationToken cancellationToken)
        {
            var fornecedores = await _fornecedorRepositorio.RetornarFornecedoresEndereco();

            return _mapper.Map<List<FornecedorViewModel>>(fornecedores);
        }
    }
}
