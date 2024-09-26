using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TasksMgmt.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {

        [Authorize]
        [HttpGet("tasks")]
        public IActionResult GetTasks()
        {
            return Content("Tasks");
        }
    }
}
