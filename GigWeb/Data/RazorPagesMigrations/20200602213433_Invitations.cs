using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GigWeb.Data.RazorPagesMigrations
{
    public partial class Invitations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Zone",
                columns: table => new
                {
                    zone_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    zone_event_id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Capacity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zone", x => x.zone_id);
                });

            migrationBuilder.CreateTable(
                name: "Invitation",
                columns: table => new
                {
                    invitation_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    event_id = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    PurchaseDateTime = table.Column<DateTime>(nullable: false),
                    Sha512key = table.Column<string>(nullable: true),
                    targetzone_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invitation", x => x.invitation_id);
                    table.ForeignKey(
                        name: "FK_Invitation_Zone_targetzone_id",
                        column: x => x.targetzone_id,
                        principalTable: "Zone",
                        principalColumn: "zone_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invitation_targetzone_id",
                table: "Invitation",
                column: "targetzone_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invitation");

            migrationBuilder.DropTable(
                name: "Zone");
        }
    }
}
