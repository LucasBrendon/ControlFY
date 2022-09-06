using ControlFY.Comum.Dominio.Entidades;

namespace ControlFY.Catalogo.Dominio.Entidades
{
    public class Endereco : EntidadeBase
    {
        public string Cep { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Pais { get; private set; }
        public long FornecedorId { get; private set; }
        public Fornecedor Fornecedor { get; private set; }

        protected Endereco()
        {
        }

        public Endereco(string cep, string logradouro, string numero, string bairro, string cidade, string estado, string pais)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
        }

        private void AtualizarEndereco(string cep, string logradouro, string numero, string bairro, string cidade, string estado, string pais)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
        }
    }
}
