using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepeatedMeetings.Migrations
{
    /// <inheritdoc />
    public partial class MemberMeetingsUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberMeets_Meetings_MeetingId",
                table: "MemberMeets");

            migrationBuilder.DropForeignKey(
                name: "FK_MemberMeets_Members_MemberId",
                table: "MemberMeets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MemberMeets",
                table: "MemberMeets");

            migrationBuilder.RenameTable(
                name: "MemberMeets",
                newName: "MemberMeetings");

            migrationBuilder.RenameIndex(
                name: "IX_MemberMeets_MemberId",
                table: "MemberMeetings",
                newName: "IX_MemberMeetings_MemberId");

            migrationBuilder.RenameIndex(
                name: "IX_MemberMeets_MeetingId",
                table: "MemberMeetings",
                newName: "IX_MemberMeetings_MeetingId");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_MemberMeetings",
                table: "MemberMeetings",
                column: "Id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberMeetings_Meetings_MeetingId",
                table: "MemberMeetings");

            migrationBuilder.DropForeignKey(
                name: "FK_MemberMeetings_Members_MemberId",
                table: "MemberMeetings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MemberMeetings",
                table: "MemberMeetings");

            migrationBuilder.RenameTable(
                name: "MemberMeetings",
                newName: "MemberMeets");

            migrationBuilder.RenameIndex(
                name: "IX_MemberMeetings_MemberId",
                table: "MemberMeets",
                newName: "IX_MemberMeets_MemberId");

            migrationBuilder.RenameIndex(
                name: "IX_MemberMeetings_MeetingId",
                table: "MemberMeets",
                newName: "IX_MemberMeets_MeetingId");

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "MemberMeets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MeetingId",
                table: "MemberMeets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MemberMeets",
                table: "MemberMeets",
                column: "Id");

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
    }
}
