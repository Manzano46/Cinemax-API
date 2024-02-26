using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cinemax.API.Models;

[Route("api/[controller]")]
[ApiController]
// [Authorize] // Requiere que el usuario esté autenticado para acceder a cualquier método de este controlador
public class UsersController : ControllerBase
{
    private readonly AppDbContext _context;

    public UsersController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/Users
    [HttpGet]
    // [Authorize(Roles = "Admin")] // Solo los usuarios con el rol de "Admin" pueden listar todos los usuarios
    public async Task<ActionResult<IEnumerable<User>>> GetUsers()
    {
        return await _context.Users.Include(u => u.RoleUsers)
                                   .Include(u => u.CardUsers)
                                   .Include(u => u.Tickets)
                                   .ToListAsync();
    }

    // GET: api/Users/5
    [HttpGet("{userId}")]
    public async Task<ActionResult<User>> GetUser(int userId)
    {
        var user = await _context.Users.Include(u => u.RoleUsers)
                                        .Include(u => u.CardUsers)
                                        .Include(u => u.Tickets)
                                        .FirstOrDefaultAsync(u => u.UserId == userId);

        if (user == null)
        {
            return NotFound();
        }

        return user;
    }

    // POST: api/Users
    [HttpPost]
    // [Authorize(Roles = "Admin")] // Solo los usuarios con el rol de "Admin" pueden crear usuarios
    public async Task<ActionResult<User>> PostUser(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetUser), new { userId = user.UserId }, user);
    }

    // PUT: api/Users/5
    [HttpPut("{userId}")]
    // [Authorize(Roles = "Admin")] // Solo los usuarios con el rol de "Admin" pueden actualizar usuarios
    public async Task<IActionResult> PutUser(int userId, User user)
    {
        if (userId != user.UserId)
        {
            return BadRequest();
        }

        _context.Entry(user).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Users.Any(e => e.UserId == userId))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // DELETE: api/Users/5
    [HttpDelete("{userId}")]
    // [Authorize(Roles = "Admin")] // Solo los usuarios con el rol de "Admin" pueden eliminar usuarios
    public async Task<IActionResult> DeleteUser(int userId)
    {
        var user = await _context.Users.FindAsync(userId);
        if (user == null)
        {
            return NotFound();
        }

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
