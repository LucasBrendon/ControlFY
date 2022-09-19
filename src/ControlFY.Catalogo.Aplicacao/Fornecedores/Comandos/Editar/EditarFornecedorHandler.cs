using AutoMapper;
using ControlFY.Catalogo.Aplicacao.Comum.Contratos.Repositorio;
using ControlFY.Catalogo.Aplicacao.Fornecedores.ViewModels;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.Aplicacao.Fornecedores.Comandos.Editar
{
    public class EditarFornecedorHandler : IRequestHandler<EditarFornecedorComando, FornecedorViewModel>
    {
        private readonly IFornecedorRepositorio _fornecedorRepositorio;
        private readonly IMapper _mapper;

        public EditarFornecedorHandler(IFornecedorRepositorio fornecedorRepositorio, IMapper mapper)
        {
            _fornecedorRepositorio = fornecedorRepositorio;
            _mapper = mapper;
        }

        public async Task<FornecedorViewModel> Handle(EditarFornecedorComando request, CancellationToken cancellationToken)
        {
            var fornecedor = await _fornecedorRepositorio.RetornarFornecedorEndereco(request.Id.Value);

            fornecedor.AtualizarFornecedor(request.Nome,
                                           request.Documento,
                                           request.TipoDocumento.Value,
                                           request.Telefone,
                                           request.Email);

            fornecedor.Endereco.AtualizarEndereco(request.Cep,
                                                  request.Logradouro,
                                                  request.Numero,
                                                  request.Bairro,
                                                  request.Cidade,
                                                  request.Estado,
                                                  request.Pais);

            await _fornecedorRepositorio.Atualizar(fornecedor);

            return _mapper.Map<FornecedorViewModel>(fornecedor);
        }
    }
}
