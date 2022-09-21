using ControlFY.Estoque.Aplicacao.Produtos.Comandos.Criar;
using ControlFY.Estoque.Aplicacao.Produtos.Comandos.Editar;
using ControlFY.Estoque.Aplicacao.Produtos.Comandos.Remover;
using ControlFY.Estoque.Aplicacao.Produtos.Consultas.ListarPorId;
using ControlFY.Estoque.Aplicacao.Produtos.Consultas.ListarTodas;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ControlFY.Estoque.API.Controllers
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
        public async Task<IActionResult> ListarTodos()
        {
            return Ok(await _mediator.Send(new ListarTodosConsulta()));
        }

        [HttpGet]
        [Route("listar-por-id")]
        public async Task<IActionResult> ListarPorId(ListarPorIdConsulta consulta)
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
