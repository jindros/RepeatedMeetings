

using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace RepeatedMeetings.Models
{
    public class RepeatedMeetingsDBContext : DbContext
    {

        public DbSet<Member> Members { get; set; }

        public RepeatedMeetingsDBContext(DbContextOptions<RepeatedMeetingsDBContext> options) : base(options)
        {
        
        
        }
        


    }
}
