using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace TimeTrackerServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductivityController : ControllerBase
    {
        private static readonly string[] Applications = new[]
        {
            "Visual Studio", "Google Chrome", "Microsoft Word", "Outlook", "Teams"
        };

        [HttpGet]
        public IActionResult Get()
        {
            var stats = new
            {
                Date = DateTime.Now.ToString("yyyy-MM-dd"),
                WorkTime = new Random().Next(120, 360),
                BreakTime = new Random().Next(30, 120),
                EntertainmentTime = new Random().Next(60, 180),
                ActiveApplications = Applications.Take(new Random().Next(2, 5)).ToArray(),
                LastUpdated = DateTime.Now
            };

            return Ok(stats);
        }
    }

    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var tasks = new[]
            {
                new { Id = 1, Name = "Complete Docker assignment", Completed = true },
                new { Id = 2, Name = "Write client application", Completed = false },
                new { Id = 3, Name = "Test Docker Compose", Completed = false }
            };

            return Ok(tasks);
        }
    }
}