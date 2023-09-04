using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web_api.Models;
using web_api.Persistence;

namespace web_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly ProductDbContext _productDbContext;

        public ProductController(ILogger<ProductController> logger, ProductDbContext productDbContext)
        {
            _logger = logger;
            _productDbContext = productDbContext;
        }


        [HttpGet("get-all")]
        public List<Product> GetProducts()
        {
            return _productDbContext.Products.Where(p => true).ToList();
        }
        [HttpGet("create")]
        public Product CreateProduct(Product product)
        {
            _productDbContext.Products.Add(product);
            _productDbContext.SaveChanges();
            return product;
        }
    }
}