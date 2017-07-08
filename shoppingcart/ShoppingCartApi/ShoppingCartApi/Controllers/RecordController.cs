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
    public class RecordController : Controller
    {

        private IRecordRepository recordRepository;

        public RecordController(ShoppingCartContext context)
        {
            this.recordRepository = new RecordRepository(context);
        }

        [HttpGet]
        public IEnumerable<Record> GetAll()
        {
            return recordRepository.GetRecords();
        }

        [HttpGet("{id}", Name = "GetRecord")]
        public IActionResult GetById(int id)
        {
            var item = recordRepository.GetRecordByID(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}
