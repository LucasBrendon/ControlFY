using ControlFY.Catalogo.Dominio.Enums;
using System;

namespace ControlFY.Catalogo.Aplicacao.Fornecedores.ViewModels
{
    public class FornecedorViewModel
    {
        public long? Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public ETipoDocumento? TipoDocumento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public EnderecoViewModel Endereco { get; set; }
    }
}
