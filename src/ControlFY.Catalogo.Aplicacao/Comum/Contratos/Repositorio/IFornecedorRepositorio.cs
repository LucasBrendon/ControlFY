using ControlFY.Catalogo.Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.Aplicacao.Comum.Contratos.Repositorio
{
    public interface IFornecedorRepositorio : IRepositorio<Fornecedor>
    {
        Task<Fornecedor> RetornarFornecedorEndereco(long id);
        Task<List<Fornecedor>> RetornarFornecedoresEndereco();
    }
}
