using System;
using System.Collections.Generic;

namespace ControlFY.Catalogo.Dominio.Entidades
{
    public class Categoria
    {
        public long Id { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime? DataAtualizacao { get; private set; }
        public ICollection<Produto> Produtos { get; private set; }

        protected Categoria()
        {
        }

        public Categoria(string nome)
        {
            Nome = nome;
            DataCadastro = DateTime.Now;
        }

        public void AtualizarCategoria(string nome)
        {
            Nome = nome;
            DataAtualizacao = DateTime.Now;
        }
    }
}
