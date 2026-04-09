using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Data;

namespace WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class webApiController : ControllerBase
    {
        private readonly DataContext _context;

        public webApiController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreateEdit(Product product)
        {
            if(product.id == 0)
            {
                _context.products.Add(product);
            }
            else
            {
                var productInDatabase = _context.products.Find(product.id);
                if(productInDatabase == null) return NotFound();

                productInDatabase.name = product.name;
                productInDatabase.price = product.price;
            }
            _context.SaveChanges();

            return Ok(product);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.products.ToList());
        }
    }
}