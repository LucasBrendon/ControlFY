using ControlFY.Estoque.Aplicacao.Produtos.Comandos.Base;
using ControlFY.Estoque.Aplicacao.Produtos.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFY.Estoque.Aplicacao.Produtos.Comandos.Editar
{
    public class EditarProdutoComando : ProdutoComandoBase, IRequest<ProdutoViewModel>
    {
        public long? Id { get; set; }
    }
}
