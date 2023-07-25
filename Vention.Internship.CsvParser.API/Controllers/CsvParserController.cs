using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vention.Internship.CsvParser.Service.Services;

namespace Vention.Internship.CsvParser.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CsvParserController : ControllerBase
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IUserService userService;
        public CsvParserController(IWebHostEnvironment webHostEnvironment, IUserService userService)
        {
            this.webHostEnvironment = webHostEnvironment;
            this.userService = userService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("CSV file is parsing...");
        }

        [HttpPost]
        [Route("upload")]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("No file uploaded.");

            string wwwrootPath = webHostEnvironment.WebRootPath;

            var newAddedUsers = await userService.CreateUserAsync(file, wwwrootPath);

            return Ok(newAddedUsers);
        }
    }
}
