using ControlFY.Catalogo.Aplicacao.Comum.Contratos.Repositorio;
using ControlFY.Catalogo.Dominio.Entidades;
using ControlFY.Catalogo.Persistencia.Contexto;

namespace ControlFY.Catalogo.Persistencia.Repositorio
{
    public class CategoriaRepositorio : Repositorio<Categoria>, ICategoriaRepositorio
    {
        public CategoriaRepositorio(ContextoCatalogo contexto) : base(contexto)
        {
        }
    }
}
