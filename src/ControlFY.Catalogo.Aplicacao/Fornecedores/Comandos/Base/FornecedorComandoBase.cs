using ControlFY.Catalogo.Dominio.Enums;

namespace ControlFY.Catalogo.Aplicacao.Fornecedores.Comandos.Base
{
    public class FornecedorComandoBase
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public ETipoDocumento? TipoDocumento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
    }
}
