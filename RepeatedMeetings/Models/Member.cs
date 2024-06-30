using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace RepeatedMeetings.Models
{
    public class Member
    {
        // [Key]
        public int Id { get; set; }

        // [Column(TypeName = "nvarchar(100)")]
        public string FullName { get; set; }

        // [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }

        // [Column(TypeName = "nvarchar(100)")]
        public string Phone { get; set; }

        public string Password { get; set; }

        // public string Salt { get; set; }

        //public List<MemberMeeting> MemberMeetings { get; } = [];
        
        //public List<Meeting> Meetings { get; } = [];


    }
}
