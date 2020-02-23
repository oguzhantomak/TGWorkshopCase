using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TGWorkshopCase.Context.Migrations
{
    public partial class Initializev1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TGProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    ProductName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TGProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TGSuppliers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TGSuppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TGSupplierProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: false),
                    SupplierId = table.Column<Guid>(nullable: false),
                    TGProductId = table.Column<Guid>(nullable: true),
                    TGSupplierId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TGSupplierProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TGSupplierProducts_TGProducts_TGProductId",
                        column: x => x.TGProductId,
                        principalTable: "TGProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TGSupplierProducts_TGSuppliers_TGSupplierId",
                        column: x => x.TGSupplierId,
                        principalTable: "TGSuppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TGSupplierProducts_TGProductId",
                table: "TGSupplierProducts",
                column: "TGProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TGSupplierProducts_TGSupplierId",
                table: "TGSupplierProducts",
                column: "TGSupplierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TGSupplierProducts");

            migrationBuilder.DropTable(
                name: "TGProducts");

            migrationBuilder.DropTable(
                name: "TGSuppliers");
        }
    }
}
