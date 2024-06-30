namespace RepeatedMeetings.Models
{
    public class MemberMeeting
    {
        public int Id { get; set; }

        public int MembersId { get; set; }

        public int MeetingsId { get; set; }

        public Member Member { get; set; } = null!;

        public Meeting Meeting { get; set; } = null!;

    }

}
