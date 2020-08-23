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
    public class PushTokensController : ControllerBase
    {
        private readonly BrasileiraoDBContext _context;

        public PushTokensController(BrasileiraoDBContext context)
        {
            _context = context;
        }

        // GET: api/PushTokens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PushToken>>> GetToken()
        {
            return await _context.Token.ToListAsync();
        }

        // GET: api/PushTokens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PushToken>> GetPushToken(int id)
        {
            var pushToken = await _context.Token.FindAsync(id);

            if (pushToken == null)
            {
                return NotFound();
            }

            return pushToken;
        }

        // PUT: api/PushTokens/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPushToken(int id, PushToken pushToken)
        {
            if (id != pushToken.Id)
            {
                return BadRequest();
            }

            _context.Entry(pushToken).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PushTokenExists(id))
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

        // POST: api/PushTokens
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PushToken>> PostPushToken(PushToken pushToken)
        {
            _context.Token.Add(pushToken);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPushToken", new { id = pushToken.Id }, pushToken);
        }

        // DELETE: api/PushTokens/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PushToken>> DeletePushToken(int id)
        {
            var pushToken = await _context.Token.FindAsync(id);
            if (pushToken == null)
            {
                return NotFound();
            }

            _context.Token.Remove(pushToken);
            await _context.SaveChangesAsync();

            return pushToken;
        }

        private bool PushTokenExists(int id)
        {
            return _context.Token.Any(e => e.Id == id);
        }
    }
}
