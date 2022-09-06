using ControlFY.Comum.Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace ControlFY.Catalogo.Dominio.Entidades
{
    public class Categoria : EntidadeBase
    {
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

        private void AtualizarCategoria(string nome)
        {
            Nome = nome;
            DataAtualizacao = DateTime.Now;
        }
    }
}
