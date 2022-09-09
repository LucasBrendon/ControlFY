using ControlFY.Catalogo.Aplicacao.Categorias.Comandos.Criar;
using ControlFY.Catalogo.Aplicacao.Categorias.Comandos.Editar;
using ControlFY.Catalogo.Aplicacao.Categorias.Comandos.Remover;
using ControlFY.Catalogo.Aplicacao.Categorias.Consultas.ConsultarPorId;
using ControlFY.Catalogo.Aplicacao.Categorias.Consultas.ListarTodas;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.API.Controllers
{
    [ApiController]
    [Route("api/categoria")]
    public class CategoriaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ListarTodos()
        {
            return Ok(await _mediator.Send(new ListarTodosConsulta()));
        }

        [HttpGet]
        [Route("consultar-por-id")]
        public async Task<IActionResult> ConsultarPorId(long id)
        {
            return Ok(await _mediator.Send(new ConsultaPorIdComando(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Criar(CriarCategoriaComando comando)
        {
            return Ok(await _mediator.Send(comando));
        }

        [HttpPut]
        public async Task<IActionResult> Editar(EditarCategoriaComando comando)
        {
            return Ok(await _mediator.Send(comando));
        }

        [HttpDelete]
        public async Task<IActionResult> Remover(RemoverCategoriaComando comando)
        {
            return Ok(await _mediator.Send(comando));
        }
    } 
}
