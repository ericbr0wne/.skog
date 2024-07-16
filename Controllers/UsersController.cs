using Microsoft.AspNetCore.Mvc;
using dotSkog.Data;
using dotSkog.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace dotSkog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase

    {
        public readonly MyDbContext _context;

        public UsersController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

    }
}
