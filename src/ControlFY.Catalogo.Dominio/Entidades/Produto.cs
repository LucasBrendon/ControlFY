using System;

namespace ControlFY.Catalogo.Dominio.Entidades
{
    public class Produto
    {
        public long Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime? DataAtualizacao { get; private set; }
        public long CategoriaId { get; private set; }
        public long FornecedorId { get; private set; }
        public Fornecedor Fornecedor { get; private set; }
        public Categoria Categoria { get; private set; }

        protected Produto()
        {
        }

        public Produto(string nome, string descricao, decimal valor, long categoriaId, long fornecedorId)
        {
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            CategoriaId = categoriaId;
            FornecedorId = fornecedorId;
            DataCadastro = DateTime.Now;
        }

        public void AtualizarProduto(string nome, string descricao, decimal valor, long categoriaId, long fornecedorId)
        {
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            CategoriaId = categoriaId;
            FornecedorId = fornecedorId;
            DataAtualizacao = DateTime.Now;
        }
    }
}
