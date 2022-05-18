﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgreSQLMigrations.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ObjectDateStamp",
                table: "ObjectExchanges",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ObjectDateStamp",
                table: "ObjectExchanges");
        }
    }
}
