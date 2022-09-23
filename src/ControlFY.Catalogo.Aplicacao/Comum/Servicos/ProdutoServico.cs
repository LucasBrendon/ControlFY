using ControlFY.Catalogo.Aplicacao.Comum.Contratos.Servicos;
using ControlFY.Catalogo.Dominio.Entidades;
using ControlFY.Catalogo.Infraestrutura.RabbitMq.ProdutoSender;

namespace ControlFY.Catalogo.Aplicacao.Comum.Servicos
{
    public class ProdutoServico : IProdutoServico
    {
        private readonly IProdutoSender _produtoSender;

        public ProdutoServico(IProdutoSender produtoSender)
        {
            _produtoSender = produtoSender;
        }

        public void PublicarProduto(Produto produto)
        {
            var mensagem = new ProdutoEnvioViewModel(produto.Id, produto.Nome, produto.Descricao, produto.Valor, 1);

            _produtoSender.PublicarNaFila(mensagem);
        }
    }
}
