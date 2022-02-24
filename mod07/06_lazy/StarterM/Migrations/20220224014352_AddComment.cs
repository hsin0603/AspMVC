using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterM.Migrations
{
    public partial class AddComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OperaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Operas_OperaID",
                        column: x => x.OperaID,
                        principalTable: "Operas",
                        principalColumn: "OperaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "LastModified", "OperaID", "UserComment", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 24, 9, 43, 52, 41, DateTimeKind.Local).AddTicks(767), 1, "comment1", "user1" },
                    { 2, new DateTime(2022, 2, 24, 9, 43, 52, 42, DateTimeKind.Local).AddTicks(3400), 1, "comment2", "user2" },
                    { 3, new DateTime(2022, 2, 24, 9, 43, 52, 42, DateTimeKind.Local).AddTicks(3418), 2, "comment3", "user3" },
                    { 4, new DateTime(2022, 2, 24, 9, 43, 52, 42, DateTimeKind.Local).AddTicks(3421), 2, "comment4", "user4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_OperaID",
                table: "Comments",
                column: "OperaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");
        }
    }
}
