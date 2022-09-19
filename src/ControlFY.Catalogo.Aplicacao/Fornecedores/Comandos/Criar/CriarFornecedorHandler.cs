using AutoMapper;
using ControlFY.Catalogo.Aplicacao.Comum.Contratos.Repositorio;
using ControlFY.Catalogo.Aplicacao.Fornecedores.ViewModels;
using ControlFY.Catalogo.Dominio.Entidades;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.Aplicacao.Fornecedores.Comandos.Criar
{
    public class CriarFornecedorHandler : IRequestHandler<CriarFornecedorComando, FornecedorViewModel>
    {
        private readonly IFornecedorRepositorio _fornecedorRepositorio;
        private readonly IMapper _mapper;

        public CriarFornecedorHandler(IFornecedorRepositorio fornecedorRepositorio, IMapper mapper)
        {
            _fornecedorRepositorio = fornecedorRepositorio;
            _mapper = mapper;
        }

        public async Task<FornecedorViewModel> Handle(CriarFornecedorComando request, CancellationToken cancellationToken)
        {
            var fornecedor = new Fornecedor(request.Nome,
                                            request.Documento,
                                            request.TipoDocumento.Value,
                                            request.Telefone,
                                            request.Email);

            var endereco = new Endereco(request.Cep,
                                        request.Logradouro,
                                        request.Numero,
                                        request.Bairro,
                                        request.Cidade,
                                        request.Estado,
                                        request.Pais);

            fornecedor.VincularEndereco(endereco);

            await _fornecedorRepositorio.Cadastrar(fornecedor);

            return _mapper.Map<FornecedorViewModel>(fornecedor);
        }
    }
}
