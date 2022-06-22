using E_Commerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ecartContext db;
        public ProductController(ecartContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return db.TblProducts;
        }
    }
}