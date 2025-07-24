using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeoSapiens.Database.Migrations
{
    /// <inheritdoc />
    public partial class CreateEvents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("create extension if not exists citext");
            
            migrationBuilder.CreateTable(
                name: "events",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid7()"),
                    name_en = table.Column<string>(type: "text", nullable: false),
                    name_pl = table.Column<string>(type: "text", nullable: true),
                    slug = table.Column<string>(type: "citext", nullable: false),
                    begins_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ends_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    description_en = table.Column<string>(type: "text", nullable: true),
                    description_pl = table.Column<string>(type: "text", nullable: true),
                    inserted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now() at time zone 'utc'"),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now() at time zone 'utc'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_events", x => x.id);
                    table.CheckConstraint("events_ends_at_begins_at_check", sql: "ends_at > begins_at");
                });

            migrationBuilder.CreateIndex(name: "events_slug_idx", unique: true, columns: ["slug"], table: "events");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "events");
        }
    }
}
