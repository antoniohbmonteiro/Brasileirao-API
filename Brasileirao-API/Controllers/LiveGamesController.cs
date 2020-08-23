using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Brasileirao_API.Data;
using Brasileirao_API.Models;
using FirebaseAdmin.Messaging;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using System.Net.Http;
using System.Text;

namespace Brasileirao_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LiveGamesController : ControllerBase
    {
        private readonly BrasileiraoDBContext _context;

        private readonly IHttpClientFactory _clientFactory;

        public LiveGamesController(BrasileiraoDBContext context, IHttpClientFactory httpClientFactory)
        {
            _context = context;
            _clientFactory = httpClientFactory;
        }

        // GET: api/LiveGames
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LiveGame>>> GetLiveGame()
        {
            return await _context.LiveGame.ToListAsync();
        }

        // GET: api/LiveGames
        [Route("getLiveGamesByGame/{gameId}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LiveGame>>> GetLiveGamesByGame(int gameId)
        {
            return await _context.LiveGame.Where(c => c.GameId == gameId).ToListAsync();
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

            var tokens = await _context.Token.ToListAsync<PushToken>();

            var registrationTokens = tokens.Select(c => c.Token).ToList();

            var request = new HttpRequestMessage(HttpMethod.Post,
                "https://fcm.googleapis.com/fcm/send");
            request.Headers.TryAddWithoutValidation("Authorization", "key=AAAAxDTznoQ:APA91bGacTqXyAHk6KW98J9AWDLPaxu_e8hma4sB5KYJ7KDKFt7gKenAyzRKxE-ToyY2ggMM7oaUVZ9tv389TAowSV0RfVRWFVaM1UI02Aq0VGnDUcH1-nnHflXZn6EGPVIId8_DNOdl");
            request.Headers.TryAddWithoutValidation("Content-Type", "application/json");

            var tokenModel = new TokenModel
            {
                Tokens = registrationTokens,
                ContentAvailable = true,
                NotificationPush = new TokenModel.Notification { Title = "Teste C#", Body = "Body C#" },
                DataPush = new TokenModel.Data { Extra = Newtonsoft.Json.JsonConvert.SerializeObject(liveGame) }
            };

            var tokenJson = Newtonsoft.Json.JsonConvert.SerializeObject(tokenModel);

            request.Content = new StringContent(tokenJson,
                Encoding.UTF8, "application/json");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            string pushResponse = "";

            if (response.IsSuccessStatusCode)
            {
                pushResponse = await response.Content.ReadAsStringAsync();
            }

            return CreatedAtAction("GetLiveGame", new { id = liveGame.Id, pushResponse }, liveGame);
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
