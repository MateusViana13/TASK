using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB_API_TESTE.Service;

namespace WEB_API_TESTE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        private readonly IServiceTeste _serviceTeste;

        public TesteController(IServiceTeste serviceTeste)
        {
            _serviceTeste = serviceTeste;
        }

        [HttpGet("GetTeste01")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetTeste()
        {
            try
            {
                int count = await _serviceTeste.GetCountAsync();
                return Ok(count);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetTeste02")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetTeste2()
        {
            try
            {
                int count = await _serviceTeste.GetCountAsync_2();
                return Ok(count);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
