using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace desafio.hyperativa.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartoesController : ControllerBase
    {
        private readonly ILogger<CartoesController> _logger;
        public CartoesController(ILogger<CartoesController> logger)
        {
            _logger = logger;
        }
        public IActionResult PostArquivo(IFormFile file)
        {
            _logger.LogInformation($"validating the file {file.FileName}");
            _logger.LogInformation("saving file");
            _logger.LogInformation("file saved.");
            return Ok();
        }
    }
}
