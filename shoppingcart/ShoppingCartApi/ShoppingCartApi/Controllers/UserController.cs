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
    public class UserController : Controller
    {

        private IUserRepository userRepository;
        public UserController(ShoppingCartContext context)
        {
            this.userRepository = new UserRepository(context);
        }

        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            return userRepository.GetUsers();
        }

        [HttpGet("{id}", Name = "GetUser")]
        public IActionResult GetById(int id)
        {
            var item = userRepository.GetUserByID(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}
