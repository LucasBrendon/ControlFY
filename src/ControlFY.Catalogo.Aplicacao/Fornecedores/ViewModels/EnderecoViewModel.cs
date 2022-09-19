namespace ControlFY.Catalogo.Aplicacao.Fornecedores.ViewModels
{
    public class EnderecoViewModel
    {
        public long? Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public long FornecedorId { get; set; }
    }
}
