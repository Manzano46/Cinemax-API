using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.JsonPatch;
// using Cinemax.API.Models;

[Route("api/[controller]")]
[ApiController]
public class MoviesController : ControllerBase
{
    private readonly AppDbContext _context;

    public MoviesController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/Movies
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
    {
        return await _context.Movies.ToListAsync();
    }

    // GET: api/Movies/5
    [HttpGet("{movieId}")]
    public async Task<ActionResult<Movie>> GetMovie(int movieId)
    {
        var movie = await _context.Movies.FindAsync(movieId);

        if (movie == null)
        {
            return NotFound();
        }

        return movie;
    }

    // POST: api/Movies
    [HttpPost]
    // [Authorize(Roles = "Admin")] // Solo los usuarios con el rol de "Admin" pueden crear películas
    public async Task<ActionResult<Movie>> PostMovie(Movie movie)
    {
        _context.Movies.Add(movie);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetMovie), new { movieId = movie.MovieId }, movie);
    }
    
    // PATCH: api/Movies/5
    [HttpPatch("{movieId}")]
    public async Task<IActionResult> PatchMovie(int movieId, [FromBody] JsonPatchDocument<Movie> patchDoc)
    {
        if (patchDoc == null)
        {
            return BadRequest();
        }

        var movie = await _context.Movies.FindAsync(movieId);
        if (movie == null)
        {
            return NotFound();
        }

        patchDoc.ApplyTo(movie, (err) => 
        {
            ModelState.AddModelError(err.Operation.path, err.ErrorMessage);
        });

        if (!ModelState.IsValid)
        {
            return new BadRequestObjectResult(ModelState);
        }

        try
        {
            _context.Entry(movie).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Movies.Any(e => e.MovieId == movieId))
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

   
}
