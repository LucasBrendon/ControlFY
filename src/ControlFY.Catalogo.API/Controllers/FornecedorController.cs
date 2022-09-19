using ControlFY.Catalogo.Aplicacao.Fornecedores.Comandos.Criar;
using ControlFY.Catalogo.Aplicacao.Fornecedores.Comandos.Editar;
using ControlFY.Catalogo.Aplicacao.Fornecedores.Comandos.Remover;
using ControlFY.Catalogo.Aplicacao.Fornecedores.Consultas.ListarPorId;
using ControlFY.Catalogo.Aplicacao.Fornecedores.Consultas.ListarTodos;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.API.Controllers
{
    [ApiController]
    [Route("api/fornecedores")]
    public class FornecedorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FornecedorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ListarTodos()
        {
            return Ok(await _mediator.Send(new ListarFornecedoresConsulta()));
        }

        [HttpGet]
        [Route("listar-por-id")]
        public async Task<IActionResult> ListarPorId(ListarFornecedorPorIdConsulta consulta)
        {
            return Ok(await _mediator.Send(consulta));
        }

        [HttpPost]
        public async Task<IActionResult> Criar(CriarFornecedorComando comando)
        {
            return Ok(await _mediator.Send(comando));
        }

        [HttpPut]
        public async Task<IActionResult> Atualizar(EditarFornecedorComando comando)
        {
            return Ok(await _mediator.Send(comando));
        }

        [HttpDelete]
        public async Task<IActionResult> Remover(RemoverFornecedorComando comando)
        {
            return Ok(await _mediator.Send(comando));
        }
    }
}
