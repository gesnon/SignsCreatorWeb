using Microsoft.AspNetCore.Mvc;
using SignsCreatorWeb.Application.Interfaces;
using SignsCreatorWeb.Models;

namespace SignsCreatorWeb.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    public class MainController : ControllerBase
    {
        private readonly IKompasService _kompasService;
        public MainController(IKompasService kompasService)
        {
            _kompasService = kompasService;

        }


        [HttpPost("RunTask")]
        public async Task<ActionResult> RunTask([FromBody] Command command)
        {
            //Тестовый коммит 3
            return Ok();
        }



        [HttpPost("OpenKompas")]
        public async Task<ActionResult> OpenKompas()
        {
            bool startKompas = _kompasService.OpenKompas();

            return Ok();
        }




    }
}
