using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepeatedMeetings.Models;

namespace RepeatedMeetings.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberController : ControllerBase
    {
        private readonly RepeatedMeetingsDBContext _context;

        public MemberController(RepeatedMeetingsDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Members()
        {
            return Ok(await _context.Members.AsNoTracking().ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> CreateMember(Member member)
        {
            if (member == null)
            {
                return BadRequest();
            }

            await _context.Members.AddAsync(member);
            await _context.SaveChangesAsync();

            return Ok(member);
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> GetMember(int id)
        {
            var product = await _context.Members.FindAsync(id);

            if (product is null)
                return NotFound();

            return Ok(product);
        }



        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMember(int id, Member member)
        {
            if (id != member.Id)
            {
                return BadRequest();
            }

            _context.Entry(member).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMember(int id)
        {
            var member = await _context.Members.FindAsync(id);

            if (member is null)
            {
                return NotFound();
            }

            _context.Members.Remove(member);
            await _context.SaveChangesAsync();

            return Ok(member);
        }
    }
}

