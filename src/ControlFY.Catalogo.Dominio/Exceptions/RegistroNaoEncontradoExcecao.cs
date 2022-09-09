using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.Dominio.Exceptions
{
    public class RegistroNaoEncontradoExcecao : Exception
    {
        public RegistroNaoEncontradoExcecao(string nome, object chave)
            : base($"O registro ({chave}) da entidade \"{nome}\" não foi encontrado.")
        {
        }
    }
}
