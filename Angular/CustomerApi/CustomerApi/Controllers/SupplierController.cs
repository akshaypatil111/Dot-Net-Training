using CustomerApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        CustomerDb1Context db;
        public SupplierController(CustomerDb1Context _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<Supplier> Get()
        {
            return db.Suppliers;
        }

        [HttpPost]
        public string Post([FromBody] Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
            return "success";
        }
    }
}