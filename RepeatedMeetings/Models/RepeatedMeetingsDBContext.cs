

using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Identity.Client;

namespace RepeatedMeetings.Models
{
    public class RepeatedMeetingsDBContext : DbContext
    {

        public DbSet<Member> Members { get; set; }

        public DbSet<Meeting> Meetings { get; set; }

        public DbSet<MemberMeeting> MemberMeetings { get; set; }


        public RepeatedMeetingsDBContext(DbContextOptions<RepeatedMeetingsDBContext> options) : base(options)
        {
        
        
        }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Post>()
        //        .HasMany(e => e.Tags)
        //        .WithMany(e => e.Posts);
        //}\


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Post>()
        //        .HasMany(e => e.Tags)
        //        .WithMany(e => e.Posts)
        //        .UsingEntity(
        //            "PostTag",
        //            l => l.HasOne(typeof(Tag)).WithMany().HasForeignKey("TagsId").HasPrincipalKey(nameof(Tag.Id)),
        //            r => r.HasOne(typeof(Post)).WithMany().HasForeignKey("PostsId").HasPrincipalKey(nameof(Post.Id)),
        //            j => j.HasKey("PostsId", "TagsId"));
        //}



//        CREATE TABLE "Posts" (
//    "Id" INTEGER NOT NULL CONSTRAINT "PK_Posts" PRIMARY KEY AUTOINCREMENT);

//CREATE TABLE "Tags" (
//    "Id" INTEGER NOT NULL CONSTRAINT "PK_Tags" PRIMARY KEY AUTOINCREMENT);

//CREATE TABLE "PostTag" (
//    "PostsId" INTEGER NOT NULL,
//    "TagsId" INTEGER NOT NULL,
//    CONSTRAINT "PK_PostTag" PRIMARY KEY("PostsId", "TagsId"),
//    CONSTRAINT "FK_PostTag_Posts_PostsId" FOREIGN KEY("PostsId") REFERENCES "Posts" ("Id") ON DELETE CASCADE,
//    CONSTRAINT "FK_PostTag_Tags_TagsId" FOREIGN KEY("TagsId") REFERENCES "Tags" ("Id") ON DELETE CASCADE);

    }
}
