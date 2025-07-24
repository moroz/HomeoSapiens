using System;
using System.IO;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeoSapiens.Database.Migrations
{
    /// <inheritdoc />
    public partial class CreateUUIDv7Function : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using var stream = assembly.GetManifestResourceStream("HomeoSapiens.Database.Migrations.CreateUUIDv7Function.sql");
            if (stream == null)
            {
                throw new Exception($"Resource not found");
            }

            using var reader = new StreamReader(stream);
            var sql = reader.ReadToEnd();
            migrationBuilder.Sql(sql);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("drop function if exists uuid7();");
            migrationBuilder.Sql("drop function if exists uuid7(timestamp with time zone);");
            migrationBuilder.Sql("drop extension if exists pgcrypto;");
        }
    }
}
