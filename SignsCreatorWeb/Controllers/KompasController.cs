using Microsoft.AspNetCore.Mvc;
using SignsCreatorWeb.Application.Interfaces;

namespace SignsCreatorWeb.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    public class KompasController: ControllerBase
    {
        private readonly IKompasService _kompasService;
        public KompasController(IKompasService kompasService)
        {
            _kompasService=kompasService;
            
        }
        [HttpPost("OpenKompas")]
        public async Task<ActionResult> OpenKompas()
        {
            bool startKompas = _kompasService.OpenKompas();

            return Ok();
        }
    }
}
