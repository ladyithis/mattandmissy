using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MattAndMissy.Data;
using MattAndMissy.Models;
using Microsoft.AspNetCore.Authorization;

namespace MattAndMissy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GuestsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Guests/invitationCode
        [HttpGet("{invitationCode}")]
        public async Task<IActionResult> ValidateInvitationCode(string invitationCode)
        {
            bool exists = (await _context.Guests.Where(x => x.InvitationCode == invitationCode).ToListAsync()).Count() < 0;

            if(exists)
            {
                return Ok();
            }

            return NotFound();
        }

        //GET: api/Guests/invitationCode
        //TODO: return a request token with this
        [HttpGet("{invitationCode}")]
        public async Task<ActionResult<IEnumerable<Guest>>> GetGuests(string invitationCode)
        {
            var guests = await _context.Guests.Where(x => x.InvitationCode == invitationCode).ToListAsync();

            if (guests == null)
            {
                return NotFound();
            }

            return guests;
        }

       // GET: api/Guests
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Guest>>> GetGuests()
        {
            return await _context.Guests.ToListAsync();
        }

        // GET: api/Guests/5
        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<Guest>> GetGuest(int id)
        {
            var guest = await _context.Guests.FindAsync(id);

            if (guest == null)
            {
                return NotFound();
            }

            return guest;
        }

        //PUT: api/Guests/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGuest(int id, Guest guest)
        {
            if (id != guest.ID)
            {
                return BadRequest();
            }

            _context.Entry(guest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GuestExists(id))
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

        //POST: api/Guests
        //To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        // TODO: Require a request token
        [Authorize]
        [HttpPost]
        public async Task<ActionResult<Guest>> PostGuest(Guest guest)
        {
            _context.Guests.Add(guest);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGuest", new { id = guest.ID }, guest);
        }

        private bool GuestExists(int id)
        {
            return _context.Guests.Any(e => e.ID == id);
        }
    }
}
