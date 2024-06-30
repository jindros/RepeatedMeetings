using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepeatedMeetings.Migrations
{
    /// <inheritdoc />
    public partial class MemberMeetingsNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberMeetings_Meetings_MeetingId",
                table: "MemberMeetings");

            migrationBuilder.DropForeignKey(
                name: "FK_MemberMeetings_Members_MemberId",
                table: "MemberMeetings");

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "MemberMeetings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MeetingId",
                table: "MemberMeetings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MemberMeetings_Meetings_MeetingId",
                table: "MemberMeetings",
                column: "MeetingId",
                principalTable: "Meetings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MemberMeetings_Members_MemberId",
                table: "MemberMeetings",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberMeetings_Meetings_MeetingId",
                table: "MemberMeetings");

            migrationBuilder.DropForeignKey(
                name: "FK_MemberMeetings_Members_MemberId",
                table: "MemberMeetings");

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "MemberMeetings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MeetingId",
                table: "MemberMeetings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_MemberMeetings_Meetings_MeetingId",
                table: "MemberMeetings",
                column: "MeetingId",
                principalTable: "Meetings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MemberMeetings_Members_MemberId",
                table: "MemberMeetings",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id");
        }
    }
}
