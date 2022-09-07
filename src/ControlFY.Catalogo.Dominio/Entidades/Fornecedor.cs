using ControlFY.Catalogo.Dominio.Enums;
using System;
using System.Collections.Generic;

namespace ControlFY.Catalogo.Dominio.Entidades
{
    public class Fornecedor
    {
        public long Id { get; private set; }
        public string Nome { get; private set; }
        public string Documento { get; private set; }
        public ETipoDocumento TipoDocumento { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime? DataAtualizacao { get; private set; }
        public Endereco Endereco { get; private set; }
        public ICollection<Produto> Produtos { get; set; }

        protected Fornecedor()
        {
        }

        public Fornecedor(string nome, string documento, ETipoDocumento tipoDocumento, string telefone, string email, Endereco endereco)
        {
            Nome = nome;
            Documento = documento;
            TipoDocumento = tipoDocumento;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
            DataCadastro = DateTime.Now;
        }

        public void AtualizarFornecedor(string nome, string documento, ETipoDocumento tipoDocumento, string telefone, string email, Endereco endereco)
        {
            Nome = nome;
            Documento = documento;
            TipoDocumento = tipoDocumento;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
            DataAtualizacao = DateTime.Now;
        }
    }
}
