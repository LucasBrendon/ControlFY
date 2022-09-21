using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using ControlFY.Estoque.Dominio.Exceptions;

namespace ControlFY.Estoque.API.Filtros
{
    public class FiltroExcecao : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            if (context.Exception is ValidacaoExcecao)
            {
                context.HttpContext.Response.ContentType = "application/json";
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                context.Result = new JsonResult(
                    ((ValidacaoExcecao)context.Exception).Validacoes);

                return;
            }

            var code = HttpStatusCode.InternalServerError;

            if (context.Exception is RegistroNaoEncontradoExcecao)
                code = HttpStatusCode.NotFound;

            context.HttpContext.Response.ContentType = "application/json";
            context.HttpContext.Response.StatusCode = (int)code;
            context.Result = new JsonResult(new
            {
                error = new[] { context.Exception.Message },
                stackTrace = context.Exception.StackTrace
            });
        }
    }
}
