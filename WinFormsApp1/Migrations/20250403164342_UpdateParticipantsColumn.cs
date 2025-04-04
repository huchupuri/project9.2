using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class UpdateParticipantsColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                schema: "public",
                table: "Events");

            migrationBuilder.RenameTable(
                name: "Events",
                schema: "public",
                newName: "events",
                newSchema: "public");

            migrationBuilder.RenameColumn(
                name: "Title",
                schema: "public",
                table: "events",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Place",
                schema: "public",
                table: "events",
                newName: "place");

            migrationBuilder.RenameColumn(
                name: "Participants",
                schema: "public",
                table: "events",
                newName: "participants");

            migrationBuilder.RenameColumn(
                name: "Description",
                schema: "public",
                table: "events",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Date",
                schema: "public",
                table: "events",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "public",
                table: "events",
                newName: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_events",
                schema: "public",
                table: "events",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_events",
                schema: "public",
                table: "events");

            migrationBuilder.RenameTable(
                name: "events",
                schema: "public",
                newName: "Events",
                newSchema: "public");

            migrationBuilder.RenameColumn(
                name: "title",
                schema: "public",
                table: "Events",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "place",
                schema: "public",
                table: "Events",
                newName: "Place");

            migrationBuilder.RenameColumn(
                name: "participants",
                schema: "public",
                table: "Events",
                newName: "Participants");

            migrationBuilder.RenameColumn(
                name: "description",
                schema: "public",
                table: "Events",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "date",
                schema: "public",
                table: "Events",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "id",
                schema: "public",
                table: "Events",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                schema: "public",
                table: "Events",
                column: "Id");
        }
    }
}
