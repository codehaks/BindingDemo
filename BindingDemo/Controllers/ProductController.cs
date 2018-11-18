using BindingDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace BindingDemo.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        #region Create

       
        public IActionResult Index()
        {
            _logger.LogInformation("Index->Done!");
            return Ok("Done!");
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Get([FromQuery]Product model)
        {
            var message = $"Get -> price={model.Price} , name ={model.Name}";

            _logger.LogInformation(message);

            return Ok(message);
        }

        #endregion

        #region Complex Types        

        public IActionResult CreateInfo()
        {
            return View();
        }

        public IActionResult GetInfo(ProductInfo model)
        {
            var message = $"Get -> Price={model.Price},Name ={model.Name} | Maker.Name ={model.Maker.Name}, Maker.Country={model.Maker.Country}";

            _logger.LogInformation(message);

            return Ok(message);
        }

        #endregion

        #region Collection

        public IActionResult CreateList()
        {
            return View();
        }

        public IActionResult GetList(IList<Product> products)
        {
            var message = "Get -> \n";
            for (int i = 0; i < 3; i++)
            {
                message += $"price={products[i].Price} , name ={products[i].Name} \n";
            }

            _logger.LogInformation(message);

            return Ok(message);
        }

        #endregion
    }
}