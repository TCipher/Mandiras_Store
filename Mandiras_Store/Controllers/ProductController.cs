using Mandiras_Store.Data;
using Mandiras_Store.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mandiras_Store.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductController: ControllerBase
    {
        private readonly StoreContext _context;
        public ProductController(StoreContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>>GetAllProduct()
        {
            var allProducts = await  _context.Products.ToListAsync();
             return  Ok(allProducts);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>>GetProduct(int id)
        {
            var Product = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
            if(Product == null)
            return NotFound();
            return Ok(Product);
        }

        [HttpPost]
        public async Task<ActionResult<Product>>CreateProduct([FromBody]Product product)
        {
            if(product == null)
            {
                    return BadRequest("Resources cannot be null");
            }
           try
           {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
 

           }
           catch (Exception ex)
           {
            return StatusCode(500, $"Internal server error: {ex.Message}");
           }
           return Ok();

        }
    }
}