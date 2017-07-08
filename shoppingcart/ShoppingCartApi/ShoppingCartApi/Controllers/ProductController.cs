using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartApi.Data;
using ShoppingCartApi.Models;
using ShoppingCartApi.DAL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingCartApi.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {

        private IProductRepository productRepository;

        public ProductController(ShoppingCartContext context)
        {
            this.productRepository = new ProductRepository(context);
        }

        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            return productRepository.GetProducts();
        }

        [HttpGet("{id}", Name = "GetProduct")]
        public IActionResult GetById(int id)
        {
            var item = productRepository.GetProductByID(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}
