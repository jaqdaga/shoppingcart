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
    public class SubcategoryController : Controller
    {

        private ISubcategoryRepository subcategoryRepository;

        public SubcategoryController(ShoppingCartContext context)
        {
            this.subcategoryRepository = new SubcategoryRepository(context);
        }

        [HttpGet]
        public IEnumerable<Subcategory> GetAll()
        {
            return subcategoryRepository.GetSubcategories();
        }

        [HttpGet("{id}", Name = "GetSubcategory")]
        public IActionResult GetById(int id)
        {
            var item = subcategoryRepository.GetSubcategoryByID(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}
