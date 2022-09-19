using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.Aplicacao.Produtos.Comandos.Remover
{
    public class RemoverProdutoComando : IRequest
    {
        public long? Id { get; set; }
    }
}
