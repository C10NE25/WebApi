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
        public JsonResult CreateEdit(Product product)
        {
            if(product.id == 0)
            {
                _context.products.Add(product);
            }
            else
            {
                var productInDatabase = _context.products.Find(product.id);
                if(productInDatabase == null)
                    return new JsonResult(NotFound());

                productInDatabase = product;
            }
            _context.SaveChanges();

            return new JsonResult(Ok(product));
        }
    }
}