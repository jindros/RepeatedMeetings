using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepeatedMeetings.Migrations
{
    /// <inheritdoc />
    public partial class MeetingsUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberMeets_Meetings_TagId",
                table: "MemberMeets");

            migrationBuilder.DropForeignKey(
                name: "FK_MemberMeets_Members_PostId",
                table: "MemberMeets");

            migrationBuilder.RenameColumn(
                name: "TagId",
                table: "MemberMeets",
                newName: "MemberId");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "MemberMeets",
                newName: "MeetingId");

            migrationBuilder.RenameIndex(
                name: "IX_MemberMeets_TagId",
                table: "MemberMeets",
                newName: "IX_MemberMeets_MemberId");

            migrationBuilder.RenameIndex(
                name: "IX_MemberMeets_PostId",
                table: "MemberMeets",
                newName: "IX_MemberMeets_MeetingId");

            migrationBuilder.AddForeignKey(
                name: "FK_MemberMeets_Meetings_MeetingId",
                table: "MemberMeets",
                column: "MeetingId",
                principalTable: "Meetings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MemberMeets_Members_MemberId",
                table: "MemberMeets",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberMeets_Meetings_MeetingId",
                table: "MemberMeets");

            migrationBuilder.DropForeignKey(
                name: "FK_MemberMeets_Members_MemberId",
                table: "MemberMeets");

            migrationBuilder.RenameColumn(
                name: "MemberId",
                table: "MemberMeets",
                newName: "TagId");

            migrationBuilder.RenameColumn(
                name: "MeetingId",
                table: "MemberMeets",
                newName: "PostId");

            migrationBuilder.RenameIndex(
                name: "IX_MemberMeets_MemberId",
                table: "MemberMeets",
                newName: "IX_MemberMeets_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_MemberMeets_MeetingId",
                table: "MemberMeets",
                newName: "IX_MemberMeets_PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_MemberMeets_Meetings_TagId",
                table: "MemberMeets",
                column: "TagId",
                principalTable: "Meetings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MemberMeets_Members_PostId",
                table: "MemberMeets",
                column: "PostId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
