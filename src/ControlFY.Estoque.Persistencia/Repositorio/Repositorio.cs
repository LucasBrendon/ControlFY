using ControlFY.Estoque.Aplicacao.Comum.Contratos.Repositorio;
using ControlFY.Estoque.Persistencia.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ControlFY.Estoque.Persistencia.Repositorio
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        private readonly ContextoEstoque _contexto;

        public Repositorio(ContextoEstoque contexto)
        {
            _contexto = contexto;
        }

        public virtual async Task<List<T>> Listar()
        {
            return await _contexto.Set<T>().AsNoTracking().ToListAsync();
        }

        public virtual async Task<T> ConsultarPorId(Expression<Func<T, bool>> predicado)
        {
            return await _contexto.Set<T>().AsNoTracking().Where(predicado).FirstOrDefaultAsync();
        }

        public virtual async Task Cadastrar(T entidade)
        {
            _contexto.Add(entidade);
            await _contexto.SaveChangesAsync();
        }

        public virtual async Task Atualizar(T entidade)
        {
            _contexto.Update(entidade);
            await _contexto.SaveChangesAsync();
        }

        public virtual async Task Excluir(T entidade)
        {

            _contexto.Remove(entidade);
            await _contexto.SaveChangesAsync();
        }
    }
}
