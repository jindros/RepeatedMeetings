using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepeatedMeetings.Models;

namespace RepeatedMeetings.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MeetingController : Controller
    {
        private readonly RepeatedMeetingsDBContext _context;

        public MeetingController(RepeatedMeetingsDBContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> Meetings()
        {
            return Ok(await _context.Meetings.AsNoTracking().ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> CreateMeeting(Meeting meeting)
        {
            if (meeting == null)
            {
                return BadRequest();
            }

            await _context.Meetings.AddAsync(meeting);
            await _context.SaveChangesAsync();

            return Ok(meeting);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMeeting(int id)
        {
            var meeting = await _context.Meetings.FindAsync(id);

            if (meeting is null)
                return NotFound();

            return Ok(meeting);
        }



        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMeeting(int id, Meeting meeting)
        {
            if (id != meeting.Id)
            {
                return BadRequest();
            }

            _context.Entry(meeting).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMeeting(int id)
        {
            var meeting = await _context.Meetings.FindAsync(id);

            if (meeting is null)
            {
                return NotFound();
            }

            _context.Meetings.Remove(meeting);
            await _context.SaveChangesAsync();

            return Ok(meeting);
        }
    }
}
