using Lezione8.Dev.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lezione8.Dev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly LibraryDbContext _ctx;
        private readonly Logger _logger;
        public GenreController(LibraryDbContext ctx, Logger logger)
        {
            _ctx = ctx;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_ctx.Genres);
        }

        [HttpPost]
        public IActionResult Create(Genre genre)
        {
            _ctx.Genres.Add(genre);
            _ctx.SaveChanges();
            return Created();
        }
    }
}
