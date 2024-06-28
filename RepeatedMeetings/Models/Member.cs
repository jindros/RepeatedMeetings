using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

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
    }
}
