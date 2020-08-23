using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Brasileirao_API.Data;
using Brasileirao_API.Models;

namespace Brasileirao_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LiveGamesController : ControllerBase
    {
        private readonly BrasileiraoDBContext _context;

        public LiveGamesController(BrasileiraoDBContext context)
        {
            _context = context;
        }

        // GET: api/LiveGames
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LiveGame>>> GetLiveGame()
        {
            return await _context.LiveGame.ToListAsync();
        }

        // GET: api/LiveGames/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LiveGame>> GetLiveGame(int id)
        {
            var liveGame = await _context.LiveGame.FindAsync(id);

            if (liveGame == null)
            {
                return NotFound();
            }

            return liveGame;
        }

        // PUT: api/LiveGames/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLiveGame(int id, LiveGame liveGame)
        {
            if (id != liveGame.Id)
            {
                return BadRequest();
            }

            _context.Entry(liveGame).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LiveGameExists(id))
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

        // POST: api/LiveGames
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<LiveGame>> PostLiveGame(LiveGame liveGame)
        {
            _context.LiveGame.Add(liveGame);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLiveGame", new { id = liveGame.Id }, liveGame);
        }

        // DELETE: api/LiveGames/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LiveGame>> DeleteLiveGame(int id)
        {
            var liveGame = await _context.LiveGame.FindAsync(id);
            if (liveGame == null)
            {
                return NotFound();
            }

            _context.LiveGame.Remove(liveGame);
            await _context.SaveChangesAsync();

            return liveGame;
        }

        private bool LiveGameExists(int id)
        {
            return _context.LiveGame.Any(e => e.Id == id);
        }
    }
}
