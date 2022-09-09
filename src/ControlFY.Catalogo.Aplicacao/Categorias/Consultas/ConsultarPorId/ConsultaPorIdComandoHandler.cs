using AutoMapper;
using ControlFY.Catalogo.Aplicacao.Categorias.ViewModels;
using ControlFY.Catalogo.Aplicacao.Comum.Contratos.Repositorio;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.Aplicacao.Categorias.Consultas.ConsultarPorId
{
    public class ConsultaPorIdComandoHandler : IRequestHandler<ConsultaPorIdComando, CategoriaViewModel>
    {
        private readonly IMapper _mapper;
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public ConsultaPorIdComandoHandler(IMapper mapper, ICategoriaRepositorio categoriaRepositorio)
        {
            _mapper = mapper;
            _categoriaRepositorio = categoriaRepositorio;
        }

        public async Task<CategoriaViewModel> Handle(ConsultaPorIdComando request, CancellationToken cancellationToken)
        {
            var categoria = await _categoriaRepositorio.ConsultarPorId(x => x.Id == request.Id);

            return _mapper.Map<CategoriaViewModel>(categoria);
        }
    }
}
