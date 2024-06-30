namespace RepeatedMeetings.Models
{
    public class Meeting
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateTime { get; set; }

        //public List<MemberMeeting> MemberMeetings { get; } = [];

        //public List<Member> Members { get; } = [];
    }
}
