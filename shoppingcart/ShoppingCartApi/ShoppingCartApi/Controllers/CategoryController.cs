using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartApi.Data;
using ShoppingCartApi.Models;
using ShoppingCartApi.DAL;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingCartApi.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {

        private ICategoryRepository categoryRepository;

        public CategoryController(ShoppingCartContext context)
        {
            this.categoryRepository = new CategoryRepository(context);
        }

        [HttpGet]
        [Authorize]
        public IEnumerable<Category> GetAll()
        {
            return categoryRepository.GetCategories();
        }

        [HttpGet("{id}", Name = "GetCategory")]
        public IActionResult GetById(int id)
        {
            var item = categoryRepository.GetCategoryByID(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}
