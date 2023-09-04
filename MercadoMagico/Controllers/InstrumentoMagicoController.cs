using MercadoMagico.Models;
using MercadoMagico.Repositorios.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace MercadoMagico.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class InstrumentoMagicoController : ControllerBase
    {
        private readonly IInstrumentoMagicoRepositorio _instrumentoMagicoRepositorio;
        private readonly IInstrumentoMagicoEstatistica _estatistica;
        private readonly IInstrumentoMagicoBusca _busca;

        public InstrumentoMagicoController(
            IInstrumentoMagicoRepositorio instrumentoMagicoRepositorio,
            IInstrumentoMagicoEstatistica estatistica,
            IInstrumentoMagicoBusca busca)
        {
            _instrumentoMagicoRepositorio = instrumentoMagicoRepositorio;
            _estatistica = estatistica;
            _busca = busca;
        }

        [HttpGet]
        public async Task<ActionResult<List<InstrumentoMagicoModel>>> ListAll()
        {
            List<InstrumentoMagicoModel> instrumentosMagicos = await _instrumentoMagicoRepositorio.ListAll();
            return Ok(instrumentosMagicos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InstrumentoMagicoModel>> GetById(int id)
        {
            InstrumentoMagicoModel instrumentoMagico = await _instrumentoMagicoRepositorio.GetById(id);

            return Ok(instrumentoMagico);

        }

        [HttpPost]
        public async Task<ActionResult<InstrumentoMagicoModel>> Add([FromBody] InstrumentoMagicoModel instrumentoMagicoModel)
        {
            InstrumentoMagicoModel instrumentoMagico = await _instrumentoMagicoRepositorio.Add(instrumentoMagicoModel);

            return Ok(instrumentoMagico);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<InstrumentoMagicoModel>> Update([FromBody] InstrumentoMagicoModel instrumentoMagicoModel, int id)
        {
            instrumentoMagicoModel.Id = id; 
            InstrumentoMagicoModel instrumentoMagico = await _instrumentoMagicoRepositorio.Update(instrumentoMagicoModel, id);

            return Ok(instrumentoMagico);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<InstrumentoMagicoModel>> Delete(int id)
        {
            bool apagado = await _instrumentoMagicoRepositorio.Delete(id);

            return Ok(apagado);
        }

        [HttpGet("CalculateTotalPriceByType")]
        public IActionResult CalculateTotalPriceByType(string tipo)
        {
            decimal totalPrice = _estatistica.CalculateTotalPriceByType(tipo);

            return Ok(totalPrice);
        }

        [HttpGet("SearchByMagicProperty")]
        public IActionResult SearchByMagicProperty(string searchTerm)
        {
            var result = _busca.SearchByMagicProperty(searchTerm);

            return Ok(result);
        }
    }
}
