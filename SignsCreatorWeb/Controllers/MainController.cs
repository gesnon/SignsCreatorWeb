using Microsoft.AspNetCore.Mvc;
using SignsCreatorWeb.Application.Interfaces;
using SignsCreatorWeb.Application.Models;
using SignsCreatorWeb.Models;

namespace SignsCreatorWeb.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    public class MainController : ControllerBase
    {
        private readonly ITaskService _taskService;
        public MainController(ITaskService taskService)
        {
            _taskService = taskService;
        }


        [HttpPost("RunTask")]
        public async Task<ActionResult> RunTask([FromBody] Command command)
        {

            if (!string.IsNullOrEmpty(command.Data))
            {
                int Id = await _taskService.CreateAsync(new Application.Models.Task { State=State.Open, Data = command.Data, Type= command.Type });
                if (Id != 0)
                {
                    return Ok();
                }
            }

            return BadRequest();
        }

    }
}
