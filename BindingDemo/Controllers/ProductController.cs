using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BindingDemo.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            _logger.LogInformation("Index->Done!");
            return Ok("Done!");
        }
    }
}