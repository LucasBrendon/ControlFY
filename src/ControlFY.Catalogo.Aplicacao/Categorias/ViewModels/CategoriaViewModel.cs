using System;

namespace ControlFY.Catalogo.Aplicacao.Categorias.ViewModels
{
    public class CategoriaViewModel
    {
        public long? Id { get; set; }
        public string Nome { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
