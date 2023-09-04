using MercadoMagico.Models;
using MercadoMagico.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MercadoMagico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioModel>> GetById(int id)
        {
            UsuarioModel usuario = await _usuarioRepositorio.GetById(id);

            return Ok(usuario);

        }

        [HttpPost]
        public async Task<ActionResult<UsuarioModel>> Add([FromBody] UsuarioModel usuarioModel)
        {
            UsuarioModel usuario = await _usuarioRepositorio.Add(usuarioModel);

            return Ok(usuario);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<UsuarioModel>> Delete(int id)
        {
            bool apagado = await _usuarioRepositorio.Delete(id);

            return Ok(apagado);
        }
    }
}
