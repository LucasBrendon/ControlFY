using ControlFY.Catalogo.Aplicacao.Comum.Contratos.Repositorio;
using ControlFY.Catalogo.Dominio.Entidades;
using ControlFY.Catalogo.Persistencia.Contexto;

namespace ControlFY.Catalogo.Persistencia.Repositorio
{
    public class ProdutoRepositorio : Repositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(ContextoCatalogo contexto) : base(contexto)
        {
        }
    }
}
