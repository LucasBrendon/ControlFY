using ControlFY.Catalogo.Aplicacao.Produtos.Comandos.Criar;
using ControlFY.Catalogo.Aplicacao.Produtos.Comandos.Editar;
using ControlFY.Catalogo.Aplicacao.Produtos.Comandos.Remover;
using ControlFY.Catalogo.Aplicacao.Produtos.Consultas.ListarPorId;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.API.Controllers
{
    [ApiController]
    [Route("api/produto")]
    public class ProdutoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProdutoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("listar-por-id")]
        public async Task<IActionResult> ListarPorId(ListarProdutoPorIdConsulta consulta)
        {
            return Ok(await _mediator.Send(consulta));
        }

        [HttpPost]
        public async Task<IActionResult> Criar(CriarProdutoComando comando)
        {
            return Ok(await _mediator.Send(comando));
        }

        [HttpPut]
        public async Task<IActionResult> Editar(EditarProdutoComando comando)
        {
            return Ok(await _mediator.Send(comando));
        }

        [HttpDelete]
        public async Task<IActionResult> Deletar(RemoverProdutoComando comando)
        {
            return Ok(await _mediator.Send(comando));
        }
    }
}
