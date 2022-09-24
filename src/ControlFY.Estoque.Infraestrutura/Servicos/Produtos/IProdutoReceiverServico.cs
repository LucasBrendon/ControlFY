using ControlFY.Estoque.Infraestrutura.RabbitMq.ProdutoConsumer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFY.Estoque.Infraestrutura.Servicos.Produtos
{
    public interface IProdutoReceiverServico
    {
        Task CriarProduto(ProdutoReceiverViewModel receiver);
    }
}
