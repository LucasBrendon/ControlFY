using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.Aplicacao.Comum.Contratos.Repositorio
{
    public interface IRepositorio<T> where T : class
    {
        Task<List<T>> Listar();
        Task<T> ConsultarPorId(Expression<Func<T, bool>> predicado);
        Task Cadastrar(T entidade);
        Task Atualizar(T entidade);
        Task Excluir(T entidade);
    }
}
