using Lezione8.Dev.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lezione8.Dev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShelfController : ControllerBase
    {
        private readonly LibraryDbContext _ctx;
        public ShelfController(LibraryDbContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_ctx.Shelves);
        }

        [HttpPost]
        public IActionResult Create(Shelf shelf)
        {
            _ctx.Shelves.Add(shelf);
            _ctx.SaveChanges();
            return Created();
        }
    }
}
