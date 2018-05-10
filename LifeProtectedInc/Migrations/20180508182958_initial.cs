using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LifeProtectedInc.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    InventoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductAmount = table.Column<decimal>(type: "money", nullable: false),
                    ProductName = table.Column<string>(maxLength: 50, nullable: false),
                    ProductNo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.InventoryID);
                });

            migrationBuilder.CreateTable(
                name: "StaffMembers",
                columns: table => new
                {
                    StaffMemberID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffMembers", x => x.StaffMemberID);
                });

            migrationBuilder.CreateTable(
                name: "Supervisors",
                columns: table => new
                {
                    SupervisorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    InventoryID = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supervisors", x => x.SupervisorID);
                    table.ForeignKey(
                        name: "FK_Supervisors_Inventories_InventoryID",
                        column: x => x.InventoryID,
                        principalTable: "Inventories",
                        principalColumn: "InventoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(maxLength: 150, nullable: false),
                    City = table.Column<string>(maxLength: 60, nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(type: "nchar(7)", maxLength: 7, nullable: false),
                    Province = table.Column<string>(type: "nchar(2)", maxLength: 2, nullable: false),
                    StaffMemberID = table.Column<int>(nullable: false),
                    SupervisorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientID);
                    table.ForeignKey(
                        name: "FK_Clients_StaffMembers_StaffMemberID",
                        column: x => x.StaffMemberID,
                        principalTable: "StaffMembers",
                        principalColumn: "StaffMemberID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_Supervisors_SupervisorID",
                        column: x => x.SupervisorID,
                        principalTable: "Supervisors",
                        principalColumn: "SupervisorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_StaffMemberID",
                table: "Clients",
                column: "StaffMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_SupervisorID",
                table: "Clients",
                column: "SupervisorID");

            migrationBuilder.CreateIndex(
                name: "IX_Supervisors_InventoryID",
                table: "Supervisors",
                column: "InventoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "StaffMembers");

            migrationBuilder.DropTable(
                name: "Supervisors");

            migrationBuilder.DropTable(
                name: "Inventories");
        }
    }
}
