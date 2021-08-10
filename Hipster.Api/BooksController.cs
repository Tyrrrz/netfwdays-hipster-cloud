using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hipster.Api
{
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly DatabaseContext _db;

        public BooksController(DatabaseContext db)
        {
            _db = db;
        }

        [HttpGet("/")]
        [ProducesResponseType(typeof(Book[]), 200)]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _db.Books.ToArrayAsync();
            return Ok(books);
        }
    }
}