using AgendaContatos.Domain.Commands.Usuario.AdicionarUsuario;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaContatos.Api.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsuarioController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarUsuario([FromBody] AdicionarUsuarioRequest command) 
        {
            var response = await _mediator.Send(command).ConfigureAwait(false);

            if (response.Notificacoes.Any())
                return BadRequest(response.Notificacoes);

            return Ok(response.Resposta);
        }

    }
}