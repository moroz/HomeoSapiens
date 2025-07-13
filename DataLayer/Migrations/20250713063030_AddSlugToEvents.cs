using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddSlugToEvents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("create extension if not exists citext");
            
            migrationBuilder.AddColumn<string>(
                name: "slug",
                table: "events",
                type: "citext",
                nullable: false);
            
            migrationBuilder.CreateIndex(
                name: "events_slug_idx",
                table: "events",
                unique: true,
                columns: ["slug"]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "slug",
                table: "events");

            migrationBuilder.Sql("drop extension if exists citext");
        }
    }
}
