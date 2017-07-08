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
    public class RoleController : Controller
    {

        private IRoleRepository roleRepository;

        public RoleController(ShoppingCartContext context)
        {
            this.roleRepository = new RoleRepository(context);
        }

        [HttpGet]
        public IEnumerable<Role> GetAll()
        {
            return roleRepository.GetRoles();
        }

        [HttpGet("{id}", Name = "GetRole")]
        public IActionResult GetById(int id)
        {
            var item = roleRepository.GetRoleByID(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}
