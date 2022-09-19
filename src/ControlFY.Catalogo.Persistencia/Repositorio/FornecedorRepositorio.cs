using ControlFY.Catalogo.Aplicacao.Comum.Contratos.Repositorio;
using ControlFY.Catalogo.Dominio.Entidades;
using ControlFY.Catalogo.Persistencia.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.Persistencia.Repositorio
{
    public class FornecedorRepositorio : Repositorio<Fornecedor>, IFornecedorRepositorio
    {
        private readonly ContextoCatalogo _contexto;

        public FornecedorRepositorio(ContextoCatalogo contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public async Task<Fornecedor> RetornarFornecedorEndereco(long id)
        {
            return await _contexto.Fornecedores.Where(x => x.Id == id).Include(x => x.Endereco).FirstOrDefaultAsync();
        }

        public async Task<List<Fornecedor>> RetornarFornecedoresEndereco()
        {
            return await _contexto.Fornecedores.AsNoTracking().Include(x => x.Endereco).ToListAsync();
        }
    }
}
