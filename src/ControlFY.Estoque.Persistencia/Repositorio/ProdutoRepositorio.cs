using ControlFY.Estoque.Aplicacao.Comum.Contratos.Repositorio;
using ControlFY.Estoque.Dominio.Entidades;
using ControlFY.Estoque.Persistencia.Contexto;

namespace ControlFY.Estoque.Persistencia.Repositorio
{
    public class ProdutoRepositorio : Repositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(ContextoEstoque contexto) : base(contexto)
        {
        }
    }
}
