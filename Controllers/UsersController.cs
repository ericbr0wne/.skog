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

        //PUT: api/users/{id}
        [HttpPut("{id}")] // update a user
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.UserId)
            {
                return BadRequest();
            }
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent(); // GREAT SUCCESS, no content to return
        }

        //DELETE: api/users/{id}
        [HttpDelete("{id}")] // Delete a user
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null )
            {
                return NotFound();               
            }
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    
    }
}
