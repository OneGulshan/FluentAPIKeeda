using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FluentAPIKeeda.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "User_Info",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_Info_DepartmentId",
                table: "User_Info",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Info_Departments_DepartmentId",
                table: "User_Info",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Info_Departments_DepartmentId",
                table: "User_Info");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_User_Info_DepartmentId",
                table: "User_Info");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "User_Info");
        }
    }
}
