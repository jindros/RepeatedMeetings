using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepeatedMeetings.Models;

namespace RepeatedMeetings.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberMeetingController : Controller
    {

        private readonly RepeatedMeetingsDBContext _context;


        public MemberMeetingController(RepeatedMeetingsDBContext context)
        {
            _context = context;
        }


        [HttpPost]
        [Route("testah")]
        public async Task<IActionResult> AddMemberToMeeting(int meetingId, int memberId)
        {
            var member = await _context.Members.FindAsync(memberId);

            var meeting = await _context.Meetings.FindAsync(meetingId);


            if (member == null || meeting == null)
            {
                return BadRequest();
            }

            MemberMeeting val = new MemberMeeting() { MeetingsId = meetingId, MembersId = memberId, Meeting = meeting, Member = member};

            await _context.MemberMeetings.AddAsync(val);
            await _context.SaveChangesAsync();

            return Ok(val);


            //if (memberMeeting == null)
            //{
            //    return BadRequest();
            //}

            //var member = await _context.Members.FindAsync(memberMeeting.MembersId);

            //var meeting = await _context.Meetings.FindAsync(memberMeeting.MeetingsId);


            //if (meeting == null || meeting == null)
            //{
            //    return BadRequest();
            //}

            //await _context.MemberMeetings.AddAsync(memberMeeting);
            //await _context.SaveChangesAsync();

            //return Ok(memberMeeting);
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




        [HttpDelete]        
        public async Task<IActionResult> RemoveMemberFromMeeting(int meetingId, int memberId)
        {
            //if (meeting == null)
            //{
            //    return BadRequest();
            //}

            //await _context.Meetings.AddAsync(meeting);
            //await _context.SaveChangesAsync();

            return Ok();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMemberMeeting(int id)
        {
            var memberMeeting = await _context.MemberMeetings.FindAsync(id);

            if (memberMeeting is null)
            {
                return NotFound();
            }

            _context.MemberMeetings.Remove(memberMeeting);
            await _context.SaveChangesAsync();

            return Ok(memberMeeting);
        }

    }
}
