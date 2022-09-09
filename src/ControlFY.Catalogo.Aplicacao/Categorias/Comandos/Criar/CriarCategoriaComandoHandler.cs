﻿using AutoMapper;
using ControlFY.Catalogo.Aplicacao.Categorias.ViewModels;
using ControlFY.Catalogo.Aplicacao.Comum.Contratos.Repositorio;
using ControlFY.Catalogo.Dominio.Entidades;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.Aplicacao.Categorias.Comandos.Criar
{
    public class CriarCategoriaComandoHandler : IRequestHandler<CriarCategoriaComando, CategoriaViewModel>
    {
        private readonly IMapper _mapper;
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public CriarCategoriaComandoHandler(IMapper mapper, ICategoriaRepositorio categoriaRepositorio)
        {
            _mapper = mapper;
            _categoriaRepositorio = categoriaRepositorio;
        }

        public async Task<CategoriaViewModel> Handle(CriarCategoriaComando request, CancellationToken cancellationToken)
        {
            var categoria = new Categoria(request.Nome);
            await _categoriaRepositorio.Cadastrar(categoria);

            return _mapper.Map<CategoriaViewModel>(categoria);
        }
    }
}
