using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace soft20181_starter.Migrations
{
    /// <inheritdoc />
    public partial class NewEventCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EventImg",
                table: "Events",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventImg",
                table: "Events");
        }
    }
}
