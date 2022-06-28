using EcommerceWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CategoryController : ControllerBase
    {
        EcommerceContext db;
        public CategoryController(EcommerceContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<TblCategory> GetCategory()
        {
            return db.TblCategories;
        }
        [HttpPost]
        public string post([FromBody] TblCategory ct)
        {
            db.TblCategories.Add(ct);
            db.SaveChanges();
            return "Success";
        }
    }
}
