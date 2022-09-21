using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ControlFY.Estoque.Aplicacao.Comum.Contratos.Repositorio
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
